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
    public partial class FrmMaterialsOutSelect : Main.BaseForm
    {
        private string m_outputCode;
        private int m_factoryId;
        private int m_outputDetailId;
        private int m_type;
        private int m_materialsId;
        private int m_specsId;
        private int m_applyMemberId;
        private decimal m_realityOutputNum;

        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllMaterialsIn m_bllMaterialsIn = new BllMaterialsIn();
        private BllMaterialsOut m_bllMaterialsOut = new BllMaterialsOut();
        private BllPurchase m_bllPurchase = new BllPurchase();
        private BllProduce m_bllProduce = new BllProduce();
        private BllStore m_bllStore = new BllStore();
        private BllCode m_bllCode = new BllCode();
        private BllFactory m_bllFactory = new BllFactory();

        public FrmMaterialsOutSelect(string _outputCode, int _outputDetailId, int _factoryId, int _materialsId, int _specsId, int _applyMemberId)
        {
            InitializeComponent();
            m_outputCode = _outputCode;
            m_outputDetailId = _outputDetailId;
            m_materialsId = _materialsId;
            m_specsId = _specsId;
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

            ModelMaterialsOutputDetail modelMaterialsOutputDetail = m_bllMaterialsOut.GetMaterialsOutDetailById(m_outputDetailId);

            //出库单号
            this.txt_outputCode.Text = m_outputCode;

            //工厂
            this.txt_factory.Text = m_bllFactory.GetFactoryById(m_factoryId).name;

            ModelMaterials modelMaterials = m_bllMaterials.GetMaterialsById(m_materialsId);

            //原料类型
            m_type = modelMaterials.type;

            //原料名称
            this.txt_materials.Text = modelMaterials.name;
            //原料规格
            ModelMaterialsSpecs modelSpecs = m_bllMaterials.GetMaterialsSpecsById(m_specsId);
            if(StringUtils.IsBlank(modelSpecs.name))
            {
                this.txt_specs.Text = "件";
            }else{
                this.txt_specs.Text = m_bllMaterials.GetMaterialsSpecsById(m_specsId).name;
            }

            //请求出库数量
            this.txt_applyNum.Text = ConvertUtils.ConvertToInt(modelMaterialsOutputDetail.requestOutputNum).ToString();
            this.txt_outputNum.Text = ConvertUtils.ConvertToInt(modelMaterialsOutputDetail.realityOutputNum).ToString();

            m_realityOutputNum = modelMaterialsOutputDetail.realityOutputNum;

            if (modelMaterialsOutputDetail.outputStatus == 1)
            {
                this.grb_applyProduce.Enabled = false;
                this.lbl_selectOutput.Visible = false;
                this.dataGridView1.Visible = false;
                this.btn_submit.Visible = false;
                this.btn_select.Visible = false;
                this.btn_cancel.Visible = false;
                this.btn_close.Visible = true;
            }
            else
            {
                this.grb_materialsOut.Enabled = true;
                this.lbl_selectOutput.Visible = true;
                this.dataGridView1.Visible = true;
                this.btn_submit.Visible = true;
                this.btn_select.Visible = true;
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
            this.dataGridView1.DataSource = m_bllMaterialsOut.GetMaterialsOutSelect(m_factoryId, m_materialsId, m_specsId);
            this.dataGridView1.Refresh();

            this.dataGridView2.DataSource = m_bllStore.GetMaterialsOutputLogByOutputCode(m_outputCode, m_materialsId, m_specsId);
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

                    //规格
                    int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value);
                    dc.Add("specsId", specsId);

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

            rtn = m_bllMaterialsOut.doOutPut(m_outputCode, m_outputDetailId, m_factoryId, m_materialsId, selectedAllOutputNum, m_applyMemberId, listOutput, LoginUserInfo.LoginUser.loginUser.userName);

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
            //输入的出库数合计
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
                    //int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value);
                    //if (specsId > 0)
                    //{
                    //    ModelMaterialsSpecs modelSpecs = m_bllMaterials.GetMaterialsSpecsById(specsId);
                    //    selectedAllOutputNum = selectedAllOutputNum + curOutPutNum * modelSpecs.weight * modelSpecs.num;
                    //}
                    //else
                    //{
                    //    selectedAllOutputNum = selectedAllOutputNum + curOutPutNum;
                    //}
                }
            }

            if (selectedAllOutputNum <= 0)
            {
                MsgUtils.ShowErrorMsg("出库数量不可为空！");
                return false;
            }

            //要求的出库数
            decimal requestOutputNum = ConvertUtils.ConvertToDecimal(this.txt_applyNum.Text.Trim(), 4) - ConvertUtils.ConvertToDecimal(this.txt_outputNum.Text.Trim(), 4);

            if (requestOutputNum > 0 && selectedAllOutputNum  > requestOutputNum)
            {
                if (MsgUtils.ShowQustMsg("出库数量大于申请数量，确认出库么？", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return false;
                }
            }
            if (requestOutputNum > 0 && selectedAllOutputNum  < requestOutputNum)
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
            colMaterials.Name = "materialsName";
            colMaterials.HeaderText = "原料";
            colMaterials.DataPropertyName = "materialsName";
            colMaterials.Width = 160;
            colMaterials.ReadOnly = true;
            this.dataGridView1.Columns.Add(colMaterials);

            DataGridViewTextBoxColumn colSpecs = new DataGridViewTextBoxColumn();
            colSpecs.Name = "specsName";
            colSpecs.HeaderText = "规格";
            colSpecs.DataPropertyName = "specsName";
            colSpecs.Width = 80;
            colSpecs.ReadOnly = true;
            this.dataGridView1.Columns.Add(colSpecs);

            DataGridViewTextBoxColumn colExpiresDate = new DataGridViewTextBoxColumn();
            colExpiresDate.Name = "expiresDate";
            colExpiresDate.HeaderText = "过期日";
            colExpiresDate.DataPropertyName = "expiresDate";
            colExpiresDate.Width = 70;
            colExpiresDate.ReadOnly = true;
            this.dataGridView1.Columns.Add(colExpiresDate);

            DataGridViewTextBoxColumn colQC = new DataGridViewTextBoxColumn();
            colQC.Name = "QC";
            colQC.HeaderText = "质检";
            colQC.DataPropertyName = "QC";
            colQC.Width = 60;
            colQC.ReadOnly = true;
            this.dataGridView1.Columns.Add(colQC);

            DataGridViewTextBoxColumn colNum = new DataGridViewTextBoxColumn();
            colNum.Name = "num";
            colNum.HeaderText = "库存数";
            colNum.DataPropertyName = "num";
            colNum.Width = 70;
            colNum.ReadOnly = true;
            this.dataGridView1.Columns.Add(colNum);

            DataGridViewTextBoxColumn colOutputNum = new DataGridViewTextBoxColumn();
            colOutputNum.Name = "outputNum";
            colOutputNum.HeaderText = "出库数";
            colOutputNum.DataPropertyName = "outputNum";
            colOutputNum.Width = 70;
            colOutputNum.ReadOnly = true;
            this.dataGridView1.Columns.Add(colOutputNum);

            DataGridViewTextBoxColumn colSpecsId = new DataGridViewTextBoxColumn();
            colSpecsId.Name = "specsId";
            colSpecsId.DataPropertyName = "specsId";
            colSpecsId.Visible = false;
            this.dataGridView1.Columns.Add(colSpecsId);
        }
        #endregion

        private void btn_select_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyInt(e.KeyChar);
        }

        private void btn_applyPurchase_Click(object sender, EventArgs e)
        {
            decimal purchaseNum = ConvertUtils.ConvertToDecimal(this.txt_purchaseNum.Text.Trim());
            if (purchaseNum <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入合适的购买数量！");
                this.txt_purchaseNum.Focus();
                return;
            }
  
            ModelMaterialsOutput modelMaterialsOutput = m_bllMaterialsOut.GetMaterialsOutByOutputCode(m_outputCode);

            ModelPurchaseApply modelPurchaseApply = m_bllPurchase.GetPurchaseApplyByProcudeCodeAndMaterialsId(modelMaterialsOutput.produceCode, m_materialsId);

            if (modelPurchaseApply.id > 0)
            {
                if (MsgUtils.ShowQustMsg("原料【" + this.txt_specs.Text + "】已经申请购买，是否再次申请？", MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if (MsgUtils.ShowQustMsg("是否确认申请购买原料【" + this.txt_specs.Text + "】？", MessageBoxDefaultButton.Button1) == DialogResult.No)
                {
                    return;
                }
            }

            ModelProduce modelProduce = m_bllProduce.GetProduceyByProduceCode(modelMaterialsOutput.produceCode);

            List<ModelPurchaseApply> listPurchaseApply = new List<ModelPurchaseApply>();
            ModelPurchaseApply newPurchaseApply = new ModelPurchaseApply();
            newPurchaseApply.factoryId = m_factoryId;
            newPurchaseApply.materialsId = m_materialsId;
            if(m_type == 2)
            {
                newPurchaseApply.num = ConvertUtils.ConvertToInt(this.txt_purchaseNum.Text.Trim());
            } else {
                ModelMaterialsSpecs modelSpecs = m_bllMaterials.GetMaterialsSpecsById(m_specsId);
                newPurchaseApply.num = ConvertUtils.ConvertToInt(this.txt_purchaseNum.Text.Trim()) * modelSpecs.weight * modelSpecs.num;
            }
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
                int selectedNum = 0;
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    if (i != e.RowIndex && this.dataGridView1.Rows[i].Cells["selected"].EditedFormattedValue.ToString() == "True")
                    {
                        selectedNum = selectedNum + ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["outputNum"].Value);
                    }
                }
                int curNum = ConvertUtils.ConvertToInt(this.txt_applyNum.Text) - ConvertUtils.ConvertToInt(this.txt_outputNum.Text) - selectedNum;
                if (curNum > 0 && ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["num"].Value) > curNum)
                {
                    this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].Value = curNum;
                }
                else
                {
                    this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].Value = this.dataGridView1.Rows[e.RowIndex].Cells["num"].Value;
                }
            }
            else
            {
                this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].ReadOnly = true;
                this.dataGridView1.Rows[e.RowIndex].Cells["outputNum"].Value = "";
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //选择
            if (this.dataGridView1.Rows[e.RowIndex].Cells["selected"].EditedFormattedValue.ToString() == "False")
            {
                if (ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells["QC"].Value) != "有")
                {
                    if (MsgUtils.ShowQustMsg("没有质检报告,不可出库！是否现在添加？", MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        string inputCode = ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells["inputCode"].Value);
                        Form form = new FrmMaterialsInQC(1, inputCode);
                        form.ShowDialog();
                        DataTable dt = m_bllMaterialsIn.GetMaterialsInQCByInputCode(inputCode);
                        if(dt != null && dt.Rows.Count > 0)
                        {
                            this.dataGridView1.Rows[e.RowIndex].Cells["QC"].Value = "有";
                        } else {
                            this.dataGridView1.Rows[e.RowIndex].Cells["QC"].Value = "无";
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void txt_purchaseNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyInt(e.KeyChar);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "inputCode")
            {
                string inputCode = ConvertUtils.ConvertToString(this.dataGridView2.Rows[e.RowIndex].Cells["inputCode"].Value);
                if (StringUtils.IsNotBlank(inputCode))
                {
                    Form form = new FrmMaterialsInDetail(3, m_bllMaterialsIn.GetMaterialsInByInputCode(inputCode).id);
                    form.ShowDialog();
                }
            }
        }
    }
}
