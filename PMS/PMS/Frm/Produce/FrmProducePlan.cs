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
    public partial class FrmProducePlan : Form
    {
        private BllProduce m_bllProduce = new BllProduce();
        private BllPurchase m_bllPurchase = new BllPurchase();
        private BllFactory m_bllFactory = new BllFactory();

        public FrmProducePlan()
        {
            InitializeComponent();
        }

        private void FrmProducePlan_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //工厂
            List<ModelItem> listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem, true);

            this.cmb_applyStatus.SelectedIndex = 0;

            this.dtp_begin.Value = DateTime.Now;
            this.dtp_end.Value = DateTime.Now.AddMonths(1);

            this.txt_product.Focus();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void FrmProducePlan_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit();
        }

        private void doSelect()
        {
            string productName = this.txt_product.Text.Trim();
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > 0)
            {
                factoryId = (int)((ModelItem)this.cmb_factory.SelectedItem).itemKey;
            }
            int applyType = -1;
            if (this.cmb_applyType.SelectedIndex > -1)
            {
                applyType = this.cmb_applyType.SelectedIndex - 1;
            }
            int applyStatus = this.cmb_applyStatus.SelectedIndex;

            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            DataTable dt = m_bllProduce.GetProduceApply(productName, factoryId, applyType, applyStatus, beginTime, endTime);

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
                    dc.Add("productId", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["productId"].Value));
                    dc.Add("num", ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["num"].Value));
                    dc.Add("unit", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["unit"].Value));
                    dc.Add("deliveryDate", ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["deliveryDate"].Value));
                    dc.Add("applyBy", LoginUserInfo.LoginUser.loginUser.userName);
                    dc.Add("applyMemberId", LoginUserInfo.LoginUser.loginUser.userId);
                    dc.Add("applyDate", DateTime.Now);

                    listApply.Add(dc);
                }
            }

            if (listApply.Count <= 0)
            {
                MsgUtils.ShowErrorMsg("请至少选择一行！");
                return;
            }

            Result rtnResult = m_bllProduce.SubmitProduceApply(listApply, LoginUserInfo.LoginUser.loginUser.userName);

            if (rtnResult.resultCode == Enum.EnumResultCode.Success)
            {
                MsgUtils.ShowInfoMsg("确认生产已成功！");
                doSelect();

                //检查物料库存
                List<ModelPurchaseApply> listPurchaseApply = m_bllProduce.CheckProduceMaterial((Dictionary<int, object>)rtnResult.resultObj, LoginUserInfo.LoginUser.loginUser.userName);
                if (listPurchaseApply.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach(ModelPurchaseApply purchaseApply in listPurchaseApply)
                    {
                        if (!sb.ToString().Contains(purchaseApply.materialsName))
                        {
                            sb.Append(purchaseApply.materialsName).Append(",");
                        }
                    }
                    //string materialName = sb.ToString();
                    //sb.ToString().Substring(0, sb.ToString().Length - 1);

                    if (MsgUtils.ShowQustMsg("物料【" + sb.ToString().Substring(0, sb.ToString().Length - 1) + "】不足，是否生成购买订单？", MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        //生成物料购买订单
                        if (m_bllPurchase.AddPurchaseApply(listPurchaseApply) == true)
                        {
                            MsgUtils.ShowInfoMsg("物料购买订单已成功生成！");
                            return;
                        }
                        else
                        {
                            MsgUtils.ShowErrorMsg("物料购买订单生成失败！");
                            return;
                        }
                    }
                }
            }
            else
            {
                MsgUtils.ShowErrorMsg("确认生产失败！");
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            List<ModelProduceApply> listCancelApply = new List<ModelProduceApply>();

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                //选择的行
                if (this.dataGridView1.Rows[i].Cells["selected"].EditedFormattedValue.ToString() == "True")
                {
                    ModelProduceApply modelProduceApply = new ModelProduceApply();
                    modelProduceApply.id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value);
                    modelProduceApply.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    modelProduceApply.modifyTime = DateTime.Now;
                    listCancelApply.Add(modelProduceApply);
                }
            }

            if (listCancelApply.Count <= 0)
            {
                MsgUtils.ShowErrorMsg("请至少选择一行！");
                return;
            }

            if (MsgUtils.ShowQustMsg("是否确认取消生产申请？", MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bool rtn = m_bllProduce.CancelProduceApply(listCancelApply);
                if (rtn == true)
                {
                    MsgUtils.ShowInfoMsg("取消生产申请已成功！");
                    doSelect();
                }
                else
                {
                    MsgUtils.ShowErrorMsg("取消生产申请失败！");
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

            //查看商品
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
    }
}
