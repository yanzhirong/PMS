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

namespace PMS.Frm.Purchase
{
    public partial class FrmPurchaseDetail : Form
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看；4:财务确认；5:财务取消）
        private int m_mode;
        private int m_purchaseId;
        private string m_produceCode;
        private string m_purchaseCode;

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
            WinCommon.Exit();
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
            //申请者
            listItem = m_bllUser.GetUsersWithItem();
            WinCommon.BindComboBox(ref cmb_applyBy, listItem);
            //物料
            listItem = m_bllMaterials.GetMaterialsItem("");
            WinCommon.BindComboBox(ref this.cmb_materials, listItem);
            //工厂
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem);
            //单位
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.WeightUnit, false);
            WinCommon.BindComboBox(ref this.cmb_unit, listItem);
            //省市区
            WinCommon.BindComboBox(ref cmb_province, BllArea.GetProvince());
            WinCommon.BindComboBox(ref cmb_city, null);
            WinCommon.BindComboBox(ref cmb_district, null);

            //新增时
            if (m_mode == 0)
            {
                this.cmb_type.SelectedIndex = 1;
                this.cmb_status.SelectedIndex = 0;
                this.dtp_deliveryDate.Value = DateTime.Now.AddMonths(1);
            }
            
            ////修改删除时，检查是否已经入库或者已支付
            //if (m_mode == 1 || m_mode == 2)
            //{
            //    int rtn = m_bllPurchase.CheckUpdateDelete(m_purchaseId);
            //    if (rtn == 1)
            //    {
            //        if (m_mode == 1)
            //        {
            //            MsgUtils.ShowErrorMsg("物料已入库，不可修改！");
            //            m_mode = 3;
            //        }
            //        else
            //        {
            //            MsgUtils.ShowErrorMsg("物料已入库，不可修改！");
            //            m_mode = 3;
            //        }
            //    }

            //    if (rtn == 2)
            //    {
            //        if (m_mode == 1)
            //        {
            //            MsgUtils.ShowErrorMsg("采购单已支付，不可删除！");
            //            m_mode = 3;
            //        }
            //        else
            //        {
            //            MsgUtils.ShowErrorMsg("采购单已支付，不可删除！");
            //            m_mode = 3;
            //        }
            //    }
            //}

            ////标题
            //if (m_mode == 0)
            //{
            //    this.lbl_title.Text = "采购单-新增";
            //}
            //else if (m_mode == 1)
            //{
            //    this.lbl_title.Text = "采购单-修改";
            //}
            //else if (m_mode == 2)
            //{
            //    this.lbl_title.Text = "采购单-删除";
            //}
            //else if (m_mode == 3)
            //{
            //    this.lbl_title.Text = "采购单-查看";
            //}

            //初始化数据
            if (m_mode != 0 && m_purchaseId > 0)
            {
                ModelPurchase model = m_bllPurchase.GetPurchaseById(m_purchaseId);

                //采购编号
                m_purchaseCode = model.purchaseCode;

                //生产编号
                m_produceCode = model.produceCode;

                //申请种类
                this.cmb_type.SelectedIndex = model.applyType;

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

                //申请者
                for (int i = 0; i < this.cmb_applyBy.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_applyBy.Items[i];
                    if (model.applyBy == modelItem.itemValue)
                    {
                        this.cmb_applyBy.SelectedIndex = i;
                        break;
                    }
                }
                //登陆者作为申请者
                if (this.cmb_applyBy.SelectedIndex < 0)
                {
                    for (int i = 0; i < this.cmb_applyBy.Items.Count; i++)
                    {
                        ModelItem modelItem = (ModelItem)this.cmb_applyBy.Items[i];
                        if (LoginUserInfo.LoginUser.loginUser.userId == (int)modelItem.itemKey)
                        {
                            this.cmb_applyBy.SelectedIndex = i;
                            break;
                        }
                    }
                }

                //申请日期
                this.dtp_applyDate.Value = model.applyDate;

                //采购物料
                for (int i = 0; i < this.cmb_materials.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_materials.Items[i];
                    if (model.materialsId == (int)modelItem.itemKey)
                    {
                        this.cmb_materials.SelectedIndex = i;
                        break;
                    }
                }

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
                this.txt_num.Text = model.num.ToString();

                //采购单位
                for (int i = 0; i < this.cmb_unit.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_unit.Items[i];
                    if (model.unit == (int)modelItem.itemKey)
                    {
                        this.cmb_unit.SelectedIndex = i;
                        break;
                    }
                }

                //交货日期
                this.dtp_deliveryDate.Value = model.deliveryDate;

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

                //交货日期
                this.dtp_deliveryDate.Value = model.deliveryDate;

                //采购价格
                this.txt_price.Text = model.price.ToString();

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
                this.grb_finance.Enabled = false;
                this.grb_cancel.Visible = false;
            }

            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                this.grb_purchase.Enabled = false;
                this.grb_finance.Enabled = false;
                this.grb_cancel.Enabled = false;
                this.grb_cancel.Visible = true;
            }

            //财务确认
            if (m_mode == 4)
            {
                this.grb_purchase.Enabled = false;
                this.grb_finance.Enabled = true;
                this.grb_cancel.Visible = false;
            }

            //财务取消
            if (m_mode == 5)
            {
                this.btn_submit.Text = "确认取消";
                this.grb_purchase.Enabled = false;
                this.grb_finance.Enabled = false;
                this.grb_cancel.Visible = true;
            }

            //采购单状态不可修改
            this.cmb_status.Enabled = false;

            //采购金额（仅限财务)
            if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                this.grb_finance.Visible = true;
            }
            else
            {
                this.grb_finance.Visible = false;
            }

        }
        #endregion

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        private Boolean doSubmit(bool showMsg)
        {
            Boolean rtn = false;

            //检查
            if (doCheck() == false)
            {
                return false;
            }

            ModelPurchase modelPurchase = new ModelPurchase();
            modelPurchase.id = m_purchaseId;
            modelPurchase.purchaseCode = m_purchaseCode;
            modelPurchase.produceCode = m_produceCode;

            modelPurchase.applyType = this.cmb_type.SelectedIndex;
            modelPurchase.status = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_status.SelectedItem).itemKey);
            modelPurchase.applyBy = ((ModelItem)this.cmb_applyBy.SelectedItem).itemValue;
            modelPurchase.applyDate = this.dtp_applyDate.Value;

            modelPurchase.materialsId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_materials.SelectedItem).itemKey);
            modelPurchase.factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            modelPurchase.num = ConvertUtils.ConvertToDecimal(this.txt_num.Text.Trim());
            modelPurchase.unit = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_unit.SelectedItem).itemKey);
            modelPurchase.deliveryDate = this.dtp_deliveryDate.Value;

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

            modelPurchase.remark = this.txt_remark.Text.Trim();
            modelPurchase.price = ConvertUtils.ConvertToDecimal(this.txt_price.Text.Trim());
            modelPurchase.cancelReason = this.txt_cancelReason.Text.Trim();

            if (m_mode == 0 || m_mode == 1)
            {
                modelPurchase.status = (int)Enum.EnumPurchaseOrderStatus.WaitConfirm;
            }

            if (m_mode == 4)
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
                rtn = m_bllPurchase.AddPurchase(modelPurchase);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("新增采购单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("新增采购单成功！");
                    }
                }

                this.Hide();
                return true;
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllPurchase.UpdatePurchase(modelPurchase);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("修改采购单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
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
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("删除采购单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("删除采购单成功！");
                    }
                    //返回列表
                    this.Hide();
                    return true;
                }
            }

            //财务确认
            if (m_mode == 4)
            {
                rtn = m_bllPurchase.ConfirmPurchase(modelPurchase);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("确认采购单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("确认采购单成功！");
                    }
                    //返回列表
                    this.Hide();
                    return true;
                }
            }

            //财务取消
            if (m_mode == 5)
            {
                rtn = m_bllPurchase.CancelPurchase(modelPurchase);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("取消采购单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("取消采购单成功！");
                    }
                    //返回列表
                    this.Hide();
                    return true;
                }
            } 
            
            return true;
        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean doCheck()
        {
            ////检查是否已入库或已支付
            //if (m_mode == 1 || m_mode == 2)
            //{
            //    int rtn = m_bllPurchase.CheckUpdateDelete(m_purchaseId);

            //    if (rtn == 1)
            //    {
            //        if (m_mode == 1)
            //        {
            //            MsgUtils.ShowErrorMsg("物料已入库，不可修改！");
            //            return false;
            //        }
            //        else
            //        {
            //            MsgUtils.ShowErrorMsg("物料已入库，不可修改！");
            //            return false;
            //        }
            //    }

            //    if (rtn == 2)
            //    {
            //        if (m_mode == 1)
            //        {
            //            MsgUtils.ShowErrorMsg("采购单已支付，不可删除！");
            //            return false;
            //        }
            //        else
            //        {
            //            MsgUtils.ShowErrorMsg("采购单已支付，不可删除！");
            //            return false;
            //        }
            //    }
            //}           
             
            // 新增或修改
            if (m_mode == 0 || m_mode == 1)
            {

                // 申请人
                if (this.cmb_type.SelectedIndex == 1)
                {
                    if (this.cmb_applyBy.SelectedIndex < 0)
                    {
                        MsgUtils.ShowErrorMsg("请选择采购申请人！");
                        this.cmb_applyBy.Focus();
                        return false;
                    }
                }

                //采购物料
                if (this.cmb_materials.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择采购物料！");
                    this.cmb_materials.Focus();
                    return false;
                }

                //工厂
                if (this.cmb_factory.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择工厂！");
                    this.cmb_factory.Focus();
                    return false;
                }
                
                //采购数量
                decimal num = ConvertUtils.ConvertToDecimal(this.txt_num.Text.Trim());
                if (num <= 0)
                {
                    MsgUtils.ShowErrorMsg("请输入合适的采购数量！");
                    this.txt_num.Focus();
                    return false;
                }

                //数量单位
                if (this.cmb_unit.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择数量单位！");
                    this.cmb_unit.Focus();
                    return false;
                }

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
                    MsgUtils.ShowErrorMsg("请输入客户地址！");
                    this.txt_address.Focus();
                    return false;
                }
            }

            //财务确认
            if (m_mode == 4)
            {
                //采购金额
                decimal price = ConvertUtils.ConvertToDecimal(this.txt_price.Text.Trim());
                if (price <= 0)
                {
                    MsgUtils.ShowErrorMsg("请输入合适的采购金额！");
                    this.txt_price.Focus();
                    return false;
                }
            }

            //财务取笑
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

        private void cmb_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_supplier.SelectedIndex >= 0)
            {
                int customerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_supplier.SelectedItem).itemKey);
                ModelCustomer modelCustomer = m_bllCustomer.GetCustomerById(customerId);

                //省
                for (int i = 0; i < this.cmb_province.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_province.Items[i];
                    if (modelCustomer.province == (int)modelItem.itemKey)
                    {
                        this.cmb_province.SelectedIndex = i;
                        break;
                    }
                }

                //市
                for (int i = 0; i < this.cmb_city.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_city.Items[i];
                    if (modelCustomer.city == (int)modelItem.itemKey)
                    {
                        this.cmb_city.SelectedIndex = i;
                        break;
                    }
                }

                //区
                for (int i = 0; i < this.cmb_district.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_district.Items[i];
                    if (modelCustomer.district == (int)modelItem.itemKey)
                    {
                        this.cmb_district.SelectedIndex = i;
                        break;
                    }
                }

                //地址
                this.txt_address.Text = modelCustomer.address;

                //联系人
                this.txt_manager.Text = modelCustomer.manager;

                //电话
                this.txt_telephone.Text = modelCustomer.telephone1;
            }
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_type.SelectedIndex == 0)
            {
                this.cmb_applyBy.Enabled = false;
                this.dtp_applyDate.Enabled = false;
            }
            else
            {
                this.cmb_applyBy.Enabled = true;
                this.dtp_applyDate.Enabled = true;
            }
        }

    }
}
