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
using Common.Tools;

namespace PMS.Frm.Purchase
{
    public partial class FrmPurchaseManage : Main.BaseForm
    {

        private BllCode m_bllCode = new BllCode();
        private BllFactory m_bllFactory = new BllFactory();
        private BllPurchase m_bllPurchase = new BllPurchase();
        private BllFinance m_bllFinance = new BllFinance();

        public FrmPurchaseManage()
        {
            InitializeComponent();
        }

        private void FrmPurchaseManage_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.menuFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //工厂
            List<ModelItem> listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem, true);
            
            //状态
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.PurchaseStatus, false);
            WinCommon.BindComboBox(ref this.cmb_status, listItem, true);

            this.dtp_begin.Value = DateTime.Now;
            this.dtp_end.Value = DateTime.Now.AddMonths(1);

            this.cmb_status.SelectedIndex = 1;
            this.txt_materialsName.Focus();

            doSelect();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void doSelect()
        {
            string materialsName = this.txt_materialsName.Text.Trim();
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = (int)((ModelItem)this.cmb_factory.SelectedItem).itemKey;
            }
            int status = -1;
            if (this.cmb_status.SelectedIndex > 0)
            {
                status = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_status.SelectedItem).itemKey);
            }
            int type = -1;
            if (this.cmb_type.SelectedIndex > 0)
            {
                type = this.cmb_type.SelectedIndex - 1;
            }
            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);

            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            DataTable dt = m_bllPurchase.GetPurchase(materialsName, factoryId, beginTime, endTime, status, type);

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

                int statusCode = (int)dataGridView1.Rows[e.RowIndex].Cells["statusCode"].Value;
                if (statusCode == (int)Enum.EnumPurchaseOrderStatus.Complete || statusCode == (int)Enum.EnumPurchaseOrderStatus.Cancel)
                {
                    form = new FrmPurchaseDetail(3, id);
                }
                else
                { 
                    int rtn = m_bllPurchase.CheckUpdateDelete(id);
                    if (rtn == 1)
                    {
                        Common.Tools.MsgUtils.ShowInfoMsg("已收货，不可编辑！");
                        form = new FrmPurchaseDetail(3, id);
                    }
                    else if (rtn == 2)
                    {
                        Common.Tools.MsgUtils.ShowInfoMsg("已付款，不可编辑！");
                        form = new FrmPurchaseDetail(3, id);
                    }
                    else
                    {
                        form = new FrmPurchaseDetail(1, id);
                    }
                }

                form.ShowDialog();
                doSelect();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                int rtn = m_bllPurchase.CheckUpdateDelete(id);
                if (rtn == 1)
                {
                    Common.Tools.MsgUtils.ShowInfoMsg("已收货，不可取消！");
                    return;
                }

                if (rtn == 2)
                {
                    Common.Tools.MsgUtils.ShowInfoMsg("已付款，不可取消！");
                    return;
                }

                Form form = new FrmPurchaseDetail(5, id);
                form.ShowDialog();
                doSelect();
            }

            //查看库存
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "queryStore")
            {
                int factoryId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["factoryId"].Value);
                string materialsName = ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells["materialsName"].Value);

                Form form = new Store.FrmMaterialsQueryStore(factoryId, materialsName, 0);
                form.ShowDialog();
            }
        }

        private void FrmPurchaseManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmPurchaseDetail(0, 0);
            form.ShowDialog();
            doSelect();
        }
        
    }
}
