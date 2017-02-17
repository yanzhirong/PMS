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
    public partial class FrmMaterialsOut : Form
    {
        private BllFactory m_bllFactory = new BllFactory();
        private BllMaterialsOut m_bllMaterialsOut = new BllMaterialsOut();
        private BllUser m_bllUser = new BllUser();

        public FrmMaterialsOut()
        {
            InitializeComponent();
        }

        private void FrmMaterialsOut_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //工厂
            List<ModelItem> listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem, true);
            //申请人
            listItem = m_bllUser.GetUsersWithItem();
            WinCommon.BindComboBox(ref this.cmb_applyBy, listItem);
            
            this.dtp_begin.Value = DateTime.Now;
            this.dtp_end.Value = DateTime.Now.AddMonths(1);

            this.cmb_outputStatus.SelectedIndex = 1;
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
            int applyMemberId = 0;
            if (this.cmb_applyBy.SelectedIndex > 0)
            {
                applyMemberId = (int)((ModelItem)this.cmb_applyBy.SelectedItem).itemKey;
            }
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = (int)((ModelItem)this.cmb_factory.SelectedItem).itemKey;
            }
            int outputStatus = -1;
            if (this.cmb_outputStatus.SelectedIndex > -1)
            {
                outputStatus = this.cmb_outputStatus.SelectedIndex - 1;
            }
            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);

            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            DataTable dt = m_bllMaterialsOut.GetMaterialsOut(materialsName, applyMemberId, factoryId, beginTime, endTime, outputStatus);

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修改
            if (dataGridView1.Columns[e.ColumnIndex].Name == "modifyBtn")
            {

                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                int outputCnt = ConvertUtils.ConvertToInt(dataGridView1.Rows[e.RowIndex].Cells["outputCnt"].Value);
                Form form;
                
                if (outputCnt == 0)
                {
                    form = new FrmMaterialsOutDetail(1, id);
                }
                else
                {
                    form = new FrmMaterialsOutDetail(3, id);
                }
                form.ShowDialog();
                doSelect();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int outputCnt = ConvertUtils.ConvertToInt(dataGridView1.Rows[e.RowIndex].Cells["outputCnt"].Value);

                if (outputCnt > 0)
                {
                    Common.Tools.MsgUtils.ShowInfoMsg("已实际出库，不可删除！");
                    return;
                }

                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmMaterialsOutDetail(2, id);
                form.ShowDialog();
                doSelect();
            }
        }

        private void FrmMaterialsOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            Form form = new FrmMaterialsOutDetail(0, 0);
            form.ShowDialog();
            doSelect();
        }
        
    }
}
