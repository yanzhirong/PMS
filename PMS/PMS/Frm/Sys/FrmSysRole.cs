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
    public partial class FrmSysRole : Form
    {
        private BllRole m_bllRole = new BllRole();

        public FrmSysRole()
        {
            InitializeComponent();
        }

        private void FrmSysUser_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            this.txt_name.Focus();

            doSelect();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {

        }

        private void doSelect()
        {
            string name = this.txt_name.Text.Trim();

            DataTable dt = m_bllRole.GetRoles(name);

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmSysRoleDetail(0, 0);
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modify")
            {
                int roleId = (int)dataGridView1.Rows[e.RowIndex].Cells["roleId"].Value;
                Form form = new FrmSysRoleDetail(1, roleId);
                form.ShowDialog();
                doSelect();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                int roleId = (int)dataGridView1.Rows[e.RowIndex].Cells["roleID"].Value;
                Form form = new FrmSysRoleDetail(2, roleId);
                form.ShowDialog();
                doSelect();
            }

        }

        private void FrmSysRole_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

 
    }
}
