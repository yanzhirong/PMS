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
    public partial class FrmMaterialsDetail : Main.BaseForm
    {
        //处理模式（0：新建；1：修改；2：删除）
        private int m_mode;
        //原来ID
        private int m_materialsId;

        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllMaterialsIn m_bllMaterialsIn = new BllMaterialsIn();
        private BllCode m_bllCode = new BllCode();

        public FrmMaterialsDetail(int _mode, int _materialsId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_materialsId = _materialsId;
        }

        private void FrmMaterialsDetail_Load(object sender, EventArgs e)
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
            WinCommon.BindComboBox(ref this.cmb_packingType, listItem);
            //成品形态
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.ProductForm, false);
            WinCommon.BindComboBox(ref this.cmb_morphology, listItem);
            //执行标准
            listItem = m_bllMaterials.GetExcuteStandard();
            WinCommon.BindComboBox(ref this.cmb_excuteStandard, listItem);
            //危险等级
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.DangerClasses, false);
            WinCommon.BindComboBox(ref this.cmb_dangerClasses, listItem);

            SetDataGridViewStyle_specs();

            this.cmb_materialsType.SelectedIndex = 0;

            //初始化(修改或者删除时)
            if (m_mode != 0 && m_materialsId > 0)
            {
                ModelMaterials modelMaterials = m_bllMaterials.GetMaterialsById(m_materialsId);

                //原料名
                this.txt_name.Text = modelMaterials.name;
                //原料略名
                this.txt_subName.Text = modelMaterials.subName;
                //检索键
                this.txt_searchKey.Text = modelMaterials.modelMaterialsSearch.searchKey;

                //执行标准
                for (int i = 0; i < this.cmb_excuteStandard.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_excuteStandard.Items[i];
                    if (modelMaterials.excuteStandard == modelItem.itemValue)
                    {
                        this.cmb_excuteStandard.SelectedIndex = i;
                        break;
                    }
                }

                //危险等级
                for (int i = 0; i < this.cmb_dangerClasses.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_dangerClasses.Items[i];
                    if (modelMaterials.dangerClasses == (int)modelItem.itemKey)
                    {
                        this.cmb_dangerClasses.SelectedIndex = i;
                        break;
                    }
                }

                //CAS
                this.txt_cas.Text = modelMaterials.CAS;

                //FEMA
                this.txt_fema.Text = modelMaterials.FEMA;

                //包装类型
                for (int i = 0; i < this.cmb_packingType.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_packingType.Items[i];
                    if (modelMaterials.packingType == (int)modelItem.itemKey)
                    {
                        this.cmb_packingType.SelectedIndex = i;
                        break;
                    }
                }
                //成品形态
                for (int i = 0; i < this.cmb_morphology.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_morphology.Items[i];
                    if (modelMaterials.morphology == (int)modelItem.itemKey)
                    {
                        this.cmb_morphology.SelectedIndex = i;
                        break;
                    }
                }

                //原料类型
                this.cmb_materialsType.SelectedIndex = modelMaterials.type;

                //包装说明
                this.txt_packingRemark.Text = modelMaterials.packingRemark;
                //保质期
                this.txt_shelfLife.Text = modelMaterials.shelfLife.ToString();
                //过期提醒天数
                this.txt_expiredDays.Text = modelMaterials.expiredDays.ToString();
                //库存报警数
                this.txt_minStockNum.Text = modelMaterials.minStockNum.ToString();

                //其他原料
                if (modelMaterials.type == 2)
                {
                    //价格
                    this.txt_price.Text = modelMaterials.modelMaterialsPrice[0].price.ToString();
                }
                else
                {
                    this.dgv_specs.DataSource = m_bllMaterials.GetMaterialsSpecsListByMaterialsId(m_materialsId);
                    this.dgv_specs.Refresh();
                }


            }

            //删除时，输入项不能修改
            if (m_mode == 2)
            {
                grb_materials.Enabled = false;
            }
            else
            {
                grb_materials.Enabled = true;
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

            ModelMaterials modelMaterials = new ModelMaterials();
            modelMaterials.id = m_materialsId;
            modelMaterials.name = this.txt_name.Text.Trim();
            modelMaterials.subName = this.txt_subName.Text.Trim();

            ModelMaterialsSearch modelMaterialsSearch = new ModelMaterialsSearch();
            modelMaterialsSearch.materialsId = modelMaterials.id;
            modelMaterialsSearch.materialsName = modelMaterials.name;
            modelMaterialsSearch.searchKey = this.txt_searchKey.Text.Trim();
            modelMaterials.modelMaterialsSearch = modelMaterialsSearch;

            modelMaterials.excuteStandard = this.cmb_excuteStandard.Text.Trim();
            if(this.cmb_dangerClasses.SelectedIndex >= 0)
            {
                modelMaterials.dangerClasses = (int)((ModelItem)this.cmb_dangerClasses.SelectedItem).itemKey;
            }
            modelMaterials.CAS = this.txt_cas.Text.Trim();
            modelMaterials.FEMA = this.txt_fema.Text.Trim();

            modelMaterials.packingType = (int)((ModelItem)this.cmb_packingType.SelectedItem).itemKey;
            modelMaterials.packingRemark = this.txt_packingRemark.Text.Trim();
            modelMaterials.morphology = (int)((ModelItem)this.cmb_morphology.SelectedItem).itemKey;
            modelMaterials.shelfLife = ConvertUtils.ConvertToInt(this.txt_shelfLife.Text);
            modelMaterials.expiredDays = ConvertUtils.ConvertToInt(this.txt_expiredDays.Text);
            modelMaterials.minStockNum = ConvertUtils.ConvertToDecimal(this.txt_minStockNum.Text, 4);
            modelMaterials.type = this.cmb_materialsType.SelectedIndex;
            modelMaterials.isDelete = 0;
            modelMaterials.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelMaterials.createTime = DateTime.Now;
            modelMaterials.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelMaterials.modifyTime = DateTime.Now;

            List<ModelMaterialsPrice> listModelMaterialsPrice = new List<ModelMaterialsPrice>();
            //其他原料
            if (this.cmb_materialsType.SelectedIndex == 2)
            {
                ModelMaterialsPrice modelMaterialsPrice = new ModelMaterialsPrice();
                modelMaterialsPrice.materialsId = m_materialsId;
                modelMaterialsPrice.price = ConvertUtils.ConvertToDecimal(this.txt_price.Text);
                modelMaterialsPrice.isDelete = 0;
                modelMaterialsPrice.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                modelMaterialsPrice.createTime = DateTime.Now;
                modelMaterialsPrice.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                modelMaterialsPrice.modifyTime = DateTime.Now;
                listModelMaterialsPrice.Add(modelMaterialsPrice);
            }
            else
            {
                for (int i = 0; i < this.dgv_specs.Rows.Count; i++)
                {
                    ModelMaterialsPrice modelMaterialsPrice = new ModelMaterialsPrice();
                    modelMaterialsPrice.materialsId = m_materialsId;
                    modelMaterialsPrice.id = ConvertUtils.ConvertToInt(this.dgv_specs.Rows[i].Cells["priceId"].Value);
                    modelMaterialsPrice.specsId = ConvertUtils.ConvertToInt(this.dgv_specs.Rows[i].Cells["specsId"].Value);
                    modelMaterialsPrice.price = ConvertUtils.ConvertToDecimal(this.dgv_specs.Rows[i].Cells["price"].Value);
                    modelMaterialsPrice.isDelete = 0;
                    modelMaterialsPrice.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                    modelMaterialsPrice.createTime = DateTime.Now;
                    modelMaterialsPrice.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    modelMaterialsPrice.modifyTime = DateTime.Now;

                    listModelMaterialsPrice.Add(modelMaterialsPrice);
                }
            }
            modelMaterials.modelMaterialsPrice = listModelMaterialsPrice;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllMaterials.AddMaterials(modelMaterials);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("新增原料失败！");
                    return false;
                }
                else
                {
                    //处理模式变为修改
                    m_mode = 1;
                    m_materialsId = m_bllMaterials.GetMaterialsByName(this.txt_name.Text).id;

                    if (_isConfirm)
                    {
                        MsgUtils.ShowInfoMsg("新增原料成功！");
                        this.Hide();
                    }
                }

                return true;
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllMaterials.UpdateMaterials(modelMaterials);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("修改原料失败！");
                    return false;
                }
                else
                {
                    if (_isConfirm)
                    {
                        MsgUtils.ShowInfoMsg("修改原料成功！");
                        this.Hide();
                    }
                    return true;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllMaterials.DeleteMaterials(modelMaterials);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("删除原料失败！");
                    return false;
                }
                else
                {
                    if (_isConfirm)
                    {
                        MsgUtils.ShowInfoMsg("删除原料成功！");
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
                ModelMaterials materials = m_bllMaterials.GetMaterialsByName(this.txt_name.Text);
                if (materials.id > 0 && materials.id != m_materialsId)
                {
                    MsgUtils.ShowErrorMsg("该原料已存在！");
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

                ////执行标准
                //if (this.cmb_excuteStandard.SelectedIndex < 0)
                //{
                //    MsgUtils.ShowErrorMsg("请选择执行标准！");
                //    this.cmb_excuteStandard.Focus();
                //    return false;
                //}

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
                //原料类型
                if (this.cmb_materialsType.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择原料类型！");
                    this.cmb_materialsType.Focus();
                    return false;
                }
                ////重量
                //if (StringUtils.IsBlank(this.txt_weight.Text))
                //{
                //    MsgUtils.ShowErrorMsg("请输入重量！");
                //    this.txt_weight.Focus();
                //    return false;
                //}
                //decimal weigth = 0;
                //if (!decimal.TryParse(this.txt_weight.Text.Trim(), out weigth))
                //{
                //    MsgUtils.ShowErrorMsg("重量仅限数字！");
                //    this.txt_weight.Focus();
                //    return false;
                //}
                ////重量单位
                //if (this.cmb_weightUnit.SelectedIndex < 0)
                //{
                //    MsgUtils.ShowErrorMsg("请选择重量单位！");
                //    this.cmb_weightUnit.Focus();
                //    return false;
                //}
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
                //库存报警克数
                if (StringUtils.IsBlank(this.txt_minStockNum.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入库存报警数！");
                    this.txt_minStockNum.Focus();
                    return false;
                }
                decimal minStockNum = 0;
                if (!decimal.TryParse(this.txt_minStockNum.Text.Trim(), out minStockNum))
                {
                    MsgUtils.ShowErrorMsg("库存报警数仅限数字！");
                    this.txt_minStockNum.Focus();
                    return false;
                }

                if (_isConfirm == true && this.dgv_specs.Visible == false)
                {
                    if (ConvertUtils.ConvertToDecimal(this.txt_price.Text) <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入合适的原料价格！");
                        this.dgv_specs.Focus();
                        return false;
                    }

                }
                
                if (_isConfirm == true && this.dgv_specs.Visible == true)
                {
                    if (this.dgv_specs.Rows.Count <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入原料规格！");
                        this.dgv_specs.Focus();
                        return false;
                    }

                    List<string> listSpecs = new List<string>();

                    for (int i = 0; i < this.dgv_specs.Rows.Count; i++)
                    {

                        string specs = ConvertUtils.ConvertToString(this.dgv_specs.Rows[i].Cells["name"].Value);
                        if (listSpecs.Contains(specs))
                        {
                            MsgUtils.ShowErrorMsg("原料规格已重复！");
                            this.dgv_specs.Focus();
                            return false;
                        }
                        else
                        {
                            listSpecs.Add(specs);
                        }

                        if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
                        {
                            decimal minPrice = ConvertUtils.ConvertToDecimal(this.dgv_specs.Rows[i].Cells["price"].Value);
                            if (minPrice <= 0)
                            {
                                MsgUtils.ShowErrorMsg("请输入合适的原料价格！");
                                this.dgv_specs.Focus();
                                return false;
                            }
                        }
                    }
                }
            }
            else
            {
                DataTable dt = m_bllMaterials.GetProductMaterialsById(m_materialsId);
                if(dt != null && dt.Rows.Count > 0)
                {
                    MsgUtils.ShowErrorMsg("该原料已被用作生产，无法删除！");
                    return false;
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

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

        private void FrmMaterialsDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void cmb_materialsType_SelectedIndexChanged(object sender, EventArgs e)
        {

            //其他原料
            if (this.cmb_materialsType.SelectedIndex == 2)
            {
                if (this.grb_specs.Visible == true)
                {
                    this.grb_price.Visible = true;
                    this.grb_specs.Visible = false;
                    this.grb_materials.Height = this.grb_materials.Height - this.grb_specs.Height;
                    this.btn_submit.Top = this.btn_submit.Top - this.grb_specs.Height;
                    this.btn_cancel.Top = this.btn_cancel.Top - this.grb_specs.Height;
                    this.Height = this.Height - this.grb_specs.Height;
                }
            }
            else
            {
                if (this.grb_specs.Visible == false)
                {
                    this.grb_price.Visible = false;
                    this.grb_specs.Visible = true;
                    this.grb_materials.Height = this.grb_materials.Height + this.grb_specs.Height;
                    this.btn_submit.Top = this.btn_submit.Top + this.grb_specs.Height;
                    this.btn_cancel.Top = this.btn_cancel.Top + this.grb_specs.Height;
                    this.Height = this.Height + this.grb_specs.Height;
                }
            }
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
            columnsName.ReadOnly = true;
            this.dgv_specs.Columns.Add(columnsName);

            DataGridViewTextBoxColumn columnsPriceId = new DataGridViewTextBoxColumn();
            columnsPriceId.Name = "priceId";
            columnsPriceId.HeaderText = "priceId";
            columnsPriceId.DataPropertyName = "priceId";
            columnsPriceId.Visible = false;
            this.dgv_specs.Columns.Add(columnsPriceId);

            DataGridViewTextBoxColumn columnsPrice = new DataGridViewTextBoxColumn();
            columnsPrice.Name = "price";
            columnsPrice.HeaderText = "采购售价";
            columnsPrice.DataPropertyName = "price";
            columnsPrice.Width = 100;
            if (WinCommon.IsPurchaser(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                columnsPrice.Visible = true;
            }
            else
            {
                columnsPrice.Visible = false;
            }
            this.dgv_specs.Columns.Add(columnsPrice);
            
            DataGridViewButtonColumn btnColumns = new DataGridViewButtonColumn();
            btnColumns.Name = "deleteBtn";
            btnColumns.HeaderText = "删除";
            btnColumns.DataPropertyName = "deleteBtn";
            btnColumns.Width = 100;
            if (WinCommon.IsPurchaser(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                btnColumns.Visible = true;
            }
            else
            {
                btnColumns.Visible = false;
            }
            this.dgv_specs.Columns.Add(btnColumns);

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

            decimal price = ConvertUtils.ConvertToInt(this.txt_price2.Text.Trim());
            if (price <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入合适的单价！");
                this.txt_price2.Focus();
                return;
            }

            string name = weight + "(KG)*" + num;
            for (int i = 0; i < this.dgv_specs.Rows.Count; i++)
            {
                if (name == ConvertUtils.ConvertToString(this.dgv_specs.Rows[i].Cells["name"].Value))
                {
                    MsgUtils.ShowErrorMsg("规格已重复！");
                    this.txt_weight.Focus();
                    return;
                }
            }

            ModelMaterialsSpecs newSpecs = new ModelMaterialsSpecs();
            newSpecs.materialsId = m_materialsId;
            newSpecs.name = name;
            //转为克
            newSpecs.weight = weight * 1000;
            newSpecs.num = num;
            newSpecs.isDelete = 0;
            newSpecs.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            newSpecs.createTime = DateTime.Now;

            int newSpecsId = m_bllMaterials.AddMaterialsSpecs(newSpecs);
            if (newSpecsId > 0)
            {
                ModelMaterialsPrice newPrice = new ModelMaterialsPrice();
                newPrice.materialsId = m_materialsId;
                newPrice.specsId = newSpecsId;
                newPrice.price = price;
                newPrice.isDelete = 0;
                newPrice.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                newPrice.createTime = DateTime.Now;
                int newPriceId = m_bllMaterials.AddMaterialsPrice(newPrice);

                DataTable dt = (DataTable)this.dgv_specs.DataSource;
                if (dt == null)
                {
                    dt = m_bllMaterials.GetMaterialsSpecsListByMaterialsId(m_materialsId);
                }
                else
                {
                    DataRow dr = dt.NewRow();
                    dr["specsId"] = newSpecsId;
                    dr["name"] = newSpecs.name;
                    dr["price"] = price;
                    dr["priceId"] = newPriceId;
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

                DataTable dt = m_bllMaterialsIn.GetMaterialsInByMaterialsIdSpecsId(m_materialsId, specsId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MsgUtils.ShowErrorMsg("此规格已有原料入库，不可删除！");
                    return;
                }

                if (MsgUtils.ShowQustMsg("确认删除此规格？", MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ModelMaterialsSpecs modelMaterialsSpecs = new ModelMaterialsSpecs();
                    modelMaterialsSpecs.id = specsId;
                    modelMaterialsSpecs.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    modelMaterialsSpecs.modifyTime = DateTime.Now;

                    if (m_bllMaterials.DeleteMaterialsSpecs(modelMaterialsSpecs))
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

        private void txt_price2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);

        }

        private void txt_price_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);

        }
    }
}
