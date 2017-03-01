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

namespace PMS.Frm.Sys
{
    public partial class FrmSysUser : Main.BaseForm
    {
        private BllUser m_bllUser = new BllUser();
        private BllRole m_bllRole = new BllRole();

        public FrmSysUser()
        {
            InitializeComponent();
        }

        private void FrmSysUser_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //获取所有角色
            List<ModelItem> listRole = m_bllRole.GetAllRoles();

            //绑定下拉框
            WinCommon.BindComboBox(ref cmb_role, listRole);

            this.txt_name.Focus();
            doSelect();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void doSelect()
        {
            string name = this.txt_name.Text.Trim();
            int roleId = 0;
            if (this.cmb_role.SelectedIndex >= 0)
            {
                roleId = (int)((ModelItem)this.cmb_role.SelectedItem).itemKey;
            }
            DataTable users = m_bllUser.GetUsers(name, roleId);

            this.dataGridView1.DataSource = users;
            this.dataGridView1.Refresh();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmSysUserDetail(0, 0);
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modify")
            {
                int userId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Form form = new FrmSysUserDetail(1, userId);
                form.ShowDialog();
                doSelect();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                int userId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Form form = new FrmSysUserDetail(2, userId);
                form.ShowDialog();
                doSelect();
            }

        }

        private void FrmSysUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

 
    }
}
