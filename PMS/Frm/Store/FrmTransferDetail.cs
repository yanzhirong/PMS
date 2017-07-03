using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bll;
using Common.Tools;

namespace PMS.Frm.Store
{
    public partial class FrmTransferDetail : Main.BaseForm
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看）
        private int m_mode;
        private int m_transferId;

        private BllStore m_bllStore = new BllStore();
        private BllUser m_bllUser = new BllUser();
        private BllProduct m_bllProduct = new BllProduct();
        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllFactory m_bllFactory = new BllFactory();
        private BllCode m_bllCode = new BllCode();
        private BllProductOut m_bllProductOut = new BllProductOut();
        private BllMaterialsOut m_bllMaterialsOut = new BllMaterialsOut();

        public FrmTransferDetail(int _mode, int _transferId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_transferId = _transferId;
        }

        private void FrmTransferDetail_Load(object sender, EventArgs e)
        {           
            //初始化
            init();
        }

        private void FrmTransferDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit(true);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回列表
            this.Hide();
        }
                
        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {      

            //下拉框
            //来源工厂
            List<ModelItem> listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_fromFactory, listItem);
            //目标工厂
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_toFactory, listItem);
            //申请人
            listItem = m_bllUser.GetUsersWithItem();
            WinCommon.BindComboBox(ref this.cmb_applyBy, listItem);
            //调拨人
            listItem = m_bllUser.GetUsersWithItem();
            WinCommon.BindComboBox(ref this.cmb_transferBy, listItem);

            //调拨人
            for (int i = 0; i < this.cmb_transferBy.Items.Count; i++)
            {
                ModelItem modelItem = (ModelItem)this.cmb_transferBy.Items[i];
                if (LoginUserInfo.LoginUser.loginUser.userId == (int)modelItem.itemKey)
                {
                    this.cmb_transferBy.SelectedIndex = i;
                    break;
                }
            }

            //初始化数据
            if (m_mode != 0 && m_transferId > 0)
            {

                ModelTransfer model = m_bllStore.GetTransferById(m_transferId);

                //类型
                for (int i = 0; i < this.cmb_type.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_type.Items[i];
                    if (model.type == (int)modelItem.itemKey)
                    {
                        this.cmb_type.SelectedIndex = i;
                        break;
                    }
                }

                //调拨对象
                for (int i = 0; i < this.cmb_transferObject.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_transferObject.Items[i];
                    if (model.type == 0)
                    {
                        if (model.productId == (int)modelItem.itemKey)
                        {
                            this.cmb_transferObject.SelectedIndex = i;
                            break;
                        }
                    }
                    else
                    {
                        if (model.materialsId == (int)modelItem.itemKey)
                        {
                            this.cmb_transferObject.SelectedIndex = i;
                            break;
                        }
                    }
                }

                //申请人
                for (int i = 0; i < this.cmb_applyBy.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_applyBy.Items[i];
                    if (model.applyMemberId == (int)modelItem.itemKey)
                    {
                        this.cmb_applyBy.SelectedIndex = i;
                        break;
                    }
                }

                //申请日
                this.dtp_applyDate.Value = ConvertUtils.ConvertToDate(model.applyDate, "yyyy-MM-dd");

                //调拨人
                for (int i = 0; i < this.cmb_transferBy.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_transferBy.Items[i];
                    if (model.transferMemberId == (int)modelItem.itemKey)
                    {
                        this.cmb_transferBy.SelectedIndex = i;
                        break;
                    }
                }

                //调拨日
                this.dtp_transferDate.Value = ConvertUtils.ConvertToDate(model.transferDate, "yyyy-MM-dd");

                //备注
                this.txt_remark.Text = model.remark;

            }           

            //按钮处理
            this.btn_submit.Visible = true;
            this.btn_cancel.Visible = true;
            this.btn_close.Visible = false;

            if (m_mode == 3)
            {
                this.btn_submit.Visible = false;
                this.btn_cancel.Visible = false;
                this.btn_close.Visible = true;
            }

            //新增修改时
            if (m_mode == 0 || m_mode == 1)
            {
                grb_transfer.Enabled = true;
            }

            if (m_mode == 2)
            {
                this.btn_submit.Text = "确认删除";
            }

            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                grb_transfer.Enabled = false;
            }

        }
        #endregion

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        private Boolean doSubmit(bool showMsg)
        {
            Boolean rtn = false;

            //检查
            if (doCheck() == false)
            {
                return false;
            }

            ModelTransfer model = new ModelTransfer();
            model.id = m_transferId;
            model.type = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_type.SelectedItem).itemKey);

            model.fromFactoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_fromFactory.SelectedItem).itemKey);
            model.toFactoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_toFactory.SelectedItem).itemKey);

            if (this.cmb_type.SelectedIndex == 0)
            {
                model.productId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_transferObject.SelectedItem).itemKey);
            }
            else
            {
                model.materialsId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_transferObject.SelectedItem).itemKey);
            }

            //调拨数
            decimal selectedAllTransferNum = 0;
            int transferUnit = 0;
            List<Dictionary<string, object>> listTransferDetail = new List<Dictionary<string, object>>();

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                //选择的行
                if (this.dataGridView1.Rows[i].Cells["selected"].EditedFormattedValue.ToString() == "True")
                {

                    Dictionary<string, object> dc = new Dictionary<string, object>();

                    //入库单号
                    string inputCode = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["inputCode"].Value);
                    dc.Add("inputCode", inputCode);

                    //输入的调拨数
                    decimal curTransferNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["transferNum"].Value);
                    dc.Add("transferNum", curTransferNum);

                    int unit = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["unit"].Value);
                    dc.Add("transferUnit", unit);

                    if (this.cmb_type.SelectedIndex == 1)
                    {
                        if (transferUnit <= 0)
                        {
                            transferUnit = unit;
                        }

                        curTransferNum = curTransferNum * m_bllCode.GetWeightUnit(unit);
                        selectedAllTransferNum = selectedAllTransferNum + curTransferNum;
                    }
                    else
                    {
                        selectedAllTransferNum = selectedAllTransferNum + curTransferNum;
                    }

                    listTransferDetail.Add(dc);
                }
            }

            if (this.cmb_type.SelectedIndex == 1)
            {
                selectedAllTransferNum = selectedAllTransferNum / m_bllCode.GetWeightUnit(transferUnit);
                model.num = selectedAllTransferNum;
                model.unit = transferUnit;
            }
            else
            {
                model.num = selectedAllTransferNum;
            }

            model.transferMemberId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_transferBy.SelectedItem).itemKey);
            model.transferDate = this.dtp_transferDate.Value;

            if (this.cmb_applyBy.SelectedIndex >= 0)
            {
                model.applyMemberId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_applyBy.SelectedItem).itemKey);
            }
            model.applyDate = this.dtp_applyDate.Value;

            model.remark = this.txt_remark.Text.Trim();

            model.isDelete = 0;
            model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.createTime = DateTime.Now;
            model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllStore.AddTransfer(model, listTransferDetail);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("新增调拨单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("新增调拨单成功！");
                    }
                }

                //返回列表
                this.Hide();

                return true;
            }

            return true;
        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean doCheck()
        {
            
            // 新增或修改
            if (m_mode == 0 || m_mode == 1)
            {
                //调拨类型
                if (this.cmb_type.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择调拨类型！");
                    this.cmb_type.Focus();
                    return false;
                }

                //调拨对象
                if(this.cmb_transferObject.SelectedIndex < 0)
                {
                    if (this.cmb_type.SelectedIndex == 0)
                    {
                        MsgUtils.ShowErrorMsg("请选择调拨成品！");
                    }
                    else
                    {
                        MsgUtils.ShowErrorMsg("请选择调拨原料！");
                    }
                    this.cmb_transferObject.Focus();
                    return false;
                }

                //来源工厂
                if (this.cmb_fromFactory.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择来源工厂！");
                    this.cmb_fromFactory.Focus();
                    return false;
                }

                //目标工厂
                if (this.cmb_toFactory.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择目标工厂！");
                    this.cmb_toFactory.Focus();
                    return false;
                }

                //调拨数
                decimal selectedAllTransferNum = 0;

                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    //选择的行
                    if (this.dataGridView1.Rows[i].Cells["selected"].EditedFormattedValue.ToString() == "True")
                    {

                        //输入的调拨数
                        decimal curTransferNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["transferNum"].Value);
                        if (curTransferNum <= 0)
                        {
                            MsgUtils.ShowErrorMsg("请输入调拨数！");
                            return false;
                        }

                        //库存数量
                        decimal curStockNum = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["num"].Value);

                        if (curTransferNum > curStockNum)
                        {
                            MsgUtils.ShowErrorMsg("调拨数量大于在库数量，请输入适当的调拨数！");
                            return false;
                        }

                        selectedAllTransferNum = selectedAllTransferNum + curTransferNum;
                    }
                }

                if (selectedAllTransferNum <= 0)
                {
                    MsgUtils.ShowErrorMsg("调拨数不可为空！");
                    return false;
                }

                //调拨人
                if (this.cmb_transferBy.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择调拨人！");
                    this.cmb_transferBy.Focus();
                    return false;
                }
            }

            return true;
        }
        #endregion
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_type.SelectedIndex == 0)
            {
                this.lbl_transferObject.Text = "调拨成品";
                //调拨成品
                List<ModelItem> listItem = m_bllProduct.GetProductItem("");
                WinCommon.BindComboBox(ref this.cmb_transferObject, listItem, false);

            }
            else
            {
                this.lbl_transferObject.Text = "调拨原料";
                //调拨原料
                List<ModelItem> listItem = m_bllMaterials.GetMaterialsItem("");
                WinCommon.BindComboBox(ref this.cmb_transferObject, listItem, false);
            }
        }

        #region 设置DataGridView列
        /// <summary>
        /// 设置DataGridView列
        /// </summary>
        private void SetDataGridViewStyle()
        {
            this.dataGridView1.Columns.Clear();

            if (this.cmb_transferObject.SelectedIndex < 0)
            {
                return;
            }

            if (this.cmb_fromFactory.SelectedIndex < 0)
            {
                return;
            } 
            
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "id";
            colId.HeaderText = "id";
            colId.DataPropertyName = "id";
            colId.Visible = false;
            this.dataGridView1.Columns.Add(colId);

            DataGridViewTextBoxColumn colInputId = new DataGridViewTextBoxColumn();
            colInputId.Name = "inputCode";
            colInputId.HeaderText = "inputCode";
            colInputId.DataPropertyName = "inputCode";
            colInputId.Visible = false;
            this.dataGridView1.Columns.Add(colInputId);

            DataGridViewCheckBoxColumn colSelect = new DataGridViewCheckBoxColumn();
            colSelect.Name = "selected";
            colSelect.HeaderText = "选择";
            colSelect.Width = 40;
            this.dataGridView1.Columns.Add(colSelect);

            DataGridViewTextBoxColumn colProduct = new DataGridViewTextBoxColumn();
            colProduct.Name = "name";
            colProduct.HeaderText = "名称";
            colProduct.DataPropertyName = "name";
            colProduct.Width = 160;
            colProduct.ReadOnly = true;
            this.dataGridView1.Columns.Add(colProduct);

            DataGridViewTextBoxColumn colExpiresDate = new DataGridViewTextBoxColumn();
            colExpiresDate.Name = "expiresDate";
            colExpiresDate.HeaderText = "过期日";
            colExpiresDate.DataPropertyName = "expiresDate";
            colExpiresDate.Width = 100;
            colExpiresDate.ReadOnly = true;
            this.dataGridView1.Columns.Add(colExpiresDate);

            DataGridViewTextBoxColumn colNumDisplay = new DataGridViewTextBoxColumn();
            colNumDisplay.Name = "numDisplay";
            colNumDisplay.HeaderText = "库存数";
            colNumDisplay.DataPropertyName = "numDisplay";
            colNumDisplay.Width = 80;
            colNumDisplay.ReadOnly = true;
            this.dataGridView1.Columns.Add(colNumDisplay);

            DataGridViewTextBoxColumn colOutputNum = new DataGridViewTextBoxColumn();
            colOutputNum.Name = "transferNum";
            colOutputNum.HeaderText = "出库数量";
            colOutputNum.Width = 80;
            colOutputNum.ReadOnly = false;
            this.dataGridView1.Columns.Add(colOutputNum);

            DataGridViewTextBoxColumn colNum = new DataGridViewTextBoxColumn();
            colNum.Name = "num";
            colNum.HeaderText = "库存数";
            colNum.DataPropertyName = "num";
            colNum.Visible = false;
            this.dataGridView1.Columns.Add(colNum);

            DataGridViewTextBoxColumn colUnit = new DataGridViewTextBoxColumn();
            colUnit.Name = "unit";
            colUnit.HeaderText = "库存单位";
            colUnit.DataPropertyName = "unit";
            colUnit.Visible = false;
            this.dataGridView1.Columns.Add(colUnit);

            int factoryId =  ConvertUtils.ConvertToInt(((ModelItem)this.cmb_toFactory.SelectedItem).itemKey);
            int transferObjectId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_transferObject.SelectedItem).itemKey);
            if (this.cmb_type.SelectedIndex == 0)
            {
                this.dataGridView1.DataSource = m_bllProductOut.GetProductOutSelect(factoryId, transferObjectId, 0);
            }
            else
            {
                this.dataGridView1.DataSource = m_bllMaterialsOut.GetMaterialsOutSelect(factoryId, transferObjectId, 0);
            }
            this.dataGridView1.Refresh();

        }
        #endregion

        private void cmb_transferObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDataGridViewStyle();
        }

        private void cmb_fromFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDataGridViewStyle();
        }

    }
}
