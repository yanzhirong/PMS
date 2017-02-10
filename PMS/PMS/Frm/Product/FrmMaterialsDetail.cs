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
    public partial class FrmMaterialsDetail : Form
    {
        //处理模式（0：新建；1：修改；2：删除）
        private int m_mode;
        //原来ID
        private int m_materialsId;

        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllCode m_bllCode = new BllCode();

        public FrmMaterialsDetail(int _mode, int _materialsId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_materialsId = _materialsId;
        }

        private void FrmMaterialsDetail_Load(object sender, EventArgs e)
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
            Form form = new FrmMaterialsManage();
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
                this.lbl_title.Text = "物料信息设定-新增";
            }
            else if (m_mode == 1)
            {
                this.lbl_title.Text = "物料信息设定-修改";
            }
            else
            {
                this.lbl_title.Text = "物料信息设定-删除";
            }

            //下拉框
            //包装类型
            List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.PackagingType, false);
            WinCommon.BindComboBox(ref cmb_packingType, listItem);
            //产品形态
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.ProductForm, false);
            WinCommon.BindComboBox(ref cmb_morphology, listItem);
            //重量单位
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.WeightUnit, false);
            WinCommon.BindComboBox(ref cmb_weightUnit, listItem);
            //价格单位
            WinCommon.BindComboBox(ref cmb_priceUnit, listItem);

            //初始化(修改或者删除时)
            if (m_mode != 0 && m_materialsId > 0)
            {
                ModelMaterials modelMaterials = m_bllMaterials.GetMaterialsById(m_materialsId);

                //物料名
                this.txt_name.Text = modelMaterials.name;
                //物料略名
                this.txt_subName.Text = modelMaterials.subName;
                //检索键
                this.txt_searchKey.Text = modelMaterials.modelMaterialsSearch.searchKey;

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
                //产品形态
                for (int i = 0; i < this.cmb_morphology.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_morphology.Items[i];
                    if (modelMaterials.morphology == (int)modelItem.itemKey)
                    {
                        this.cmb_morphology.SelectedIndex = i;
                        break;
                    }
                }

                //物料类型
                this.cmb_materialsType.SelectedIndex = modelMaterials.type;

                //重量单位
                for (int i = 0; i < this.cmb_weightUnit.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_weightUnit.Items[i];
                    if (modelMaterials.weightUnit == (int)modelItem.itemKey)
                    {
                        this.cmb_weightUnit.SelectedIndex = i;
                        break;
                    }
                }

                //包装说明
                this.txt_packingRemark.Text = modelMaterials.packingRemark;
                //重量
                this.txt_weight.Text = modelMaterials.weight.ToString();
                //保质期
                this.txt_shelfLife.Text = modelMaterials.shelfLife.ToString();
                //过期提醒天数
                this.txt_expiredDays.Text = modelMaterials.expiredDays.ToString();
                //库存报警数
                this.txt_minStockNum.Text = modelMaterials.minStockNum.ToString();
                //价格
                this.txt_price.Text = modelMaterials.modelMaterialsPrice.price.ToString();
                //价格单位
                for (int i = 0; i < this.cmb_priceUnit.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_priceUnit.Items[i];
                    if (modelMaterials.modelMaterialsPrice.priceUnit == (int)modelItem.itemKey)
                    {
                        this.cmb_priceUnit.SelectedIndex = i;
                        break;
                    }
                }
            }

            //删除时，输入项不能修改
            if (m_mode == 2)
            {
                grb_materials.Enabled = false;
                grb_price.Enabled = false;
            }
            else
            {
                grb_materials.Enabled = true;
                grb_price.Enabled = true;
            }

            //价格相关
            this.grb_price.Visible = WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType); 
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

            ModelMaterials modelMaterials = new ModelMaterials();
            modelMaterials.id = m_materialsId;
            modelMaterials.name = this.txt_name.Text.Trim();
            modelMaterials.subName = this.txt_subName.Text.Trim();

            ModelMaterialsSearch modelMaterialsSearch = new ModelMaterialsSearch();
            modelMaterialsSearch.materialsId = modelMaterials.id;
            modelMaterialsSearch.materialsName = modelMaterials.name;
            modelMaterialsSearch.searchKey = this.txt_searchKey.Text.Trim();
            modelMaterials.modelMaterialsSearch = modelMaterialsSearch;

            modelMaterials.packingType = (int)((ModelItem)this.cmb_packingType.SelectedItem).itemKey;
            modelMaterials.packingRemark = this.txt_packingRemark.Text.Trim();
            modelMaterials.morphology = (int)((ModelItem)this.cmb_morphology.SelectedItem).itemKey;
            //modelMaterials.weight = ConvertUtils.ConvertToDecimal(this.txt_weight.Text);
            //modelMaterials.weightUnit = (int)((ModelItem)this.cmb_weightUnit.SelectedItem).itemKey;
            modelMaterials.shelfLife = ConvertUtils.ConvertToInt(this.txt_shelfLife.Text);
            modelMaterials.expiredDays = ConvertUtils.ConvertToInt(this.txt_expiredDays.Text);
            modelMaterials.minStockNum = ConvertUtils.ConvertToInt(this.txt_minStockNum.Text);
            modelMaterials.type = this.cmb_materialsType.SelectedIndex;

            if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                ModelMaterialsPrice modelMaterialsPrice = new ModelMaterialsPrice();
                modelMaterialsPrice.materialsId = m_materialsId;
                modelMaterialsPrice.price = ConvertUtils.ConvertToDecimal(this.txt_price.Text);
                if (this.cmb_priceUnit.SelectedIndex >= 0)
                {
                    modelMaterialsPrice.priceUnit = (int)((ModelItem)this.cmb_priceUnit.SelectedItem).itemKey;
                }
                modelMaterials.modelMaterialsPrice = modelMaterialsPrice;
            }
            else
            {
                modelMaterials.modelMaterialsPrice = null;
            }
            modelMaterials.isDelete = 0;
            modelMaterials.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelMaterials.createTime = DateTime.Now;
            modelMaterials.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelMaterials.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllMaterials.AddMaterials(modelMaterials);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("新增物料失败！");
                    return ;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("新增物料成功！");
                }

                //处理模式变为修改
                m_mode = 1;
                m_materialsId = m_bllMaterials.GetMaterialsByName(this.txt_name.Text).id;

                init();

                return;
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllMaterials.UpdateMaterials(modelMaterials);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("修改物料失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("修改物料成功！");
                    init();
                    return;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllMaterials.DeleteMaterials(modelMaterials);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("删除物料失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("删除物料成功！");

                    //返回用户列表
                    Form form = new FrmMaterialsManage();
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
                    MsgUtils.ShowErrorMsg("请输入物料名！");
                    this.txt_name.Focus();
                    return false;
                }
                ModelMaterials materials = m_bllMaterials.GetMaterialsByName(this.txt_name.Text);
                if (materials.id > 0 && materials.id != m_materialsId)
                {
                    MsgUtils.ShowErrorMsg("该物料已存在！");
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
                //物料类型
                if (this.cmb_materialsType.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择物料类型！");
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

                if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
                {
                    if (StringUtils.IsBlank(this.txt_price.Text))
                    {
                        MsgUtils.ShowErrorMsg("请输入最低价格！");
                        this.txt_price.Focus();
                        return false;
                    }
                    int price = 0;
                    if (!int.TryParse(this.txt_price.Text.Trim(), out price))
                    {
                        MsgUtils.ShowErrorMsg("最低价格仅限数字！");
                        this.txt_price.Focus();
                        return false;
                    }

                    //其它物料可不选单位
                    if (this.cmb_materialsType.SelectedIndex != 2 && this.cmb_priceUnit.SelectedIndex < 0)
                    {
                        MsgUtils.ShowErrorMsg("请选择重量价格单位！");
                        this.cmb_weightUnit.Focus();
                        return false;
                    }
                }
            }
            else
            {
                DataTable dt = m_bllMaterials.GetProductMaterialsById(m_materialsId);
                if(dt != null && dt.Rows.Count > 0)
                {
                    MsgUtils.ShowErrorMsg("该物料已被用作生产，无法删除！");
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
            e.Handled = WinCommon.IsOnlyInt(e.KeyChar);
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

        private void FrmMaterialsDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void cmb_materialsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_materialsType.SelectedIndex == 2)
            {
                this.cmb_priceUnit.Visible = false;
            }
            else
            {
                this.cmb_priceUnit.Visible = true;
            }
        }
    }
}
