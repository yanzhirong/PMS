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
    public partial class FrmProductOutDetail : Form
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看）
        private int m_mode;
        private int m_productOutId;

        private BllCustomer m_bllCustomer = new BllCustomer();
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
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);
            
            //初始化
            init();
        }

        private void FrmOrderDetail_FormClosed(object sender, FormClosedEventArgs e)
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
            Form form = new FrmProductOut();
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
            //if (m_mode == 0)
            //{
            //    this.lbl_title.Text = "出库单信息设定-新增";
            //}
            //else if (m_mode == 1)
            //{
            //    this.lbl_title.Text = "出库单信息设定-修改";
            //}
            //else if (m_mode == 2)
            //{
            //    this.lbl_title.Text = "出库单息设定-删除";
            //}
            //else if (m_mode == 3)
            //{
            //    this.lbl_title.Text = "出库单信息设定-查看";
            //}

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
            //仓库
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref cmb_factory, listItem);

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

                // 设置datagrid
                SetDataGridViewStyle();

                //明细
                dataGridView1.DataSource = m_bllProductOut.GetProductOutDetailByOutputCode(model.outputCode);
                dataGridView1.Refresh();
            }
            else
            {
                // 设置datagrid
                SetDataGridViewStyle();
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
                grb_productOut.Enabled = true;
            }
            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                grb_productOut.Enabled = false;
            }

            //出库单类型不可修改
            cmb_outputType.Enabled = false;
            if (cmb_outputType.SelectedIndex == 0)
            {
                this.cmb_apply.Enabled = false;
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

            ModelProductOutput modelProductOutput = new ModelProductOutput();
            modelProductOutput.id = m_productOutId;
            modelProductOutput.outputCode = this.txt_outputCode.Text.Trim();
            modelProductOutput.outputType = this.cmb_outputType.SelectedIndex;
            modelProductOutput.outputStatus = this.cmb_outputStatus.SelectedIndex;

            modelProductOutput.orderCode = this.txt_orderCode.Text.Trim();
            if (this.cmb_apply.SelectedIndex >= 0)
            {
                modelProductOutput.applyMemberId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_apply.SelectedItem).itemKey);
            }
            modelProductOutput.customerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_customer.SelectedItem).itemKey);
            modelProductOutput.salerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_saler.SelectedItem).itemKey);

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

            //List<ModelProductOutputDetail> listProductOutputDetail = new List<ModelProductOutputDetail>();
            //for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            //{

            //    int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["productId"].Value);
            //    if (productId > 0)
            //    {
            //        ModelProductOutputDetail modelProductOutputDetail = new ModelProductOutputDetail();
            //        modelProductOutputDetail.id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value);
            //        modelProductOutputDetail.outputCode = modelProductOutput.outputCode;
            //        modelProductOutputDetail.productId = productId;
            //        modelProductOutputDetail.productNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["productNum"].Value);
            //        modelProductOutputDetail.productUnit = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["productUnit"].Value);
            //        modelProductOutputDetail.outputStatus = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["outputStatus"].Value);
            //        modelProductOutputDetail.outputType = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["outputType"].Value);
            //        modelProductOutputDetail.outputDate = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["outputDate"].Value).Substring(0, 10);
            //        modelProductOutputDetail.logisticsOrder = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["logisticsOrder"].Value);
            //        modelProductOutputDetail.remark = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["remark"].Value);
            //        modelProductOutputDetail.isDelete = 0;
            //        modelProductOutputDetail.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            //        modelProductOutputDetail.createTime = DateTime.Now;
            //        modelProductOutputDetail.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            //        modelProductOutputDetail.modifyTime = DateTime.Now;

            //        listProductOutputDetail.Add(modelProductOutputDetail);
            //    }

            //}
            //modelProductOutput.modelProductOutputDetail = listProductOutputDetail;

            modelProductOutput.outputStatus = this.cmb_outputStatus.SelectedIndex;
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
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("新增出库单成功！");
                    }
                }

                //处理模式变为修改
                m_mode = 1;
                ModelProductOutput newProductOutput = m_bllProductOut.GetProductOutByOutputCode(modelProductOutput.outputCode);
                m_productOutId = newProductOutput.id;
                this.txt_outputCode.Text = newProductOutput.outputCode;

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
                    }
                    //返回列表
                    Form form = new FrmProductOut();
                    this.Hide();
                    form.ShowDialog();
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

                // 特殊出库单
                if (this.cmb_outputType.SelectedIndex == 1)
                {
                    if (this.cmb_apply.SelectedIndex < 0)
                    {
                        MsgUtils.ShowErrorMsg("请选择出库申请人！");
                        this.cmb_apply.Focus();
                        return false;
                    }
                }

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

                //仓库
                if (this.cmb_factory.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择仓库！");
                    this.cmb_factory.Focus();
                    return false;
                }

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
                    MsgUtils.ShowErrorMsg("请选择出库商品！");
                    this.dataGridView1.Focus();
                    return false;
                }

            }
            
            //删除
            if(m_mode == 2)
            {
                if (m_bllProductOut.CheckDelete(this.txt_outputCode.Text) == false)
                {
                    MsgUtils.ShowErrorMsg("已有部分商品出库，不可删除！");
                    this.dataGridView1.Focus();
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
            cmbColumn.HeaderText = "商品";
            cmbColumn.DataPropertyName = "productId";
            cmbColumn.Width = 150;
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
            cmbColumn.Name = "outputStatus";
            cmbColumn.DataPropertyName = "outputStatus";
            cmbColumn.HeaderText = "状态";
            cmbColumn.Width = 80;
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

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "outputDate";
            textColumn.HeaderText = "出库日期";
            textColumn.DataPropertyName = "outputDate";
            textColumn.ReadOnly = true;
            textColumn.Width = 100;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "outputNum";
            textColumn.HeaderText = "出库数量";
            textColumn.DataPropertyName = "outputNum";
            textColumn.ReadOnly = true;
            textColumn.Width = 100;
            this.dataGridView1.Columns.Add(textColumn);

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "outputBtn";
            buttonColumn.Text = "出库";
            buttonColumn.HeaderText = "出库";
            buttonColumn.DataPropertyName = "outputBtn";
            buttonColumn.Width = 120;
            this.dataGridView1.Columns.Add(buttonColumn);

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
        
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

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
            //出库按钮
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "outputBtn")
            {
                int outputDetailId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["productId"].Value);
                if (productId <= 0)
                {
                    MsgUtils.ShowInfoMsg("请选择出库商品！");
                    return;
                }

                //状态
                int outputStatus = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["outputStatus"].Value);
                //已完成出库
                if (outputStatus > 0)
                {
                    MsgUtils.ShowInfoMsg("已完成出库，不可再出库！");
                    return;
                }

                //保存数据
                if (doSubmit(false) == true)
                {
                    int factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
                    Form form = new FrmProductOutSelect(this.txt_outputCode.Text, outputDetailId, productId, factoryId);
                    form.ShowDialog();

                    dataGridView1.DataSource = m_bllProductOut.GetProductOutDetailByOutputCode(this.txt_outputCode.Text);
                    dataGridView1.Refresh();

                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //this.dataGridView1.Rows[e.RowIndex].Cells["outputBtn"].Value = "出库";
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                this.dataGridView1.Rows[e.RowIndex].Cells["outputBtn"].Value = "出库";
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 1)
            {
                return;
            }

            //商品
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "productId")
            {
                //状态
                int outputStatus = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["outputStatus"].Value);
                //已完成出库
                if (outputStatus > 0)
                {
                    MsgUtils.ShowInfoMsg("已完成出库，不可变换商品！");
                    e.Cancel = true;
                    return;
                }
            }

        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Form form = new FrmProductOut();
            this.Hide();
            form.ShowDialog();
        }

    }
}
