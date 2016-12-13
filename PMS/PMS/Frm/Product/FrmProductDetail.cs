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
    public partial class FrmProductDetail : Form
    {
        //处理模式（0：新建；1：修改；2：删除）
        private int m_mode;
        //原来ID
        private int m_productId;
        
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
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //初始化
            init();

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回用户列表
            Form form = new FrmProductManage();
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
                this.lbl_title.Text = "商品信息设定-新增";
            }
            else if (m_mode == 1)
            {
                this.lbl_title.Text = "商品信息设定-修改";
            }
            else
            {
                this.lbl_title.Text = "商品信息设定-删除";
            }

            //下拉框
            //包装类型
            List<ModelItem> listItem = m_bllCode.GetCodeItem(1, false);
            WinCommon.BindComboBox(ref cmb_packingType, listItem);
            //产品形态
            listItem = m_bllCode.GetCodeItem(2, false);
            WinCommon.BindComboBox(ref cmb_morphology, listItem);
            //重量单位
            listItem = m_bllCode.GetCodeItem(3, false);           
            WinCommon.BindComboBox(ref cmb_weightUnit, listItem);
            //价格单位
            WinCommon.BindComboBox(ref cmb_priceUnit, listItem);

            // 设置datagrid
            SetDataGridViewStyle();

            //初始化(修改或者删除时)
            if (m_mode != 0 && m_productId > 0)
            {
                ModelProduct modelProduct = m_bllProduct.GetProductById(m_productId);

                //商品名
                this.txt_name.Text = modelProduct.name;
                //商品略名
                this.txt_subName.Text = modelProduct.subName;
                //检索键
                this.txt_searchKey.Text = modelProduct.modelProductSearch.searchKey;

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
                //产品形态
                for (int i = 0; i < this.cmb_morphology.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_morphology.Items[i];
                    if (modelProduct.morphology == (int)modelItem.itemKey)
                    {
                        this.cmb_morphology.SelectedIndex = i;
                        break;
                    }
                }
                //重量单位
                for (int i = 0; i < this.cmb_weightUnit.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_weightUnit.Items[i];
                    if (modelProduct.weightUnit == (int)modelItem.itemKey)
                    {
                        this.cmb_weightUnit.SelectedIndex = i;
                        break;
                    }
                }

                //包装说明
                this.txt_packingRemark.Text = modelProduct.packingRemark;
                //重量
                this.txt_weight.Text = modelProduct.weight.ToString();
                //保质期
                this.txt_shelfLife.Text = modelProduct.shelfLife.ToString();
                //过期提醒天数
                this.txt_expiredDays.Text = modelProduct.expiredDays.ToString();
                //库存报警数
                this.txt_minStockNum.Text = modelProduct.minStockNum.ToString();
                //价格
                this.txt_minPrice.Text = modelProduct.modelProductPrice.minPrice.ToString();
                this.txt_advisePrice.Text = modelProduct.modelProductPrice.advisePrice.ToString();
                //价格单位
                for (int i = 0; i < this.cmb_priceUnit.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_priceUnit.Items[i];
                    if (modelProduct.modelProductPrice.priceUnit == (int)modelItem.itemKey)
                    {
                        this.cmb_priceUnit.SelectedIndex = i;
                        break;
                    }
                }

                dataGridView1.DataSource = m_bllProduct.GetProductMaterialsById(m_productId);
                dataGridView1.Refresh();

            }

            //删除时，输入项不能修改
            if (m_mode == 2)
            {
                grb_materials.Enabled = false;
                grb_price.Enabled = false;
                dataGridView1.Enabled = false;
            }
            else
            {
                grb_materials.Enabled = true;
                grb_price.Enabled = true;
                dataGridView1.Enabled = true;
            }

            //价格相关
            this.grb_price.Visible = LoginUserInfo.LoginUser.loginRole.isFinance == 1 ? true: false;
            
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

            ModelProduct modelProduct = new ModelProduct();
            modelProduct.id = m_productId;
            modelProduct.name = this.txt_name.Text.Trim();
            modelProduct.subName = this.txt_subName.Text.Trim();

            ModelProductSearch modelProductSearch = new ModelProductSearch();
            modelProductSearch.productId = modelProduct.id;
            modelProductSearch.productName = modelProduct.name;
            modelProductSearch.searchKey = this.txt_searchKey.Text.Trim();
            modelProduct.modelProductSearch = modelProductSearch;

            modelProduct.packingType = (int)((ModelItem)this.cmb_packingType.SelectedItem).itemKey;
            modelProduct.packingRemark = this.txt_packingRemark.Text.Trim();
            modelProduct.morphology = (int)((ModelItem)this.cmb_morphology.SelectedItem).itemKey;
            modelProduct.weight = ConvertUtils.ConvertToDecimal(this.txt_weight.Text);
            modelProduct.weightUnit = (int)((ModelItem)this.cmb_weightUnit.SelectedItem).itemKey;
            modelProduct.shelfLife = ConvertUtils.ConvertToInt(this.txt_shelfLife.Text);
            modelProduct.expiredDays = ConvertUtils.ConvertToInt(this.txt_expiredDays.Text);
            modelProduct.minStockNum = ConvertUtils.ConvertToInt(this.txt_minStockNum.Text);

            if (LoginUserInfo.LoginUser.loginRole.isFinance == 1)
            {
                ModelProductPrice modelProductPrice = new ModelProductPrice();
                modelProductPrice.productId = modelProduct.id;
                modelProductPrice.minPrice = ConvertUtils.ConvertToDecimal(this.txt_minPrice.Text);
                modelProductPrice.advisePrice = ConvertUtils.ConvertToDecimal(this.txt_advisePrice.Text);
                modelProductPrice.priceUnit = (int)((ModelItem)this.cmb_priceUnit.SelectedItem).itemKey;
                modelProduct.modelProductPrice = modelProductPrice;
            }
            else
            {
                modelProduct.modelProductPrice = null;
            }
            modelProduct.isDelete = 0;
            modelProduct.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelProduct.createTime = DateTime.Now;
            modelProduct.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelProduct.modifyTime = DateTime.Now;

            List<ModelProductMaterials> modelProductMaterials = new List<ModelProductMaterials>();
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {

                int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[2].Value);
                if (materialsId > 0)
                {
                    ModelProductMaterials materials = new ModelProductMaterials();
                    materials.id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[0].Value);
                    materials.productId = modelProduct.id;
                    materials.materialsId = materialsId;
                    materials.searchKey = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells[1].Value);
                    materials.materialsNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells[3].Value);
                    materials.materialsUnit = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[4].Value);

                    modelProductMaterials.Add(materials);
                }

            }
            modelProduct.modelProductMaterials = modelProductMaterials;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllProduct.AddProduct(modelProduct);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("新增商品失败！");
                    return ;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("新增商品成功！");
                }

                //处理模式变为修改
                m_mode = 1;
                m_productId = m_bllProduct.GetProductByName(this.txt_name.Text).id;

                init();

                return;
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllProduct.UpdateProduct(modelProduct);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("修改商品失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("修改商品成功！");
                    return;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllProduct.DeleteProduct(modelProduct);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("删除商品失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("删除商品成功！");

                    //返回用户列表
                    Form form = new FrmProductManage();
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
                    MsgUtils.ShowErrorMsg("该商品已存在！");
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
                //产品形态
                if (this.cmb_morphology.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择产品形态！");
                    this.cmb_morphology.Focus();
                    return false;
                }
                //重量
                if (StringUtils.IsBlank(this.txt_weight.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入重量！");
                    this.txt_weight.Focus();
                    return false;
                }
                decimal weigth = 0;
                if (!decimal.TryParse(this.txt_weight.Text.Trim(), out weigth))
                {
                    MsgUtils.ShowErrorMsg("重量仅限数字！");
                    this.txt_weight.Focus();
                    return false;
                }
                //重量单位
                if (this.cmb_weightUnit.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择重量单位！");
                    this.cmb_weightUnit.Focus();
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
                int minStockNum = 0;
                if (!int.TryParse(this.txt_minStockNum.Text.Trim(), out minStockNum))
                {
                    MsgUtils.ShowErrorMsg("库存报警天数仅限数字！");
                    this.txt_minStockNum.Focus();
                    return false;
                }

                if (this.dataGridView1.Rows.Count <= 1)
                {
                    MsgUtils.ShowErrorMsg("请输入原料！");
                    this.dataGridView1.Focus();
                    return false;
                }

                List<int> listMaterialsId = new List<int>();
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {

                    int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[2].Value);
                    if (materialsId > 0)
                    {
                        if (listMaterialsId.Contains(materialsId))
                        {
                            MsgUtils.ShowErrorMsg("选择的原料不可重复！");
                            this.dataGridView1.Focus();
                            return false;
                        }

                        decimal materialsNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells[3].Value);
                        if (materialsNum <= 0)
                        {
                            MsgUtils.ShowErrorMsg("原料数量不能为空！");
                            this.dataGridView1.Focus();
                            return false;
                        }

                        int materialsUnit = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[4].Value);
                        if (materialsUnit <= 0)
                        {
                            MsgUtils.ShowErrorMsg("原料单位不能为空！");
                            this.dataGridView1.Focus();
                            return false;
                        }

                        listMaterialsId.Add(materialsId);
                    }

                    if (LoginUserInfo.LoginUser.loginRole.isFinance == 1) 
                    {
                        if (StringUtils.IsBlank(this.txt_minPrice.Text))
                        {
                            MsgUtils.ShowErrorMsg("请输入最低价格！");
                            this.txt_minPrice.Focus();
                            return false;
                        }
                        int minPrice = 0;
                        if (!int.TryParse(this.txt_minPrice.Text.Trim(), out minPrice))
                        {
                            MsgUtils.ShowErrorMsg("最低价格仅限数字！");
                            this.txt_minPrice.Focus();
                            return false;
                        }

                        if (StringUtils.IsBlank(this.txt_advisePrice.Text))
                        {
                            MsgUtils.ShowErrorMsg("请输入最低价格！");
                            this.txt_advisePrice.Focus();
                            return false;
                        }
                        int advisePrice = 0;
                        if (!int.TryParse(this.txt_advisePrice.Text.Trim(), out advisePrice))
                        {
                            MsgUtils.ShowErrorMsg("建议销售价格仅限数字！");
                            this.txt_advisePrice.Focus();
                            return false;
                        }

                        if (this.cmb_priceUnit.SelectedIndex < 0)
                        {
                            MsgUtils.ShowErrorMsg("请选择重量价格单位！");
                            this.cmb_weightUnit.Focus();
                            return false;
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
            e.Handled = WinCommon.IsOnlyInt(e.KeyChar);
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
            WinCommon.Exit();
        }

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
            columns.Width = 150;
            this.dataGridView1.Columns.Add(columns);

            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            column.Name = "materialsId";
            column.HeaderText = "原料";
            column.DataPropertyName = "materialsId";
            column.Width = 150;
            this.dataGridView1.Columns.Add(column);
            column.DataSource = m_bllMaterials.GetMaterialsBySearchKey("");
            column.DisplayMember = "materialsName";
            column.ValueMember = "materialsId";

            columns = new DataGridViewTextBoxColumn();
            columns.Name = "materialsNum";
            columns.HeaderText = "数量";
            columns.DataPropertyName = "materialsNum";
            columns.Width = 100;
            this.dataGridView1.Columns.Add(columns);

            column = new DataGridViewComboBoxColumn();
            column.Name = "materialsUnit";
            column.DataPropertyName = "materialsUnit";
            column.HeaderText = "单位";
            column.Width = 100;
            this.dataGridView1.Columns.Add(column);
            column.DataSource = m_bllCode.GetCodeList(3);      
            column.DisplayMember = "value1";
            column.ValueMember = "subCode";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // return;

            if( e.RowIndex < 0 || e.ColumnIndex != 1)
            {
                return;
            }

            // 检索键
            if (e.ColumnIndex == 1)
            {
                string searchKey = ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                searchKey = searchKey.ToUpper();

                DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells[2];

                column.DataSource = m_bllMaterials.GetMaterialsBySearchKey(searchKey);
                column.DisplayMember = "materialsName";
                column.ValueMember = "materialsId";

            }

            if (e.ColumnIndex == 3)
            {
                DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells[4];

                column.DataSource = m_bllCode.GetCodeList(3);
                column.DisplayMember = "value1";
                column.ValueMember = "subCode";
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                TextBox tx = (TextBox)e.Control;
                tx.KeyPress -= new KeyPressEventHandler(tx_keyPress);
                tx.KeyPress += new KeyPressEventHandler(tx_keyPress);
            }
        }

        private void tx_keyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }
    }
}
