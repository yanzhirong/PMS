using Bll;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Tools;

namespace PMS.Frm.Sys
{
    public partial class FrmSysRoleDetail : Form
    {
        //处理模式（0：新建；1：修改；2：删除）
        private int m_mode;
        //角色ID
        private int m_roleId;

        private BllRole m_bllRole = new BllRole();
        private BllCode m_bllCode = new BllCode();

        public FrmSysRoleDetail(int _mode , int _roleId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_roleId = _roleId;
        }

        private void FrmSysUser_Load(object sender, EventArgs e)
        {

            //角色类型
            List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.RoleType, false);
            WinCommon.BindComboBox(ref this.cmb_type, listItem);

            if (m_mode == 0)
            {
                this.txt_name.Focus();

                this.grb_role.Enabled = true;
                this.btn_submit.Enabled = true;
            }
            else
            {
                ModelRole modelRole = m_bllRole.GetRoleById(m_roleId);

                for (int i = 0; i < this.cmb_type.Items.Count; i++)
                {
                    if(modelRole.roleType == (int)((ModelItem)this.cmb_type.Items[i]).itemKey)
                    {
                        this.cmb_type.SelectedIndex = i;
                        break;
                    }
                }

                this.txt_name.Text = modelRole.roleName;

                setMenuCheckBox();

                if (m_mode == 2)
                {
                    this.txt_name.Enabled = false;
                    this.cmb_type.Enabled = false;
                    this.grb_role.Enabled = false;
                }
            }
        }

        private void setMenuCheckBox()
        {
            if (m_roleId > 0)
            {
                // 获取角色的权限
                List<ModelMenu> listMenu = m_bllRole.GetMenuByRoleId(m_roleId);

                foreach (ModelMenu menu in listMenu)
                {
                    if(StringUtils.IsBlank(menu.checkBoxName))
                    {
                        continue;
                    }

                    Control[] control = this.Controls.Find(menu.checkBoxName, true);
                    if (control.Length > 0)
                    {
                        CheckBox checkBox = (CheckBox)control[0];
                        checkBox.Text = menu.menuName;
                        checkBox.Checked = menu.isChecked > 0 ? true : false;
                    }
                }
            }
        }

        #region CheckBox处理
        private void chk_sys_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_sys.Enabled = this.chk_sys.Checked;
            if (this.chk_sys.Checked == false)
            {
                this.chk_sys_user.Checked = false;
                this.chk_sys_role.Checked = false;
                this.chk_sys_company.Checked = false;
                this.chk_sys_factory.Checked = false;
                this.chk_sys_config.Checked = false;
            }
            else
            {
                this.chk_sys_user.Checked = true;
                this.chk_sys_role.Checked = true;
                this.chk_sys_company.Checked = true;
                this.chk_sys_factory.Checked = true;
                this.chk_sys_config.Checked = true;
            }
        }

        private void chk_product_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_product.Enabled = this.chk_product.Checked;
            if (this.chk_product.Checked == false)
            {
                this.chk_product_query.Checked = false;
                this.chk_product_set.Checked = false;
                this.chk_materials_set.Checked = false;
            }
            else
            {
                this.chk_product_query.Checked = true;
                this.chk_product_set.Checked = true;
                this.chk_materials_set.Checked = true;
            }
        }

        private void chk_sale_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_sale.Enabled = this.chk_sale.Checked;
            if (this.chk_sale.Checked == false)
            {
                this.chk_sale_customer.Checked = false;
                this.chk_sale_order.Checked = false;
            }
            else
            {
                this.chk_sale_customer.Checked = true;
                this.chk_sale_order.Checked = true;
            }
        }

        private void chk_factory_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_factory.Enabled = this.chk_store.Checked;
            if (this.chk_store.Checked == false)
            {
                this.chk_store_product_in.Checked = false;
                this.chk_store_product_out.Checked = false;
                this.chk_store_materials_in.Checked = false;
                this.chk_store_materials_out.Checked = false;
                this.chk_store_transfer.Checked = false;
                this.chk_store_nventory.Checked = false;
            }
            else
            {
                this.chk_store_product_in.Checked = true;
                this.chk_store_product_out.Checked = true;
                this.chk_store_materials_in.Checked = true;
                this.chk_store_materials_out.Checked = true;
                this.chk_store_transfer.Checked = true;
                this.chk_store_nventory.Checked = true;
            }
        }

        private void chk_produce_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_produce.Enabled = this.chk_produce.Checked;
            if (this.chk_produce.Checked == false)
            {
                this.chk_produce_plan.Checked = false;
                this.chk_produce_manage.Checked = false;
            }
            else
            {
                this.chk_produce_plan.Checked = true;
                this.chk_produce_manage.Checked = true;
            }
        }

        private void chk_purchase_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_purchase.Enabled = this.chk_purchase.Checked;
            if (this.chk_purchase.Checked == false)
            {
                this.chk_purchase_provider.Checked = false;
                this.chk_purchase_plan.Checked = false;
                this.chk_purchase_manage.Checked = false;
            }
            else
            {
                this.chk_purchase_provider.Checked = true;
                this.chk_purchase_plan.Checked = true;
                this.chk_purchase_manage.Checked = true;
            }
        }

        private void chk_finance_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_finance.Enabled = this.chk_finance.Checked;
            if (this.chk_finance.Checked == false)
            {
                this.chk_finance_sale.Checked = false;
                this.chk_finance_purchase.Checked = false;
                this.chk_finance_receive.Checked = false;
                this.chk_finance_paid.Checked = false;
            }
            else
            {
                this.chk_finance_sale.Checked = true;
                this.chk_finance_purchase.Checked = true;
                this.chk_finance_receive.Checked = true;
                this.chk_finance_paid.Checked = true;
            }
        }
        #endregion

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(StringUtils.IsBlank(this.txt_name.Text))
            {
                MsgUtils.ShowErrorMsg("请输入角色名！");
                this.txt_name.Focus();
                return;
            }

            if (m_mode == 0)
            {
                ModelRole modelRole = m_bllRole.GetRoleByName(this.txt_name.Text.Trim());
                if (modelRole.roleId > 0)
                {
                    MsgUtils.ShowErrorMsg("角色已经存在，请换一个名字！");
                    this.txt_name.Focus();
                    return;
                }
            }

            string msg = "";
            if (m_mode == 0)
            {
                msg = "是否确认新增角色？";
            }
            else if (m_mode == 1)
            {
                msg = "是否确认更新角色？";
            }
            else
            {
                msg = "是否确认删除角色？";
            }

            if (MsgUtils.ShowQustMsg(msg, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                doSubmit();
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回
            this.Hide();
        }

        private void doSubmit()
        {
            ModelRole modelRole = new ModelRole();
            modelRole.roleId = m_roleId;
            modelRole.roleName = this.txt_name.Text.Trim();
            if (this.cmb_type.SelectedIndex >= 0)
            {
                modelRole.roleType = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_type.SelectedItem).itemKey);
            }
            else
            {
                modelRole.roleType = 0;
            }
            modelRole.isDelete = 0;
            modelRole.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelRole.createTime = DateTime.Now;
            modelRole.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelRole.modifyTime = DateTime.Now;

            if (m_mode == 2)
            {
                if (m_bllRole.DeleteRole(modelRole))
                {
                    MsgUtils.ShowInfoMsg("删除角色成功！");
                    this.Hide();
                    return;
                }
                else
                {
                    MsgUtils.ShowErrorMsg("删除角色失败！");
                }
                return;
            }

            List<ModelMenu> listMenu = new List<ModelMenu>();
            GetCheckedMenu(this, ref listMenu);

            if (m_mode == 0)
            {
                //更新角色的权限
                if (m_bllRole.AddRole(modelRole, listMenu))
                {
                    MsgUtils.ShowInfoMsg("新增角色成功！");
                    this.Hide();
                    return;
                }
                else
                {
                    MsgUtils.ShowErrorMsg("新增角色失败！");
                }
            }
            else
            {
                //更新角色的权限
                if (m_bllRole.UpdateRole(modelRole, listMenu))
                {
                    if (LoginUserInfo.LoginUser.loginRole.roleId == m_roleId)
                    {
                        MsgUtils.ShowInfoMsg("角色已修改，请重新登录。");
                        this.Hide();
                        return;
                    }
                    MsgUtils.ShowInfoMsg("更新角色成功！");
                    this.Hide();
                    return;
                }
                else
                {
                    MsgUtils.ShowErrorMsg("更新角色失败！");
                }
            }

            return;
        }

        private void GetCheckedMenu(Control container, ref List<ModelMenu> listMenu)
        {
            if (container.Controls.Count > 0)
            {
                foreach (Control control in container.Controls)
                {
                    GetCheckedMenu(control, ref listMenu);
                }
            }
            else
            {
                if (container is CheckBox)
                {
                    CheckBox chk = (CheckBox)container;
                    if (chk.Checked)
                    {
                        ModelMenu menu = new ModelMenu();
                        menu.menuId = m_bllRole.GetMenuIdByCheckBoxName(chk.Name);
                        menu.isDelete = 0;
                        menu.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                        menu.createTime = DateTime.Now;
                        menu.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                        menu.modifyTime = DateTime.Now;
                        listMenu.Add(menu);
                    }
                }
            }
        }

        private void FrmSysRoleDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
