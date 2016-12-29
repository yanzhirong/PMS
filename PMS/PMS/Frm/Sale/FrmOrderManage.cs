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

namespace PMS.Frm.Sale
{
    public partial class FrmOrderManage : Form
    {
        //销售ID
        private int m_salerId;

        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();
        private BllSaleOrder m_bllSaleOrder = new BllSaleOrder();

        public FrmOrderManage()
        {
            InitializeComponent();
        }

        private void FrmCustomerManage_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            List<ModelItem> listItem = m_bllCode.GetCodeItem(7, true);
            WinCommon.BindComboBox(ref this.cmb_status, listItem);

            if (LoginUserInfo.LoginUser.loginRole.roleType == (int)Enum.EnumRoleType.Saler)
            {
                m_salerId = LoginUserInfo.LoginUser.loginUser.userId;

                ModelItem item = new ModelItem();
                item.itemKey = m_salerId;
                item.itemValue = LoginUserInfo.LoginUser.loginUser.userName;

                this.cmb_saler.Items.Clear();
                this.cmb_saler.Items.Add(item);
                this.cmb_saler.SelectedIndex = 0;
                this.cmb_saler.Enabled = false;
            }
            else
            {
                m_salerId = 0;

                listItem = m_bllUser.GetUserGroupByRoleType((int)Enum.EnumRoleType.Saler);
                WinCommon.BindComboBox(ref this.cmb_saler, listItem);
            }

            this.dtp_begin.Value = DateTime.Now.AddMonths(-1);
            this.dtp_end.Value = DateTime.Now;

            this.txt_code.Focus();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string code = this.txt_code.Text.Trim();
            string name = this.txt_name.Text.Trim();
            int salerId = 0;
            if (this.cmb_saler.SelectedIndex >= 0)
            {
                salerId = (int)((ModelItem)this.cmb_saler.SelectedItem).itemKey;
            }
            int status = 0;
            if (this.cmb_status.SelectedIndex >= 0)
            {
                status = (int)((ModelItem)this.cmb_status.SelectedItem).itemKey;
            } 
            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);

            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            DataTable dt = m_bllSaleOrder.GetSaleOrders(code, name, salerId, status, beginTime, endTime, LoginUserInfo.LoginUser.loginRole.roleType);

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {

            Form form = new FrmCustomerDetail(0, 0);
            this.Hide();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modifyBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                int orderStatus = (int)dataGridView1.Rows[e.RowIndex].Cells["orderStatusCode"].Value;
                if (orderStatus == (int)Enum.EnumSaleOrderStatus.WaitConfirm)
                {
                    //财务确认
                    if (LoginUserInfo.LoginUser.loginRole.roleType == (int)Enum.EnumRoleType.Finance)
                    {
                        Form form = new FrmCustomerDetail(4, id);
                        this.Hide();
                        form.ShowDialog();
                    }
                    //修改
                    else
                    {
                        Form form = new FrmCustomerDetail(1, id);
                        this.Hide();
                        form.ShowDialog();
                    }
                }
                //查看
                else
                {
                    Form form = new FrmCustomerDetail(3, id);
                    this.Hide();
                    form.ShowDialog();
                }
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int orderStatus = (int)dataGridView1.Rows[e.RowIndex].Cells["orderStatusCode"].Value;
                if (orderStatus == (int)Enum.EnumSaleOrderStatus.WaitConfirm)
                {
                    int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                    Form form = new FrmCustomerDetail(2, id);
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    Common.Tools.MsgUtils.ShowInfoMsg("已确认订单，不可删除！");
                    return;

                }
            }
        }

        private void FrmOrderManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

    }
}
