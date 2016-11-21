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

namespace PMS
{
    public partial class FrmSysRoleDetail : Form
    {
        private BllRole m_bllRole = new BllRole();

        public FrmSysRoleDetail()
        {
            InitializeComponent();
        }

        private void FrmSysUser_Load(object sender, EventArgs e)
        {
            //获取所有角色
            List<ModelItem> listRole = m_bllRole.GetAllRoles();

            //绑定下拉框
            WinCommon.BindComboBox(ref cmb_role, listRole);

            this.cmb_role.Focus();

            this.grb_role.Enabled = false;
            this.btn_submit.Enabled = false;
        }

        private void cmb_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roleId = 0;
            roleId = (int)((ModelItem)this.cmb_role.SelectedItem).itemKey;

            if (roleId > 0)
            {
                // 获取角色的权限
                List<ModelMenu> listMenu = m_bllRole.GetMenuByRoleId(roleId);

                foreach (ModelMenu menu in listMenu)
                {
                    Control[] control = this.Controls.Find(menu.checkBoxName, true);
                    if (control.Length > 0)
                    {
                        CheckBox checkBox = (CheckBox)control[0];
                        checkBox.Text = menu.menuName;
                        checkBox.Checked = menu.isChecked > 0 ? true : false;
                    }
                }

                this.grb_role.Enabled = true;
                this.btn_submit.Enabled = true;
            }
            else
            {
                this.grb_role.Enabled = false;
                this.btn_submit.Enabled = false;
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
            this.grb_factory.Enabled = this.chk_factory.Checked;
            if (this.chk_factory.Checked == false)
            {
                this.chk_factory_product_in.Checked = false;
                this.chk_factory_product_out.Checked = false;
                this.chk_factory_product_transfer.Checked = false;
                this.chk_factory_materials_in.Checked = false;
                this.chk_factory_materials_out.Checked = false;
            }
            else
            {
                this.chk_factory_product_in.Checked = true;
                this.chk_factory_product_out.Checked = true;
                this.chk_factory_product_transfer.Checked = true;
                this.chk_factory_materials_in.Checked = true;
                this.chk_factory_materials_out.Checked = true;
            }
        }

        private void chk_produce_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_produce.Enabled = this.chk_produce.Checked;
            if (this.chk_produce.Checked == false)
            {
                this.chk_produce_plan.Checked = false;
            }
            else
            {
                this.chk_produce_plan.Checked = true;
            }
        }

        private void chk_purchase_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_purchase.Enabled = this.chk_purchase.Checked;
            if (this.chk_purchase.Checked == false)
            {
                this.chk_purchase_provider.Checked = false;
                this.chk_purchase_plan.Checked = false;
                this.chk_purchase_order.Checked = false;
            }
            else
            {
                this.chk_purchase_provider.Checked = true;
                this.chk_purchase_plan.Checked = true;
                this.chk_purchase_order.Checked = true;
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
            int roleId = (int)((ModelItem)this.cmb_role.SelectedItem).itemKey;

            if(roleId <= 0)
            {
                MsgUtils.ShowErrorMsg("请选择角色！");
                cmb_role.Focus();
                return;
            }

            if (MsgUtils.ShowQustMsg("是否确认修改角色的权限？", MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                doSubmit(roleId);
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回
            WinCommon.ReturnMain();
        }

        private void doSubmit(int _roleId)
        {
            List<ModelMenu> listMenu = new List<ModelMenu>();
            GetCheckedMenu(this, ref listMenu);

            //更新角色的权限
            if (m_bllRole.UpdateMenuByRoleId(_roleId, listMenu, LoginUserInfo.LoginUser.loginUser.userId))
            {
                MsgUtils.ShowInfoMsg("更新角色权限成功！");
            }
            else
            {
                MsgUtils.ShowErrorMsg("更新角色权限失败！");
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
    }
}
