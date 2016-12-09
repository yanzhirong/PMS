using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;

namespace PMS.Frm.Product
{
    public partial class FrmProductManage : Form
    {
        private BllProduct m_bllProduct = new BllProduct();
        
        public FrmProductManage()
        {
            InitializeComponent();
        }

        private void FrmProductManage_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string name = this.txt_name.Text.Trim();

            DataTable dt = m_bllProduct.GetProducts(name);

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmProductDetail(0, 0);
            this.Hide();
            form.ShowDialog();
        }

        private void FrmProductManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modifyBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmProductDetail(1, id);
                this.Hide();
                form.ShowDialog();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmProductDetail(2, id);
                this.Hide();
                form.ShowDialog();
            }
        }
    }
}
