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

namespace PMS.Frm.Sale
{
    public partial class FrmOrderDetail : Main.BaseForm
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看；4:财务确认；5:财务取消）
        private int m_mode;
        //原来ID
        private int m_saleOrderId;

        private BllSaleOrder m_bllSaleOrder = new BllSaleOrder();
        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllProduct m_bllProduct = new BllProduct();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();
        private BllFinance m_bllFinance = new BllFinance();

        public FrmOrderDetail(int _mode, int _saleOrderId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_saleOrderId = _saleOrderId;
        }

        private void FrmOrderDetail_Load(object sender, EventArgs e)
        {           
            //初始化
            init();
        }

        private void FrmOrderDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit(true);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回用户列表
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //返回用户列表
            this.Hide();
        }
        
        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {           

            //下拉框
            //销售
            List<ModelItem> listItem = m_bllUser.GetUserGroupByRoleType((int)Enum.EnumRoleType.Saler);
            WinCommon.BindComboBox(ref cmb_saler, listItem);
            //客户
            if (LoginUserInfo.LoginUser.loginRole.roleType == (int)Enum.EnumRoleType.Saler)
            {
                listItem = m_bllCustomer.GetCustomersBySalerId(LoginUserInfo.LoginUser.loginUser.userId);
            }
            else
            {
                listItem = m_bllCustomer.GetCustomersBySalerId(0);
            }
            WinCommon.BindComboBox(ref cmb_customer, listItem);
            //工厂
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref cmb_factory, listItem);
            //成品
            listItem = m_bllProduct.GetProductItem("");
            WinCommon.BindComboBox(ref this.cmb_product, listItem);
            //付款方式
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.PayType, false);
            WinCommon.BindComboBox(ref this.cmb_payType, listItem);
            
            //省市区
            WinCommon.BindComboBox(ref cmb_province, BllArea.GetProvince());
            WinCommon.BindComboBox(ref cmb_city, null);
            WinCommon.BindComboBox(ref cmb_district, null);

            // 设置datagrid
            // SetDataGridViewStyle();

            //登录者是销售
            if (LoginUserInfo.LoginUser.loginRole.roleType == (int)Enum.EnumRoleType.Saler)
            {
                if (m_mode == 0)
                {
                    for (int i = 0; i < this.cmb_saler.Items.Count; i++)
                    {
                        if (LoginUserInfo.LoginUser.loginUser.userId == (int)((ModelItem)this.cmb_saler.Items[i]).itemKey)
                        {
                            this.cmb_saler.SelectedIndex = i;
                        }
                    }
                }

                this.cmb_saler.Enabled = false;
            }

            //初始化数据
            if (m_mode != 0 && m_saleOrderId > 0)
            {
                ModelSaleOrder model = m_bllSaleOrder.GetSaleOrderById(m_saleOrderId);

                //订单编号
                this.txt_orderCode.Text = model.orderCode;
                
                //订单状态
                this.txt_orderStatusCode.Text = model.orderStatus.ToString();
                this.txt_orderStatus.Text = m_bllCode.GetSubCode((int)Enum.EnumCode.SaleOrderStatus, model.orderStatus).value1;

                //客户
                for (int i = 0; i < this.cmb_customer.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_customer.Items[i];
                    if (model.customerId == (int)modelItem.itemKey)
                    {
                        this.cmb_customer.SelectedIndex = i;
                        break;
                    }
                }

                //销售
                for (int i = 0; i < this.cmb_saler.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_saler.Items[i];
                    if (model.salerId == (int)modelItem.itemKey)
                    {
                        this.cmb_saler.SelectedIndex = i;
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

                //职位
                this.txt_telephone.Text = model.telephone;

                //订单明细
                dataGridView1.DataSource = m_bllSaleOrder.GetSaleOrderDetailByOrderCode(model.orderCode);
                dataGridView1.Refresh();

                //交货日期
                this.dtp_deliveryDate.Value = model.deliveryDate;

                //订单金额
                this.txt_orderPrice.Text = model.price.ToString();

                //运输费用
                this.txt_transPrice.Text = model.transPrice.ToString();

                //订单金额说明
                this.txt_priceRemark.Text = model.priceRemark;

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

                //取消理由
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

            //新增时
            if (m_mode <= 1)
            {
                grb_saleOrder.Enabled = true;
                grb_price.Enabled = true;
                grb_cancel.Visible = false;
            }

            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                grb_saleOrder.Enabled = false;
                grb_price.Enabled = false;
                grb_cancel.Enabled = false;
                grb_cancel.Visible = true;
            }

            ////财务确认时
            //if (m_mode == 4)
            //{
            //    grb_saleOrder.Enabled = false;
            //    grb_price.Enabled = true;
            //    grb_cancel.Visible = false;
            //}

            //取消时
            if (m_mode == 5)
            {
                this.btn_submit.Text = "确认取消";
                grb_saleOrder.Enabled = false;
                grb_price.Enabled = false;
                grb_cancel.Visible = true;
                grb_cancel.Enabled = true;
            }

            if (this.grb_price.Visible == false)
            {
                this.grb_cancel.Top = this.grb_cancel.Top - this.grb_cancel.Height;
                this.btn_submit.Top = this.btn_submit.Top - this.grb_price.Height;
                this.btn_cancel.Top = this.btn_cancel.Top - this.grb_price.Height;
                this.btn_close.Top = this.btn_close.Top - this.grb_price.Height;
                this.Height = this.Height - this.grb_price.Height;
            }

            if (this.grb_cancel.Visible == false)
            {
                this.btn_submit.Top = this.btn_submit.Top - this.grb_cancel.Height;
                this.btn_cancel.Top = this.btn_cancel.Top - this.grb_cancel.Height;
                this.btn_close.Top = this.btn_close.Top - this.grb_cancel.Height;
                this.Height = this.Height - this.grb_cancel.Height;
            }
        }
        #endregion

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        private bool doSubmit(bool _isConfirm)
        {
            Boolean rtn = false;

            //检查
            if (doCheck(_isConfirm) == false)
            {
                return false;
            }

            ModelSaleOrder modelSaleOrder = new ModelSaleOrder();
            modelSaleOrder.id = m_saleOrderId;
            modelSaleOrder.orderCode = this.txt_orderCode.Text.Trim();
            modelSaleOrder.orderStatus = ConvertUtils.ConvertToInt(this.txt_orderStatusCode.Text.Trim());
            modelSaleOrder.customerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_customer.SelectedItem).itemKey);
            modelSaleOrder.salerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_saler.SelectedItem).itemKey);

            modelSaleOrder.province = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_province.SelectedItem).itemKey);
            modelSaleOrder.city = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_city.SelectedItem).itemKey);
            modelSaleOrder.district = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_district.SelectedItem).itemKey);
            modelSaleOrder.provinceName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_province.SelectedItem).itemValue);
            modelSaleOrder.cityName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_city.SelectedItem).itemValue);
            modelSaleOrder.districtName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_district.SelectedItem).itemValue);
            modelSaleOrder.address = this.txt_address.Text.Trim();
            modelSaleOrder.manager = this.txt_manager.Text.Trim();
            modelSaleOrder.telephone = this.txt_telephone.Text.Trim();

            List<ModelSaleOrderDetail> modelSaleOrderDetail = new List<ModelSaleOrderDetail>();
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {

                int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["productId"].Value);
                if (productId > 0)
                {
                    ModelSaleOrderDetail model = new ModelSaleOrderDetail();
                    model.id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value);
                    model.orderCode = modelSaleOrder.orderCode;
                    model.productId = productId;
                    model.specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value);
                    model.num = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["num"].Value);
                    model.price = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["price"].Value);
                    //model.remark = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["remark"].Value);

                    modelSaleOrderDetail.Add(model);
                }

            }
            modelSaleOrder.modelSaleOrderDetail = modelSaleOrderDetail;

            modelSaleOrder.deliveryDate = this.dtp_deliveryDate.Value;
            modelSaleOrder.cancelReason = this.txt_cancelReason.Text.Trim();

            if (grb_price.Visible == true)
            {
                modelSaleOrder.price = ConvertUtils.ConvertToDecimal(this.txt_orderPrice.Text.Trim());
                modelSaleOrder.transPrice = ConvertUtils.ConvertToDecimal(this.txt_transPrice.Text.Trim());
                if (this.cmb_factory.SelectedIndex >= 0)
                {
                    modelSaleOrder.factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
                }
                modelSaleOrder.priceRemark = this.txt_priceRemark.Text.Trim();
                if (this.cmb_payType.SelectedIndex >= 0)
                {
                    modelSaleOrder.payType = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_payType.SelectedItem).itemKey);
                }
            }

            modelSaleOrder.isDelete = 0;
            modelSaleOrder.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelSaleOrder.createTime = DateTime.Now;
            modelSaleOrder.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelSaleOrder.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllSaleOrder.AddSaleOrder(modelSaleOrder, _isConfirm);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("新增订单失败！");
                    return false;
                }
                else
                {
                    m_mode = 1;
                    ModelSaleOrder newSaleOrder = m_bllSaleOrder.GetSaleOrderByOrderCode(modelSaleOrder.orderCode);
                    m_saleOrderId = newSaleOrder.id;
                    this.txt_orderCode.Text = newSaleOrder.orderCode;
                    this.txt_orderStatusCode.Text = newSaleOrder.orderStatus.ToString();
                    if (_isConfirm)
                    {
                        MsgUtils.ShowInfoMsg("新增订单成功！");
                        //处理模式变为修改

                        if (doCheckStore())
                        {
                            this.Hide();
                        }
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllSaleOrder.UpdateSaleOrder(modelSaleOrder, _isConfirm);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("修改订单失败！");
                    return false;
                }
                else
                {
                    if (_isConfirm)
                    {
                        MsgUtils.ShowInfoMsg("修改订单成功！");
                        if (doCheckStore())
                        {
                            this.Hide();
                        }
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllSaleOrder.DeleteSaleOrder(modelSaleOrder);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("删除订单失败！");
                    return false;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("删除订单成功！");

                    //返回列表
                    this.Hide();
                    return true;
                }
            }
            
            //取消
            if (m_mode == 5)
            {
                rtn = m_bllSaleOrder.CancelSaleOrder(modelSaleOrder);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("取消订单失败！");
                    return false;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("取消订单成功！");
                }

                //返回列表
                this.Hide();
                return true;
            }

            return true;
        }

        /// <summary>
        /// 检查库存
        /// </summary>
        /// <returns></returns>
        private Boolean doCheckStore()
        {
            ModelSaleOrder modelSaleOrder = m_bllSaleOrder.GetSaleOrderById(m_saleOrderId);

            // 查看库存
            string productName = m_bllSaleOrder.CheckStore(modelSaleOrder);

            if (StringUtils.IsNotBlank(productName))
            {
                if (MsgUtils.ShowQustMsg("成品【" + productName + "】库存不足，是否生成生产申请单？", MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    // 生成生产申请单
                    if (m_bllSaleOrder.AddProduceApply(modelSaleOrder))
                    {
                        MsgUtils.ShowInfoMsg("生产申请单生成成功！");
                        return true;
                    }
                    else
                    {
                        MsgUtils.ShowErrorMsg("生产申请单生成失败！");
                        return false;
                    }
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
            // 新增或修改
            if (m_mode == 0 || m_mode == 1)
            {

                //客户
                if (this.cmb_customer.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择客户！");
                    this.cmb_customer.Focus();
                    return false;
                }

                //销售
                if(this.cmb_saler.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择销售！");
                    this.cmb_saler.Focus();
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
                if (_isConfirm)
                {
                    bool hasProduct = false;
                    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                    {
                        int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["productId"].Value);
                        if (productId > 0)
                        {
                            if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value) <= 0)
                            {
                                MsgUtils.ShowErrorMsg("请选择成品规格！");
                                this.dataGridView1.Focus();
                                return false;
                            }
                            if (ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["num"].Value) <= 0)
                            {
                                MsgUtils.ShowErrorMsg("请输入销售数量！");
                                this.dataGridView1.Focus();
                                return false;
                            }
                            if (ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["price"].Value) <= 0)
                            {
                                MsgUtils.ShowErrorMsg("请输入销售单价！");
                                this.dataGridView1.Focus();
                                return false;
                            }

                            hasProduct = true;
                        }
                    }
                    if (hasProduct == false)
                    {
                        MsgUtils.ShowErrorMsg("请选择销售成品！");
                        this.dataGridView1.Focus();
                        return false;
                    }

                    //订单金额
                    decimal price = ConvertUtils.ConvertToDecimal(this.txt_orderPrice.Text);
                    if (price <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入销售金额！");
                        this.txt_orderPrice.Focus();
                        return false;
                    }

                    //出货工厂
                    if (this.cmb_factory.SelectedIndex < 0)
                    {
                        MsgUtils.ShowErrorMsg("请选择出货工厂！");
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

                    decimal adviseSalePrice = 0;
                    decimal minSalePrice = 0;
                    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                    {

                        int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["productId"].Value);
                        int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value);

                        ModelProductPrice modelProductPrice = m_bllProduct.GetProductPriceById(productId, specsId);
                        if (modelProductPrice != null)
                        {
                            adviseSalePrice = minSalePrice + ConvertUtils.ConvertToDecimal(modelProductPrice.advisePrice) *
                                ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["num"].Value);
                            minSalePrice = minSalePrice + ConvertUtils.ConvertToDecimal(modelProductPrice.minPrice) *
                                ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["num"].Value);
                        }
                        else
                        {

                        }
                    }

                    if (price < adviseSalePrice)
                    {
                        if (MsgUtils.ShowQustMsg("销售价格低于建议销售价（￥" + adviseSalePrice + "），是否确认订单？", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                        {
                            this.txt_orderPrice.Focus();
                            return false;
                        }
                    }

                    if (price < minSalePrice)
                    {
                        if (MsgUtils.ShowQustMsg("销售价格低于最低销售价（￥" + minSalePrice + "），是否确认订单？", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                        {
                            this.txt_orderPrice.Focus();
                            return false;
                        }
                    }

                    //客户ID
                    int customerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_customer.SelectedItem).itemKey);
                    ModelCustomerPaid modelCustomerPaid = m_bllCustomer.GetCustomerPaidById(customerId);
                    if (modelCustomerPaid.creditLimit > 0)
                    {
                        decimal receivableMoney = m_bllFinance.GetReceivableMoneyByCustomerId(customerId, this.txt_orderCode.Text);

                        if (modelCustomerPaid.creditLimit <= receivableMoney)
                        {
                            if (MsgUtils.ShowQustMsg("该客户的未收金额（￥" + receivableMoney + "）已超出其信用额度（￥" + modelCustomerPaid.creditLimit + "），是否确认订单？", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                            {
                                this.txt_orderPrice.Focus();
                                return false;
                            }
                        }
                    }
                }
            }

            if (m_mode == 5)
            {
                if(StringUtils.IsBlank(this.txt_cancelReason.Text.Trim()))
                {
                    MsgUtils.ShowErrorMsg("请输入取消原因！");
                    this.txt_cancelReason.Focus();
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

            DataGridViewTextBoxColumn columns = new DataGridViewTextBoxColumn();
            columns.Name = "id";
            columns.HeaderText = "id";
            columns.DataPropertyName = "id";
            columns.Visible = false;
            this.dataGridView1.Columns.Add(columns);

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "searchKey";
            columns.HeaderText = "  ";
            columns.DataPropertyName = "searchKey";
            columns.Width = 50;
            this.dataGridView1.Columns.Add(columns);

            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            column.Name = "productId";
            column.HeaderText = "成品";
            column.DataPropertyName = "productId";
            column.Width = 160;
            this.dataGridView1.Columns.Add(column);
            column.DataSource = m_bllProduct.GetProducts("");
            column.DisplayMember = "name";
            column.ValueMember = "id";

            column = new DataGridViewComboBoxColumn();
            column.Name = "specsId";
            column.HeaderText = "规格";
            column.DataPropertyName = "specsId";
            column.Width = 100;
            this.dataGridView1.Columns.Add(column);
            //column.DataSource = m_bllProduct.GetProductSpecsListForCombo(-1);
            column.DisplayMember = "name";
            column.ValueMember = "id";

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "num";
            columns.HeaderText = "数量";
            columns.DataPropertyName = "num";
            columns.Width = 60;
            this.dataGridView1.Columns.Add(columns);

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "remark";
            columns.HeaderText = "说明";
            columns.DataPropertyName = "remark";
            columns.Width = 120;
            this.dataGridView1.Columns.Add(columns);

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "orderCode";
            columns.HeaderText = "orderCode";
            columns.DataPropertyName = "orderCode";
            columns.Visible = false;
            this.dataGridView1.Columns.Add(columns);

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "advisePrice";
            columns.HeaderText = "建议销售单价";
            columns.DataPropertyName = "advisePrice";
            columns.Width = 120;
            columns.ReadOnly = true;
            this.dataGridView1.Columns.Add(columns);
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

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }
        
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 1)
            {
                return;
            }

            // 设定成品
            if (e.ColumnIndex == 1)
            {
                string searchKey = ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["productId"].Value);

                searchKey = searchKey.ToUpper();

                DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells["productId"];

                DataTable dt = m_bllProduct.GetProductBySearchKey(searchKey);
                if (dt == null || dt.Rows.Count <= 0)
                {
                    MsgUtils.ShowInfoMsg("没有此成品，请重新输入！");
                    this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                    return;
                }

                column.DataSource = dt;
                column.DisplayMember = "productName";
                column.ValueMember = "productId";

                bool isFind = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (productId == ConvertUtils.ConvertToInt(dt.Rows[i]["productId"]))
                    {
                        isFind = true;
                        break;
                    }
                }
                if (!isFind)
                {
                    this.dataGridView1.Rows[e.RowIndex].Cells["productId"].Value = dt.Rows[0]["productId"];
                }
            }

            //设定规格
            if (e.ColumnIndex == 2)
            {
                int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["productId"].Value);
                if (productId > 0)
                {
                    DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells["specsId"];

                    column.DataSource = m_bllProduct.GetProductSpecsListForCombo(productId);
                    column.DisplayMember = "name";
                    column.ValueMember = "id";
   
                }
            }

            //设定销售价格
            if (e.ColumnIndex == 3)
            {
                int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["productId"].Value);
                int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["specsId"].Value);
                if (productId > 0 && specsId > 0)
                {
                    DataGridViewTextBoxCell column = (DataGridViewTextBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells["advisePrice"];

                    column.Value = m_bllProduct.GetProductPriceById(productId, specsId).advisePrice;
                }
            }
        }

        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_customer.SelectedIndex >= 0)
            {
                int customerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_customer.SelectedItem).itemKey);

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

                //职位
                this.txt_telephone.Text = modelCustomer.telephone1;
            }
        }

        private void cmb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmb_specs.Items.Clear();

            int productId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_product.SelectedItem).itemKey);
            if (productId > 0)
            {
                List<ModelItem> listItem = m_bllProduct.GetProductSpecsListForCombo(productId);
                WinCommon.BindComboBox(ref this.cmb_specs, listItem);
            }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (this.cmb_product.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择成品！");
                this.cmb_product.Focus();
                return ;
            }
            int productId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_product.SelectedItem).itemKey);

            if (this.cmb_specs.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择规格！");
                this.cmb_specs.Focus();
                return;
            }
            int specsId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_specs.SelectedItem).itemKey);

            int num = ConvertUtils.ConvertToInt(this.txt_num.Text.Trim());
            if (num <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入销售数量！");
                this.cmb_specs.Focus();
                return;
            }

            decimal price = ConvertUtils.ConvertToInt(this.txt_price.Text.Trim());
            if (price <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入销售单价！");
                this.txt_price.Focus();
                return;
            }

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                int productIdExist = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["productId"].Value);
                int specsIdExist = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value);

                if (productIdExist == productId && specsIdExist == specsId)
                {
                    MsgUtils.ShowErrorMsg("选择的成品规格已存在！");
                    this.cmb_specs.Focus();
                    return;
                }
            }

            if (doSubmit(false))
            {
                ModelSaleOrderDetail model = new ModelSaleOrderDetail();
                model.orderCode = m_bllSaleOrder.GetSaleOrderById(m_saleOrderId).orderCode;
                model.productId = productId;
                model.specsId = specsId;
                model.num = num;
                model.price = price;
                model.isDelete = 0;
                model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                model.createTime = DateTime.Now;

                if (m_bllSaleOrder.AddSaleOrderDetail(model) == false)
                {
                    MsgUtils.ShowErrorMsg("新增销售成品失败！");
                    return;
                }
                else
                {
                    //MsgUtils.ShowInfoMsg("新增成品规格成功！");
                    dataGridView1.DataSource = m_bllSaleOrder.GetSaleOrderDetailByOrderCode(model.orderCode);
                    dataGridView1.Refresh();

                    this.txt_orderPrice.Text = ConvertUtils.ConvertToString(ConvertUtils.ConvertToDecimal(this.txt_orderPrice.Text) + model.price * model.num);
                    return;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                if (id > 0)
                {
                    if (MsgUtils.ShowQustMsg("确认从销售清单中删除此成品么？", MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }

                    ModelSaleOrderDetail model = new ModelSaleOrderDetail();
                    model.id = id;
                    model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    model.modifyTime = DateTime.Now;

                    if (m_bllSaleOrder.DeteleSaleOrderDetail(model) == false)
                    {
                        MsgUtils.ShowErrorMsg("删除成品规格失败！");
                        return;
                    }
                    else
                    {
                        decimal price = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[e.RowIndex].Cells["price"].Value);
                        int num = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["num"].Value);
                        
                        //MsgUtils.ShowInfoMsg("删除成品规格成功！");
                        dataGridView1.DataSource = m_bllSaleOrder.GetSaleOrderDetailByOrderCode(m_bllSaleOrder.GetSaleOrderById(m_saleOrderId).orderCode);
                        dataGridView1.Refresh();

                        decimal orderPrice = ConvertUtils.ConvertToDecimal(this.txt_orderPrice.Text);
                        if (orderPrice > 0 && (orderPrice > price * num))
                        {
                            this.txt_orderPrice.Text = ConvertUtils.ConvertToString(orderPrice - price * num);
                        }

                        return;
                    }
                }
            }

        }

        private void cmb_specs_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbl_advisePrice.Text = "0";
            this.lbl_minPrice.Text = "0";
            
            if (this.cmb_product.SelectedIndex >= 0 && this.cmb_specs.SelectedIndex >= 0)
            {
                int productId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_product.SelectedItem).itemKey);
                int specsId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_specs.SelectedItem).itemKey);

                ModelProductPrice model = m_bllProduct.GetProductPriceById(productId, specsId);
                if (model != null)
                {
                    this.lbl_advisePrice.Text = ConvertUtils.ConvertToString(model.advisePrice);
                    this.lbl_minPrice.Text = ConvertUtils.ConvertToString(model.minPrice);
                }
            }
        }
        
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "num" || this.dataGridView1.Columns[e.ColumnIndex].Name == "price")
            {
                decimal orderPrice = 0;
                for(int i = 0; i < this.dataGridView1.Rows.Count ; i++)
                {
                    int num = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["num"].Value);
                    decimal price = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[e.RowIndex].Cells["price"].Value);

                    orderPrice = orderPrice + (num * price);
                }

                this.txt_orderPrice.Text = orderPrice.ToString();
            }
        }

        private void txt_transPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyInt(e.KeyChar);
        }

        private void txt_price_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

    }
}
