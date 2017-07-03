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

namespace PMS.Frm.Purchase
{
    public partial class FrmPurchaseDetail : Main.BaseForm
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看；5:取消）
        private int m_mode;
        private int m_purchaseId;
        //private string m_produceCode;
        //private string m_purchaseCode;

        private BllCompany m_bllCompany = new BllCompany();
        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();
        private BllPurchase m_bllPurchase = new BllPurchase();

        public FrmPurchaseDetail(int _mode, int _purchaseId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_purchaseId = _purchaseId;
        }

        private void FrmPurchaseDetail_Load(object sender, EventArgs e)
        {
            //初始化
            init();
        }

        private void FrmPurchaseDetail_FormClosed(object sender, FormClosedEventArgs e)
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
            //采购单状态
            List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.PurchaseStatus, false);
            WinCommon.BindComboBox(ref this.cmb_status, listItem);
            //供应商
            listItem = m_bllCustomer.GetSupplier();
            WinCommon.BindComboBox(ref this.cmb_supplier, listItem);
            ////申请者
            //listItem = m_bllUser.GetUsersWithItem();
            //WinCommon.BindComboBox(ref cmb_applyBy, listItem);
            //工厂
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem);
            //付款方式
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.PayType, false);
            WinCommon.BindComboBox(ref this.cmb_payType, listItem);
            //省市区
            WinCommon.BindComboBox(ref cmb_province, BllArea.GetProvince());
            WinCommon.BindComboBox(ref cmb_city, null);
            WinCommon.BindComboBox(ref cmb_district, null);

            DataGridViewComboBoxColumn colSpecs = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["specs"];
            listItem = m_bllMaterials.GetMaterialsSpecsListForCombo(0);
            ModelItem blankModelItem = new ModelItem();
            blankModelItem.itemKey = 0;
            blankModelItem.itemValue = "";
            listItem.Add(blankModelItem);
            colSpecs.DataSource = listItem;
            colSpecs.DisplayMember = "itemValue";
            colSpecs.ValueMember = "itemKey";

            //新增时
            if (m_mode == 0)
            {
                //this.cmb_type.SelectedIndex = 1;
                this.cmb_status.SelectedIndex = 0;
                this.dtp_deliveryDate.Value = DateTime.Now.AddMonths(1);

                ModelUser modelUser = m_bllUser.GetUserById(LoginUserInfo.LoginUser.loginUser.userId);

                this.txt_manager.Text = modelUser.userName;
                this.txt_telephone.Text = modelUser.telphone;
            }
            
            //初始化数据
            if (m_mode != 0 && m_purchaseId > 0)
            {
                ModelPurchase model = m_bllPurchase.GetPurchaseById(m_purchaseId);

                //采购编号
                this.txt_purchaseCode.Text = model.purchaseCode;

                //生产编号
                //m_produceCode = model.produceCode;

                //申请种类
                //this.cmb_type.SelectedIndex = model.applyType;

                //采购单状态
                for (int i = 0; i < this.cmb_status.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_status.Items[i];
                    if (model.status == (int)modelItem.itemKey)
                    {
                        this.cmb_status.SelectedIndex = i;
                        break;
                    }
                }

                ////申请者
                //for (int i = 0; i < this.cmb_applyBy.Items.Count; i++)
                //{
                //    ModelItem modelItem = (ModelItem)this.cmb_applyBy.Items[i];
                //    if (model.applyBy == modelItem.itemValue)
                //    {
                //        this.cmb_applyBy.SelectedIndex = i;
                //        break;
                //    }
                //}
                ////登陆者作为申请者
                //if (this.cmb_applyBy.SelectedIndex < 0)
                //{
                //    for (int i = 0; i < this.cmb_applyBy.Items.Count; i++)
                //    {
                //        ModelItem modelItem = (ModelItem)this.cmb_applyBy.Items[i];
                //        if (LoginUserInfo.LoginUser.loginUser.userId == (int)modelItem.itemKey)
                //        {
                //            this.cmb_applyBy.SelectedIndex = i;
                //            break;
                //        }
                //    }
                //}

                ////申请日期
                //this.dtp_applyDate.Value = model.applyDate;

                ////采购原料
                //for (int i = 0; i < this.cmb_materials.Items.Count; i++)
                //{
                //    ModelItem modelItem = (ModelItem)this.cmb_materials.Items[i];
                //    if (model.materialsId == (int)modelItem.itemKey)
                //    {
                //        this.cmb_materials.SelectedIndex = i;
                //        break;
                //    }
                //}

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

                //采购数量
                //this.txt_num.Text = model.num.ToString();

                //交货日期
                this.dtp_deliveryDate.Value = model.deliveryDate;

                //采购日期
                this.dtp_purchaseDate.Value = model.purchaseDate;

                //供应商
                for (int i = 0; i < this.cmb_supplier.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_supplier.Items[i];
                    if (model.customerId == (int)modelItem.itemKey)
                    {
                        this.cmb_supplier.SelectedIndex = i;
                        break;
                    }
                }

                //省
                for (int i = 0; i < this.cmb_province.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_province.Items[i];
                    if (model.province == (int)modelItem.itemKey)
                    {
                        this.cmb_province.SelectedIndex = i;
                        break;
                    }
                }

                //市
                for (int i = 0; i < this.cmb_city.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_city.Items[i];
                    if (model.city == (int)modelItem.itemKey)
                    {
                        this.cmb_city.SelectedIndex = i;
                        break;
                    }
                }

                //区
                for (int i = 0; i < this.cmb_district.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_district.Items[i];
                    if (model.district == (int)modelItem.itemKey)
                    {
                        this.cmb_district.SelectedIndex = i;
                        break;
                    }
                }

                //地址
                this.txt_address.Text = model.address;

                //联系人
                this.txt_manager.Text = model.manager;

                //电话
                this.txt_telephone.Text = model.telephone;

                //采购明细
                this.dataGridView1.DataSource = m_bllPurchase.GetPurchaseDetailByPurchaseCode(model.purchaseCode);
                this.dataGridView1.Refresh();

                //采购价格
                this.txt_orderPrice.Text = model.price.ToString();

                //付款方式
                for (int i = 0; i < this.cmb_payType.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_payType.Items[i];
                    if (model.payType == (int)modelItem.itemKey)
                    {
                        this.cmb_payType.SelectedIndex = i;
                        break;
                    }
                }

                // 备注
                this.txt_remark.Text = model.remark;

                //取消原因
                this.txt_cancelReason.Text = model.cancelReason;
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
                this.grb_purchase.Enabled = true;
                this.grb_cancel.Visible = false;
            }

            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                this.grb_purchase.Enabled = false;
                this.grb_cancel.Enabled = false;
                this.grb_cancel.Visible = true;
            }

            //取消
            if (m_mode == 5)
            {
                this.btn_submit.Text = "确认取消";
                this.grb_purchase.Enabled = false;
                this.grb_cancel.Visible = true;
            }

            //采购单状态不可修改
            this.cmb_status.Enabled = false;

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

            ModelPurchase modelPurchase = new ModelPurchase();
            modelPurchase.id = m_purchaseId;
            modelPurchase.purchaseCode = this.txt_purchaseCode.Text;
            modelPurchase.status = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_status.SelectedItem).itemKey);
            modelPurchase.factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            modelPurchase.deliveryDate = this.dtp_deliveryDate.Value;
            modelPurchase.purchaseDate = this.dtp_purchaseDate.Value;

            modelPurchase.customerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_supplier.SelectedItem).itemKey);
            modelPurchase.province = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_province.SelectedItem).itemKey);
            modelPurchase.city = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_city.SelectedItem).itemKey);
            modelPurchase.district = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_district.SelectedItem).itemKey);
            modelPurchase.provinceName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_province.SelectedItem).itemValue);
            modelPurchase.cityName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_city.SelectedItem).itemValue);
            modelPurchase.districtName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_district.SelectedItem).itemValue);
            modelPurchase.address = this.txt_address.Text.Trim();
            modelPurchase.manager = this.txt_manager.Text.Trim();
            modelPurchase.telephone = this.txt_telephone.Text.Trim();

            List<ModelPurchaseDetail> listModelPurhcaseDetail = new List<ModelPurchaseDetail>();

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["materialsId"].Value);
                if (materialsId > 0)
                {
                    ModelPurchaseDetail modelPurchaseDetail = new ModelPurchaseDetail();
                    modelPurchaseDetail.id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value);
                    modelPurchaseDetail.inputCode = BllSeq.GetCode("ylrk", "materialsInCode");
                    modelPurchaseDetail.purchaseCode = modelPurchase.purchaseCode;
                    modelPurchaseDetail.materialsId = materialsId;
                    modelPurchaseDetail.specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specs"].Value);
                    modelPurchaseDetail.num = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["num"].Value);
                    modelPurchaseDetail.price = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["price"].Value);
                    modelPurchaseDetail.produceCode = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["produceCode"].Value);
                    modelPurchaseDetail.applyType = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["applyType"].Value);
                    modelPurchaseDetail.applyDate = ConvertUtils.ConvertToDate(this.dataGridView1.Rows[i].Cells["applyDate"].Value, "yyyy-MM-dd");
                    modelPurchaseDetail.isDelete = 0;
                    modelPurchaseDetail.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                    modelPurchaseDetail.createTime = DateTime.Now;
                    modelPurchaseDetail.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    modelPurchaseDetail.modifyTime = DateTime.Now;

                    listModelPurhcaseDetail.Add(modelPurchaseDetail);
                }
            }
            modelPurchase.modelPurchaseDetail = listModelPurhcaseDetail;

            modelPurchase.remark = this.txt_remark.Text.Trim();
            modelPurchase.price = ConvertUtils.ConvertToDecimal(this.txt_orderPrice.Text.Trim());
            if (this.cmb_payType.SelectedIndex >= 0)
            {
                modelPurchase.payType = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_payType.SelectedItem).itemKey);

            }
            modelPurchase.cancelReason = this.txt_cancelReason.Text.Trim();

            if (m_mode == 0 || m_mode == 1)
            {
                modelPurchase.status = (int)Enum.EnumPurchaseOrderStatus.Purchasing;
            }

            if (m_mode == 5)
            {
                modelPurchase.status = (int)Enum.EnumPurchaseOrderStatus.Cancel;
            }
            modelPurchase.purchaserId = LoginUserInfo.LoginUser.loginUser.userId;
            modelPurchase.isDelete = 0;
            modelPurchase.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelPurchase.createTime = DateTime.Now;
            modelPurchase.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelPurchase.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                string purchaseCode = m_bllPurchase.AddPurchase(modelPurchase);

                if (StringUtils.IsBlank(purchaseCode))
                {
                    MsgUtils.ShowErrorMsg("新增采购单失败！");
                    return false;
                }
                else
                {
                    m_mode = 1;
                    m_purchaseId = m_bllPurchase.GetPurchaseByPurchaseCode(purchaseCode).id;
                    this.txt_purchaseCode.Text = purchaseCode;
                    if (_isConfirm == true)
                    {
                        MsgUtils.ShowInfoMsg("新增采购单成功！");
                        this.Hide();
                    }
                }

                return true;
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllPurchase.UpdatePurchase(modelPurchase);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("修改采购单失败！");
                    return false;
                }
                else
                {
                    if (_isConfirm == true)
                    {
                        MsgUtils.ShowInfoMsg("修改采购单成功！");
                        this.Hide();
                    }
                    return true;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllPurchase.DeletePurchase(modelPurchase);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("删除采购单失败！");
                    return false;
                }
                else
                {
                    if (_isConfirm == true)
                    {
                        MsgUtils.ShowInfoMsg("删除采购单成功！");
                        this.Hide();
                    }
                    //返回列表
                    return true;
                }
            }

            //取消
            if (m_mode == 5)
            {
                rtn = m_bllPurchase.CancelPurchase(modelPurchase);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("取消采购单失败！");
                    return false;
                }
                else
                {
                    if (_isConfirm == true)
                    {
                        MsgUtils.ShowInfoMsg("取消采购单成功！");
                        this.Hide();
                    }
                    //返回列表
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
            //检查是否已入库或已支付
            if (m_mode == 1 || m_mode == 5)
            {
                int rtn = m_bllPurchase.CheckUpdateDelete(m_purchaseId);

                if (rtn == 1)
                {
                    if (m_mode == 1)
                    {
                        MsgUtils.ShowErrorMsg("原料已入库，不可修改！");
                        return false;
                    }
                    else
                    {
                        MsgUtils.ShowErrorMsg("原料已入库，不可取消！");
                        return false;
                    }
                }

                if (rtn == 2)
                {
                    if (m_mode == 1)
                    {
                        MsgUtils.ShowErrorMsg("采购单已支付，不可修改！");
                        return false;
                    }
                    else
                    {
                        MsgUtils.ShowErrorMsg("采购单已支付，不可取消！");
                        return false;
                    }
                }
            }           
             
            // 新增或修改
            if (m_mode == 0 || m_mode == 1)
            {

                //// 申请人
                //if (this.cmb_type.SelectedIndex == 1)
                //{
                //    if (this.cmb_applyBy.SelectedIndex < 0)
                //    {
                //        MsgUtils.ShowErrorMsg("请选择采购申请人！");
                //        this.cmb_applyBy.Focus();
                //        return false;
                //    }
                //}

                ////采购原料
                //if (this.cmb_materials.SelectedIndex < 0)
                //{
                //    MsgUtils.ShowErrorMsg("请选择采购原料！");
                //    this.cmb_materials.Focus();
                //    return false;
                //}

                //工厂
                if (this.cmb_factory.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择工厂！");
                    this.cmb_factory.Focus();
                    return false;
                }
                
                ////采购数量
                //decimal num = ConvertUtils.ConvertToDecimal(this.txt_num.Text.Trim());
                //if (num <= 0)
                //{
                //    MsgUtils.ShowErrorMsg("请输入合适的采购数量！");
                //    this.txt_num.Focus();
                //    return false;
                //}

                //供应商
                if (this.cmb_supplier.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择供应商！");
                    this.cmb_supplier.Focus();
                    return false;
                }

                //省
                if (this.cmb_province.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择省！");
                    this.cmb_province.Focus();
                    return false;
                }
                //市
                if (this.cmb_city.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择市！");
                    this.cmb_city.Focus();
                    return false;
                }
                //区
                if (this.cmb_district.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择区！");
                    this.cmb_district.Focus();
                    return false;
                }

                //地址
                if (StringUtils.IsBlank(this.txt_address.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入收货地址！");
                    this.txt_address.Focus();
                    return false;
                }

                //收货人姓名
                if (StringUtils.IsBlank(this.txt_manager.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入收货人姓名！");
                    this.txt_manager.Focus();
                    return false;
                }

                //收货电话
                if (StringUtils.IsBlank(this.txt_telephone.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入收货电话！");
                    this.txt_telephone.Focus();
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
                            int specs = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specs"].Value);

                            if (modelMaterials.type != 2 && specs <= 0)
                            {
                                MsgUtils.ShowErrorMsg("请选择原料【" + modelMaterials.name + "】的规格！");
                                this.dataGridView1.Focus();
                                return false;
                            }

                            int num = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["num"].Value);

                            if (num <= 0)
                            {
                                MsgUtils.ShowErrorMsg("请输入采购数量！");
                                this.dataGridView1.Focus();
                                return false;
                            }
                            decimal price = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["price"].Value, 4);

                            if (price <= 0)
                            {
                                MsgUtils.ShowErrorMsg("请输入采购单价！");
                                this.dataGridView1.Focus();
                                return false;
                            } hasMaterials = true;
                        }
                    }

                    if (hasMaterials == false)
                    {
                        MsgUtils.ShowErrorMsg("请选择采购原料！");
                        this.dataGridView1.Focus();
                        return false;
                    }

                    //采购金额
                    decimal orderPrice = ConvertUtils.ConvertToDecimal(this.txt_orderPrice.Text.Trim());
                    if (orderPrice <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入订单金额！");
                        this.txt_orderPrice.Focus();
                        return false;
                    }

                    //付款方式
                    if (this.cmb_payType.SelectedIndex < 0)
                    {
                        MsgUtils.ShowErrorMsg("请选择付款方式！");
                        this.cmb_payType.Focus();
                        return false;
                    }
                }
            }

            //取消
            if (m_mode == 5)
            {
                //取消原因
                if (StringUtils.IsBlank(this.txt_cancelReason.Text.Trim()))
                {
                    MsgUtils.ShowErrorMsg("请输入取消原因！");
                    this.txt_cancelReason.Focus();
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 省市区联动
        private void cmb_province_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cmb_city.Items.Clear();
            this.cmb_district.Items.Clear();
            
            if (this.cmb_province.SelectedIndex < 0)
            {
                return;
            }

            int province = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_province.SelectedItem).itemKey);

            WinCommon.BindComboBox(ref this.cmb_city, BllArea.GetCity(province));
        }

        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cmb_district.Items.Clear();

            if (this.cmb_city.SelectedIndex < 0)
            {
                return;
            }

            int city = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_city.SelectedItem).itemKey);

            WinCommon.BindComboBox(ref this.cmb_district, BllArea.GetDistrict(city));
        }
        #endregion

        private void btn_close_Click(object sender, EventArgs e)
        {
            //返回列表
            this.Hide();
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

        private void btn_print_jx_Click(object sender, EventArgs e)
        {
            if (m_mode == 0 || m_mode == 1)
            {
                if (doSubmit(false) == false)
                {
                    return;
                }
            }

            //Excel模板文件
            string strFilePath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")) + "\\tpl\\采购单-嘉兴.xlsx";
            if (!File.Exists(strFilePath))
            {
                MsgUtils.ShowErrorMsg("采购单Excel模版不存在，无法打印！");
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
            worksheet.Cells[2, 2] = m_bllCompany.GetCompany().name;
            //采购日期
            worksheet.Cells[4, 3] = this.dtp_purchaseDate.Text;
            //供应商
            ModelCustomer modelCustomer = m_bllCustomer.GetCustomerById(ConvertUtils.ConvertToInt(((ModelItem)this.cmb_supplier.SelectedItem).itemKey));
            worksheet.Cells[5, 3] = modelCustomer.name;
            //电话
            worksheet.Cells[6, 3] = modelCustomer.telephone1;
            //传真
            worksheet.Cells[7, 3] = modelCustomer.fax;
            //联系人
            worksheet.Cells[8, 3] = modelCustomer.manager;

            //检验项目
            int idx = 0;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value) > 0)
                {
                    if (idx > 0)
                    {
                        worksheet.get_Range("B" + (10 + idx), "G" + (10 + idx)).Insert(Shift:Excel.XlInsertShiftDirection.xlShiftDown);
                        worksheet.get_Range("B10", "G10").Select();
                        worksheet.get_Range("B10", "G10").Copy(Type.Missing);
                        worksheet.get_Range("B" + (10 + idx), "G" + (10 + idx)).PasteSpecial(Excel.XlPasteType.xlPasteFormats);
                    }

                    //物料代码
                    worksheet.Cells[10 + idx, 2] = "/";
                    //物料名称
                    worksheet.Cells[10 + idx, 3] = this.dataGridView1.Rows[i].Cells["materialsName"].Value;
                    //规格
                    int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specs"].Value);
                    if (specsId <= 0)
                    {
                        worksheet.Cells[10 + idx, 4] = "个";
                    }
                    else
                    {
                        ModelMaterialsSpecs modelSpecs = m_bllMaterials.GetMaterialsSpecsById(specsId);
                        worksheet.Cells[10 + idx, 4] = modelSpecs.name;
                    }
                    //数量
                    worksheet.Cells[10 + idx, 5] = this.dataGridView1.Rows[i].Cells["num"].Value;
                    //单价
                    worksheet.Cells[10 + idx, 6] = this.dataGridView1.Rows[i].Cells["price"].Value;
                    //金额
                    worksheet.Cells[10 + idx, 7] = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["num"].Value) * ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["price"].Value);

                    idx = idx + 1;
                }
            }

            //合计
            worksheet.Cells[10 + idx, 7] = this.txt_orderPrice.Text;

            //交货日期
            worksheet.Cells[10 + idx + 1, 3] = this.dtp_deliveryDate.Text;

            //收货地址
            worksheet.Cells[10 + idx + 1, 4] = "收货地址:" + ((ModelItem)this.cmb_province.SelectedItem).itemValue +
                ((ModelItem)this.cmb_city.SelectedItem).itemValue + 
                ((ModelItem)this.cmb_district.SelectedItem).itemValue + 
                this.txt_address.Text.Trim();

            //收货人
            worksheet.Cells[10 + idx + 2, 3] = this.txt_manager.Text;

            //收货电话
            worksheet.Cells[10 + idx + 2, 5] = this.txt_telephone.Text;

            //付款方式
            if (this.cmb_payType.SelectedIndex >= 0)
            {
                worksheet.Cells[10 + idx + 3, 3] = ((ModelItem)this.cmb_payType.SelectedItem).itemValue;
            }

            //备注
            worksheet.Cells[10 + idx + 4, 3] = this.txt_remark.Text;

            //经办人
            int purchaserId = m_bllPurchase.GetPurchaseByPurchaseCode(this.txt_purchaseCode.Text).purchaserId;
            worksheet.Cells[10 + idx + 5, 3] = m_bllUser.GetUserById(purchaserId).userName;

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

            if (this.cmb_type.SelectedIndex == 2)
            {
                ModelMaterialsPrice modelPrice = m_bllMaterials.GetMaterialsPriceById(materialsId, 0);
                this.lbl_advisePrice.Text = modelPrice.price.ToString();
            }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (this.cmb_type.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择原料类型！");
                this.cmb_type.Focus();
                return ;
            }
            if (this.cmb_materials.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择原料名称！");
                this.cmb_materials.Focus();
                return ;
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
                MsgUtils.ShowErrorMsg("请输入采购数量！");
                this.cmb_specs.Focus();
                return;
            }

            decimal price = ConvertUtils.ConvertToInt(this.txt_price.Text.Trim());
            if (price <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入采购单价！");
                this.txt_price.Focus();
                return;
            }

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                int materialsIdExist = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["materialsId"].Value);
                int specsIdExist = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specs"].Value);

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

            if (m_mode == 0)
            {
                if (doSubmit(false) == false)
                {
                    return;
                }
           }

            ModelPurchaseDetail model = new ModelPurchaseDetail();
            //model.inputCode = BllSeq.GetCode("ylrk", "materialsInCode");
            model.purchaseCode = this.txt_purchaseCode.Text;
            model.materialsId = materialsId;
            model.specsId = specsId;
            model.num = num;
            model.price = price;
            model.deliveryDate = this.dtp_deliveryDate.Value;
            model.applyBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.applyDate = DateTime.Now;
            model.applyType = 1;
            model.isDelete = 0;
            model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.createTime = DateTime.Now;

            int factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            int customerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_supplier.SelectedItem).itemKey);
            if (m_bllPurchase.AddPurchaseDetail(factoryId, customerId, model) == false)
            {
                MsgUtils.ShowErrorMsg("新增采购原料失败！");
                return;
            }
            else
            {
                //MsgUtils.ShowInfoMsg("新增成品规格成功！");
                dataGridView1.DataSource = m_bllPurchase.GetPurchaseDetailByPurchaseCode(model.purchaseCode);
                dataGridView1.Refresh();

                doSubmit(false);

                this.txt_orderPrice.Text = ConvertUtils.ConvertToString(ConvertUtils.ConvertToDecimal(this.txt_orderPrice.Text) + model.price * model.num);
                return;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            //删除
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                if (id > 0)
                {
                    if (MsgUtils.ShowQustMsg("确认从采购清单中删除此原料么？", MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }

                    ModelPurchaseDetail model = new ModelPurchaseDetail();
                    model.id = id;
                    //model.purchaseCode = this.txt_purchaseCode.Text;
                    //model.materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["materialsId"].Value);
                    //model.specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["specs"].Value);
                    model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    model.modifyTime = DateTime.Now;

                    if (m_bllPurchase.DetelePurchaseDetail(model) == false)
                    {
                        MsgUtils.ShowErrorMsg("删除原料规格失败！");
                        return;
                    }
                    else
                    {
                        decimal price = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[e.RowIndex].Cells["price"].Value);
                        int num = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["num"].Value);

                        //MsgUtils.ShowInfoMsg("删除成品规格成功！");
                        dataGridView1.DataSource = m_bllPurchase.GetPurchaseDetailByPurchaseCode(this.txt_purchaseCode.Text);
                        dataGridView1.Refresh();

                        doSubmit(false);

                        decimal orderPrice = ConvertUtils.ConvertToDecimal(this.txt_orderPrice.Text);
                        if (orderPrice > 0 && (orderPrice > price * num))
                        {
                            this.txt_orderPrice.Text = ConvertUtils.ConvertToString(orderPrice - price * num);
                        }

                        return;
                    }
                }
            }

            //查看库存
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "queryStore")
            {
                int factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
                string materialsName = ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells["materialsName"].Value);
                int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["specs"].Value);

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

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "specs")
            {
                int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["materialsId"].Value);

                if (materialsId > 0)
                {
                    ModelMaterials modelMaterials = m_bllMaterials.GetMaterialsById(materialsId);

                    DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells["specs"];

                    if (modelMaterials.type != 2)
                    {
                        column.ReadOnly = false;
                        List<ModelItem> listItem = m_bllMaterials.GetMaterialsSpecsListForCombo(materialsId);
                        column.DataSource = listItem;
                        column.DisplayMember = "itemValue";
                        column.ValueMember = "itemKey";
                    }
                    else
                    {
                        column.ReadOnly = true;
                    }
                }
            }

        }

        private void cmb_factory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            ModelFactory modelFactory= m_bllFactory.GetFactoryById(factoryId);

            //省
            for (int i = 0; i < this.cmb_province.Items.Count; i++)
            {
                ModelItem modelItem = (ModelItem)this.cmb_province.Items[i];
                if (modelFactory.province == (int)modelItem.itemKey)
                {
                    this.cmb_province.SelectedIndex = i;
                    break;
                }
            }

            //市
            for (int i = 0; i < this.cmb_city.Items.Count; i++)
            {
                ModelItem modelItem = (ModelItem)this.cmb_city.Items[i];
                if (modelFactory.city == (int)modelItem.itemKey)
                {
                    this.cmb_city.SelectedIndex = i;
                    break;
                }
            }

            //区
            for (int i = 0; i < this.cmb_district.Items.Count; i++)
            {
                ModelItem modelItem = (ModelItem)this.cmb_district.Items[i];
                if (modelFactory.district == (int)modelItem.itemKey)
                {
                    this.cmb_district.SelectedIndex = i;
                    break;
                }
            }

            //地址
            this.txt_address.Text = modelFactory.address;
          
        }

        private void cmb_specs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_materials.SelectedIndex >= 0)
            {
                int materialsId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_materials.SelectedItem).itemKey);

                int specsId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_specs.SelectedItem).itemKey);

                ModelMaterialsPrice modelPrice = m_bllMaterials.GetMaterialsPriceById(materialsId, specsId);
                this.lbl_advisePrice.Text = modelPrice.price.ToString();
            }
        }

        private void btn_print_sh_Click(object sender, EventArgs e)
        {
            if (m_mode == 0 || m_mode == 1)
            {
                if (doSubmit(false) == false)
                {
                    return;
                }
            }
            //Excel模板文件
            string strFilePath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")) + "\\tpl\\采购单-上海.xlsx";
            if (!File.Exists(strFilePath))
            {
                MsgUtils.ShowErrorMsg("采购单Excel模版不存在，无法打印！");
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
            worksheet.Cells[2, 2] = m_bllCompany.GetCompany().name;
            //采购日期
            worksheet.Cells[4, 3] = this.dtp_purchaseDate.Text;
            //供应商
            ModelCustomer modelCustomer = m_bllCustomer.GetCustomerById(ConvertUtils.ConvertToInt(((ModelItem)this.cmb_supplier.SelectedItem).itemKey));
            worksheet.Cells[5, 3] = modelCustomer.name;
            //电话
            worksheet.Cells[6, 3] = modelCustomer.telephone1;
            //传真
            worksheet.Cells[7, 3] = modelCustomer.fax;
            //联系人
            worksheet.Cells[8, 3] = modelCustomer.manager;

            //检验项目
            int idx = 0;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value) > 0)
                {
                    if (idx > 0)
                    {
                        worksheet.get_Range("B" + (10 + idx), "G" + (10 + idx)).Insert(Shift: Excel.XlInsertShiftDirection.xlShiftDown);
                        worksheet.get_Range("B10", "G10").Select();
                        worksheet.get_Range("B10", "G10").Copy(Type.Missing);
                        worksheet.get_Range("B" + (10 + idx), "G" + (10 + idx)).PasteSpecial(Excel.XlPasteType.xlPasteFormats);
                    }

                    //物料代码
                    worksheet.Cells[10 + idx, 2] = "/";
                    //物料名称
                    worksheet.Cells[10 + idx, 3] = this.dataGridView1.Rows[i].Cells["materialsName"].Value;
                    //规格
                    int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specs"].Value);
                    if (specsId <= 0)
                    {
                        worksheet.Cells[10 + idx, 4] = "个";
                    }
                    else
                    {
                        ModelMaterialsSpecs modelSpecs = m_bllMaterials.GetMaterialsSpecsById(specsId);
                        worksheet.Cells[10 + idx, 4] = modelSpecs.name;
                    }                    //数量
                    worksheet.Cells[10 + idx, 5] = this.dataGridView1.Rows[i].Cells["num"].Value;
                    //单价
                    worksheet.Cells[10 + idx, 6] = this.dataGridView1.Rows[i].Cells["price"].Value;
                    //金额
                    worksheet.Cells[10 + idx, 7] = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["num"].Value) * ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["price"].Value);

                    idx = idx + 1;
                }
            }

            //合计
            worksheet.Cells[10 + idx, 7] = this.txt_orderPrice.Text;

            //交货日期
            worksheet.Cells[10 + idx + 1, 3] = this.dtp_deliveryDate.Text;

            //收货地址
            worksheet.Cells[10 + idx + 1, 4] = "收货地址:" + ((ModelItem)this.cmb_province.SelectedItem).itemValue +
                ((ModelItem)this.cmb_city.SelectedItem).itemValue +
                ((ModelItem)this.cmb_district.SelectedItem).itemValue +
                this.txt_address.Text.Trim();

            //收货人
            worksheet.Cells[10 + idx + 2, 3] = this.txt_manager.Text;

            //收货电话
            worksheet.Cells[10 + idx + 2, 5] = this.txt_telephone.Text;

            //付款方式
            if (this.cmb_payType.SelectedIndex >= 0)
            {
                worksheet.Cells[10 + idx + 3, 3] = ((ModelItem)this.cmb_payType.SelectedItem).itemValue;
            }

            //备注
            worksheet.Cells[10 + idx + 4, 3] = this.txt_remark.Text;

            WinCommon.PrintExcel(xlApp, workbook);
        }

    }
}
