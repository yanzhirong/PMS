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
    public partial class FrmProductOutDetail : Main.BaseForm
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看）
        private int m_mode;
        private int m_productOutId;

        private BllCompany m_bllCompany = new BllCompany();
        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllSaleOrder m_bllSaleOrder = new BllSaleOrder();
        private BllProduct m_bllProduct = new BllProduct();
        private BllProductOut m_bllProductOut = new BllProductOut();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmProductOutDetail(int _mode, int _productOutId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_productOutId = _productOutId;
        }

        private void FrmProductOutDetail_Load(object sender, EventArgs e)
        {
           
            //初始化
            init();
        }

        private void FrmProductOutDetail_FormClosed(object sender, FormClosedEventArgs e)
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
            //销售
            List<ModelItem> listItem = m_bllUser.GetUserGroupByRoleType((int)Enum.EnumRoleType.Saler);
            WinCommon.BindComboBox(ref cmb_saler, listItem);
            //客户
            listItem = m_bllCustomer.GetCustomersBySalerId(0);
            WinCommon.BindComboBox(ref cmb_customer, listItem);
            //申请者
            listItem = m_bllUser.GetUsersWithItem();
            WinCommon.BindComboBox(ref cmb_apply, listItem);
            //工厂
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref cmb_factory, listItem);

            //成品
            listItem = m_bllProduct.GetProductItem("");
            WinCommon.BindComboBox(ref cmb_product, listItem);

            //省市区
            WinCommon.BindComboBox(ref cmb_province, BllArea.GetProvince());
            WinCommon.BindComboBox(ref cmb_city, null);
            WinCommon.BindComboBox(ref cmb_district, null);

            //新增时
            if (m_mode == 0)
            {
                this.cmb_outputType.SelectedIndex = 1;
                this.cmb_outputStatus.SelectedIndex = 0;
            }

            //初始化数据
            if (m_mode != 0 && m_productOutId > 0)
            {
                ModelProductOutput model = m_bllProductOut.GetProductOutById(m_productOutId);

                //出库单编号
                this.txt_outputCode.Text = model.outputCode;

                //出库单类型
                this.cmb_outputType.SelectedIndex = model.outputType;

                //出库单状态
                this.cmb_outputStatus.SelectedIndex = model.outputStatus;

                if (model.outputStatus == 1)
                {
                    m_mode = 3;
                }

                //订单编号
                this.txt_orderCode.Text = model.orderCode;

                //申请者
                for (int i = 0; i < this.cmb_apply.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_apply.Items[i];
                    if (model.applyMemberId == (int)modelItem.itemKey)
                    {
                        this.cmb_apply.SelectedIndex = i;
                        break;
                    }
                }

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

                //电话
                this.txt_telephone.Text = model.telephone;

                //交货日期
                this.dtp_deliveryDate.Value = model.deliveryDate;

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

                //明细
                dataGridView1.DataSource = m_bllProductOut.GetProductOutDetailByOutputCode(model.outputCode);
                dataGridView1.Refresh();
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
                this.grb_productOut.Enabled = true;
                this.grb_product.Enabled = true;
            }
            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                this.grb_productOut.Enabled = false;
                this.grb_product.Enabled = true;
                this.grb_productNew.Enabled = false;
                this.dataGridView1.Columns["deleteBtn"].Visible = false;
            }

            //出库单类型不可修改
            cmb_outputType.Enabled = false;
            if (cmb_outputType.SelectedIndex == 0)
            {
                this.cmb_apply.Enabled = false;
            }

            //修改
            //if (m_mode == 1)
            //{
            //    if (m_bllProductOut.CheckUpdateDelete(this.txt_outputCode.Text) == false)
            //    {
            //        this.grb_productOut.Enabled = false;
            //        this.grb_product.Enabled = true;
            //    }
            //}

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
            if (doCheck(showMsg) == false)
            {
                return false;
            }

            ModelProductOutput modelProductOutput = new ModelProductOutput();
            modelProductOutput.id = m_productOutId;
            modelProductOutput.outputCode = this.txt_outputCode.Text.Trim();
            modelProductOutput.outputType = this.cmb_outputType.SelectedIndex;
            modelProductOutput.outputStatus = this.cmb_outputStatus.SelectedIndex;

            modelProductOutput.orderCode = this.txt_orderCode.Text.Trim();
            modelProductOutput.applyMemberId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_apply.SelectedItem).itemKey);
            modelProductOutput.customerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_customer.SelectedItem).itemKey);
            if (this.cmb_saler.SelectedIndex > -1)
            {
                modelProductOutput.salerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_saler.SelectedItem).itemKey);
            }
            modelProductOutput.province = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_province.SelectedItem).itemKey);
            modelProductOutput.city = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_city.SelectedItem).itemKey);
            modelProductOutput.district = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_district.SelectedItem).itemKey);
            modelProductOutput.provinceName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_province.SelectedItem).itemValue);
            modelProductOutput.cityName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_city.SelectedItem).itemValue);
            modelProductOutput.districtName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_district.SelectedItem).itemValue);
            modelProductOutput.address = this.txt_address.Text.Trim();
            modelProductOutput.manager = this.txt_manager.Text.Trim();
            modelProductOutput.telephone = this.txt_telephone.Text.Trim();
            modelProductOutput.factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            modelProductOutput.deliveryDate = this.dtp_deliveryDate.Value;

            if (showMsg)
            {
                bool isAllComplete = true;
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {

                    int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["productId"].Value);
                    if (productId > 0)
                    {
                        int outputStatus = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["statusCode"].Value);
                        if (outputStatus == 0)
                        {
                            isAllComplete = false;
                            break;
                        }
                    }

                }

                if (isAllComplete == true)
                {
                    if (MsgUtils.ShowQustMsg("是否完成出库？", MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        modelProductOutput.outputStatus = 1;
                    }
                }
            }

            modelProductOutput.isDelete = 0;
            modelProductOutput.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelProductOutput.createTime = DateTime.Now;
            modelProductOutput.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelProductOutput.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllProductOut.AddProductOut(modelProductOutput);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("新增出库单失败！");
                    }
                    return false;
                }
                else
                {
                    //处理模式变为修改
                    m_mode = 1;
                    ModelProductOutput newProductOutput = m_bllProductOut.GetProductOutByOutputCode(modelProductOutput.outputCode);
                    m_productOutId = newProductOutput.id;
                    this.txt_outputCode.Text = newProductOutput.outputCode;
                    
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("新增出库单成功！");
                        this.Hide();
                    }
                }
                return true;
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllProductOut.UpdateProductOut(modelProductOutput);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("修改出库单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("修改出库单成功！");
                        this.Hide();
                    }
                    return true;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllProductOut.DeleteProductOut(modelProductOutput);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("删除出库单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
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
        private Boolean doCheck(bool showMsg)
        {
            if (StringUtils.IsNotBlank(this.txt_outputCode.Text))
            {
                ////修改
                //if (m_mode == 1 && showMsg == true)
                //{
                //    if (m_bllProductOut.CheckUpdateDelete(this.txt_outputCode.Text) == false)
                //    {
                //        MsgUtils.ShowErrorMsg("已有部分成品出库，不可修改！");
                //        return false;
                //    }
                //}

                //删除
                if (m_mode == 2)
                {
                    if (m_bllProductOut.CheckUpdateDelete(this.txt_outputCode.Text) == false)
                    {
                        MsgUtils.ShowErrorMsg("已有部分成品出库，不可删除！");
                        return false;
                    }
                }
            }
            
            // 新增或修改
            if (m_mode == 0 || m_mode == 1)
            {
                //出库单状态
                if (this.cmb_outputStatus.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择出库单状态！");
                    this.cmb_outputStatus.Focus();
                    return false;
                }

                //客户
                if (this.cmb_customer.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择客户！");
                    this.cmb_customer.Focus();
                    return false;
                }

                // 申请人
                if (this.cmb_apply.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择出库申请人！");
                    this.cmb_apply.Focus();
                    return false;
                }

                ////销售
                //if(this.cmb_saler.SelectedIndex < 0)
                //{
                //    MsgUtils.ShowErrorMsg("请选择销售！");
                //    this.cmb_saler.Focus();
                //    return false;
                //}

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

                //工厂
                if (this.cmb_factory.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择工厂！");
                    this.cmb_factory.Focus();
                    return false;
                }

                if (showMsg)
                {
                    bool hasProduct = false;
                    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                    {
                        int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["productId"].Value);
                        if (productId > 0)
                        {
                            hasProduct = true;
                            break;
                        }
                    }
                    if (hasProduct == false)
                    {
                        MsgUtils.ShowErrorMsg("请选择出库成品！");
                        this.dataGridView1.Focus();
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

            if (this.cmb_outputType.SelectedIndex == 1)
            {
                this.dataGridView1.AllowUserToAddRows = true;
            }
            else
            {
                this.dataGridView1.AllowUserToAddRows  = false;
            }

            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "id";
            textColumn.HeaderText = "id";
            textColumn.DataPropertyName = "id";
            textColumn.Visible = false;
            this.dataGridView1.Columns.Add(textColumn);

            DataGridViewComboBoxColumn cmbColumn = new DataGridViewComboBoxColumn();
            cmbColumn.Name = "productId";
            cmbColumn.HeaderText = "成品";
            cmbColumn.DataPropertyName = "productId";
            cmbColumn.Width = 160;
            if (this.cmb_outputType.SelectedIndex == 1)
            {
                cmbColumn.ReadOnly = false;
            }
            else
            {
                cmbColumn.ReadOnly = true;
            }
            this.dataGridView1.Columns.Add(cmbColumn);
            cmbColumn.DataSource = m_bllProduct.GetProducts("");
            cmbColumn.DisplayMember = "name";
            cmbColumn.ValueMember = "id";

            cmbColumn = new DataGridViewComboBoxColumn();
            cmbColumn.Name = "specsId";
            cmbColumn.DataPropertyName = "specsId";
            cmbColumn.HeaderText = "规格";
            cmbColumn.Width = 120;
            cmbColumn.ReadOnly = false;
            this.dataGridView1.Columns.Add(cmbColumn);
            cmbColumn.DataSource = m_bllProduct.GetProductSpecsListForCombo(-1);
            cmbColumn.DisplayMember = "itemValue";
            cmbColumn.ValueMember = "itemKey";

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "outputDate";
            textColumn.HeaderText = "出库日期";
            textColumn.DataPropertyName = "outputDate";
            textColumn.ReadOnly = true;
            textColumn.Width = 80;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "outputNum";
            textColumn.HeaderText = "请求数量";
            textColumn.DataPropertyName = "outputNum";
            textColumn.ReadOnly = true;
            textColumn.Width = 80;
            this.dataGridView1.Columns.Add(textColumn);

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "outputBtn";
            buttonColumn.Text = "出库";
            buttonColumn.HeaderText = "出库";
            buttonColumn.DataPropertyName = "outputBtn";
            buttonColumn.DefaultCellStyle.NullValue = "出库";
            buttonColumn.Width = 70;
            this.dataGridView1.Columns.Add(buttonColumn);

            cmbColumn = new DataGridViewComboBoxColumn();
            cmbColumn.Name = "outputStatus";
            cmbColumn.DataPropertyName = "outputStatus";
            cmbColumn.HeaderText = "状态";
            cmbColumn.Width = 90;
            cmbColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(cmbColumn);
            List<ModelItem> listItem = new List<ModelItem>();
            listItem.Add(new ModelItem());
            ModelItem item = new ModelItem();
            item.itemKey = 0;
            item.itemValue = "请求出库";
            listItem.Add(item);
            item = new ModelItem();
            item.itemKey = 1;
            item.itemValue = "完成出库";
            listItem.Add(item);
            cmbColumn.DataSource = listItem;
            cmbColumn.DisplayMember = "itemValue";
            cmbColumn.ValueMember = "itemKey";
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
            Form form = new FrmProductOut();
            this.Hide();
            form.ShowDialog();
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

                //电话
                this.txt_telephone.Text = modelCustomer.telephone1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                if (id > 0)
                {
                    if (MsgUtils.ShowQustMsg("确认从出库清单中删除此成品么？", MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }

                    ModelProductOutputDetail model = new ModelProductOutputDetail();
                    model.id = id;
                    model.outputCode = this.txt_outputCode.Text;
                    model.productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["productId"].Value);
                    model.specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["specsId"].Value);
                    model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    model.modifyTime = DateTime.Now;

                    if (m_bllProductOut.DeleteProductOutDetail(model) == false)
                    {
                        MsgUtils.ShowErrorMsg("删除出库成品失败！");
                        return;
                    }
                    else
                    {
                        dataGridView1.DataSource = m_bllProductOut.GetProductOutDetailByOutputCode(this.txt_outputCode.Text);
                        dataGridView1.Refresh();

                        return;
                    }
                }
            }

            //出库按钮
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "outputBtn")
            {
                int id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                if (id > 0)
                {
                    int outputDetailId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    int factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
                    int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["productId"].Value);
                    int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["specsId"].Value);
                    int outputStatus = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["statusCode"].Value);

                    //保存数据
                    if (m_mode ==0)
                    {
                        if (doSubmit(false) == false)
                        {
                            return;
                        }
                    }

                    Form form = new FrmProductOutSelect(outputStatus, this.txt_outputCode.Text, outputDetailId, productId, specsId, factoryId, ConvertUtils.ConvertToInt(((ModelItem)this.cmb_apply.SelectedItem).itemKey));
                    form.ShowDialog();
                    dataGridView1.DataSource = m_bllProductOut.GetProductOutDetailByOutputCode(this.txt_outputCode.Text);
                    dataGridView1.Refresh();

                }
            }
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Hide();
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
                return;
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
                MsgUtils.ShowErrorMsg("请输入出库数量！");
                this.cmb_specs.Focus();
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
                ModelProductOutputDetail model = new ModelProductOutputDetail();
                model.outputCode = this.txt_outputCode.Text;
                model.productId = productId;
                model.specsId = specsId;
                model.productNum = num;
                model.realityOutputNum = 0;
                model.outputStatus = 0;
                model.outputDate = DateTime.Now;
                model.isDelete = 0;
                model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                model.createTime = DateTime.Now;

                if (m_bllProductOut.AddProductOutDetail(model) == false)
                {
                    MsgUtils.ShowErrorMsg("新增出库成品失败！");
                    return;
                }
                else
                {
                    //MsgUtils.ShowInfoMsg("新增成品规格成功！");
                    dataGridView1.DataSource = m_bllProductOut.GetProductOutDetailByOutputCode(model.outputCode);
                    dataGridView1.Refresh();
                    return;
                }
            }
        }

        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyInt(e.KeyChar);
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
            string strFilePath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")) + "\\tpl\\出库单-成品.xlsx";
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

            ModelProductOutput modelProductOutput = m_bllProductOut.GetProductOutByOutputCode(this.txt_outputCode.Text);
            ModelSaleOrder modelSaleOrder = new ModelSaleOrder();

            //赋值
            //公司名称
            worksheet.Cells[2, 2] = m_bllCompany.GetCompany().name;
            //公司地址
            worksheet.Cells[3, 3] = m_bllCompany.GetCompany().address;
            //出库单号
            worksheet.Cells[5, 5] = modelProductOutput.outputCode;
            //出库日期
            worksheet.Cells[6, 5] = ConvertUtils.ConvertToDateString(modelProductOutput.modifyTime,"yyyy-MM-dd");

            ModelCustomer modelCustomer = m_bllCustomer.GetCustomerById(modelProductOutput.customerId);
            //客户代码
            worksheet.Cells[7, 3] = modelCustomer.code;
            //客户名称
            worksheet.Cells[8, 3] = modelCustomer.name;
            //客户地址
            worksheet.Cells[10, 2] = "客户地址：" + modelCustomer.provinceName + modelCustomer.cityName + modelCustomer.districtName + modelCustomer.address;
            //客户电话
            worksheet.Cells[11, 2] = "电话：" + modelCustomer.telephone1;
            //客户邮编
            worksheet.Cells[12, 2] = "邮编：" + modelCustomer.zip;
            //收货地址
            worksheet.Cells[10, 4] = "收货地址：" + modelProductOutput.provinceName + modelProductOutput.cityName + modelProductOutput.districtName + modelProductOutput.address;
            //收货电话
            worksheet.Cells[11, 4] = "电话：" + modelProductOutput.telephone;
            //收货人
            worksheet.Cells[12, 4] = "联系人：" + modelProductOutput.manager;

            //库房
            worksheet.Cells[13, 3] = m_bllFactory.GetFactoryById(modelProductOutput.factoryId).name;

            //订单编号
            worksheet.Cells[14, 3] = modelProductOutput.orderCode;
            //订货日期
            if (StringUtils.IsNotBlank(modelProductOutput.orderCode))            
            {                
                string orderDate = modelProductOutput.orderCode.Replace("xxdd_", "");
                orderDate = orderDate.Substring(0,4) + "-" + orderDate.Substring(4,2) + "-" + orderDate.Substring(6,2);
                worksheet.Cells[14, 5] = orderDate;

                modelSaleOrder = m_bllSaleOrder.GetSaleOrderByOrderCode(modelProductOutput.orderCode);

                //付款方式
                worksheet.Cells[15, 3] = m_bllCode.GetSubCode((int)Enum.EnumCode.PayType, modelSaleOrder.payType).value1;
                //销售
                worksheet.Cells[15, 5] = m_bllUser.GetUserById(modelSaleOrder.salerId).userName;
                //备注
                worksheet.Cells[16, 5] = modelSaleOrder.remark;
            }

            //检验项目
            int startIdx = 19;
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
                    int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["productId"].Value);
                    //成品编码
                    worksheet.Cells[startIdx + idx, 2] = m_bllProduct.GetProductById(productId).modelProductSearch.searchKey;
                    //成品名称
                    worksheet.Cells[startIdx + idx, 3] = this.dataGridView1.Rows[i].Cells["productName"].Value;
                    //规格
                    worksheet.Cells[startIdx + idx, 4] = this.dataGridView1.Rows[i].Cells["specsName"].Value;
                    //数量
                    worksheet.Cells[startIdx + idx, 5] = this.dataGridView1.Rows[i].Cells["realityOutputNum"].Value;

                    if (StringUtils.IsNotBlank(modelProductOutput.orderCode))            
                    {
                        int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value);

                        ModelSaleOrderDetail modelSaleOrderDetail = m_bllSaleOrder.GetSaleOrderDetailByProductSpecs(modelProductOutput.orderCode, productId, specsId);

                        //单价
                        worksheet.Cells[startIdx + idx, 6] = modelSaleOrderDetail.price;
                        //金额
                        worksheet.Cells[startIdx + idx, 7] = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["realityOutputNum"].Value) * modelSaleOrderDetail.price;
                    }
                    idx = idx + 1;
                }
            }

            if (StringUtils.IsNotBlank(modelProductOutput.orderCode))
            {
                //小计
                worksheet.Cells[startIdx + idx + 1, 7] = modelSaleOrder.price;
                //运费
                worksheet.Cells[startIdx + idx + 2, 7] = modelSaleOrder.transPrice;
                //合计
                worksheet.Cells[startIdx + idx + 3, 7] = modelSaleOrder.price + modelSaleOrder.transPrice;
            }
 
            WinCommon.PrintExcel(xlApp, workbook);
        }

    }
}
