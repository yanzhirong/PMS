using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bll;
using Common.Tools;

namespace PMS.Frm.Finance
{
    public partial class FrmReceivedDetailAdd : Form
    {
        private string m_orderCode;
        private decimal m_maxReceiveMoney;

        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllProduct m_bllProduct = new BllProduct();
        private BllProductOut m_bllProductOut = new BllProductOut();
        private BllStore m_bllStore = new BllStore();
        private BllProduce m_bllProduce = new BllProduce();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmReceivedDetailAdd(string _orderCode, decimal _maxReceiveMoney)
        {
            InitializeComponent();
            m_orderCode = _orderCode;
            m_maxReceiveMoney = _maxReceiveMoney;
        }

        private void FrmReceivedDetailAdd_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            
            //初始化
            init();
        }

        private void FrmReceivedDetailAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
                
        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {
            //出库单号
            this.txt_receiveMoney.Text = m_outputCode;
            //工厂
            this.txt_customer.Text = m_bllFactory.GetFactoryById(m_factoryId).name;
            //出库产品
            this.txt_orderStatus.Text = m_bllProduct.GetProductById(m_productId).name;

            if (m_outputDetailId > 0)
            {
                ModelProductOutputDetail modelProductOutputDetail = m_bllProductOut.GetProductOutDetailById(m_outputDetailId);
                //出库数量
                this.txt_receiveStatus.Text = modelProductOutputDetail.productNum.ToString();

                //生产申请数
                this.txt_produceNum.Text = modelProductOutputDetail.productNum.ToString();

                //实际已出库数
                m_realityOutputNum = modelProductOutputDetail.realityOutputNum;

                if (modelProductOutputDetail.outputStatus == 1)
                {
                    this.grb_productOut.Enabled = false;
                    this.lbl_selectOutput.Visible = false;
                    this.dataGridView1.Visible = false;
                    this.btn_submit.Visible = false;
                    this.btn_cancel.Visible = false;
                    this.btn_close.Visible = true;
                }
                else
                {
                    this.grb_productOut.Enabled = true;
                    this.lbl_selectOutput.Visible = true;
                    this.dataGridView1.Visible = true;
                    this.btn_submit.Visible = true;
                    this.btn_cancel.Visible = true;
                    this.btn_close.Visible = false;
                }
            }
            else
            {
                this.grb_productOut.Enabled = true;
                this.lbl_selectOutput.Visible = true;
                this.dataGridView1.Visible = true;
                this.btn_submit.Visible = true;
                this.btn_cancel.Visible = true;
                this.btn_close.Visible = false;
            }

            //设置列表信息
            SetDataGridViewStyle();

            //初始化列表
            doSelect();
        }

        //查询
        private void doSelect()
        {
            this.dataGridView1.DataSource = m_bllProductOut.GetProductOutSelect(m_factoryId, m_productId);
            this.dataGridView1.Refresh();

            this.dataGridView1.DataSource = m_bllStore.GetProductOutputLog(m_outputCode, m_productId);
            this.dataGridView1.Refresh();
        }

        #endregion

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        private void doSubmit()
        {
            Boolean rtn = false;

            //检查
            if (doCheck() == false)
            {
                return ;
            }

            //输入的出库数合计
            int selectedAllOutputNum = 0;

            List<Dictionary<string, object>> listOutput = new List<Dictionary<string, object>>();
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                //选择的行
                if (this.dataGridView1.Rows[i].Cells["selected"].EditedFormattedValue.ToString() == "True")
                {
                    Dictionary<string, object> dc = new Dictionary<string, object>();
                    dc.Add("inputId", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value));
                    dc.Add("inputCode", ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["inputCode"].Value));

                    //出库数
                    int curOutPutNum = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["outputNum"].Value);
                    dc.Add("outputNum", curOutPutNum);

                    //出库后剩余在库数
                    int stockNum = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["num"].Value);
                    stockNum = stockNum - curOutPutNum;
                    dc.Add("stockNum", stockNum);

                    listOutput.Add(dc);

                    selectedAllOutputNum = selectedAllOutputNum + curOutPutNum;
                }
            }

            rtn = m_bllProductOut.doOutPut(m_outputCode, m_outputDetailId, m_factoryId, m_productId, m_applyMemberId, selectedAllOutputNum, listOutput, LoginUserInfo.LoginUser.loginUser.userName);

            if (rtn == true)
            {
                MsgUtils.ShowInfoMsg("出库成功！");
                this.Hide();
                return;
            }
            else
            {
                MsgUtils.ShowInfoMsg("出库失败！");
                return;
            }

        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean doCheck()
        {
            //输入的出库数合计（克）
            decimal selectedAllOutputNum = 0;

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                //选择的行
                if (this.dataGridView1.Rows[i].Cells["selected"].EditedFormattedValue.ToString() == "True")
                {

                    //输入的出库数
                    int curOutPutNum = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["outputNum"].Value);
                    if (curOutPutNum <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入出库数量！");
                        return false;
                    }

                    //库存数量
                    int curStockNum = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["num"].Value);

                    if (curOutPutNum > curStockNum)
                    {
                        MsgUtils.ShowErrorMsg("出库数量大于在库数量，请输入适当的出库数！");
                        return false;
                    }

                    selectedAllOutputNum = selectedAllOutputNum + curOutPutNum;
                }
            }

            if (selectedAllOutputNum <= 0)
            {
                MsgUtils.ShowErrorMsg("出库数量不可为空！");
                return false;
            }

            //要求的出库数
            int requestOutputNum = ConvertUtils.ConvertToInt(this.txt_receiveStatus.Text.Trim());

            if (requestOutputNum > 0 && (selectedAllOutputNum + m_realityOutputNum) < requestOutputNum)
            {
                if (MsgUtils.ShowQustMsg("出库数量低于申请数量，确认出库么？", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        private void txt_receiveMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyInt(e.KeyChar);
        }

    }
}
