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
    public partial class FrmMaterialsOutDetail : Main.BaseForm
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看）
        private int m_mode;
        private int m_materialsOutId;
        private string m_outputCode;

        private BllCompany m_bllCompany = new BllCompany();
        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllMaterialsOut m_bllMaterialsOut = new BllMaterialsOut();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmMaterialsOutDetail(int _mode, int _materialsOutId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_materialsOutId = _materialsOutId;
        }

        private void FrmMaterialsOutDetail_Load(object sender, EventArgs e)
        {           
            //初始化
            init();
        }

        private void FrmMaterialsOutDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit(true);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回列表
            this.Hide();
        }
                
        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {      

            //下拉框
            //申请人
            List<ModelItem>  listItem = m_bllUser.GetUsersWithItem();
            WinCommon.BindComboBox(ref this.cmb_applyBy, listItem);
            ////入库原料
            //listItem = m_bllMaterials.GetMaterialsItem("");
            //WinCommon.BindComboBox(ref this.cmb_type, listItem);
            //入库工厂
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem);

            DataGridViewComboBoxColumn colSpecs = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["specsId"];
            listItem = m_bllMaterials.GetMaterialsSpecsListForCombo(0);
            ModelItem blankModelItem = new ModelItem();
            blankModelItem.itemKey = 0;
            blankModelItem.itemValue = "";
            listItem.Add(blankModelItem);
            colSpecs.DataSource = listItem;
            colSpecs.DisplayMember = "itemValue";
            colSpecs.ValueMember = "itemKey";

            //初始化数据
            if (m_mode != 0 && m_materialsOutId > 0)
            {

                ModelMaterialsOutput model = m_bllMaterialsOut.GetMaterialsOutById(m_materialsOutId);

                //出库单号
                m_outputCode = model.outputCode;

                //出库类型
                this.cmb_outputType.SelectedIndex = model.outputType;

                //出库状态
                this.cmb_outputStatus.SelectedIndex = model.outputStatus;

                //生产编号
                this.txt_produceCode.Text = model.produceCode;

                //申请人
                for (int i = 0; i < this.cmb_applyBy.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_applyBy.Items[i];
                    if (model.applyMemberId == (int)modelItem.itemKey)
                    {
                        this.cmb_applyBy.SelectedIndex = i;
                        break;
                    }
                }

                //申请日期
                this.dtp_applyDate.Value = ConvertUtils.ConvertToDate(model.createTime, "yyyy-MM-dd");

                //工厂
                for (int i = 0; i < this.cmb_factory.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_factory.Items[i];
                    if (model.factoryId == (int)modelItem.itemKey)
                    {
                        this.cmb_factory.SelectedIndex = i;
                        break;
                    }
                }

                //备注
                this.txt_remark.Text = model.remark;

                if (model.outputStatus == 1)
                {
                    m_mode = 3;
                    grb_materialsOut.Enabled = false;
                }

                this.dataGridView1.DataSource = m_bllMaterialsOut.GetMaterialsOutDetailByOutputCode(model.outputCode);
                this.dataGridView1.Refresh();
            }           

            //按钮处理
            this.btn_submit.Visible = true;
            this.btn_cancel.Visible = true;
            this.btn_close.Visible = false;

            if (m_mode == 3)
            {
                this.btn_submit.Visible = false;
                this.btn_cancel.Visible = false;
                this.btn_close.Visible = true;
            }

            //新增修改时
            if (m_mode == 0 || m_mode == 1)
            {
                grb_materialsOut.Enabled = true;
            }

            if (m_mode == 2)
            {
                this.btn_submit.Text = "确认删除";
            }

            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                grb_materialsOut.Enabled = false;
                grb_new.Enabled = false;
                this.dataGridView1.Columns["deleteBtn"].Visible = false;
            }

            
        }
        #endregion

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        private Boolean doSubmit(bool _isConfirm)
        {
            Boolean rtn = false;

            //检查
            if (doCheck(_isConfirm) == false)
            {
                return false;
            }

            ModelMaterialsOutput modelMaterialsOutput = new ModelMaterialsOutput();
            modelMaterialsOutput.id = m_materialsOutId;
            modelMaterialsOutput.outputCode = m_outputCode;
            modelMaterialsOutput.outputType = this.cmb_outputType.SelectedIndex;
            modelMaterialsOutput.outputStatus = this.cmb_outputStatus.SelectedIndex;
            modelMaterialsOutput.outputDate = DateTime.Now;

            modelMaterialsOutput.produceCode = this.txt_produceCode.Text.Trim();
            modelMaterialsOutput.applyMemberId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_applyBy.SelectedItem).itemKey);
            modelMaterialsOutput.applyDate = this.dtp_applyDate.Value;

            modelMaterialsOutput.factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            modelMaterialsOutput.remark = this.txt_remark.Text.Trim();

            List<ModelMaterialsOutputDetail> listModelMaterialsOutputDetail = new List<ModelMaterialsOutputDetail>();

            int outputStatus = 1;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                int statusCode = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["statusCode"].Value);
                if (statusCode == 0)
                {
                    outputStatus = 0;
                    int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["materialsId"].Value);
                    if (materialsId > 0)
                    {
                        ModelMaterialsOutputDetail modelMaterialsOutputDetail = new ModelMaterialsOutputDetail();
                        modelMaterialsOutputDetail.id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value);
                        modelMaterialsOutputDetail.outputCode = m_outputCode;
                        modelMaterialsOutputDetail.materialsId = materialsId;
                        modelMaterialsOutputDetail.specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value);
                        modelMaterialsOutputDetail.requestOutputWeight = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["requestOutputWeight"].Value);
                        modelMaterialsOutputDetail.requestOutputNum = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["requestOutputNum"].Value);
                        modelMaterialsOutputDetail.isDelete = 0;
                        modelMaterialsOutputDetail.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                        modelMaterialsOutputDetail.createTime = DateTime.Now;
                        modelMaterialsOutputDetail.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                        modelMaterialsOutputDetail.modifyTime = DateTime.Now;

                        listModelMaterialsOutputDetail.Add(modelMaterialsOutputDetail);
                    }
                }
            }
            modelMaterialsOutput.modelMaterialsOutputDetail = listModelMaterialsOutputDetail;

            if (modelMaterialsOutput.outputStatus == 0 && outputStatus == 1 && _isConfirm == true)
            {
                if(MsgUtils.ShowQustMsg("是否完成出库?",MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    modelMaterialsOutput.outputStatus = 1;
                    modelMaterialsOutput.outputDate = DateTime.Now;
                }
            }

            modelMaterialsOutput.isDelete = 0;
            modelMaterialsOutput.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelMaterialsOutput.createTime = DateTime.Now;
            modelMaterialsOutput.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelMaterialsOutput.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllMaterialsOut.AddMaterialsOut(modelMaterialsOutput);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("新增出库单失败！");
                    return false;
                }
                else
                {
                    //处理模式变为修改
                    m_mode = 1;
                    ModelMaterialsOutput newMaterialsOutput = m_bllMaterialsOut.GetMaterialsOutByOutputCode(modelMaterialsOutput.outputCode);
                    m_materialsOutId = newMaterialsOutput.id;
                    m_outputCode = modelMaterialsOutput.outputCode;

                    if (_isConfirm == true)
                    {
                        MsgUtils.ShowInfoMsg("新增出库单成功！");
                        this.Hide();
                    }
                    return true;
                }
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllMaterialsOut.UpdateMaterialsOut(modelMaterialsOutput);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("修改出库单失败！");
                    return false;
                }
                else
                {
                    if (_isConfirm == true)
                    {
                        MsgUtils.ShowInfoMsg("修改出库单成功！");
                        m_outputCode = modelMaterialsOutput.outputCode;
                        this.Hide();
                    }
                    return true;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllMaterialsOut.DeleteMaterialsOut(modelMaterialsOutput);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("删除出库单失败！");
                    return false;
                }
                else
                {
                    if (_isConfirm == true)
                    {
                        MsgUtils.ShowInfoMsg("删除出库单成功！");
                        this.Hide();
                    }
                    return true;
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
            if (StringUtils.IsNotBlank(m_outputCode))
            {
                //修改
                if (m_mode == 1)
                {
                    if (m_bllMaterialsOut.CheckUpdateDelete(m_outputCode) == false)
                    {
                        MsgUtils.ShowErrorMsg("已出库，不可修改！");
                        return false;
                    }
                }

                //删除
                if (m_mode == 2)
                {
                    if (m_bllMaterialsOut.CheckUpdateDelete(m_outputCode) == false)
                    {
                        MsgUtils.ShowErrorMsg("已出库，不可删除！");
                        return false;
                    }
                }
            }

            // 新增或修改
            if (m_mode == 0 || m_mode == 1)
            {
                //出库类型
                if (this.cmb_outputType.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择出库类型！");
                    this.cmb_outputType.Focus();
                    return false;
                }

                //出库状态
                if (this.cmb_outputStatus.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择出库状态！");
                    this.cmb_outputType.Focus();
                    return false;
                }
               
                //申请人
                if (this.cmb_applyBy.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择申请人！");
                    this.cmb_applyBy.Focus();
                    return false;
                }

                //工厂
                if (this.cmb_factory.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择出库工厂！");
                    this.cmb_factory.Focus();
                    return false;
                }

                if (_isConfirm)
                {
                    bool hasMaterials = false;
                    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                    {
                        int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["materialsId"].Value);
                        ModelMaterials modelMaterials = m_bllMaterials.GetMaterialsById(materialsId);
                        if (materialsId > 0)
                        {
                            int specs = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value);

                            if (modelMaterials.type != 2 && specs <= 0)
                            {
                                MsgUtils.ShowErrorMsg("请选择原料【" + modelMaterials.name + "】的规格！");
                                this.dataGridView1.Focus();
                                return false;
                            }

                            int requestOutputNum = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["requestOutputNum"].Value);

                            if (requestOutputNum <= 0)
                            {
                                MsgUtils.ShowErrorMsg("请输入出库数量！");
                                this.dataGridView1.Focus();
                                return false;
                            }

                            int realityOutputNum = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["realityOutputNum"].Value);
                            if (requestOutputNum < realityOutputNum)
                            {
                                MsgUtils.ShowErrorMsg("请求出库数不可小于已经出库数！");
                                this.dataGridView1.Focus();
                                return false;
                            }

                            hasMaterials = true;
                        }
                    }

                    if (hasMaterials == false)
                    {
                        MsgUtils.ShowErrorMsg("请选择出库原料！");
                        this.dataGridView1.Focus();
                        return false;
                    }

                }
            }

            return true;
        }
        #endregion
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_applyNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.cmb_type.SelectedIndex == 2)
            {   
                //仅限数字
                e.Handled = WinCommon.IsOnlyInt(e.KeyChar);
            }
            else
            {
                //仅限数字
                e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (m_mode == 0 || m_mode == 1)
            {
                if (doSubmit(false) == false)
                {
                    return;
                }
            }
            //Excel模板文件
            string strFilePath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")) + "\\tpl\\出库单-原料.xlsx";
            if (!File.Exists(strFilePath))
            {
                MsgUtils.ShowErrorMsg("出库单Excel模版不存在，无法打印！");
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

            ModelMaterialsOutput modelMaterialsOutput = m_bllMaterialsOut.GetMaterialsOutByOutputCode(m_outputCode);

            //赋值
            //公司名称
            worksheet.Cells[2, 2] = m_bllCompany.GetCompany().name;
            //公司地址
            worksheet.Cells[3, 3] = m_bllCompany.GetCompany().address;
            //出库单号
            worksheet.Cells[5, 3] = m_outputCode;
            //出库日期
            worksheet.Cells[6, 3] = ConvertUtils.ConvertToDateString(modelMaterialsOutput.modifyTime, "yyyy-MM-dd");
            //库房
            worksheet.Cells[7, 3] = m_bllFactory.GetFactoryById(modelMaterialsOutput.factoryId).name;
            //申领人
            worksheet.Cells[8, 3] = ((ModelItem)this.cmb_applyBy.SelectedItem).itemValue;
            //生产单号
            worksheet.Cells[9, 3] = this.txt_produceCode.Text;

            //出库原料明细
            int startIdx = 12;
            int idx = 0;

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value) > 0)
                {
                    if (idx > 0)
                    {
                        worksheet.get_Range("B" + (startIdx + idx), "G" + (startIdx + idx)).Insert(Shift: Excel.XlInsertShiftDirection.xlShiftDown);
                        worksheet.get_Range("B" + startIdx, "G" + startIdx).Select();
                        worksheet.get_Range("B" + startIdx, "G" + startIdx).Copy(Type.Missing);
                        worksheet.get_Range("B" + (startIdx + idx), "G" + (startIdx + idx)).PasteSpecial(Excel.XlPasteType.xlPasteFormats);
                    }
                    int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["materialsId"].Value);
                    //原料编码
                    worksheet.Cells[startIdx + idx, 2] = m_bllMaterials.GetMaterialsById(materialsId).modelMaterialsSearch.searchKey;
                    //原料名称
                    worksheet.Cells[startIdx + idx, 3] = this.dataGridView1.Rows[i].Cells["materialsName"].Value;
                    //规格
                    int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value);
                    worksheet.Cells[startIdx + idx, 6] = m_bllMaterials.GetMaterialsSpecsById(specsId).name;
                    //数量
                    worksheet.Cells[startIdx + idx, 7] = this.dataGridView1.Rows[i].Cells["realityOutputNum"].Value;

                    idx = idx + 1;
                }
            }
 
            WinCommon.PrintExcel(xlApp, workbook);
        }

        private void cmb_materials_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmb_specs.Items.Clear();

            int materialsId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_materials.SelectedItem).itemKey);
            if (materialsId > 0)
            {
                List<ModelItem> listItem = m_bllMaterials.GetMaterialsSpecsListForCombo(materialsId);
                WinCommon.BindComboBox(ref this.cmb_specs, listItem);
            }

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (this.cmb_type.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择原料类型！");
                this.cmb_type.Focus();
                return;
            }
            if (this.cmb_materials.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择原料名称！");
                this.cmb_materials.Focus();
                return;
            }
            int materialsId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_materials.SelectedItem).itemKey);

            if (this.cmb_specs.Enabled == true && this.cmb_specs.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择规格！");
                this.cmb_specs.Focus();
                return;
            }
            int specsId = this.cmb_specs.SelectedIndex < 0 ? 0 : ConvertUtils.ConvertToInt(((ModelItem)this.cmb_specs.SelectedItem).itemKey);

            int num = ConvertUtils.ConvertToInt(this.txt_num.Text.Trim());
            if (num <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入出库数量！");
                this.cmb_specs.Focus();
                return;
            }

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                int materialsIdExist = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["materialsId"].Value);
                int specsIdExist = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value);

                if (this.cmb_specs.Enabled == true)
                {
                    if (materialsIdExist == materialsId && specsIdExist == specsId)
                    {
                        MsgUtils.ShowErrorMsg("选择的原料规格已存在！");
                        this.cmb_specs.Focus();
                        return;
                    }
                }
                else
                {
                    if (materialsIdExist == materialsId)
                    {
                        MsgUtils.ShowErrorMsg("选择的原料规格已存在！");
                        this.cmb_specs.Focus();
                        return;
                    }
                }
            }

            if (doSubmit(false))
            {
                ModelMaterialsOutputDetail model = new ModelMaterialsOutputDetail();
                model.outputCode = m_outputCode;
                model.materialsId = materialsId;
                model.specsId = specsId;
                model.requestOutputNum = num;
                model.outputStatus = 0;
                model.isDelete = 0;
                model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                model.createTime = DateTime.Now;

                if (m_bllMaterialsOut.AddMaterialsOutputDetail(model) == false)
                {
                    MsgUtils.ShowErrorMsg("新增出库原料失败！");
                    return;
                }
                else
                {
                    //MsgUtils.ShowInfoMsg("新增成品规格成功！");
                    dataGridView1.DataSource = m_bllMaterialsOut.GetMaterialsOutDetailByOutputCode(model.outputCode);
                    dataGridView1.Refresh();

                    return;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            //出库按钮
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "outputBtn")
            {
                int id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                if (id > 0)
                {
                    int outputDetailId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    int factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
                    int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["materialsId"].Value);
                    int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["specsId"].Value);
                    int outputStatus = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["statusCode"].Value);

                    ModelMaterials modelMaterials = m_bllMaterials.GetMaterialsById(materialsId);
                    if (modelMaterials.type != 2 && specsId <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请先选择规格！");
                        return;
                    }

                    //保存数据
                    if (m_mode == 0 || m_mode == 1)
                    {
                        if (doSubmit(false) == false)
                        {
                            return;
                        }
                    }

                    Form form = new FrmMaterialsOutSelect(m_outputCode, outputDetailId, factoryId, materialsId, specsId, ConvertUtils.ConvertToInt(((ModelItem)this.cmb_applyBy.SelectedItem).itemKey));
                    form.ShowDialog();
                    dataGridView1.DataSource = m_bllMaterialsOut.GetMaterialsOutDetailByOutputCode(m_outputCode);
                    dataGridView1.Refresh();

                }
            }

            //删除
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["realityOutputNum"].Value) > 0)
                {
                    MsgUtils.ShowErrorMsg("原料已出库，不可删除!");
                    return;
                }

                int id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                if (id > 0)
                {
                    if (MsgUtils.ShowQustMsg("确认从出库清单中删除此原料么？", MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }

                    ModelMaterialsOutputDetail model = new ModelMaterialsOutputDetail();
                    model.id = id;
                    model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    model.modifyTime = DateTime.Now;

                    if (m_bllMaterialsOut.DeteleMaterialsOutputDetail(model) == false)
                    {
                        MsgUtils.ShowErrorMsg("删除原料失败！");
                        return;
                    }
                    else
                    {
                        dataGridView1.DataSource = m_bllMaterialsOut.GetMaterialsOutDetailByOutputCode(m_outputCode);
                        dataGridView1.Refresh();

                        return;
                    }
                }
            }

            //查看库存
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "queryStore")
            {
                int factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
                string materialsName = ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells["materialsName"].Value);
                int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["specsId"].Value);

                Form form = new Store.FrmMaterialsQueryStore(factoryId, materialsName, specsId);
                form.ShowDialog();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "specsId")
            {
               
                int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["materialsId"].Value);

                if (materialsId > 0)
                {
                    ModelMaterials modelMaterials = m_bllMaterials.GetMaterialsById(materialsId);

                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells["specsId"];

                    if (modelMaterials.type != 2)
                    {
                        cell.ReadOnly = false;
                        List<ModelItem> listItem = m_bllMaterials.GetMaterialsSpecsListForCombo(materialsId);
                        ModelItem item = new ModelItem();
                        item.itemKey = 0;
                        item.itemValue = "";
                        listItem.Insert(0, item);
                        cell.DataSource = listItem;
                        cell.DisplayMember = "itemValue";
                        cell.ValueMember = "itemKey";
                    }
                    else
                    {
                        cell.ReadOnly = true;
                    }
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["statusCode"].Value) == 1)
                {
                    DataGridViewComboBoxCell cellSpecs = (DataGridViewComboBoxCell)this.dataGridView1.Rows[i].Cells["specsId"];
                    cellSpecs.ReadOnly = true;
                    DataGridViewTextBoxCell cellNum = (DataGridViewTextBoxCell)this.dataGridView1.Rows[i].Cells["requestOutputNum"];
                    cellNum.ReadOnly = true;
                }
            }
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ModelItem> listItem = m_bllMaterials.GetMaterialsItemByType(this.cmb_type.SelectedIndex);
            WinCommon.BindComboBox(ref this.cmb_materials, listItem);

            if (this.cmb_type.SelectedIndex == 2)
            {
                this.cmb_specs.Enabled = false;
            }
            else
            {
                this.cmb_specs.Enabled = true;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "specsId")
            {
                decimal requestWeight = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[e.RowIndex].Cells["requestOutputWeight"].Value, 4);
                int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["specsId"].Value);

                if (requestWeight > 0 && specsId > 0)
                {
                    ModelMaterialsSpecs modelSpecs = m_bllMaterials.GetMaterialsSpecsById(specsId);

                    int requestNum = ConvertUtils.ConvertToInt(Math.Ceiling(requestWeight / (modelSpecs.weight * modelSpecs.num)));

                    this.dataGridView1.Rows[e.RowIndex].Cells["requestOutputNum"].Value = requestNum;
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.Cancel = true;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "specsId")
            {
                if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["statusCode"].Value) == 1)
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
