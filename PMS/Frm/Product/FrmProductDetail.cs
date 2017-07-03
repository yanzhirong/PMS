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

namespace PMS.Frm.Product
{
    public partial class FrmProductDetail : Main.BaseForm
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看）
        private int m_mode;
        //原来ID
        private int m_productId;

        private BllSaleOrder m_bllSaleOrder = new BllSaleOrder();
        private BllProduct m_bllProduct = new BllProduct();
        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllCode m_bllCode = new BllCode();

        public FrmProductDetail(int _mode, int _productId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_productId = _productId;
        }

        private void FrmProductDetail_Load(object sender, EventArgs e)
        {
            //初始化
            init();
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

        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {           
           
            //下拉框
            //包装类型
            List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.PackagingType, false);
            WinCommon.BindComboBox(ref cmb_packingType, listItem);
            //成品形态
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.ProductForm, false);
            WinCommon.BindComboBox(ref cmb_morphology, listItem);
            //执行标准
            listItem = m_bllProduct.GetExcuteStandard();
            WinCommon.BindComboBox(ref this.cmb_excuteStandard, listItem);
            //危险等级
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.DangerClasses, false);
            WinCommon.BindComboBox(ref this.cmb_dangerClasses, listItem);

            // 设置datagrid
            SetDataGridViewStyle_materials();
            SetDataGridViewStyle_specs();

            //初始化(修改或者删除时)
            if (m_mode != 0 && m_productId > 0)
            {
                ModelProduct modelProduct = m_bllProduct.GetProductById(m_productId);

                //成品名
                this.txt_name.Text = modelProduct.name;
                //成品略名
                this.txt_subName.Text = modelProduct.subName;
                //检索键
                this.txt_searchKey.Text = modelProduct.modelProductSearch.searchKey;

                //执行标准
                for (int i = 0; i < this.cmb_excuteStandard.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_excuteStandard.Items[i];
                    if (modelProduct.excuteStandard == modelItem.itemValue)
                    {
                        this.cmb_excuteStandard.SelectedIndex = i;
                        break;
                    }
                }

                //危险等级
                for (int i = 0; i < this.cmb_dangerClasses.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_dangerClasses.Items[i];
                    if (modelProduct.dangerClasses == (int)modelItem.itemKey)
                    {
                        this.cmb_dangerClasses.SelectedIndex = i;
                        break;
                    }
                }

                //CAS
                this.txt_cas.Text = modelProduct.CAS;

                //FEMA
                this.txt_fema.Text = modelProduct.FEMA;

                //包装类型
                for (int i = 0; i < this.cmb_packingType.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_packingType.Items[i];
                    if (modelProduct.packingType == (int)modelItem.itemKey)
                    {
                        this.cmb_packingType.SelectedIndex = i;
                        break;
                    }
                }
                //成品形态
                for (int i = 0; i < this.cmb_morphology.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_morphology.Items[i];
                    if (modelProduct.morphology == (int)modelItem.itemKey)
                    {
                        this.cmb_morphology.SelectedIndex = i;
                        break;
                    }
                }
              
                //包装说明
                this.txt_packingRemark.Text = modelProduct.packingRemark;
                //保质期
                this.txt_shelfLife.Text = modelProduct.shelfLife.ToString();
                //过期提醒天数
                this.txt_expiredDays.Text = modelProduct.expiredDays.ToString();
                //库存报警数
                this.txt_minStockNum.Text = modelProduct.minStockNum.ToString();

                this.dgv_productMaterials.DataSource = m_bllProduct.GetProductMaterialsById(m_productId);
                this.dgv_productMaterials.Refresh();

                this.dgv_specs.DataSource = m_bllProduct.GetProductSpecsListByProdcutId(m_productId);
                this.dgv_specs.Refresh();

            }

            //查看/删除时，输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                this.grb_product.Enabled = false;
                this.grb_productMaterials.Enabled = false;
                this.grb_specs.Enabled = false;
            }
            else
            {
                this.grb_product.Enabled = true;
                this.grb_productMaterials.Enabled = true;
                this.grb_specs.Enabled = true;
            }

            if (m_mode == 3)
            {
                this.btn_submit.Visible = false;
                this.btn_cancel.Visible = false;
                this.btn_close.Visible = true;
            }
            else
            {
                this.btn_submit.Visible = true;
                this.btn_cancel.Visible = true;
                this.btn_close.Visible = false;
            }
            
            if (!WinCommon.IsProducer(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                this.grb_new.Visible = false;

                this.grb_specs.Height = this.grb_specs.Height - this.grb_new.Height;

                this.grb_productMaterials.Visible = false;

                this.grb_product.Enabled = false;

                this.Height = this.Height - this.grb_productMaterials.Height - this.grb_new.Height;
                this.grb_specs.Top = this.grb_specs.Top - this.grb_productMaterials.Height;
                this.btn_submit.Top = this.btn_submit.Top - this.grb_productMaterials.Height - this.grb_new.Height;
                this.btn_cancel.Top = this.btn_cancel.Top - this.grb_productMaterials.Height - this.grb_new.Height;
                this.btn_close.Top = this.btn_close.Top - this.grb_productMaterials.Height - this.grb_new.Height;
            }
            else
            {
                this.grb_productMaterials.Visible = true;
                this.grb_new.Visible = true;
            }
            
        }
        #endregion

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        private Boolean doSubmit(bool _showMsg)
        {
            Boolean rtn = false;

            //检查
            if (doCheck(_showMsg) == false)
            {
                return false;
            }

            ModelProduct modelProduct = new ModelProduct();
            modelProduct.id = m_productId;
            modelProduct.name = this.txt_name.Text.Trim();
            modelProduct.subName = this.txt_subName.Text.Trim();

            ModelProductSearch modelProductSearch = new ModelProductSearch();
            modelProductSearch.productId = modelProduct.id;
            modelProductSearch.productName = modelProduct.name;
            modelProductSearch.searchKey = this.txt_searchKey.Text.Trim();
            modelProduct.modelProductSearch = modelProductSearch;

            modelProduct.excuteStandard = this.cmb_excuteStandard.Text.Trim();
            if (this.cmb_dangerClasses.SelectedIndex >= 0)
            {
                modelProduct.dangerClasses = (int)((ModelItem)this.cmb_dangerClasses.SelectedItem).itemKey;
            }
            modelProduct.CAS = this.txt_cas.Text.Trim();
            modelProduct.FEMA = this.txt_fema.Text.Trim();

            modelProduct.packingType = (int)((ModelItem)this.cmb_packingType.SelectedItem).itemKey;
            modelProduct.packingRemark = this.txt_packingRemark.Text.Trim();
            modelProduct.morphology = (int)((ModelItem)this.cmb_morphology.SelectedItem).itemKey;
            modelProduct.shelfLife = ConvertUtils.ConvertToInt(this.txt_shelfLife.Text);
            modelProduct.expiredDays = ConvertUtils.ConvertToInt(this.txt_expiredDays.Text);
            modelProduct.minStockNum = ConvertUtils.ConvertToDecimal(this.txt_minStockNum.Text, 4);
            modelProduct.isDelete = 0;
            modelProduct.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelProduct.createTime = DateTime.Now;
            modelProduct.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelProduct.modifyTime = DateTime.Now;

            List<ModelProductMaterials> modelProductMaterials = new List<ModelProductMaterials>();
            for (int i = 0; i < this.dgv_productMaterials.Rows.Count; i++)
            {

                int materialsId = ConvertUtils.ConvertToInt(this.dgv_productMaterials.Rows[i].Cells[2].Value);
                if (materialsId > 0)
                {
                    ModelProductMaterials materials = new ModelProductMaterials();
                    materials.id = ConvertUtils.ConvertToInt(this.dgv_productMaterials.Rows[i].Cells[0].Value);
                    materials.productId = modelProduct.id;
                    materials.materialsId = materialsId;
                    materials.searchKey = ConvertUtils.ConvertToString(this.dgv_productMaterials.Rows[i].Cells[1].Value);
                    materials.percent = ConvertUtils.ConvertToDecimal(this.dgv_productMaterials.Rows[i].Cells[3].Value);

                    modelProductMaterials.Add(materials);
                }

            }
            modelProduct.modelProductMaterials = modelProductMaterials;

            List<ModelProductPrice> listModelProductPrice = new List<ModelProductPrice>();
            for (int i = 0; i < this.dgv_specs.Rows.Count; i++)
            {
                ModelProductPrice modelProductPrice = new ModelProductPrice();
                modelProductPrice.productId = m_productId;
                modelProductPrice.id = ConvertUtils.ConvertToInt(this.dgv_specs.Rows[i].Cells["priceId"].Value);
                modelProductPrice.specsId = ConvertUtils.ConvertToInt(this.dgv_specs.Rows[i].Cells["specsId"].Value);
                modelProductPrice.minPrice = ConvertUtils.ConvertToDecimal(this.dgv_specs.Rows[i].Cells["minPrice"].Value);
                modelProductPrice.advisePrice = ConvertUtils.ConvertToDecimal(this.dgv_specs.Rows[i].Cells["advisePrice"].Value);
                modelProductPrice.isDelete = 0;
                modelProductPrice.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                modelProductPrice.createTime = DateTime.Now;
                modelProductPrice.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                modelProductPrice.modifyTime = DateTime.Now;

                listModelProductPrice.Add(modelProductPrice);
            }
            modelProduct.modelProductPrice = listModelProductPrice;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllProduct.AddProduct(modelProduct);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("新增成品失败！");
                    return false;
                }
                else
                {
                    //处理模式变为修改
                    m_mode = 1;
                    m_productId = m_bllProduct.GetProductByName(this.txt_name.Text).id;

                    if (_showMsg)
                    {
                        MsgUtils.ShowInfoMsg("新增成品成功！");
                        this.Hide();
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
                rtn = m_bllProduct.UpdateProduct(modelProduct);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("修改成品失败！");
                    return false;
                }
                else
                {
                    if (_showMsg)
                    {
                        MsgUtils.ShowInfoMsg("修改成品成功！");
                        this.Hide();
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
                rtn = m_bllProduct.DeleteProduct(modelProduct);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("删除成品失败！");
                    return false;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("删除成品成功！");

                    //返回用户列表
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
        private Boolean doCheck(bool _showMsg)
        {
            // 新增或修改
            if (m_mode == 0 || m_mode == 1)
            {
                //名称
                if (StringUtils.IsBlank(this.txt_name.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入原料名！");
                    this.txt_name.Focus();
                    return false;
                }
                ModelProduct product = m_bllProduct.GetProductByName(this.txt_name.Text);
                if (product.id > 0 && product.id != m_productId)
                {
                    MsgUtils.ShowErrorMsg("该成品已存在！");
                    this.txt_name.Focus();
                    return false;
                }

                //检索键
                if (StringUtils.IsBlank(this.txt_searchKey.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入检索键！");
                    this.txt_searchKey.Focus();
                    return false;
                }

                //包装类型
                if (this.cmb_packingType.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择包装类型！");
                    this.cmb_packingType.Focus();
                    return false;
                }
                //成品形态
                if (this.cmb_morphology.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择成品形态！");
                    this.cmb_morphology.Focus();
                    return false;
                }
                //保质期
                if (StringUtils.IsBlank(this.txt_shelfLife.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入保质期！");
                    this.txt_shelfLife.Focus();
                    return false;
                }
                int shelfLife = 0;
                if (!int.TryParse(this.txt_shelfLife.Text.Trim(), out shelfLife))
                {
                    MsgUtils.ShowErrorMsg("保质期仅限数字！");
                    this.txt_shelfLife.Focus();
                    return false;
                }
                //过期报警天数
                if (StringUtils.IsBlank(this.txt_expiredDays.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入过期报警天数！");
                    this.txt_expiredDays.Focus();
                    return false;
                }
                int expiredDays = 0;
                if (!int.TryParse(this.txt_expiredDays.Text.Trim(), out expiredDays))
                {
                    MsgUtils.ShowErrorMsg("过期报警天数仅限数字！");
                    this.txt_expiredDays.Focus();
                    return false;
                }                
                //库存报警天数
                if (StringUtils.IsBlank(this.txt_minStockNum.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入库存报警天数！");
                    this.txt_minStockNum.Focus();
                    return false;
                }
                decimal minStockNum = 0;
                if (!decimal.TryParse(this.txt_minStockNum.Text.Trim(), out minStockNum))
                {
                    MsgUtils.ShowErrorMsg("库存报警天数仅限数字！");
                    this.txt_minStockNum.Focus();
                    return false;
                }

                if (this.dgv_productMaterials.Rows.Count <= 1)
                {
                    MsgUtils.ShowErrorMsg("请输入原料！");
                    this.dgv_productMaterials.Focus();
                    return false;
                }

                List<int> listMaterialsId = new List<int>();
                decimal allMaterialPercent = 0;

                for (int i = 0; i < this.dgv_productMaterials.Rows.Count; i++)
                {

                    int materialsId = ConvertUtils.ConvertToInt(this.dgv_productMaterials.Rows[i].Cells[2].Value);
                    if (materialsId > 0)
                    {
                        if (listMaterialsId.Contains(materialsId))
                        {
                            MsgUtils.ShowErrorMsg("选择的原料不可重复！");
                            this.dgv_productMaterials.Focus();
                            return false;
                        }

                        decimal materialPercent = ConvertUtils.ConvertToDecimal(this.dgv_productMaterials.Rows[i].Cells[3].Value);
                        if (materialPercent <= 0)
                        {
                            MsgUtils.ShowErrorMsg("请输入合适的原料百分比！");
                            this.dgv_productMaterials.Focus();
                            return false;
                        }
                        else
                        {
                            allMaterialPercent = allMaterialPercent + materialPercent;
                        }
                        
                        listMaterialsId.Add(materialsId);
                    }
                }

                if (allMaterialPercent != 100)
                {
                    MsgUtils.ShowErrorMsg("原料百分比总和必须是100%！");
                    this.dgv_productMaterials.Focus();
                    return false;
                }

                if (_showMsg == true)
                {
                    if (this.dgv_specs.Rows.Count <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入规格！");
                        this.dgv_specs.Focus();
                        return false;
                    }

                    List<string> listSpecs = new List<string>();

                    for (int i = 0; i < this.dgv_specs.Rows.Count; i++)
                    {

                        string specs = ConvertUtils.ConvertToString(this.dgv_specs.Rows[i].Cells["name"].Value);
                        if (listSpecs.Contains(specs))
                        {
                            MsgUtils.ShowErrorMsg("成品规格已重复！");
                            this.dgv_specs.Focus();
                            return false;
                        }
                        else
                        {
                            listSpecs.Add(specs);
                        }

                        if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
                        {
                            decimal minPrice = ConvertUtils.ConvertToDecimal(this.dgv_specs.Rows[i].Cells["minPrice"].Value);
                            if (minPrice <= 0)
                            {
                                MsgUtils.ShowErrorMsg("请输入合适的最低售价！");
                                this.dgv_specs.Focus();
                                return false;
                            }

                            decimal advisePrice = ConvertUtils.ConvertToDecimal(this.dgv_specs.Rows[i].Cells["advisePrice"].Value);
                            if (advisePrice <= 0)
                            {
                                MsgUtils.ShowErrorMsg("请输入合适的建议售价！");
                                this.dgv_specs.Focus();
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
        #endregion

        private void txt_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

        private void txt_shelfLife_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyInt(e.KeyChar);
        }

        private void txt_expiredDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyInt(e.KeyChar);
        }

        private void txt_minStockNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

        private void txt_minPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

        private void txt_advisePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

        private void FrmProductDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// 设置DataGridView列
        /// </summary>
        private void SetDataGridViewStyle_materials()
        {
            this.dgv_productMaterials.Columns.Clear();

            DataGridViewTextBoxColumn columns = new DataGridViewTextBoxColumn();
            columns.Name = "id";
            columns.HeaderText = "id";
            columns.DataPropertyName = "id";
            columns.Visible = false;
            this.dgv_productMaterials.Columns.Add(columns);

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "searchKey";
            columns.HeaderText = "  ";
            columns.DataPropertyName = "searchKey";
            columns.Width = 150;
            this.dgv_productMaterials.Columns.Add(columns);

            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            column.Name = "materialsId";
            column.HeaderText = "原料";
            column.DataPropertyName = "materialsId";
            column.Width = 150;
            this.dgv_productMaterials.Columns.Add(column);
            column.DataSource = m_bllMaterials.GetMaterialsBySearchKey("");
            column.DisplayMember = "materialsName";
            column.ValueMember = "materialsId";

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "percent";
            columns.HeaderText = "百分比";
            columns.DataPropertyName = "percent";
            columns.Width = 100;
            this.dgv_productMaterials.Columns.Add(columns);

        }

        /// <summary>
        /// 设置DataGridView列
        /// </summary>
        private void SetDataGridViewStyle_specs()
        {
            this.dgv_specs.AllowUserToAddRows = false;
            this.dgv_specs.AllowUserToDeleteRows = false;
            this.dgv_specs.Columns.Clear();

            DataGridViewTextBoxColumn columnsSpecsId = new DataGridViewTextBoxColumn();
            columnsSpecsId.Name = "specsId";
            columnsSpecsId.HeaderText = "specsId";
            columnsSpecsId.DataPropertyName = "specsId";
            columnsSpecsId.Visible = false;
            this.dgv_specs.Columns.Add(columnsSpecsId);

            DataGridViewTextBoxColumn columnsName = new DataGridViewTextBoxColumn();
            columnsName.Name = "name";
            columnsName.HeaderText = "规格";
            columnsName.DataPropertyName = "name";
            columnsName.Width = 200;
            columnsName.Visible = true;
            this.dgv_specs.Columns.Add(columnsName);

            DataGridViewTextBoxColumn columnsPriceId = new DataGridViewTextBoxColumn();
            columnsPriceId.Name = "priceId";
            columnsPriceId.HeaderText = "priceId";
            columnsPriceId.DataPropertyName = "priceId";
            columnsPriceId.Visible = false;
            this.dgv_specs.Columns.Add(columnsPriceId);

            DataGridViewTextBoxColumn columnsMinPrice = new DataGridViewTextBoxColumn();
            columnsMinPrice.Name = "minPrice";
            columnsMinPrice.HeaderText = "最低售价";
            columnsMinPrice.DataPropertyName = "minPrice";
            columnsMinPrice.Width = 100;
            if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                columnsMinPrice.Visible = true;
            }
            else
            {
                columnsMinPrice.Visible = false;
            }
            this.dgv_specs.Columns.Add(columnsMinPrice);

            DataGridViewTextBoxColumn columnsAdvisePrice = new DataGridViewTextBoxColumn();
            columnsAdvisePrice.Name = "advisePrice";
            columnsAdvisePrice.HeaderText = "建议售价";
            columnsAdvisePrice.DataPropertyName = "advisePrice";
            columnsAdvisePrice.Width = 100;
            if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                columnsAdvisePrice.Visible = true;
            }
            else
            {
                columnsAdvisePrice.Visible = false;
            }
            this.dgv_specs.Columns.Add(columnsAdvisePrice);

            DataGridViewButtonColumn btnColumns = new DataGridViewButtonColumn();
            btnColumns.Name = "deleteBtn";
            btnColumns.HeaderText = "删除";
            btnColumns.DataPropertyName = "deleteBtn";
            if (WinCommon.IsProducer(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                btnColumns.Width = 100;
            }
            else
            {
                btnColumns.Visible = false;
            }
            this.dgv_specs.Columns.Add(btnColumns);

        }

        private void dgv_productMaterials_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex < 0 || e.ColumnIndex != 1)
            {
                return;
            }

            // 检索键
            if (e.ColumnIndex == 1)
            {
                string searchKey = ConvertUtils.ConvertToString(this.dgv_productMaterials.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int materialsId = ConvertUtils.ConvertToInt(this.dgv_productMaterials.Rows[e.RowIndex].Cells[2].Value);
                searchKey = searchKey.ToUpper();

                DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)this.dgv_productMaterials.Rows[e.RowIndex].Cells[2];


                DataTable dt = m_bllMaterials.GetMaterialsBySearchKey(searchKey);
                if (dt == null || dt.Rows.Count <= 0)
                {
                    MsgUtils.ShowInfoMsg("没有此原料，请重新输入！");
                    this.dgv_productMaterials.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                    return;
                }
                column.DataSource = dt;
                column.DisplayMember = "materialsName";
                column.ValueMember = "materialsId";

                bool isFind = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (materialsId == ConvertUtils.ConvertToInt(dt.Rows[i][2]))
                    {
                        isFind = true;
                        break;
                    }
                }
                if (!isFind)
                {
                    this.dgv_productMaterials.Rows[e.RowIndex].Cells[2].Value = dt.Rows[0]["materialsId"];
                }
            }

        }

        private void dgv_productMaterials_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dgv_productMaterials.CurrentCell.ColumnIndex == 3)
            {
                TextBox tx = (TextBox)e.Control;
                tx.KeyPress -= new KeyPressEventHandler(tx_keyPress);
                tx.KeyPress += new KeyPressEventHandler(tx_keyPress);
            }
            if (this.dgv_productMaterials.CurrentCell.ColumnIndex == 1)
            {
                TextBox tx = (TextBox)e.Control;
                tx.KeyPress -= new KeyPressEventHandler(tx_keyPress);
            }
        }

        private void tx_keyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (m_mode == 0)
            {
                if (doSubmit(false) == false)
                {
                    return;
                }
            }

            decimal weight = ConvertUtils.ConvertToDecimal(this.txt_weight.Text.Trim(), 4);
            if (weight <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入合适的重量！");
                this.txt_weight.Focus();
                return;
            }

            int num = ConvertUtils.ConvertToInt(this.txt_num.Text.Trim());
            if (num <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入合适的数量！");
                this.txt_num.Focus();
                return;
            }

            string name = weight + "(KG)*" + num;
            for (int i = 0; i < this.dgv_specs.Rows.Count; i++)
            {
                if (name == ConvertUtils.ConvertToString(this.dgv_specs.Rows[i].Cells["name"].Value))
                {
                    MsgUtils.ShowErrorMsg("成品规格已重复！");
                    this.txt_weight.Focus();
                    return;
                }
            }

            ModelProductSpecs newSpecs = new ModelProductSpecs();
            newSpecs.productId = m_productId;
            newSpecs.name = name;
            //转为克
            newSpecs.weight = weight * 1000;
            newSpecs.num = num;
            newSpecs.isDelete = 0;
            newSpecs.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            newSpecs.createTime = DateTime.Now;

            int newSpecsId = m_bllProduct.AddProductSpecs(newSpecs);
            if (newSpecsId > 0)
            {

                DataTable dtMaterials = m_bllProduct.GetProductMaterialsById(m_productId);
                if (dtMaterials != null && dtMaterials.Rows.Count > 0)
                {
                    decimal unitProductPrice = 0;
                    foreach (DataRow dr in dtMaterials.Rows)
                    {
                        int materialsId = ConvertUtils.ConvertToInt(dr["materialsId"]);
                        decimal percent = ConvertUtils.ConvertToDecimal(dr["percent"], 4);

                        decimal unitMaterialsPrice = 0;
                        ModelMaterialsPrice modelMaterialsPrice = m_bllMaterials.GetMaterialsPriceByMaterialsId(materialsId);
                        if(modelMaterialsPrice.specsId <= 0)
                        {
                            unitMaterialsPrice = modelMaterialsPrice.price;
                        } 
                        else 
                        {
                            ModelMaterialsSpecs modelMaterialsSpecs = m_bllMaterials.GetMaterialsSpecsById(modelMaterialsPrice.specsId);
                            unitMaterialsPrice = modelMaterialsPrice.price / (modelMaterialsSpecs.weight * modelMaterialsSpecs.num);
                        }

                        unitProductPrice = unitProductPrice + unitMaterialsPrice;
                    }

                    decimal productPrice = ConvertUtils.ConvertToDecimal(unitProductPrice * newSpecs.weight * newSpecs.num);

                    ModelProductPrice modelProductPrice = new ModelProductPrice();
                    modelProductPrice.productId = m_productId;
                    modelProductPrice.specsId = newSpecsId;
                    modelProductPrice.minPrice = productPrice * ConvertUtils.ConvertToDecimal(m_bllCode.GetSubCode((int)Enum.EnumCode.AdvisePrice, 1).value1);
                    modelProductPrice.advisePrice = productPrice * ConvertUtils.ConvertToDecimal(m_bllCode.GetSubCode((int)Enum.EnumCode.AdvisePrice, 2).value1);
                    modelProductPrice.isDelete = 0;
                    modelProductPrice.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                    modelProductPrice.createTime = DateTime.Now;

                    m_bllProduct.AddProductPrice(modelProductPrice);

                }


                DataTable dt = (DataTable)this.dgv_specs.DataSource;
                if (dt == null)
                {
                    dt = m_bllProduct.GetProductSpecsListByProdcutId(m_productId);
                }
                else
                {
                    DataRow dr = dt.NewRow();
                    dr["specsId"] = newSpecsId;
                    dr["name"] = newSpecs.name;
                    dr["deleteBtn"] = "删除";
                    dt.Rows.Add(dr);
                }
                this.dgv_specs.DataSource = dt;

                MsgUtils.ShowInfoMsg("新增规格成功！");
                return;
            }
            else
            {
                MsgUtils.ShowErrorMsg("新增规格失败！");
                return;
            }
        }

        private void dgv_specs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //删除
            if (this.dgv_specs.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int specsId = (int)this.dgv_specs.Rows[e.RowIndex].Cells["specsId"].Value;

                DataTable dt = m_bllSaleOrder.GetSaleOrderDetailByProductSpecs(m_productId, specsId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MsgUtils.ShowErrorMsg("此规格已销售，不可删除！");
                    return;
                }

                if (MsgUtils.ShowQustMsg("确认删除此规格？", MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ModelProductSpecs modelProductSpecs = new ModelProductSpecs();
                    modelProductSpecs.id = specsId;
                    modelProductSpecs.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    modelProductSpecs.modifyTime = DateTime.Now;

                    if (m_bllProduct.DeleteProductSpecs(modelProductSpecs))
                    {
                        MsgUtils.ShowInfoMsg("删除规格成功！");
                        this.dgv_specs.Rows.RemoveAt(e.RowIndex);
                        return;
                    }
                    else
                    {
                        MsgUtils.ShowErrorMsg("删除规格失败！");
                        return;
                    }
                }
            }
        }

        private void dgv_specs_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dgv_specs.CurrentCell.ColumnIndex == 4 || this.dgv_specs.CurrentCell.ColumnIndex == 5)
            {
                TextBox tx = (TextBox)e.Control;
                tx.KeyPress -= new KeyPressEventHandler(tx_keyPress);
                tx.KeyPress += new KeyPressEventHandler(tx_keyPress);
            }
        }

    }
}
