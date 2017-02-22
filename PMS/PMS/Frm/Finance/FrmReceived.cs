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
    public partial class FrmReceived : Form
    {
        private BllFinance m_bllFinance = new BllFinance();
        private BllFactory m_bllFactory = new BllFactory();
        private BllStore m_bllStore = new BllStore();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();
        private BllCustomer m_bllCusyomer = new BllCustomer();

        public FrmReceived()
        {
            InitializeComponent();
        }

        private void FrmReceived_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //工厂
            List<ModelItem> listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem, true);

            //客户
            listItem = m_bllCusyomer.GetCustomersBySalerId(0);
            WinCommon.BindComboBox(ref this.cmb_customer, listItem, true);

            //销售
            listItem = m_bllUser.GetUserGroupByRoleType((int)Enum.EnumRoleType.Saler);
            WinCommon.BindComboBox(ref this.cmb_saler, listItem, true);

            //收款状态
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.ReceiveStatus);
            WinCommon.BindComboBox(ref this.cmb_receiveStatus, listItem);

            this.dtp_begin.Value = DateTime.Now;
            this.dtp_end.Value = DateTime.Now.AddMonths(1);

            cmb_receiveStatus.SelectedIndex = 1;
            doSelect();

            this.cmb_factory.Focus();
        }

        private void FrmReceived_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            }
            int customerId = 0;
            if (this.cmb_customer.SelectedIndex > 0)
            {
                customerId = (int)((ModelItem)this.cmb_customer.SelectedItem).itemKey;
            }
            int salerId = 0;
            if (this.cmb_saler.SelectedIndex > 0)
            {
                salerId = (int)((ModelItem)this.cmb_saler.SelectedItem).itemKey;
            }
            string name = this.txt_name.Text.Trim();
            int status = 0;
            if (this.cmb_receiveStatus.SelectedIndex > 0)
            {
                status = (int)((ModelItem)this.cmb_receiveStatus.SelectedItem).itemKey;
            }
            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            DataTable dt = m_bllFinance.GetReceiveExport(factoryId, customerId, salerId, name, status, beginTime, endTime);

            if (ExportUtils.DataTableToExcel(dt, true) == false)
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
                factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            }
            int customerId = 0;
            if (this.cmb_customer.SelectedIndex > 0)
            {
                customerId = (int)((ModelItem)this.cmb_customer.SelectedItem).itemKey;
            }
            int salerId = 0;
            if (this.cmb_saler.SelectedIndex > 0)
            {
                salerId = (int)((ModelItem)this.cmb_saler.SelectedItem).itemKey;
            }
            string name = this.txt_name.Text.Trim();
            int status = 0;
            if (this.cmb_receiveStatus.SelectedIndex > 0)
            {
                status = (int)((ModelItem)this.cmb_receiveStatus.SelectedItem).itemKey;
            }
            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            this.dataGridView1.DataSource = m_bllFinance.GetReceive(factoryId, customerId, salerId, name, status, beginTime, endTime);
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //收款明细
            if (dataGridView1.Columns[e.ColumnIndex].Name == "receiveDetail")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                string orderCode = (string)dataGridView1.Rows[e.RowIndex].Cells["orderCode"].Value;
                string orderStatus = (string)dataGridView1.Rows[e.RowIndex].Cells["orderStatus"].Value;
                Form form = new FrmReceivedDetail(orderCode, orderStatus, id);
                form.ShowDialog();
                doSelect();
            }

            //客户
            if (dataGridView1.Columns[e.ColumnIndex].Name == "customerName")
            {
                int customerId = (int)dataGridView1.Rows[e.RowIndex].Cells["customerId"].Value;
                Form form = new Sale.FrmCustomerDetail(1, customerId);
                form.ShowDialog();
                doSelect();
            }
        }
    }
}
