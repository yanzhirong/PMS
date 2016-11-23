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
            WinCommon.ShowInMain(ref form);
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
                this.lbl_title.Text = "原料管理-新增";
            }
            else if (m_mode == 1)
            {
                this.lbl_title.Text =  "原料管理-修改";
            }
            else
            {
                this.lbl_title.Text = "原料管理-删除";
            }

            //下拉框
            //包装类型
            List<ModelItem> listItem = m_bllCode.GetCodeItem(1);
            WinCommon.BindComboBox(ref cmb_packingType, listItem);
            //产品形态
            listItem = m_bllCode.GetCodeItem(2);
            WinCommon.BindComboBox(ref cmb_morphology, listItem);
            //重量单位
            listItem = m_bllCode.GetCodeItem(3);
            WinCommon.BindComboBox(ref cmb_weightUnit, listItem);


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
        private void doSubmit()
        {
            Boolean rtn = false;

            //检查
            if (doCheck() == false)
            {
                return ;
            }

            ModelUser modelUser = new ModelUser();
            modelUser.userId = m_userId;
            modelUser.userName = this.txt_name.Text;
            modelUser.pwd = this.txt_searchKey.Text;
            modelUser.roleId = (int)((ModelItem)this.cmb_packingType.SelectedItem).itemKey;
            modelUser.sex = ((ModelItem)this.cmb_morphology.SelectedItem).itemValue;
            modelUser.position = this.txt_weight.Text;
            modelUser.mobile = this.txt_shelfLife.Text;
            modelUser.email = this.txt_email.Text;
            modelUser.birthday = this.dtp_birthday.Value;
            modelUser.isDelete = 0;
            modelUser.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelUser.createTime = DateTime.Now;
            modelUser.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelUser.modifyTime = DateTime.Now;

            //新增用户
            if (m_mode == 0) 
            {
                rtn = m_bllUser.AddUser(modelUser);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("新增用户失败！");
                    return ;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("新增用户成功！");
                }

                //处理模式变为修改
                m_mode = 1;
                m_userId = m_bllUser.GetUserByName(this.txt_name.Text).userId;

                init();

                return;
            }

            //修改用户
            if (m_mode == 1)
            {
                rtn = m_bllUser.UpdateUser(modelUser, m_orgRoleId);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("修改用户失败！");
                    return;
                }

                if(LoginUserInfo.LoginUser.loginUser.userId == m_userId)
                {
                    MsgUtils.ShowInfoMsg("账号已修改，请重新登录。");
                    this.Parent.Parent.Hide();
                    Form frmLogin = new Frm.Login.FrmLogin();
                    frmLogin.Show();
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("修改用户成功！");
                    init();
                    return;
                }
            }

            //删除用户
            if(m_mode == 2)
            {
                rtn = m_bllUser.DeleteUser(modelUser);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("删除用户失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("删除用户成功！");

                    //返回用户列表
                    Form form = new FrmMaterialsManage();
                    WinCommon.ShowInMain(ref form);
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
            }
            return true;
        }
        #endregion

        private void txt_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsNumber(e.KeyChar);
        }

    }
}
