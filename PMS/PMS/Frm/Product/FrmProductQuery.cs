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
    public partial class FrmProductQuery : Form
    {
        private BllProduct m_bllProduct = new BllProduct();

        public FrmProductQuery()
        {
            InitializeComponent();
        }

        private void FrmProductQuery_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);
            doSelect();

            this.txt_name.Focus();

        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void doSelect()
        {
            string name = this.txt_name.Text.Trim();

            DataTable dt = m_bllProduct.GetProductsQuery(name);

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmProductQuery_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //查询产品信息
            if (dataGridView1.Columns[e.ColumnIndex].Name == "name")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmProductDetail(3, id);
                form.ShowDialog();
                doSelect();
            }

            //查询库存
            if (dataGridView1.Columns[e.ColumnIndex].Name == "queryStore")
            {
                string productName = (string)dataGridView1.Rows[e.RowIndex].Cells["name"].Value;
                Form form = new Store.FrmProductQueryStore(productName, 0);
                form.ShowDialog();
                doSelect();
            }
        }
    }
}
