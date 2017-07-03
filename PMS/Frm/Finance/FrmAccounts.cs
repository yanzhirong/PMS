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
    public partial class FrmAccounts : Main.BaseForm
    {
        private BllFinance m_bllFinance = new BllFinance();
        private BllFactory m_bllFactory = new BllFactory();
        private BllCustomer m_bllCusyomer = new BllCustomer();
        private BllSaleOrder m_bllSaleOrder = new BllSaleOrder();
        private BllPurchase m_bllPurchase = new BllPurchase();

        public FrmAccounts()
        {
            InitializeComponent();
        }

        private void FrmAccounts_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.menuFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //账目类型
            this.rdb_type_r.Checked = true;

            //客户
            List<ModelItem> listItem = m_bllCusyomer.GetCustomersBySalerId(0);
            WinCommon.BindComboBox(ref this.cmb_customer, listItem, true);

            //工厂
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem, true);

            this.dtp_begin.Value = DateTime.Now.AddYears(-1);
            this.dtp_end.Value = DateTime.Now;
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            int customerId = 0;
            if (this.cmb_customer.SelectedIndex > 0)
            {
                customerId = (int)((ModelItem)this.cmb_customer.SelectedItem).itemKey;
            }
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            }
            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            DataTable dt = m_bllFinance.GetAccountsExport(this.rdb_type_r.Checked ? 0 : 1, customerId, factoryId, beginTime, endTime);

            if (ExportUtils.DataTableToExcel(dt, true) == false)
            {
                MsgUtils.ShowInfoMsg("无法导出，请确认是否已安装Office!");
                return;
            }
        }

        private void doSelect()
        {
            int customerId = 0;
            if (this.cmb_customer.SelectedIndex > 0)
            {
                customerId = (int)((ModelItem)this.cmb_customer.SelectedItem).itemKey;
            }
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            }
            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            this.dataGridView1.DataSource = m_bllFinance.GetAccounts(this.rdb_type_r.Checked ? 0 : 1, customerId, factoryId, beginTime, endTime);
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //客户
            if (dataGridView1.Columns[e.ColumnIndex].Name == "customerName")
            {
                int customerId = (int)dataGridView1.Rows[e.RowIndex].Cells["customerId"].Value;
                Form form = new Sale.FrmCustomerDetail(1, customerId);
                form.ShowDialog();
            }

            //订单
            if (dataGridView1.Columns[e.ColumnIndex].Name == "orderCode")
            {
                if (this.rdb_type_r.Checked)
                {
                    string orderCode = ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells["orderCode"].Value);
                    Form form = new Sale.FrmOrderDetail(3, m_bllSaleOrder.GetSaleOrderByOrderCode(orderCode).id);
                    form.ShowDialog();
                }
                else
                {
                    string orderCode = ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells["orderCode"].Value);
                    Form form = new Purchase.FrmPurchaseDetail(3, m_bllPurchase.GetPurchaseByPurchaseCode(orderCode).id);
                    form.ShowDialog();
                }
            }
        }

        private void FrmAccounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void rdb_type_p_CheckedChanged(object sender, EventArgs e)
        {

            List<ModelItem> listItem = new List<ModelItem>();
            if (this.rdb_type_r.Checked)
            {
                listItem = m_bllCusyomer.GetCustomersBySalerId(0);
                WinCommon.BindComboBox(ref this.cmb_customer, listItem);

                this.dataGridView1.Columns["curPricePlan"].HeaderText = "应收";
                this.dataGridView1.Columns["curPrice"].HeaderText = "实收";
                this.dataGridView1.Columns["totalPrice"].HeaderText = "未收";

            }
            else
            {
                listItem = m_bllCusyomer.GetSupplier();
                WinCommon.BindComboBox(ref this.cmb_customer, listItem);

                this.dataGridView1.Columns["curPricePlan"].HeaderText = "应付";
                this.dataGridView1.Columns["curPrice"].HeaderText = "实付";
                this.dataGridView1.Columns["totalPrice"].HeaderText = "未付";
            }

            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);
            this.dataGridView1.DataSource = m_bllFinance.GetAccounts(1, int.MaxValue, int.MaxValue, beginTime, endTime);
            this.dataGridView1.Refresh();
        }
    }
}
