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
    public partial class FrmPurchasePlan : Main.BaseForm
    {
        private BllProduce m_bllProduce = new BllProduce();
        private BllPurchase m_bllPurchase = new BllPurchase();
        private BllFactory m_bllFactory = new BllFactory();
        private BllCustomer m_bllCustomer= new BllCustomer();
        private BllMaterials m_bllMaterials = new BllMaterials();

        public FrmPurchasePlan()
        {
            InitializeComponent();
        }

        private void FrmPurchasePlan_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.menuFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //工厂
            List<ModelItem> listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem, true);

            DataGridViewComboBoxColumn colCustomer = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["customerId"];
            colCustomer.DataSource = m_bllCustomer.GetSupplier();
            colCustomer.DisplayMember = "itemValue";
            colCustomer.ValueMember = "itemKey";

            this.dtp_begin.Value = DateTime.Now;
            this.dtp_end.Value = DateTime.Now.AddMonths(1);

            doSelect();

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

            DateTime beginTime = new DateTime(this.dtp_begin.Value.Year, this.dtp_begin.Value.Month, this.dtp_begin.Value.Day);
            DateTime endTime = new DateTime(this.dtp_end.Value.Year, this.dtp_end.Value.Month, this.dtp_end.Value.Day);
            endTime = endTime.AddDays(1).AddSeconds(-1);

            DataTable dt = m_bllPurchase.GetPurchaseApply(materialsName, factoryId, beginTime, endTime);

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
                    if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["customerId"].Value) <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请选择供应商！");
                        return;
                    }

                    int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["materialsId"].Value);
                    ModelMaterials modelMaterials = m_bllMaterials.GetMaterialsById(materialsId);
                    if (modelMaterials.type != 2)
                    {
                        if (ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specs"].Value) <= 0)
                        {
                            MsgUtils.ShowErrorMsg("请选择规格！");
                            return;
                        }
                    }

                    if (ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["purchaseNum"].Value) <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入采购数量！");
                        return;
                    }

                    if (ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["purchasePrice"].Value) <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入采购单价！");
                        return;
                    }

                    Dictionary<string, object> dc = new Dictionary<string, object>();
                    dc.Add("applyId", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["id"].Value));
                    dc.Add("factoryId", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["factoryId"].Value));
                    dc.Add("customerId", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["customerId"].Value));
                    dc.Add("materialsId", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["materialsId"].Value));
                    dc.Add("specsId", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specs"].Value));
                    dc.Add("purchaseNum", ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["purchaseNum"].Value));
                    dc.Add("purchasePrice", ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["purchasePrice"].Value));
                    dc.Add("num", ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["numDisplay"].Value));
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

            Result rtnResult = m_bllPurchase.SubmitPurchaseApply(listApply, LoginUserInfo.LoginUser.loginUser.userId, LoginUserInfo.LoginUser.loginUser.userId);

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

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "selected")
            {
                //选择
                if (this.dataGridView1.Rows[e.RowIndex].Cells["selected"].EditedFormattedValue.ToString() == "True")
                {
                    this.dataGridView1.Rows[e.RowIndex].Cells["customerId"].ReadOnly = false;
                    this.dataGridView1.Rows[e.RowIndex].Cells["specs"].ReadOnly = false;
                    this.dataGridView1.Rows[e.RowIndex].Cells["purchaseNum"].ReadOnly = false;
                    this.dataGridView1.Rows[e.RowIndex].Cells["purchasePrice"].ReadOnly = false;

                    int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["materialsId"].Value);

                    if (materialsId > 0)
                    {
                        ModelMaterials modelMaterials = m_bllMaterials.GetMaterialsById(materialsId);

                        DataGridViewComboBoxCell column = (DataGridViewComboBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells["specs"];

                        if (modelMaterials.type != 2)
                        {
                            List<ModelItem> listItem = m_bllMaterials.GetMaterialsSpecsListForCombo(materialsId);
                            column.DataSource = listItem;
                            column.DisplayMember = "itemValue";
                            column.ValueMember = "itemKey";
                        }
                        else
                        {
                            this.dataGridView1.Rows[e.RowIndex].Cells["specs"].ReadOnly = true;
                            this.dataGridView1.Rows[e.RowIndex].Cells["purchaseNum"].Value = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["requestNum"].Value);
                            ModelMaterialsPrice modelMaterialsPrice = m_bllMaterials.GetMaterialsPriceById(materialsId, 0);
                            this.dataGridView1.Rows[e.RowIndex].Cells["purchasePrice"].Value = modelMaterialsPrice.price;
                            this.dataGridView1.Rows[e.RowIndex].Cells["price"].Value = modelMaterialsPrice.price;

                        }
                    }

                }
                else
                {
                    this.dataGridView1.Rows[e.RowIndex].Cells["customerId"].ReadOnly = true;
                    this.dataGridView1.Rows[e.RowIndex].Cells["specs"].ReadOnly = true;
                    this.dataGridView1.Rows[e.RowIndex].Cells["purchaseNum"].ReadOnly = true;
                    this.dataGridView1.Rows[e.RowIndex].Cells["purchasePrice"].ReadOnly = true;
                }
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "specs")
            {
                int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["materialsId"].Value);
                int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["specs"].Value);
                if (materialsId > 0 && specsId > 0)
                {
                    ModelMaterialsSpecs modelMaterialsSpecs = m_bllMaterials.GetMaterialsSpecsById(specsId);
                    decimal requestNum = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["requestNum"].Value);
                    int purchaseNum = ConvertUtils.ConvertToInt(Math.Ceiling(requestNum / (modelMaterialsSpecs.weight * modelMaterialsSpecs.num)));
                    this.dataGridView1.Rows[e.RowIndex].Cells["purchaseNum"].Value = purchaseNum;

                    ModelMaterialsPrice modelMaterialsPrice = m_bllMaterials.GetMaterialsPriceById(materialsId, specsId);
                    this.dataGridView1.Rows[e.RowIndex].Cells["purchasePrice"].Value = modelMaterialsPrice.price;
                    this.dataGridView1.Rows[e.RowIndex].Cells["price"].Value = modelMaterialsPrice.price;

                }

            }
        }

        //private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    DataGridView dgv = sender as DataGridView;

        //    //判断相应的列
        //    if (dgv.CurrentCell.GetType().Name == "DataGridViewComboBoxCell" && dgv.CurrentCell.RowIndex != -1)
        //    {

        //        //给这个DataGridViewComboBoxCell加上下拉事件
        //        (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(Dgv_ComboBox_SelectedIndexChanged);

        //    }
        //}

        //public void Dgv_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox combox = sender as ComboBox;

        //    //这里比较重要
        //    combox.Leave += new EventHandler(Dgv_Combox_Leave);
            
        //    try
        //    {
        //        if (combox.Name == "specs")
        //        {
        //            int rowIndex = this.dataGridView1.CurrentRow.Index;

        //            int materialsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[rowIndex].Cells["materialsId"].Value);
        //            int specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[rowIndex].Cells["specs"].Value);
        //            if (materialsId > 0 && specsId > 0)
        //            {
        //                ModelMaterialsSpecs modelMaterialsSpecs = m_bllMaterials.GetMaterialsSpecsListById(specsId);
        //                decimal requestNum = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[rowIndex].Cells["requestNum"].Value);
        //                int purchaseNum = ConvertUtils.ConvertToInt(Math.Ceiling(requestNum / (modelMaterialsSpecs.weight * modelMaterialsSpecs.num)));
        //                this.dataGridView1.Rows[rowIndex].Cells["purchaseNum"].Value = purchaseNum;

        //                ModelMaterialsPrice modelMaterialsPrice = m_bllMaterials.GetMaterialsPriceById(materialsId, specsId);
        //                this.dataGridView1.Rows[rowIndex].Cells["purchasePrice"].Value = modelMaterialsPrice.price;

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void Dgv_Combox_Leave(object sender, EventArgs e)
        //{
        //    ComboBox combox = sender as ComboBox;
        //    //做完处理，须撤销动态事件
        //    combox.SelectedIndexChanged -= new EventHandler(Dgv_ComboBox_SelectedIndexChanged);
        //}
    }
}
