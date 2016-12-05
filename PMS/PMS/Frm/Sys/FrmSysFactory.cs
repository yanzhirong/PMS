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
    public partial class FrmSysFactory : Form
    {
        private BllFactory m_bllFactory = new BllFactory();

        public FrmSysFactory()
        {
            InitializeComponent();
        }

        private void FrmSysFactory_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            this.dataGridView1.DataSource = null;
            this.dataGridView1.Refresh();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            DataTable dt = m_bllFactory.GetFactory(this.txt_name.Text.Trim());
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();          
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmSysFactoryDetail(0, 0);
            this.Hide();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modify")
            {
                int factoryId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmSysFactoryDetail(1, factoryId);
                WinCommon.ShowInMain(ref form);
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                int factoryId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmSysFactoryDetail(2, factoryId);
                this.Hide();
                form.ShowDialog();
            }
        } 
    }
}
