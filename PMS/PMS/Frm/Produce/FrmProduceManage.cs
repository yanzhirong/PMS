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

namespace PMS.Frm.Produce
{
    public partial class FrmProduceManage : Form
    {
        private BllCode m_bllCode = new BllCode();
        private BllFactory m_bllFactory = new BllFactory();
        private BllProduce m_bllProduce = new BllProduce();

        public FrmProduceManage()
        {
            InitializeComponent();
        }

        private void FrmProduceManage_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //工厂
            List<ModelItem> listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem, true);
            
            //状态
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.ProduceStatus, true);
            WinCommon.BindComboBox(ref this.cmb_status, listItem);

            this.dtp_begin.Value = DateTime.Now;
            this.dtp_end.Value = DateTime.Now.AddMonths(1);

            this.txt_productName.Focus();

            doSelect();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void doSelect()
        {
            string productName = this.txt_productName.Text.Trim();
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
            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);

            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            DataTable dt = m_bllProduce.GetProduce(productName, factoryId, status, beginTime, endTime);

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modifyBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                int statusCode = (int)dataGridView1.Rows[e.RowIndex].Cells["statusCode"].Value;
                Form form;
                if (statusCode == (int)Enum.EnumProduceOrderStatus.Producing)
                {
                    form = new FrmProduceDetail(1, id);
                }
                else
                {
                    form = new FrmProduceDetail(3, id);
                }
                form.ShowDialog();
                doSelect();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                int statusCode = (int)dataGridView1.Rows[e.RowIndex].Cells["statusCode"].Value;
                if (statusCode == (int)Enum.EnumProduceOrderStatus.MaterialsPurchasing)
                {
                    Common.Tools.MsgUtils.ShowInfoMsg("已开始采购，不可删除！");
                    return;
                }
                if (statusCode == (int)Enum.EnumProduceOrderStatus.Produced)
                {
                    Common.Tools.MsgUtils.ShowInfoMsg("已完成生产，不可删除！");
                    return;
                }
                if (statusCode == (int)Enum.EnumProduceOrderStatus.Complete)
                {
                    Common.Tools.MsgUtils.ShowInfoMsg("已生产入库，不可删除！");
                    return;
                }
                Form form = new FrmProduceDetail(2, id);
                form.ShowDialog();
                doSelect();
            }

            //查看产品
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "productName")
            {
                int productId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["productId"].Value);

                Form form = new Product.FrmProductDetail(3, productId);
                form.ShowDialog();
            }

            //查看库存
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "queryStore")
            {
                int factoryId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["factoryId"].Value);
                string productName = ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells["productName"].Value);

                Form form = new Store.FrmProductQueryStore(productName, factoryId);
                form.ShowDialog();
            }
        }

        private void FrmProduceManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmProduceDetail(0, 0);
            form.ShowDialog();
            doSelect();
        }
        
    }
}
