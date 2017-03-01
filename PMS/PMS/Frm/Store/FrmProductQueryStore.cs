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
    public partial class FrmProductQueryStore : Main.BaseForm
    {
        private string m_productName;
        private int m_factoryId;

        private BllStore m_bllStore = new BllStore();
        private BllFactory m_bllFactory = new BllFactory();

        public FrmProductQueryStore(string _productName, int _factoryId)
        {
            InitializeComponent();
            m_productName = _productName;
            m_factoryId = _factoryId;
        }

        private void FrmProductQueryStore_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            
            //初始化
            init();
        }

        private void FrmProductQueryStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
                
        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {
            //工厂下拉框
            List<ModelItem> listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem);

            //出库单号
            this.txt_productName.Text = m_productName;
            //工厂
            for (int i = 0; i < this.cmb_factory.Items.Count; i++)
            {
                ModelItem modelItem = (ModelItem)this.cmb_factory.Items[i];
                if (m_factoryId == (int)modelItem.itemKey)
                {
                    this.cmb_factory.SelectedIndex = i;
                    break;
                }
            }
            
            //设置列表信息
            SetDataGridViewStyle();

            //初始化列表
            doSelect();
        }

        //查询
        private void doSelect()
        {
            string productName = this.txt_productName.Text.Trim();
            int factoryId = 0;
            if (this.cmb_factory.SelectedIndex > -1)
            {
                factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            }
            this.dataGridView1.DataSource = m_bllStore.GetProductStore(productName, factoryId);
            this.dataGridView1.Refresh();
        }

        #endregion


        #region 设置DataGridView列
        /// <summary>
        /// 设置DataGridView列
        /// </summary>
        private void SetDataGridViewStyle()
        {
            this.dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn colProduct = new DataGridViewTextBoxColumn();
            colProduct.Name = "productName";
            colProduct.HeaderText = "产品";
            colProduct.DataPropertyName = "productName";
            colProduct.Width = 160;
            colProduct.ReadOnly = true;
            this.dataGridView1.Columns.Add(colProduct);

            DataGridViewTextBoxColumn colFactory = new DataGridViewTextBoxColumn();
            colFactory.Name = "factoryName";
            colFactory.HeaderText = "工厂";
            colFactory.DataPropertyName = "factoryName";
            colFactory.Width = 160;
            colFactory.ReadOnly = true;
            this.dataGridView1.Columns.Add(colFactory);

            DataGridViewTextBoxColumn colExpiresDate = new DataGridViewTextBoxColumn();
            colExpiresDate.Name = "expiresDate";
            colExpiresDate.HeaderText = "过期日";
            colExpiresDate.DataPropertyName = "expiresDate";
            colExpiresDate.Width = 100;
            colExpiresDate.ReadOnly = true;
            this.dataGridView1.Columns.Add(colExpiresDate);

            DataGridViewTextBoxColumn colNumDisplay = new DataGridViewTextBoxColumn();
            colNumDisplay.Name = "stockNum";
            colNumDisplay.HeaderText = "库存数量";
            colNumDisplay.DataPropertyName = "stockNum";
            colNumDisplay.Width = 80;
            colNumDisplay.ReadOnly = true;
            this.dataGridView1.Columns.Add(colNumDisplay);
        }
        #endregion

        private void btn_select_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
