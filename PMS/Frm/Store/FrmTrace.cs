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

namespace PMS.Frm.Store
{
    public partial class FrmTrace : Main.BaseForm
    {
        private BllFactory m_bllFactory = new BllFactory();
        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllStore m_bllStore = new BllStore();
        private BllSaleOrder m_bllSaleOrder = new BllSaleOrder();

        public FrmTrace()
        {
            InitializeComponent();
        }

        private void FrmTrace_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.menuFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //工厂
            List<ModelItem> listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem, true);

            //客户
            listItem = m_bllCustomer.GetCustomersBySalerId(0);
            WinCommon.BindComboBox(ref this.cmb_customer, listItem, true);

            this.dtp_begin.Value = DateTime.Now.AddYears(-1);
            this.dtp_end.Value = DateTime.Now;

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
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = (int)((ModelItem)this.cmb_factory.SelectedItem).itemKey;
            }
            int customerId = 0;
            if (this.cmb_customer.SelectedIndex > 0)
            {
                customerId = (int)((ModelItem)this.cmb_customer.SelectedItem).itemKey;
            }
            DateTime outputDate_begin = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime outputDate_end = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            outputDate_end = outputDate_end.AddDays(1).AddSeconds(-1);
            string productName = this.txt_producrtName.Text.Trim();
            string productSpecs = this.txt_productSpecs.Text.Trim();
            string productOutputCode = this.txt_productOutputCode.Text.Trim();
            string materialsName = this.txt_materialsName.Text.Trim();
            string materislsSpecs = this.txt_materialsSpecs.Text.Trim();
            string materialsInputCode = this.txt_materialsInputCode.Text.Trim();

            this.dataGridView1.DataSource = m_bllStore.GetTrace(factoryId, customerId, outputDate_begin, outputDate_end, productName, productSpecs, productOutputCode, materialsName, materislsSpecs, materialsInputCode);
            this.dataGridView1.Refresh();
        }

        private DataTable GetDataTable()
        {
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = (int)((ModelItem)this.cmb_factory.SelectedItem).itemKey;
            }
            int customerId = 0;
            if (this.cmb_customer.SelectedIndex > 0)
            {
                customerId = (int)((ModelItem)this.cmb_customer.SelectedItem).itemKey;
            }
            DateTime outputDate_begin = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime outputDate_end = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            outputDate_end = outputDate_end.AddDays(1).AddSeconds(-1);
            string productName = this.txt_producrtName.Text.Trim();
            string productSpecs = this.txt_productSpecs.Text.Trim();
            string productOutputCode = this.txt_productOutputCode.Text.Trim();
            string materialsName = this.txt_materialsName.Text.Trim();
            string materislsSpecs = this.txt_materialsSpecs.Text.Trim();
            string materialsInputCode = this.txt_materialsInputCode.Text.Trim();

            return m_bllStore.GetTraceExport(factoryId, customerId, outputDate_begin, outputDate_end, productName, productSpecs, productOutputCode, materialsName, materislsSpecs, materialsInputCode);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //客户
            if (dataGridView1.Columns[e.ColumnIndex].Name == "customerName")
            {
                int customerId = (int)dataGridView1.Rows[e.RowIndex].Cells["customerId"].Value;
                Form form = new Sale.FrmCustomerDetail(3, customerId);
                form.ShowDialog();
            }

            //销售订单
            if (dataGridView1.Columns[e.ColumnIndex].Name == "orderCode")
            {
                string orderCode = ConvertUtils.ConvertToString(dataGridView1.Rows[e.RowIndex].Cells["orderCode"].Value);
                if(StringUtils.IsNotBlank(orderCode))
                {
                    Form form = new Sale.FrmOrderDetail(3, m_bllSaleOrder.GetSaleOrderByOrderCode(orderCode).id);
                    form.ShowDialog();
                }
            }

            //查看
            if (dataGridView1.Columns[e.ColumnIndex].Name == "outputDetail")
            {
                int outputId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                Form form = new FrmProductOutDetail(3, outputId);
                form.ShowDialog();
            }
        }

        private void FrmTrace_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }
        
    }
}
