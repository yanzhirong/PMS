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

namespace PMS.Frm.Store
{
    public partial class FrmProductOutSelect : Form
    {
        private string m_outputCode;
        private int m_outputDetailId;
        private int m_productId;
        private int m_factoryId;
        private int m_applyMemberId;
        private int m_realityOutputNum;

        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllProduct m_bllProduct = new BllProduct();
        private BllProductOut m_bllProductOut = new BllProductOut();
        private BllStore m_bllStore = new BllStore();
        private BllProduce m_bllProduce = new BllProduce();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmProductOutSelect(string _outputCode, int _outputDetailId, int _productId, int _factoryId, int _applyMemberId)
        {
            InitializeComponent();
            m_outputCode = _outputCode;
            m_outputDetailId = _outputDetailId;
            m_productId = _productId;
            m_factoryId = _factoryId;
            m_applyMemberId = _applyMemberId;
        }

        private void FrmOrderDetail_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            
            //初始化
            init();
        }

        private void FrmProductOutSelect_FormClosed(object sender, FormClosedEventArgs e)
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
            this.txt_outputCode.Text = m_outputCode;
            //工厂
            this.txt_factory.Text = m_bllFactory.GetFactoryById(m_factoryId).name;
            //出库产品
            this.txt_product.Text = m_bllProduct.GetProductById(m_productId).name;

            if (m_outputDetailId > 0)
            {
                ModelProductOutputDetail modelProductOutputDetail = m_bllProductOut.GetProductOutDetailById(m_outputDetailId);
                //出库数量
                this.txt_num.Text = modelProductOutputDetail.productNum.ToString();

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

            this.dataGridView2.DataSource = m_bllStore.GetProductOutputLog(m_outputCode, m_productId);
            this.dataGridView2.Refresh();
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
            int requestOutputNum = ConvertUtils.ConvertToInt(this.txt_num.Text.Trim());

            if (requestOutputNum > 0 && (selectedAllOutputNum + m_realityOutputNum) > requestOutputNum)
            {
                if (MsgUtils.ShowQustMsg("出库数量大于申请数量，确认出库么？", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return false;
                }
            }
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

        #region 设置DataGridView列
        /// <summary>
        /// 设置DataGridView列
        /// </summary>
        private void SetDataGridViewStyle()
        {
            this.dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "id";
            colId.HeaderText = "id";
            colId.DataPropertyName = "id";
            colId.Visible = false;
            this.dataGridView1.Columns.Add(colId);

            DataGridViewTextBoxColumn colInputId = new DataGridViewTextBoxColumn();
            colInputId.Name = "inputCode";
            colInputId.HeaderText = "inputCode";
            colInputId.DataPropertyName = "inputCode";
            colInputId.Visible = false;
            this.dataGridView1.Columns.Add(colInputId);

            DataGridViewCheckBoxColumn colSelect = new DataGridViewCheckBoxColumn();
            colSelect.Name = "selected";
            colSelect.HeaderText = "选择";
            colSelect.Width = 40;
            this.dataGridView1.Columns.Add(colSelect);

            DataGridViewTextBoxColumn colProduct = new DataGridViewTextBoxColumn();
            colProduct.Name = "name";
            colProduct.HeaderText = "产品";
            colProduct.DataPropertyName = "name";
            colProduct.Width = 160;
            colProduct.ReadOnly = true;
            this.dataGridView1.Columns.Add(colProduct);

            DataGridViewTextBoxColumn colExpiresDate = new DataGridViewTextBoxColumn();
            colExpiresDate.Name = "expiresDate";
            colExpiresDate.HeaderText = "过期日";
            colExpiresDate.DataPropertyName = "expiresDate";
            colExpiresDate.Width = 100;
            colExpiresDate.ReadOnly = true;
            this.dataGridView1.Columns.Add(colExpiresDate);

            DataGridViewTextBoxColumn colNumDisplay = new DataGridViewTextBoxColumn();
            colNumDisplay.Name = "numDisplay";
            colNumDisplay.HeaderText = "库存数";
            colNumDisplay.DataPropertyName = "numDisplay";
            colNumDisplay.Width = 80;
            colNumDisplay.ReadOnly = true;
            this.dataGridView1.Columns.Add(colNumDisplay);

            DataGridViewTextBoxColumn colOutputNum = new DataGridViewTextBoxColumn();
            colOutputNum.Name = "outputNum";
            colOutputNum.HeaderText = "出库数量";
            colOutputNum.Width = 80;
            colOutputNum.ReadOnly = true;
            this.dataGridView1.Columns.Add(colOutputNum);

            DataGridViewTextBoxColumn colNum = new DataGridViewTextBoxColumn();
            colNum.Name = "num";
            colNum.HeaderText = "库存数";
            colNum.DataPropertyName = "num";
            colNum.Visible = false;
            this.dataGridView1.Columns.Add(colNum);

            DataGridViewTextBoxColumn colUnit = new DataGridViewTextBoxColumn();
            colUnit.Name = "unit";
            colUnit.HeaderText = "库存单位";
            colUnit.DataPropertyName = "unit";
            colUnit.Visible = false;
            this.dataGridView1.Columns.Add(colUnit);
        }
        #endregion

        private void btn_applyProduce_Click(object sender, EventArgs e)
        {
            decimal produceNum = ConvertUtils.ConvertToDecimal(this.txt_produceNum.Text.Trim());
            if (produceNum <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入合适的生产数量！");
                this.txt_produceNum.Focus();
                return;
            }

            ModelProduceApply modelProduceApply = m_bllProduce.GetProduceApplyByOutputCodeAndProductId(m_outputCode, m_productId);
            if (modelProduceApply.id > 0)
            {
                if (MsgUtils.ShowQustMsg("产品【" + this.txt_product.Text + "】已经申请生产，是否再次申请？", MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if (MsgUtils.ShowQustMsg("是否确认申请生产产品【" + this.txt_product.Text + "】？", MessageBoxDefaultButton.Button1) == DialogResult.No)
                {
                    return;
                }
            }
            ModelProductOutput modelProductOutput = m_bllProductOut.GetProductOutByOutputCode(m_outputCode);
            List<ModelProduceApply> listProduceApply = new List<ModelProduceApply>();
            ModelProduceApply newProduceApply = new ModelProduceApply();
            newProduceApply.factoryId = m_factoryId;
            newProduceApply.productId = m_productId;
            newProduceApply.num = ConvertUtils.ConvertToInt(this.txt_produceNum.Text.Trim());
            newProduceApply.saleOrderCode = modelProductOutput.orderCode;
            newProduceApply.outputCode = m_outputCode;
            newProduceApply.deliveryDate = modelProductOutput.deliveryDate;
            if (Common.Tools.StringUtils.IsBlank(newProduceApply.saleOrderCode))
            {
                newProduceApply.applyType = 1;
            }
            else
            {
                newProduceApply.applyType = 0;
            }
            newProduceApply.applyBy = LoginUserInfo.LoginUser.loginUser.userName;
            newProduceApply.applyDate = DateTime.Now;
            newProduceApply.status = 0;
            newProduceApply.isDelete = 0;
            newProduceApply.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            newProduceApply.createTime = DateTime.Now;
            listProduceApply.Add(newProduceApply);

            bool rtn = m_bllProduce.AddProduceApply(listProduceApply);

            if (rtn == true)
            {
                MsgUtils.ShowInfoMsg("申请生产成功！");
                this.Hide();
                return;
            }
            else
            {
                MsgUtils.ShowInfoMsg("申请生产失败！");
                return;
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyInt(e.KeyChar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //选择
            if (this.dataGridView1.Rows[e.RowIndex].Cells["selected"].EditedFormattedValue.ToString() == "True")
            {
                this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].ReadOnly = false;
                this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].Value = this.dataGridView1.Rows[e.RowIndex].Cells["num"].Value;
            }
            else
            {
                this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].ReadOnly = true;
                this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].Value = "";
            }
        }

    }
}
