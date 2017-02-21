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
using Common.Tools;

namespace PMS.Frm.Finance
{
    public partial class FrmReportSale : Form
    {
        private BllFactory m_bllFactory = new BllFactory();
        private BllStore m_bllStore = new BllStore();

        public FrmReportSale()
        {
            InitializeComponent();
        }

        private void FrmReportSale_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //工厂
            List<ModelItem> listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem, true);

            this.dtp_expiresDate.Value = DateTime.Now.AddMonths(1); ;
            this.dtp_begin.Value = DateTime.Now.AddYears(-1);
            this.dtp_end.Value = DateTime.Now;

            this.txt_name.Focus();

        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            if (ExportUtils.DataTableToExcel(GetDataTable(), true) == false)
            {
                MsgUtils.ShowInfoMsg("无法导出，请确认是否已安装Office!");
                return;
            }
        }

        private void doSelect()
        {
            int type = rdb_type_p.Checked == true ? 0 : 1;
            string name = this.txt_name.Text.Trim();
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = (int)((ModelItem)this.cmb_factory.SelectedItem).itemKey;
            }
            DateTime expiresDate = new DateTime(this.dtp_expiresDate.Value.Year, this.dtp_expiresDate.Value.Month, this.dtp_expiresDate.Value.Day);
            DateTime inputDate_begin = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime inputDate_end = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            inputDate_end = inputDate_end.AddDays(1).AddSeconds(-1);
            decimal stockNum = ConvertUtils.ConvertToDecimal(this.txt_stockNum.Text.Trim());            
            
            this.dataGridView1.DataSource = m_bllStore.GetStore(type, name, factoryId, expiresDate, inputDate_begin, inputDate_end, stockNum);
            this.dataGridView1.Refresh();
        }

        private DataTable GetDataTable()
        {
            int type = rdb_type_p.Checked == true ? 0 : 1;
            string name = this.txt_name.Text.Trim();
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = (int)((ModelItem)this.cmb_factory.SelectedItem).itemKey;
            }
            DateTime expiresDate = new DateTime(this.dtp_expiresDate.Value.Year, this.dtp_expiresDate.Value.Month, this.dtp_expiresDate.Value.Day);
            DateTime inputDate_begin = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime inputDate_end = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            inputDate_end = inputDate_end.AddDays(1).AddSeconds(-1);
            decimal stockNum = ConvertUtils.ConvertToDecimal(this.txt_stockNum.Text.Trim());

            return m_bllStore.GetStoreExport(type, name, factoryId, expiresDate, inputDate_begin, inputDate_end, stockNum);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modifyBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                int type = rdb_type_p.Checked == true ? 0 : 1;
                Form form = new FrmInventoryDetail(type, id);
                form.ShowDialog();
                doSelect();

            }
        }

        private void FrmReportSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void rdb_type_p_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdb_type_p.Checked)
            {
                this.lbl_stockNum.Visible = true;
                this.txt_stockNum.Visible = true;
            }
            else
            {
                this.lbl_stockNum.Visible = false;
                this.txt_stockNum.Visible = false;
            }
        }
        
    }
}
