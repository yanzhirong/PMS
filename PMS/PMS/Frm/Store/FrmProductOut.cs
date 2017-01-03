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

namespace PMS.Frm.Store
{
    public partial class FrmProductOut : Form
    {
        //销售ID
        private int m_salerId;

        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();
        private BllSaleOrder m_bllSaleOrder = new BllSaleOrder();

        public FrmProductOut()
        {
            InitializeComponent();
        }

        private void FrmProductOut_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            List<ModelItem> listItem = m_bllCode.GetCodeItem(7, true);
            WinCommon.BindComboBox(ref this.cmb_status, listItem);

            if (LoginUserInfo.LoginUser.loginRole.roleType == (int)Enum.EnumRoleType.Saler)
            {
                m_salerId = LoginUserInfo.LoginUser.loginUser.userId;

                this.cmb_factory.Items.Clear();

                ModelItem item = new ModelItem();
                item.itemKey = 0;
                item.itemValue = "";
                this.cmb_factory.Items.Add(item);
                 item = new ModelItem();
                item.itemKey = m_salerId;
                item.itemValue = LoginUserInfo.LoginUser.loginUser.userName;
                
                this.cmb_factory.SelectedIndex = 1;
                this.cmb_factory.Enabled = false;
            }
            else
            {
                m_salerId = 0;

                listItem = m_bllUser.GetUserGroupByRoleType((int)Enum.EnumRoleType.Saler);
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

                if (LoginUserInfo.LoginUser.loginRole.roleType == (int)Enum.EnumRoleType.Finance)
                {
                    this.dataGridView1.Columns["deleteBtn"].Visible = false;
                }
            }

            this.dtp_begin.Value = DateTime.Now.AddMonths(-1);
            this.dtp_end.Value = DateTime.Now;

            this.txt_productName.Focus();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string code = this.txt_productName.Text.Trim();
            string name = this.txt_customerName.Text.Trim();
            int salerId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                salerId = (int)((ModelItem)this.cmb_factory.SelectedItem).itemKey;
            }
            int status = 0;
            if (this.cmb_status.SelectedIndex > 0)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmOrderManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }
        
    }
}
