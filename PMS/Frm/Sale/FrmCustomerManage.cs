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

namespace PMS.Frm.Sale
{
    public partial class FrmCustomerManage : Main.BaseForm
    {
        //销售ID
        private int m_salerId;

        private BllCustomer m_bllCustomer = new BllCustomer();

        public FrmCustomerManage()
        {
            InitializeComponent();
        }

        private void FrmCustomerManage_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.menuFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            if (LoginUserInfo.LoginUser.loginRole.roleType == (int)Enum.EnumRoleType.Saler)
            {
                m_salerId = LoginUserInfo.LoginUser.loginUser.userId;
                this.cmb_type.SelectedIndex = 1;
                this.cmb_type.Enabled = false;
            }
            else
            {
                m_salerId = 0;
            }

            if (LoginUserInfo.LoginUser.loginRole.roleType == (int)Enum.EnumRoleType.Purchase)
            {
                this.cmb_type.SelectedIndex = 2;
                this.cmb_type.Enabled = false;
            }

            this.txt_code.Focus();

            doSelect();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void doSelect()
        {
            string code = this.txt_code.Text.Trim();
            string name = this.txt_name.Text.Trim();
            int type = this.cmb_type.SelectedIndex;

            DataTable dt = m_bllCustomer.GetCustomers(code, name, type, m_salerId);

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }
        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmCustomerDetail(0, 0);
            form.ShowDialog();
            doSelect();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modifyBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmCustomerDetail(1, id);
                form.ShowDialog();
                doSelect();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmCustomerDetail(2, id);
                form.ShowDialog();
                doSelect();

            }

        }

        private void FrmCustomerManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

 
    }
}
