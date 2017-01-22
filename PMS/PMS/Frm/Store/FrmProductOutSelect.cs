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

        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllProduct m_bllProduct = new BllProduct();
        private BllProductOut m_bllProductOut = new BllProductOut();
        private BllProduce m_bllProduce = new BllProduce();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmProductOutSelect(string _outputCode, int _outputDetailId, int _productId, int _factoryId)
        {
            InitializeComponent();
            m_outputCode = _outputCode;
            m_outputDetailId = _outputDetailId;
            m_productId = _productId;
            m_factoryId = _factoryId;
        }

        private void FrmOrderDetail_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            
            //初始化
            init();
        }

        private void FrmProductOutSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            WinCommon.Exit();
        }
                
        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {
            //单位下拉框
            List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.WeightUnit, false);
            WinCommon.BindComboBox(ref this.cmb_produceUint, listItem);

            //出库单号
            this.txt_outputCode.Text = m_outputCode;
            //仓库
            this.txt_factory.Text = m_bllFactory.GetFactoryById(m_factoryId).name;
            //出库商品
            this.txt_product.Text = m_bllProduct.GetProductById(m_productId).name;

            if (m_outputDetailId > 0)
            {
                ModelProductOutputDetail modelProductOutputDetail = m_bllProductOut.GetProductOutDetailById(m_outputDetailId);
                //出库数量
                this.txt_num.Text = modelProductOutputDetail.productNum.ToString();
                //单位
                this.txt_unitCode.Text = modelProductOutputDetail.productUnit.ToString();
                this.txt_unit.Text = m_bllCode.GetSubCode((int)Enum.EnumCode.WeightUnit, modelProductOutputDetail.productUnit).value1;

                this.txt_produceNum.Text = modelProductOutputDetail.productNum.ToString();
                for (int i = 0; i < this.cmb_produceUint.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_produceUint.Items[i];
                    if (modelProductOutputDetail.productUnit == (int)modelItem.itemKey)
                    {
                        this.cmb_produceUint.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {

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

            //输入的出库数合计（克）
            decimal selectedAllOutputNum = 0;

            List<Dictionary<string, object>> listOutput = new List<Dictionary<string, object>>();
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                //选择的行
                if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["selected"].Value) == 1)
                {
                    Dictionary<string, object> dc = new Dictionary<string, object>();
                    dc.Add("inputId", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value));
                    dc.Add("inputCode", ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["inputCode"].Value));

                    //出库数
                    decimal curOutPutNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["outputNum"].Value);
                    dc.Add("outputNum", curOutPutNum);
                    //出库单位
                    int outputUnit = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["outputUnit"].Value);
                    dc.Add("outputUnit", outputUnit);
                    //出库数（克）
                    curOutPutNum = curOutPutNum * m_bllCode.GetWeightUnit(outputUnit);

                    //出库后剩余出库数
                    decimal stockNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["num"].Value);
                    //转为克
                    stockNum = stockNum * m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["unitCode"].Value));
                    stockNum = stockNum - curOutPutNum;
                    stockNum = stockNum / ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["unitCode"].Value);
                    dc.Add("stockNum", stockNum);

                    listOutput.Add(dc);

                    selectedAllOutputNum = selectedAllOutputNum + curOutPutNum;
                }
            }
            rtn = m_bllProductOut.doOutPut(m_outputCode, m_outputDetailId, m_factoryId, m_productId, selectedAllOutputNum, listOutput, LoginUserInfo.LoginUser.loginUser.userName);

            if (rtn == true)
            {
                MsgUtils.ShowInfoMsg("出库成功！");
                this.Close();
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
                if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["selected"].Value) == 1)
                {

                    //输入的出库数（克）
                    decimal curOutPutNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["outputNum"].Value);
                    if (curOutPutNum <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入出库数量！");
                        return false;
                    }
                    int outputUnit = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["outputUnit"].Value);
                    if (outputUnit <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请出库出库单位！");
                        return false;
                    }
                    curOutPutNum = curOutPutNum * outputUnit;

                    //库存数量（克）
                    decimal curStockNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["num"].Value);
                    curStockNum = curStockNum * m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["unitCode"].Value));

                    if (curOutPutNum > curStockNum)
                    {
                        MsgUtils.ShowErrorMsg("请输入适当的出库数！");
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

            //要求的出库数（克）
            decimal requestOutputNum = ConvertUtils.ConvertToDecimal(this.txt_num.Text.Trim());
            requestOutputNum = requestOutputNum * m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(this.txt_unitCode.Text));

            if (requestOutputNum > 0 && selectedAllOutputNum < requestOutputNum)
            {
                MsgUtils.ShowErrorMsg("出库数量不足！");
                return false;
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

            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "id";
            textColumn.HeaderText = "id";
            textColumn.DataPropertyName = "id";
            textColumn.Visible = false;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "inputCode";
            textColumn.HeaderText = "inputCode";
            textColumn.DataPropertyName = "inputCode";
            textColumn.Visible = false;
            this.dataGridView1.Columns.Add(textColumn);

            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.Name = "selected";
            chkColumn.HeaderText = "选择";
            textColumn.Width = 40;
            this.dataGridView1.Columns.Add(chkColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "productName";
            textColumn.HeaderText = "商品";
            textColumn.DataPropertyName = "productName";
            textColumn.Width = 160;
            textColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "num";
            textColumn.HeaderText = "库存数量";
            textColumn.DataPropertyName = "num";
            textColumn.Width = 100;
            textColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "unit";
            textColumn.HeaderText = "库存单位";
            textColumn.DataPropertyName = "unit";
            textColumn.Width = 80;
            textColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "unitCode";
            textColumn.HeaderText = "库存单位";
            textColumn.DataPropertyName = "unitCode";
            textColumn.Visible = false;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "expiresDate";
            textColumn.HeaderText = "过期日";
            textColumn.DataPropertyName = "expiresDate";
            textColumn.Width = 100;
            textColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "outputNum";
            textColumn.HeaderText = "出库数量";
            textColumn.DataPropertyName = "outputNum";
            textColumn.Width = 100;
            textColumn.ReadOnly = false;
            this.dataGridView1.Columns.Add(textColumn);

            DataGridViewComboBoxColumn cmbColumn = new DataGridViewComboBoxColumn();
            cmbColumn.Name = "outputUnit";
            cmbColumn.DataPropertyName = "outputUnit";
            cmbColumn.HeaderText = "出库单位";
            cmbColumn.Width = 80;
            textColumn.ReadOnly = false;
            this.dataGridView1.Columns.Add(cmbColumn);
            cmbColumn.DataSource = m_bllCode.GetCodeList(3);
            cmbColumn.DisplayMember = "value1";
            cmbColumn.ValueMember = "subCode";

        }
        #endregion

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 1)
            {
                return;
            }

        }

        private void btn_applyProduce_Click(object sender, EventArgs e)
        {
            decimal produceNum = ConvertUtils.ConvertToDecimal(this.txt_produceNum.Text.Trim());
            if (produceNum <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入合适的生产数量！");
                this.txt_produceNum.Focus();
                return;
            }
            if (this.cmb_produceUint.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择单位！");
                this.cmb_produceUint.Focus();
                return;
            }

            ModelProduceApply modelProduceApply = m_bllProduce.GetProduceApplyByOutputCodeAndProductId(m_outputCode, m_productId);
            if (modelProduceApply.id > 0)
            {
                if (MsgUtils.ShowQustMsg("商品【" + this.txt_product.Text + "】已经申请生产，是否再次申请？", MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if (MsgUtils.ShowQustMsg("是否确认申请生产商品【" + this.txt_product.Text + "】？", MessageBoxDefaultButton.Button1) == DialogResult.No)
                {
                    return;
                }
            }
            ModelProductOutput modelProductOutput = m_bllProductOut.GetProductOutrByOutputCode(m_outputCode);
            List<ModelProduceApply> listProduceApply = new List<ModelProduceApply>();
            ModelProduceApply newProduceApply = new ModelProduceApply();
            newProduceApply.factoryId = m_factoryId;
            newProduceApply.productId = m_productId;
            newProduceApply.num = ConvertUtils.ConvertToDecimal(this.txt_produceNum.Text.Trim());
            newProduceApply.unit = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_produceUint.SelectedItem).itemKey);
            newProduceApply.saleOrderCode = modelProductOutput.orderCode;
            newProduceApply.outputCode = m_outputCode;
            newProduceApply.deliveryDate = modelProductOutput.deliveryDate;
            newProduceApply.applyType = 1;
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

    }
}
