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

namespace PMS.Frm.Product
{
    public partial class FrmMaterialsManage : Form
    {
        private BllMaterials m_bllMaterials = new BllMaterials();

        public FrmMaterialsManage()
        {
            InitializeComponent();
        }

        private void FrmMaterialsManage_Load(object sender, EventArgs e)
        {

            this.txt_name.Focus();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string name = this.txt_name.Text.Trim();

            DataTable dt = m_bllMaterials.GetMaterials(name);

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmMaterialsDetail(0, 0);
            WinCommon.ShowInMain(ref form);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modify")
            {
                int userId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Form form = new FrmMaterialsDetail(1, userId);
                WinCommon.ShowInMain(ref form);
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                int userId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Form form = new FrmMaterialsDetail(2, userId);
                WinCommon.ShowInMain(ref form);
            }

        }

 
    }
}
