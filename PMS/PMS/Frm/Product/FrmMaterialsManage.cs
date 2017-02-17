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
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

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
            int type = -1;
            if (this.cmb_materialsType.SelectedIndex > 0)
            {
                type = this.cmb_materialsType.SelectedIndex - 1;
            }
            DataTable dt = m_bllMaterials.GetMaterials(name, type);

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {

            Form form = new FrmMaterialsDetail(0, 0);
            this.Hide();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modifyBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmMaterialsDetail(1, id);
                form.ShowDialog();
                doSelect();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmMaterialsDetail(2, id);
                form.ShowDialog();
                doSelect();
            }

        }

        private void FrmMaterialsManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

 
    }
}
