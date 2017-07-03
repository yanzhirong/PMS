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

namespace PMS.Frm.Product
{
    public partial class FrmProductSpecs : Main.BaseForm
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看）
        private int m_mode;
        //原来ID
        private int m_productId;
        
        private BllProduct m_bllProduct = new BllProduct();
        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllCode m_bllCode = new BllCode();

        public FrmProductSpecs(int _mode, int _productId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_productId = _productId;
        }

        private void FrmProductSpecs_Load(object sender, EventArgs e)
        {
            //初始化
            init();

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回用户列表
            this.Hide();
        }

        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {
            this.grb_product.Enabled = false;

            // 设置datagrid
            SetDataGridViewStyle();

            //初始化(
            if (m_productId > 0)
            {
                ModelProduct modelProduct = m_bllProduct.GetProductById(m_productId);

                //成品名
                this.txt_name.Text = modelProduct.name;
                //成品略名
                this.txt_subName.Text = modelProduct.subName;
  
                dataGridView1.DataSource = m_bllProduct.GetProductSpecsListByProdcutId(m_productId);
                dataGridView1.Refresh();
            }

            if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                this.grb_new.Enabled = false;
                this.btn_close.Visible = false;
            }
            else
            {
                this.grb_new.Enabled = true;
                this.btn_submit.Visible = false;
                this.btn_cancel.Visible = false;
            }

            if (m_mode == 3)
            {
                this.grb_new.Enabled = false;
                this.dataGridView1.Enabled = false;
                this.btn_submit.Visible = false;
                this.btn_cancel.Visible = false;
                this.btn_close.Visible = true;
            }
        }
        #endregion

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        private void doSubmit()
        {
            if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
            {                                                                                                                                           
                //检查
                if (doCheck() == false)
                {
                    return ;
                }

                List<ModelProductPrice> listModelProductPrice = new List<ModelProductPrice>();
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    ModelProductPrice modelProductPrice = new ModelProductPrice();
                    modelProductPrice.productId = m_productId;
                    modelProductPrice.id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["priceId"].Value);
                    modelProductPrice.specsId = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells["specsId"].Value);
                    modelProductPrice.minPrice = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["minPrice"].Value);
                    modelProductPrice.advisePrice = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["advisePrice"].Value);
                    modelProductPrice.isDelete = 0;
                    if (modelProductPrice.id <= 0)
                    {
                        modelProductPrice.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                        modelProductPrice.createTime = DateTime.Now;
                    }
                    else
                    {
                        modelProductPrice.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                        modelProductPrice.modifyTime = DateTime.Now;
                    }
                    listModelProductPrice.Add(modelProductPrice);                     
                }

                if (m_bllProduct.SetProductPrice(listModelProductPrice) == false)
                {
                    MsgUtils.ShowErrorMsg("修改成品价格失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("修改成品价格成功！");
                }
                this.Hide();
                return;
            }

        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean doCheck()
        {
            if(m_mode == 3)
            {
                return true;
            }

            if (this.dataGridView1.Rows.Count <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入规格！");
                this.dataGridView1.Focus();
                return false;
            }

            List<string> listSpecs = new List<string>();

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {

                string specs = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["name"].Value);
                if (listSpecs.Contains(specs))
                {
                    MsgUtils.ShowErrorMsg("成品规格已重复！");
                    this.dataGridView1.Focus();
                    return false;
                }
                else
                {
                    listSpecs.Add(specs);
                }

                if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType)) 
                {
                    decimal minPrice = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["minPrice"].Value);
                    if (minPrice <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入合适的最低售价！");
                        this.dataGridView1.Focus();
                        return false;
                    }

                    decimal advisePrice = ConvertUtils.ConvertToDecimal(this.dataGridView1.Rows[i].Cells["advisePrice"].Value);
                    if (advisePrice <= 0)
                    {
                        MsgUtils.ShowErrorMsg("请输入合适的建议售价！");
                        this.dataGridView1.Focus();
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        private void FrmProductSpecs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// 设置DataGridView列
        /// </summary>
        private void SetDataGridViewStyle()
        {
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn columnsSpecsId = new DataGridViewTextBoxColumn();
            columnsSpecsId.Name = "specsId";
            columnsSpecsId.HeaderText = "specsId";
            columnsSpecsId.DataPropertyName = "specsId";
            columnsSpecsId.Visible = false;
            this.dataGridView1.Columns.Add(columnsSpecsId);

            DataGridViewTextBoxColumn columnsName = new DataGridViewTextBoxColumn();
            columnsName.Name = "name";
            columnsName.HeaderText = "规格";
            columnsName.DataPropertyName = "name";
            columnsName.Visible = true;
            this.dataGridView1.Columns.Add(columnsName);

            DataGridViewTextBoxColumn columnsPriceId = new DataGridViewTextBoxColumn();
            columnsPriceId.Name = "priceId";
            columnsPriceId.HeaderText = "priceId";
            columnsPriceId.DataPropertyName = "priceId";
            columnsPriceId.Visible = false;
            this.dataGridView1.Columns.Add(columnsPriceId);

            DataGridViewTextBoxColumn columnsMinPrice = new DataGridViewTextBoxColumn();
            columnsMinPrice.Name = "minPrice";
            columnsMinPrice.HeaderText = "最低售价";
            columnsMinPrice.DataPropertyName = "minPrice";
            if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                columnsMinPrice.Width = 100;
            } else {
                columnsMinPrice.Visible = false;
            }
            this.dataGridView1.Columns.Add(columnsMinPrice);

            DataGridViewTextBoxColumn columnsAdvisePrice = new DataGridViewTextBoxColumn();
            columnsAdvisePrice.Name = "advisePrice";
            columnsAdvisePrice.HeaderText = "建议售价";
            columnsAdvisePrice.DataPropertyName = "advisePrice";
            if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                columnsAdvisePrice.Width = 100;
            } else {
                columnsAdvisePrice.Visible = false;
            }
            this.dataGridView1.Columns.Add(columnsAdvisePrice);

            DataGridViewButtonColumn btnColumns = new DataGridViewButtonColumn();
            btnColumns.Name = "deleteBtn";
            btnColumns.HeaderText = "删除";
            btnColumns.DataPropertyName = "deleteBtn";
            if (WinCommon.IsFinance(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                columnsAdvisePrice.Width = 100;
            }
            else
            {
                columnsAdvisePrice.Visible = false;
            }
            this.dataGridView1.Columns.Add(btnColumns);

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex < 0 || e.ColumnIndex != 1)
            {
                return;
            }

              if (e.ColumnIndex == 1)
            {
                
            }

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 4 || this.dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                TextBox tx = (TextBox)e.Control;
                tx.KeyPress -= new KeyPressEventHandler(tx_keyPress);
                tx.KeyPress += new KeyPressEventHandler(tx_keyPress);
            }
        }

        private void tx_keyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

            decimal weight = ConvertUtils.ConvertToDecimal(this.txt_weight.Text.Trim(), 4);
            if (weight <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入合适的重量！");
                this.txt_weight.Focus();
                return;
            }

            int num = ConvertUtils.ConvertToInt(this.txt_num.Text.Trim());
            if (num <= 0)
            {
                MsgUtils.ShowErrorMsg("请输入合适的数量！");
                this.txt_num.Focus();
                return;
            }

            string name = weight + "*" + num;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (name == ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells["name"].Value))
                {
                    MsgUtils.ShowErrorMsg("成品规格已重复！");
                    this.txt_weight.Focus();
                    return;
                }
            }

            ModelProductSpecs newSpecs = new ModelProductSpecs();
            newSpecs.productId = m_productId;
            newSpecs.name = name;
            //转为克
            newSpecs.weight = weight * 1000;
            newSpecs.num = num;
            newSpecs.isDelete = 0;
            newSpecs.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            newSpecs.createTime = DateTime.Now;

            int newSpecsId = m_bllProduct.AddProductSpecs(newSpecs);
            if (newSpecsId > 0)
            {
                DataTable dt = (DataTable)this.dataGridView1.DataSource;
                DataRow dr = dt.NewRow();
                dr["specsId"] = newSpecsId;
                dr["name"] = newSpecs.name;
                dr["deleteBtn"] = "删除";
                dt.Rows.Add(dr);
                this.dataGridView1.DataSource = dt;

                MsgUtils.ShowInfoMsg("新增规格成功！");
                return;
            }
            else
            {
                MsgUtils.ShowErrorMsg("新增规格失败！");
                return;
            }
         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //删除
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int specsId = (int)this.dataGridView1.Rows[e.RowIndex].Cells["specsId"].Value;

                if (MsgUtils.ShowQustMsg("确认删除此规格？", MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ModelProductSpecs modelProductSpecs = new ModelProductSpecs();
                    modelProductSpecs.id = specsId;
                    modelProductSpecs.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                    modelProductSpecs.modifyTime = DateTime.Now;

                    if (m_bllProduct.DeleteProductSpecs(modelProductSpecs))
                    {
                        MsgUtils.ShowInfoMsg("删除规格成功！");
                        this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                        return;
                    }
                    else
                    {
                        MsgUtils.ShowErrorMsg("删除规格失败！");
                        return;
                    }
                }
            }
        }
    }
}
