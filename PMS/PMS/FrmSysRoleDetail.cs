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
                        checkBox.Checked = menu.isChecked > 0 ? true : false;
                    }
                }
                this.btn_submit.Enabled = true;
            }
            else
            {
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
            }
        }

        private void chk_product_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_produce.Enabled = this.chk_produce.Checked;
            if (this.chk_produce.Checked == false)
            {
                this.chk_product_query.Checked = false;
                this.chk_product_set.Checked = false;
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
        }

        private void chk_produce_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_produce.Enabled = this.chk_produce.Checked;
            if (this.chk_produce.Checked == false)
            {
                this.chk_produce_plan.Checked = false;
            }
        }

        private void chk_purchase_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_purchase.Enabled = this.chk_purchase.Checked;
            if (this.chk_purchase.Checked == false)
            {
                this.chk_purchase_materials.Checked = false;
                this.chk_purchase_provider.Checked = false;
                this.chk_purchase_plan.Checked = false;
                this.chk_purchase_order.Checked = false;
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
        }
        #endregion

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (MsgUtils.ShowQustMsg("是否确认修改角色的权限？", MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                doSubmit();
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回用户列表
            Form frmSysUser = new FrmSysUser();
            WinCommon.ShowInMain(ref frmSysUser);
        }

        private void doSubmit()
        {
            List<ModelMenu> listMenu = new List<ModelMenu>();
            foreach (Control control in this.Controls)
            {
                if(control is CheckBox)
                {
                    CheckBox chk = (CheckBox) control;
                    if(chk.Checked)
                    {
                        ModelMenu menu = new ModelMenu();
                        menu.menuId = m_bllRole.GetMenuIdByCheckBoxName(rchk.Name);
                        listMenu.Add(menu);
                    }
                }
            }
            if (m_bllRole.)
            {
            }
        }

    }
}
