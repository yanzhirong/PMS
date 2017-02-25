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
    public partial class FrmMaterialsOutSelect : Form
    {
        private string m_outputCode;
        private int m_materialsId;
        private int m_factoryId;
        private int m_applyMemberId;
        private decimal m_realityOutputNum;

        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllMaterialsOut m_bllMaterialsOut = new BllMaterialsOut();
        private BllPurchase m_bllPurchase = new BllPurchase();
        private BllProduce m_bllProduce = new BllProduce();
        private BllStore m_bllStore = new BllStore();
        private BllCode m_bllCode = new BllCode();
        private BllFactory m_bllFactory = new BllFactory();

        public FrmMaterialsOutSelect(string _outputCode, int _factoryId, int _materialsId, int _applyMemberId)
        {
            InitializeComponent();
            m_outputCode = _outputCode;
            m_materialsId = _materialsId;
            m_factoryId = _factoryId;
            m_applyMemberId = _applyMemberId;
        }

        private void FrmMaterialsOutSelect_Load(object sender, EventArgs e)
        {
           
            //初始化
            init();
        }

        private void FrmMaterialsOutSelect_FormClosed(object sender, FormClosedEventArgs e)
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
            //单位下拉框
            List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.WeightUnit, false);
            WinCommon.BindComboBox(ref this.cmb_purchaseUint, listItem);

            //出库单号
            this.txt_outputCode.Text = m_outputCode;
            //工厂
            this.txt_factory.Text = m_bllFactory.GetFactoryById(m_factoryId).name;
            //出库物料
            this.txt_materials.Text = m_bllMaterials.GetMaterialsById(m_materialsId).name;

            if (StringUtils.IsNotBlank(m_outputCode))
            {
                ModelMaterialsOutput modelMaterialsOutput = m_bllMaterialsOut.GetMaterialsOutByOutputCode(m_outputCode);
                //出库数量
                this.txt_num.Text = modelMaterialsOutput.outputNum.ToString();
                //单位
                this.txt_unitCode.Text = modelMaterialsOutput.outputUnit.ToString();

                this.txt_unit.Text = m_bllCode.GetSubCode((int)Enum.EnumCode.WeightUnit, modelMaterialsOutput.outputUnit).value1;

                m_realityOutputNum = modelMaterialsOutput.realityOutputNum;

                for (int i = 0; i < this.cmb_purchaseUint.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_purchaseUint.Items[i];
                    if (modelMaterialsOutput.outputUnit == (int)modelItem.itemKey)
                    {
                        this.cmb_purchaseUint.SelectedIndex = i;
                        break;
                    }
                }

                if (modelMaterialsOutput.outputStatus == 1)
                {
                    this.grb_materialsOut.Enabled = false;
                    this.lbl_selectOutput.Visible = false;
                    this.dataGridView1.Visible = false;
                    this.btn_submit.Visible = false;
                    this.btn_cancel.Visible = false;
                    this.btn_close.Visible = true;
                }
                else
                {
                    this.grb_materialsOut.Enabled = true;
                    this.lbl_selectOutput.Visible = true;
                    this.dataGridView1.Visible = true;
                    this.btn_submit.Visible = true;
                    this.btn_cancel.Visible = true;
                    this.btn_close.Visible = false;
                }
            }

            //设置列表信息
            SetDataGridViewStyle();

            //初始化列表
            doSelect();
        }

        //查询
        private void doSelect()
        {
            this.dataGridView1.DataSource = m_bllMaterialsOut.GetMaterialsOutSelect(m_factoryId, m_materialsId);
            this.dataGridView1.Refresh();

            this.dataGridView2.DataSource = m_bllStore.GetMaterialsOutputLogByOutputCode(m_outputCode);
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
            decimal selectedAllOutputNum = 0;

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
                    decimal curOutPutNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["outputNum"].Value);
                    dc.Add("outputNum", curOutPutNum);
                    //出库单位
                    int outputUnit = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["outputUnit"].Value);
                    dc.Add("outputUnit", outputUnit);
                    //出库数（克）
                    curOutPutNum = curOutPutNum * m_bllCode.GetWeightUnit(outputUnit);

                    //出库后剩余在库数
                    decimal stockNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["num"].Value);
                    //转为克
                    stockNum = stockNum * m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["unit"].Value));
                    stockNum = stockNum - curOutPutNum;
                    stockNum = stockNum / m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["unit"].Value));
                    dc.Add("stockNum", stockNum);

                    listOutput.Add(dc);

                    selectedAllOutputNum = selectedAllOutputNum + curOutPutNum;
                }
            }

            selectedAllOutputNum = selectedAllOutputNum / m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(this.txt_unitCode.Text));

            rtn = m_bllMaterialsOut.doOutPut(m_outputCode, m_factoryId, m_materialsId, selectedAllOutputNum, m_applyMemberId, listOutput, LoginUserInfo.LoginUser.loginUser.userName);

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
                if (this.dataGridView1.Rows[i].Cells["selected"].EditedFormattedValue.ToString() == "True")
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
                        MsgUtils.ShowErrorMsg("请选择出库单位！");
                        return false;
                    }
                    curOutPutNum = curOutPutNum * m_bllCode.GetWeightUnit(outputUnit);

                    //库存数量（克）
                    decimal curStockNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["num"].Value);
                    curStockNum = curStockNum * m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["unit"].Value));

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

            //要求的出库数（克）
            decimal requestOutputNum = ConvertUtils.ConvertToDecimal(this.txt_num.Text.Trim());
            requestOutputNum = requestOutputNum * m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(this.txt_unitCode.Text));

            if (requestOutputNum > 0 && (selectedAllOutputNum + m_realityOutputNum * m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(this.txt_unitCode.Text))) > requestOutputNum)
            {
                if (MsgUtils.ShowQustMsg("出库数量大于申请数量，确认出库么？", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return false;
                }
            }
            if (requestOutputNum > 0 && (selectedAllOutputNum + m_realityOutputNum * m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(this.txt_unitCode.Text))) < requestOutputNum)
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

            DataGridViewTextBoxColumn colMaterials = new DataGridViewTextBoxColumn();
            colMaterials.Name = "name";
            colMaterials.HeaderText = "物料";
            colMaterials.DataPropertyName = "name";
            colMaterials.Width = 160;
            colMaterials.ReadOnly = true;
            this.dataGridView1.Columns.Add(colMaterials);

            DataGridViewTextBoxColumn colExpiresDate = new DataGridViewTextBoxColumn();
            colExpiresDate.Name = "expiresDate";
            colExpiresDate.HeaderText = "过期日";
            colExpiresDate.DataPropertyName = "expiresDate";
            colExpiresDate.Width = 100;
            colExpiresDate.ReadOnly = true;
            this.dataGridView1.Columns.Add(colExpiresDate);

            DataGridViewTextBoxColumn colNumDisplay = new DataGridViewTextBoxColumn();
            colNumDisplay.Name = "numDisplay";
            colNumDisplay.HeaderText = "库存数量";
            colNumDisplay.DataPropertyName = "numDisplay";
            colNumDisplay.Width = 80;
            colNumDisplay.ReadOnly = true;
            this.dataGridView1.Columns.Add(colNumDisplay);

            DataGridViewTextBoxColumn colNum = new DataGridViewTextBoxColumn();
            colNum.Name = "num";
            colNum.HeaderText = "库存数量";
            colNum.DataPropertyName = "num";
            colNum.Visible = false;
            this.dataGridView1.Columns.Add(colNum);

            DataGridViewTextBoxColumn colUnit = new DataGridViewTextBoxColumn();
            colUnit.Name = "unit";
            colUnit.HeaderText = "库存单位";
            colUnit.DataPropertyName = "unit";
            colUnit.Visible = false;
            this.dataGridView1.Columns.Add(colUnit);

            DataGridViewTextBoxColumn colOutputNum = new DataGridViewTextBoxColumn();
            colOutputNum.Name = "outputNum";
            colOutputNum.HeaderText = "出库数量";
            colOutputNum.Width = 80;
            colOutputNum.ReadOnly = true;
            this.dataGridView1.Columns.Add(colOutputNum);

            DataGridViewComboBoxColumn cmbColumn = new DataGridViewComboBoxColumn();
            cmbColumn.Name = "outputUnit";
            cmbColumn.HeaderText = "出库单位";
            cmbColumn.Width = 80;
            cmbColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(cmbColumn);
            cmbColumn.DataSource = m_bllCode.GetCodeList(3);
            cmbColumn.DisplayMember = "value1";
            cmbColumn.ValueMember = "subCode";

        }
        #endregion

        private void btn_select_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 )
            {
                return;
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "outputNum")
            {
                DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells["outputUnit"];

                column.DataSource = m_bllCode.GetCodeList(3);
                column.DisplayMember = "value1";
                column.ValueMember = "subCode";
            }
        }

        private void btn_applyPurchase_Click(object sender, EventArgs e)
        {
            decimal purchaseNum = ConvertUtils.ConvertToDecimal(this.txt_purchaseNum.Text.Trim());
            if (purchaseNum <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入合适的生产数量！");
                this.txt_purchaseNum.Focus();
                return;
            }
            if (this.cmb_purchaseUint.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择单位！");
                this.cmb_purchaseUint.Focus();
                return;
            }

            ModelMaterialsOutput modelMaterialsOutput = m_bllMaterialsOut.GetMaterialsOutByOutputCode(m_outputCode);

            ModelPurchaseApply modelPurchaseApply = m_bllPurchase.GetPurchaseApplyByProcudeCodeAndMaterialsId(modelMaterialsOutput.produceCode, modelMaterialsOutput.materialsId);

            if (modelPurchaseApply.id > 0)
            {
                if (MsgUtils.ShowQustMsg("物料【" + this.txt_materials.Text + "】已经申请购买，是否再次申请？", MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if (MsgUtils.ShowQustMsg("是否确认申请购买物料【" + this.txt_materials.Text + "】？", MessageBoxDefaultButton.Button1) == DialogResult.No)
                {
                    return;
                }
            }

            ModelProduce modelProduce = m_bllProduce.GetProduceyByProduceCode(modelMaterialsOutput.produceCode);

            List<ModelPurchaseApply> listPurchaseApply = new List<ModelPurchaseApply>();
            ModelPurchaseApply newPurchaseApply = new ModelPurchaseApply();
            newPurchaseApply.factoryId = m_factoryId;
            newPurchaseApply.materialsId = m_materialsId;
            newPurchaseApply.num = ConvertUtils.ConvertToDecimal(this.txt_purchaseNum.Text.Trim());
            newPurchaseApply.unit = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_purchaseUint.SelectedItem).itemKey);
            newPurchaseApply.deliveryDate = modelProduce.deliveryDate;
            newPurchaseApply.status = 0;
            newPurchaseApply.produceCode = modelMaterialsOutput.produceCode;
            newPurchaseApply.applyType = 0;
            newPurchaseApply.applyBy = LoginUserInfo.LoginUser.loginUser.userName;
            newPurchaseApply.applyDate = DateTime.Now;
            newPurchaseApply.isDelete = 0;
            newPurchaseApply.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            newPurchaseApply.createTime = DateTime.Now;
            listPurchaseApply.Add(newPurchaseApply);

            bool rtn = m_bllPurchase.AddPurchaseApply(listPurchaseApply);

            if (rtn == true)
            {
                MsgUtils.ShowInfoMsg("申请购买成功！");
                this.Hide();
                return;
            }
            else
            {
                MsgUtils.ShowInfoMsg("申请购买失败！");
                return;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //选择
            if (this.dataGridView1.Rows[e.RowIndex].Cells["selected"].EditedFormattedValue.ToString() == "True")
            {
                this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].ReadOnly = false;
                this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].Value = this.dataGridView1.Rows[e.RowIndex].Cells["num"].Value;
                this.dataGridView1.Rows[e.RowIndex].Cells["outputUnit"].ReadOnly = false;
                this.dataGridView1.Rows[e.RowIndex].Cells["outputUnit"].Value = this.dataGridView1.Rows[e.RowIndex].Cells["unit"].Value;
            } else {
                this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].ReadOnly = true;
                this.dataGridView1.Rows[e.RowIndex].Cells["outputUnit"].ReadOnly = true;
                this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].Value = "";
            }
        }

    }
}
