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
    public partial class FrmSysFactory : Main.BaseForm
    {
        private BllFactory m_bllFactory = new BllFactory();

        public FrmSysFactory()
        {
            InitializeComponent();
        }

        private void FrmSysFactory_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.menuFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            doSelect();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void doSelect()
        {
            DataTable dt = m_bllFactory.GetFactory(this.txt_name.Text.Trim());
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmSysFactoryDetail(0, 0);
            form.ShowDialog();
            doSelect();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modify")
            {
                int factoryId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmSysFactoryDetail(1, factoryId);
                form.ShowDialog();
                doSelect();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                int factoryId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmSysFactoryDetail(2, factoryId);
                form.ShowDialog();
                doSelect();
            }
        }

        private void FrmSysFactory_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        } 
    }
}
