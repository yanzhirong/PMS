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
    public partial class FrmOrderDetail : Form
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看；4:财务确认）
        private int m_mode;
        //原来ID
        private int m_saleOrderId;

        private BllSaleOrder m_bllSaleOrder = new BllSaleOrder();
        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllProduct m_bllProduct = new BllProduct();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmOrderDetail(int _mode, int _saleOrderId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_saleOrderId = _saleOrderId;
        }

        private void FrmCustomerDetail_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

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

            //登录者是财务
            if (LoginUserInfo.LoginUser.loginRole.roleType == (int)Enum.EnumRoleType.Finance)
            {
                this.grb_saleOrder.Enabled = false;
                this.grb_price.Visible = true;
            }
            else
            {
                this.grb_price.Visible = false;
            }
            
            //初始化
            init();
        }

        private void FrmOrderDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回用户列表
            Form form = new FrmOrderManage();
            this.Hide();
            form.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //返回用户列表
            Form form = new FrmOrderManage();
            this.Hide();
            form.ShowDialog();
        }
        
        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {           
            //标题
            if (m_mode == 0)
            {
                this.lbl_title.Text = "订单信息设定-新增";
            }
            else if (m_mode == 1)
            {
                this.lbl_title.Text = "订单信息设定-修改";
            }
            else if (m_mode == 2)
            {
                this.lbl_title.Text = "订单信息设定-删除";
            }
            else if (m_mode == 3)
            {
                this.lbl_title.Text = "订单信息设定-查看";
            }
            else
            {
                this.lbl_title.Text = "订单信息设定-确认";
            }

            //下拉框
            //销售
            List<ModelItem> listItem = m_bllUser.GetUserGroupByRoleType((int)Enum.EnumRoleType.Saler);
            WinCommon.BindComboBox(ref cmb_saler, listItem);
            //客户
            listItem = m_bllCustomer.GetCustomersBySalerId(0);
            WinCommon.BindComboBox(ref cmb_customer, listItem);
            //仓库
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref cmb_factory, listItem);
            
            //省市区
            WinCommon.BindComboBox(ref cmb_province, BllArea.GetProvince());
            WinCommon.BindComboBox(ref cmb_city, null);
            WinCommon.BindComboBox(ref cmb_district, null);

            // 设置datagrid
            SetDataGridViewStyle();

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
                this.dtp_deliverDate.Value = model.deliverDate;

                //备注
                this.txt_remark.Text = model.remark;

                //订单金额
                this.txt_price.Text = model.price.ToString();

                //订单金额说明
                this.txt_priceRemark.Text = model.priceRemark;

                //仓库
                for (int i = 0; i < this.cmb_factory.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_factory.Items[i];
                    if (model.factoryId == (int)modelItem.itemKey)
                    {
                        this.cmb_factory.SelectedIndex = i;
                        break;
                    }
                }
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
            if (m_mode == 1)
            {
                grb_saleOrder.Enabled = true;
                grb_price.Enabled = true;
            }
            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                grb_saleOrder.Enabled = false;
                grb_price.Enabled = false;
            }
            //财务确认时
            if (m_mode == 4)
            {
                grb_saleOrder.Enabled = false;
                grb_price.Enabled = true;
            }


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

                int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[2].Value);
                if (productId > 0)
                {
                    ModelSaleOrderDetail model = new ModelSaleOrderDetail();
                    model.id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[0].Value);
                    model.orderCode = modelSaleOrder.orderCode;
                    model.productId = productId;
                    model.searchKey = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells[1].Value);
                    model.num = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells[3].Value);
                    model.unit = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[4].Value);

                    modelSaleOrderDetail.Add(model);
                }

            }
            modelSaleOrder.modelSaleOrderDetail = modelSaleOrderDetail;

            modelSaleOrder.deliverDate = this.dtp_deliverDate.Value;
            modelSaleOrder.remark = this.txt_remark.Text.Trim();

            if (grb_price.Visible == true)
            {
                modelSaleOrder.price = ConvertUtils.ConvertToDecimal(this.txt_price.Text.Trim());
                modelSaleOrder.factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
                modelSaleOrder.priceRemark = this.txt_priceRemark.Text.Trim();
            }

            modelSaleOrder.isDelete = 0;
            modelSaleOrder.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelSaleOrder.createTime = DateTime.Now;
            modelSaleOrder.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelSaleOrder.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllSaleOrder.AddSaleOrder(modelSaleOrder);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("新增订单失败！");
                    return ;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("新增订单成功！");
                }

                //处理模式变为修改
                m_mode = 1;
                m_saleOrderId = m_bllSaleOrder.GetSaleOrderByOrderCode(this.txt_orderCode.Text).id;

                init();

                return;
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllSaleOrder.UpdateSaleOrder(modelSaleOrder);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("修改订单失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("修改订单成功！");
                    init();
                    return;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllSaleOrder.DeleteSaleOrder(modelSaleOrder);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("删除订单失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("删除订单成功！");

                    //返回列表
                    Form form = new FrmOrderManage();
                    this.Hide();
                    form.ShowDialog();
                    return;
                }
            }

            //财务确认
            if (m_mode == 4)
            {
                rtn = m_bllSaleOrder.ConfirmSaleOrder(modelSaleOrder);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("确认订单失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("确认订单成功！");

                    //返回列表
                    Form form = new FrmOrderManage();
                    this.Hide();
                    form.ShowDialog();
                    return;
                }
            }
        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean doCheck()
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
                bool hasProduct = false; 
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[2].Value);
                    if (productId > 0)
                    {
                        if (ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells[3].Value) <= 0)
                        {
                            MsgUtils.ShowErrorMsg("请输入销售商品数量！");
                            this.dataGridView1.Focus();
                            return false;
                        }

                        if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[4].Value) <= 0)
                        {
                            MsgUtils.ShowErrorMsg("请输入销售商品单位！");
                            this.dataGridView1.Focus();
                            return false;
                        } 
                        
                        hasProduct = true;
                    }
                }
                if (hasProduct == false)
                {
                    MsgUtils.ShowErrorMsg("请选择销售商品！");
                    this.dataGridView1.Focus();
                    return false;
                }

                //交货日期
                DateTime deliverDate = this.dtp_deliverDate.Value;
                if (deliverDate <= DateTime.Now)
                {
                    MsgUtils.ShowErrorMsg("请选择合适的交货日期！");
                    this.txt_address.Focus();
                    return false;
                }

                if (LoginUserInfo.LoginUser.loginRole.roleType == (int)Enum.EnumRoleType.Finance)
                {
                    //订单金额
                    decimal price = ConvertUtils.ConvertToDecimal(this.txt_price.Text);
                    if (price <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入订单金额！");
                        this.txt_price.Focus();
                        return false;
                    }

                    //出货仓库
                    if(this.cmb_factory.SelectedIndex < 0)
                    {
                        MsgUtils.ShowErrorMsg("请选择出货仓库！");
                        this.txt_price.Focus();
                        return false;                    
                    }
                }

                if (m_mode == 4)
                {
                    //订单金额
                    decimal price = ConvertUtils.ConvertToDecimal(this.txt_price.Text);
                    if (price <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入订单金额！");
                        this.txt_price.Focus();
                        return false;
                    }

                    //出货仓库
                    if (this.cmb_factory.SelectedIndex < 0)
                    {
                        MsgUtils.ShowErrorMsg("请选择出货仓库！");
                        this.txt_price.Focus();
                        return false;
                    }
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
            columns.Width = 60;
            this.dataGridView1.Columns.Add(columns);

            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            column.Name = "productId";
            column.HeaderText = "商品";
            column.DataPropertyName = "productId";
            column.Width = 230;
            this.dataGridView1.Columns.Add(column);
            column.DataSource = m_bllProduct.GetProducts("");
            column.DisplayMember = "name";
            column.ValueMember = "id";

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "num";
            columns.HeaderText = "数量";
            columns.DataPropertyName = "num";
            columns.Width = 60;
            this.dataGridView1.Columns.Add(columns);

            column = new DataGridViewComboBoxColumn();
            column.Name = "unit";
            column.DataPropertyName = "unit";
            column.HeaderText = "单位";
            column.Width = 80;
            this.dataGridView1.Columns.Add(column);
            column.DataSource = m_bllCode.GetCodeList(3);
            column.DisplayMember = "value1";
            column.ValueMember = "subCode";

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "reamrk";
            columns.HeaderText = "说明";
            columns.DataPropertyName = "reamrk";
            columns.Width = 160;
            this.dataGridView1.Columns.Add(columns);

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "orderCode";
            columns.HeaderText = "orderCode";
            columns.DataPropertyName = "orderCode";
            columns.Visible = false;
            this.dataGridView1.Columns.Add(columns);

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "price";
            columns.HeaderText = "price";
            columns.DataPropertyName = "price";
            columns.Visible = false;
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

            if (e.RowIndex < 0 || e.ColumnIndex != 1)
            {
                return;
            }

            // 检索键
            if (e.ColumnIndex == 1)
            {
                string searchKey = ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                searchKey = searchKey.ToUpper();

                DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells[2];

                column.DataSource = m_bllProduct.GetProductBySearchKey(searchKey);
                column.DisplayMember = "productName";
                column.ValueMember = "productId";

            }

            if (e.ColumnIndex == 3)
            {
                DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells[4];

                column.DataSource = m_bllCode.GetCodeList(3);
                column.DisplayMember = "value1";
                column.ValueMember = "subCode";
            }
        }
    }
}
