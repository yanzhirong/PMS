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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace PMS.Frm.Store
{
    public partial class FrmProductInQC : Main.BaseForm
    {
        private string m_inputCode;
        private int m_mode;
        private int QCid;

        private BllCompany m_bllCompany = new BllCompany();
        private BllProductIn m_bllProductIn = new BllProductIn();
        private BllUser m_bllUser = new BllUser();

        public FrmProductInQC(int _model, string _inputCode)
        {
            InitializeComponent();
            m_mode = _model;
            m_inputCode = _inputCode;
        }

        private void FrmProductInQC_Load(object sender, EventArgs e)
        {
            
            //初始化
            init();
        }

        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {
            //下拉框
            //销售
            List<ModelItem> listItem = m_bllUser.GetUsersWithItem();
            WinCommon.BindComboBox(ref this.cmb_inspecter, listItem);
            WinCommon.BindComboBox(ref this.cmb_checker, listItem);

            System.Data.DataTable dt = m_bllProductIn.GetProductInQC(m_inputCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                this.QCid = ConvertUtils.ConvertToInt(dr["QCid"]);

                this.txt_factoryName.Text = ConvertUtils.ConvertToString(dr["factoryName"]);
                this.txt_inputNum.Text = ConvertUtils.ConvertToString(dr["inputNum"]);
                this.txt_productName.Text = ConvertUtils.ConvertToString(dr["productName"]);
                this.txt_productType.Text = ConvertUtils.ConvertToString(dr["morphology"]);
                this.txt_specsName.Text = ConvertUtils.ConvertToString(dr["specsName"]);
                this.txt_excuteStandard.Text = ConvertUtils.ConvertToString(dr["excuteStandard"]);
                this.txt_produceCode.Text = ConvertUtils.ConvertToString(dr["produceCode"]);
                this.txt_produceDate.Text = ConvertUtils.ConvertToString(dr["produceDate"]);

                if (ConvertUtils.ConvertToInt(dr["inspectResult"]) >= 0)
                {
                    this.cmb_result.SelectedIndex = ConvertUtils.ConvertToInt(dr["inspectResult"]);

                    int inspecterId = ConvertUtils.ConvertToInt(dr["inspecterId"]);
                    for (int i = 0; i < this.cmb_inspecter.Items.Count; i++)
                    {
                        ModelItem modelItem = (ModelItem)this.cmb_inspecter.Items[i];
                        if (inspecterId == (int)modelItem.itemKey)
                        {
                            this.cmb_inspecter.SelectedIndex = i;
                            break;
                        }
                    }
                    int checkerId = ConvertUtils.ConvertToInt(dr["checkerId"]);
                    for (int i = 0; i < this.cmb_checker.Items.Count; i++)
                    {
                        ModelItem modelItem = (ModelItem)this.cmb_checker.Items[i];
                        if (checkerId == (int)modelItem.itemKey)
                        {
                            this.cmb_checker.SelectedIndex = i;
                            break;
                        }
                    }

                    this.dtp_QCDate.Value = ConvertUtils.ConvertToDate(dr["inspectDate"],"yyyy-MM-dd");
                }

                this.dataGridView1.DataSource = m_bllProductIn.GetProductInQCDetail(m_inputCode); 
                this.dataGridView1.Refresh();
            }

            if (m_mode == 3)
            {
                this.grb_QC.Enabled = false;
                this.btn_submit.Enabled = false;
                this.btn_cancel.Text = "关闭";
            }
        }
        #endregion

        private void FrmProductInQC_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
 
        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit(true);
        }

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        private bool doSubmit(bool _isConfirm)
        {
            //检查
            if (doCheck(_isConfirm) == false)
            {
                return false;
            }

            ModelProductInQC modelProductInQC = new ModelProductInQC();

            modelProductInQC.id = QCid;
            modelProductInQC.inputCode = m_inputCode;
            modelProductInQC.inspectResult = this.cmb_result.SelectedIndex;
            modelProductInQC.inspecterId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_inspecter.SelectedItem).itemKey);
            modelProductInQC.checkerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_checker.SelectedItem).itemKey);
            modelProductInQC.inspectDate = this.dtp_QCDate.Value;

            List<ModelProductInQCDetail> modelProductInQCDetail = new List<ModelProductInQCDetail>();
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {

                int id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value);
                string name = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["name"].Value);
                string target = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["target"].Value);
                string resultString = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["result"].Value);
                if (StringUtils.IsNotBlank(name))
                {
                    ModelProductInQCDetail model = new ModelProductInQCDetail();
                    model.id = id;
                    model.inputCode = m_inputCode;
                    model.name = name;
                    model.target = target;
                    model.result = resultString == "合格" ? 1: 0;
                    model.isDelete = 0;
                    model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                    model.createTime = DateTime.Now;
                    model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    model.modifyTime = DateTime.Now;

                    modelProductInQCDetail.Add(model);
                }

            }
            modelProductInQC.modelProductInQCDetail = modelProductInQCDetail;

            modelProductInQC.isDelete = 0;
            modelProductInQC.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelProductInQC.createTime = DateTime.Now;
            modelProductInQC.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelProductInQC.modifyTime = DateTime.Now;

            if (m_bllProductIn.AddUpdateProductInQC(modelProductInQC) == false)
            {
                MsgUtils.ShowErrorMsg("质检报告更新失败！");
                return false;
            }
            else
            {
                DataTable dt = m_bllProductIn.GetProductInQC(m_inputCode);
                if (dt != null && dt.Rows.Count > 0)
                {
                    QCid = ConvertUtils.ConvertToInt(dt.Rows[0]["QCid"]);
                }
                if (_isConfirm)
                {
                    MsgUtils.ShowInfoMsg("质检报告更新成功！");
                    this.Hide();
                }
            }
            return true;
        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean doCheck(bool _isConfirm)
        {
            //结论
            if (this.cmb_result.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择检验结论！");
                this.cmb_result.Focus();
                return false;
            }

            //检验员
            if (this.cmb_inspecter.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择检验员！");
                this.cmb_inspecter.Focus();
                return false;
            }

            //审核员
            if (this.cmb_checker.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择审核员！");
                this.cmb_checker.Focus();
                return false;
            }
            bool hasInspecter = false;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                string name = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["name"].Value);
                if (StringUtils.IsNotBlank(name))
                {
                    string target = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["target"].Value);
                    if (StringUtils.IsBlank(target))
                    {
                        MsgUtils.ShowErrorMsg("请输入指标！");
                        this.dataGridView1.Focus();
                        return false;
                    }
                    if (StringUtils.IsBlank(ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["result"].Value)))
                    {
                        MsgUtils.ShowErrorMsg("请选择检验结果！");
                        this.dataGridView1.Focus();
                        return false;
                    }

                    hasInspecter = true;
                }
            }
            if (hasInspecter == false)
            {
                MsgUtils.ShowErrorMsg("请输入检验项目！");
                this.dataGridView1.Focus();
                return false;
            }

            return true;
        }
        #endregion

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (this.dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
                {
                    if (e.RowIndex == this.dataGridView1.Rows.Count -1)
                    {
                        this.dataGridView1.Rows[e.RowIndex].Cells["name"].Value = "";
                        this.dataGridView1.Rows[e.RowIndex].Cells["target"].Value = "";
                        this.dataGridView1.Rows[e.RowIndex].Cells["result"].Value = "合格";
                    }
                    else
                    {
                        this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (doSubmit(false) == false)
            {
                return;
            }

            //Excel模板文件
            string strFilePath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")) + "\\tpl\\质检单.xlsx";
            if (!File.Exists(strFilePath))
            {
                MsgUtils.ShowErrorMsg("质检单Excel模版不存在，无法打印！");
                return;
            }
            
            //定义
            Excel.Application xlApp;
            Excel.Workbook workbook;

            if (WinCommon.OpenExcelTpl(strFilePath, out xlApp, out workbook) == false)
            {
                return;
            }

            Excel.Worksheet worksheet = workbook.Worksheets[1];//取得sheet1

            //赋值
            //公司名称
            worksheet.Cells[2, 1] = m_bllCompany.GetCompany().name;
            //品名
            worksheet.Cells[5, 2] = this.txt_productName.Text;
            //检验依据
            worksheet.Cells[5, 4] = this.txt_excuteStandard.Text;
            //类别
            worksheet.Cells[6, 2] = this.txt_productType.Text;
            //生产批号
            worksheet.Cells[6, 4] = this.txt_produceCode.Text;
            //规格
            worksheet.Cells[7, 2] = this.txt_specsName.Text;
            //生产日期
            worksheet.Cells[7, 4] = this.txt_produceDate.Text;
            //数量
            worksheet.Cells[8, 2] = this.txt_inputNum.Text;
            //检验日期
            worksheet.Cells[8, 4] = this.dtp_QCDate.Text;

            //检验项目
            int startRowIdx = 11;
            int idx = 0;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (StringUtils.IsNotBlank((string)this.dataGridView1.Rows[i].Cells["name"].Value))
                {
                    if (i > 0)
                    {
                        worksheet.get_Range("A" + (startRowIdx + idx), "D" + (startRowIdx + idx)).Insert(Shift: Excel.XlInsertShiftDirection.xlShiftDown);
                        worksheet.get_Range("A" + startRowIdx, "D" + startRowIdx).Select();
                        worksheet.get_Range("A" + startRowIdx, "D" + startRowIdx).Copy(Type.Missing);
                        worksheet.get_Range("A" + (startRowIdx + idx), "D" + (startRowIdx + idx)).PasteSpecial(Excel.XlPasteType.xlPasteFormats);
                    }

                    //序号
                    worksheet.Cells[startRowIdx + idx, 1] = idx + 1;
                    //检验项目名
                    worksheet.Cells[startRowIdx + idx, 2] = this.dataGridView1.Rows[i].Cells["name"].Value;
                    //指标
                    worksheet.Cells[startRowIdx + idx, 3] = this.dataGridView1.Rows[i].Cells["target"].Value;
                    //指标
                    worksheet.Cells[startRowIdx + idx, 4] = this.dataGridView1.Rows[i].Cells["result"].Value;

                    idx = idx + 1;
                }
            }

            //结论
            worksheet.Cells[startRowIdx + idx, 2] = this.cmb_result.Text;
            //检验
            worksheet.Cells[startRowIdx + idx + 2, 2] = ConvertUtils.ConvertToString(((ModelItem)this.cmb_inspecter.SelectedItem).itemValue);
            //审核
            worksheet.Cells[startRowIdx + idx + 2, 4] = ConvertUtils.ConvertToString(((ModelItem)this.cmb_checker.SelectedItem).itemValue);

            WinCommon.PrintExcel(xlApp, workbook);
 
        }

    }
}
