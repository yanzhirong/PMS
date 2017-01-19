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
    public partial class FrmProductOutSelect : Form
    {
        private string m_outputCode;
        private int m_outputDetailId;
        private int m_productId;
        private int m_factoryId;

        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllProduct m_bllProduct = new BllProduct();
        private BllProductOut m_bllProductOut = new BllProductOut();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmProductOutSelect(string _outputCode, int _outputDetailId, int _productId, int _factoryId)
        {
            InitializeComponent();
            m_outputCode = _outputCode;
            m_outputDetailId = _outputDetailId;
            m_productId = _productId;
            m_factoryId = _factoryId;
        }

        private void FrmOrderDetail_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            
            //初始化
            init();
        }

        private void FrmProductOutSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            WinCommon.Exit();
        }
                
        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {
            //出库单号
            this.txt_outputCode.Text = m_outputCode;
            //仓库
            this.txt_factory.Text = m_bllFactory.GetFactoryById(m_factoryId).name;
            //出库商品
            this.txt_product.Text = m_bllProduct.GetProductById(m_productId).name;

            if (m_outputDetailId > 0)
            {
                ModelProductOutputDetail modelProductOutputDetail = m_bllProductOut.GetProductOutDetailById(m_outputDetailId);
                //出库数量
                this.txt_num.Text = modelProductOutputDetail.productNum.ToString();
                //单位
                this.txt_unitCode.Text = modelProductOutputDetail.productUnit.ToString();
                this.txt_unit.Text = m_bllCode.GetSubCode(3, modelProductOutputDetail.productUnit).value1;
            }
            else
            {

            }

            //设置列表信息
            SetDataGridViewStyle();

            //初始化列表
            doSelect();
        }

        //查询
        private void doSelect()
        {

        }

        #endregion

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        private void doSubmit()
        {
            Boolean rtn = false;

            //检查
            if (doCheck() == false)
            {
                return ;
            }


        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean doCheck()
        {
            
            return true;
        }
        #endregion

        #region 设置DataGridView列
        /// <summary>
        /// 设置DataGridView列
        /// </summary>
        private void SetDataGridViewStyle()
        {
            this.dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "id";
            textColumn.HeaderText = "id";
            textColumn.DataPropertyName = "id";
            textColumn.Visible = false;
            this.dataGridView1.Columns.Add(textColumn);

            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.Name = "selected";
            chkColumn.HeaderText = "选择";
            textColumn.Width = 60;
            this.dataGridView1.Columns.Add(chkColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "productName";
            textColumn.HeaderText = "商品";
            textColumn.DataPropertyName = "productName";
            textColumn.Width = 230;
            textColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "num";
            textColumn.HeaderText = "库存数量";
            textColumn.DataPropertyName = "num";
            textColumn.Width = 100;
            textColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "unit";
            textColumn.HeaderText = "库存单位";
            textColumn.DataPropertyName = "unit";
            textColumn.Width = 80;
            textColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "unitCode";
            textColumn.HeaderText = "库存单位";
            textColumn.DataPropertyName = "unitCode";
            textColumn.Visible = false;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "expiresDate";
            textColumn.HeaderText = "过期日";
            textColumn.DataPropertyName = "expiresDate";
            textColumn.Width = 100;
            textColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(textColumn);

            textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "outputNum";
            textColumn.HeaderText = "出库数量";
            textColumn.DataPropertyName = "outputNum";
            textColumn.Width = 100;
            textColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(textColumn);

            DataGridViewComboBoxColumn cmbColumn = new DataGridViewComboBoxColumn();
            cmbColumn.Name = "outputUnit";
            cmbColumn.DataPropertyName = "outputUnit";
            cmbColumn.HeaderText = "出库单位";
            cmbColumn.Width = 80;
            textColumn.ReadOnly = true;
            this.dataGridView1.Columns.Add(cmbColumn);
            cmbColumn.DataSource = m_bllCode.GetCodeList(3);
            cmbColumn.DisplayMember = "value1";
            cmbColumn.ValueMember = "subCode";

        }
        #endregion

                
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 1)
            {
                return;
            }

        }

    }
}
