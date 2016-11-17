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
        private BllUser m_bllUser = new BllUser();

        public FrmSysUser()
        {
            InitializeComponent();
        }

        private void FrmSysUser_Load(object sender, EventArgs e)
        {
            //获取所有角色
            List<ModelItem> listRole = m_bllUser.GetAllRoles();

            //绑定下拉框
            WinCommon.BindComboBox(ref cmb_role, listRole);

            this.txt_name.Focus();
        }

        private void btn_query_Click(object sender, EventArgs e)
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
            WinCommon.ShowInMain(ref form);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modify")
            {
                int userId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Form form = new FrmSysUserDetail(1, userId);
                WinCommon.ShowInMain(ref form);
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                int userId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Form form = new FrmSysUserDetail(2, userId);
                WinCommon.ShowInMain(ref form);
            }

        }

 
    }
}
