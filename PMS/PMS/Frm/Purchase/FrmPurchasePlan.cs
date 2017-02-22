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
    public partial class FrmPurchasePlan : Form
    {
        private BllProduce m_bllProduce = new BllProduce();
        private BllPurchase m_bllPurchase = new BllPurchase();
        private BllFactory m_bllFactory = new BllFactory();

        public FrmPurchasePlan()
        {
            InitializeComponent();
        }

        private void FrmPurchasePlan_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //工厂
            List<ModelItem> listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem, true);

            this.cmb_applyStatus.SelectedIndex = 0;

            this.dtp_begin.Value = DateTime.Now;
            this.dtp_end.Value = DateTime.Now.AddMonths(1);

            this.txt_materials.Focus();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void FrmPurchasePlan_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit();
        }

        private void doSelect()
        {
            string materialsName = this.txt_materials.Text.Trim();
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = (int)((ModelItem)this.cmb_factory.SelectedItem).itemKey;
            }
            int applyStatus = this.cmb_applyStatus.SelectedIndex;

            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            DataTable dt = m_bllPurchase.GetPurchaseApply(materialsName, factoryId, applyStatus, beginTime, endTime);

            if (applyStatus == 0)
            {
                this.dataGridView1.Columns["selected"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["selected"].Visible = false;
            }

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void doSubmit()
        {
            List<Dictionary<string, object>> listApply = new List<Dictionary<string, object>>();

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                //选择的行
                if (this.dataGridView1.Rows[i].Cells["selected"].EditedFormattedValue.ToString() == "True")
                {
                    Dictionary<string, object> dc = new Dictionary<string, object>();
                    dc.Add("applyId", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value));
                    dc.Add("factoryId", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["factoryId"].Value));
                    dc.Add("materialsId", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["materialsId"].Value));
                    dc.Add("num", ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["num"].Value));
                    dc.Add("unit", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["unit"].Value));
                    dc.Add("deliveryDate", ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["deliveryDate"].Value));
                    dc.Add("applyBy", ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["applyMember"].Value));
                    dc.Add("applyDate", ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["applyDate"].Value));
                    dc.Add("produceCode", ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["produceCode"].Value));
                    
                    listApply.Add(dc);
                }
            }

            if (listApply.Count <= 0)
            {
                MsgUtils.ShowErrorMsg("请至少选择一行！");
                return;
            }

            Result rtnResult = m_bllPurchase.SubmitPurchaseApply(listApply, LoginUserInfo.LoginUser.loginUser.userId, LoginUserInfo.LoginUser.loginUser.userName);

            if (rtnResult.resultCode == Enum.EnumResultCode.Success)
            {
                MsgUtils.ShowInfoMsg("确认采购已成功！");
                //doSelect();
                this.Hide();
                Form form = new FrmPurchaseManage();
                form.ShowDialog();
            }
            else
            {
                MsgUtils.ShowErrorMsg("确认采购失败！");
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            List<ModelPurchaseApply> listCancelApply = new List<ModelPurchaseApply>();

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                //选择的行
                if (this.dataGridView1.Rows[i].Cells["selected"].EditedFormattedValue.ToString() == "True")
                {
                    ModelPurchaseApply modelPurchaseApply = new ModelPurchaseApply();
                    modelPurchaseApply.id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value);
                    modelPurchaseApply.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    modelPurchaseApply.modifyTime = DateTime.Now;
                    listCancelApply.Add(modelPurchaseApply);
                }
            }

            if (listCancelApply.Count <= 0)
            {
                MsgUtils.ShowErrorMsg("请至少选择一行！");
                return;
            }

            if (MsgUtils.ShowQustMsg("是否确认取消采购申请？", MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bool rtn = m_bllPurchase.CancelProduceApply(listCancelApply);
                if (rtn == true)
                {
                    MsgUtils.ShowInfoMsg("取消采购申请已成功！");
                    doSelect();
                }
                else
                {
                    MsgUtils.ShowErrorMsg("取消采购申请失败！");
                    return;
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            //查看库存
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "queryStore")
            {
                int factoryId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["factoryId"].Value);
                string materialsName = ConvertUtils.ConvertToString(this.dataGridView1.Rows[e.RowIndex].Cells["materialsName"].Value);

                Form form = new Store.FrmMaterialsQueryStore(materialsName, factoryId);
                form.ShowDialog();
            }
        }

        private void cmb_applyStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_applyStatus.SelectedIndex == 0)
            {
                this.btn_submit.Visible = true;
                this.btn_cancel.Visible = true;
            }
            else
            {
                this.btn_submit.Visible = false;
                this.btn_cancel.Visible = false;
            }
        }
    }
}
