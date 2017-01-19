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
using Common;

namespace PMS.Frm.Store
{
    public partial class FrmProductOut : Form
    {

        private BllCode m_bllCode = new BllCode();
        private BllProductOut m_bllProductOut = new BllProductOut();

        public FrmProductOut()
        {
            InitializeComponent();
        }

        private void FrmProductOut_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            List<ModelItem> listItem = m_bllCode.GetCodeItem(7, true);
            WinCommon.BindComboBox(ref this.cmb_orderStatus, listItem);

            ModelItem item = new ModelItem();
            item.itemKey = 0;
            item.itemValue = "";
            this.cmb_factory.Items.Add(item);
            foreach (ModelItem modelItem in listItem)
            {
                this.cmb_factory.Items.Add(modelItem);
            }
            this.cmb_factory.DisplayMember = "itemValue";
            this.cmb_factory.ValueMember = "itemKey";
            
            this.dtp_begin.Value = DateTime.Now.AddMonths(-1);
            this.dtp_end.Value = DateTime.Now;

            this.txt_productName.Focus();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string productName = this.txt_productName.Text.Trim();
            string customerName = this.txt_customerName.Text.Trim();
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = (int)((ModelItem)this.cmb_factory.SelectedItem).itemKey;
            }
            int orderStatus = 0;
            if (this.cmb_orderStatus.SelectedIndex > 0)
            {
                orderStatus = (int)((ModelItem)this.cmb_orderStatus.SelectedItem).itemKey;
            }
            int outputType = -1;
            if (this.cmb_outputType.SelectedIndex >= 0)
            {
                outputType = this.cmb_outputType.SelectedIndex;
            }
            int outputStatus = -1;
            if (this.cmb_outputStatus.SelectedIndex >= 0)
            {
                outputStatus = this.cmb_outputStatus.SelectedIndex;
            } 
            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);

            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            DataTable dt = m_bllProductOut.GetProductOut(productName, customerName, beginTime, endTime, orderStatus, outputType, outputStatus);

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modifyBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form;
                int outputStatus = (int)dataGridView1.Rows[e.RowIndex].Cells["outputStatusCode"].Value;
                if (outputStatus > 0)
                {
                    form = new FrmProductOutDetail(3, id);
                }
                else
                {
                    form = new FrmProductOutDetail(1, id);
                }
                this.Hide();
                form.ShowDialog();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int outputStatus = (int)dataGridView1.Rows[e.RowIndex].Cells["outputStatusCode"].Value;
                if (outputStatus > 0)
                {
                    Common.Tools.MsgUtils.ShowInfoMsg("已完成出库，不可删除！");
                    return;
                }

                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmProductOutDetail(2, id);
                this.Hide();
                form.ShowDialog();
            }
        }

        private void FrmOrderManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmProductOutDetail(0, 0);
            this.Hide();
            form.ShowDialog();
        }
        
    }
}
