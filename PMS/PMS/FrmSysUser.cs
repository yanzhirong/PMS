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

namespace PMS
{
    public partial class FrmSysUser : Form
    {
        private BllUser bllUser = new BllUser();
        public static Form MAINFORM;

        public FrmSysUser()
        {
            InitializeComponent();
        }

        private void FrmSysUser_Load(object sender, EventArgs e)
        {
            //获取所有角色
            List<ModelItem> listRole = bllUser.GetAllRoles();

            //绑定下拉框
            WinCommon.BindComboBox(ref cmb_role, listRole);

            this.txt_name.Focus();

            MAINFORM = this;
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string name = this.txt_name.Text.Trim();
            int roleId = 0;
            if (this.cmb_role.SelectedIndex > 0)
            {
                roleId = (int)this.cmb_role.SelectedValue;
            }
            DataTable users = bllUser.GetUsers(name, roleId);

            this.dataGridView1.DataSource = users;
            this.dataGridView1.Refresh();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmSysUserDetail();
            WinCommon.ShowInMain(ref form);
        }

 
    }
}
