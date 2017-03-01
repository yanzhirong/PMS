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

namespace PMS.Frm.Finance
{
    public partial class FrmPaidDetail : Main.BaseForm
    {
        private string m_purchaseCode;
        private string m_purchaseStatus;
        private int m_paidId;

        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllFinance m_bllFinance = new BllFinance();
        private BllCode m_bllCode = new BllCode();

        public FrmPaidDetail(string _purchaseCode, string _purchaseStatus, int _receiveId)
        {
            InitializeComponent();
            m_purchaseCode = _purchaseCode;
            m_purchaseStatus = _purchaseStatus;
            m_paidId = _receiveId;
        }

        private void FrmPaidDetail_Load(object sender, EventArgs e)
        {
            //初始化
            init();
        }

        private void FrmPaidDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
                
        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {
            //销售单号
            this.txt_purchaseCode.Text = m_purchaseCode;

            ModelFinancePaid modelFinancePaid = m_bllFinance.GetPaidById(m_paidId);
            
            //客户
            this.txt_customer.Text = m_bllCustomer.GetCustomerById(modelFinancePaid.customerId).name;
            
            //订单状态
            this.txt_purchaseStatus.Text = m_purchaseStatus;

            //付款状态
            this.txt_paidStatus.Text = m_bllCode.GetSubCode((int)Enum.EnumCode.ReceiveStatus, modelFinancePaid.paidStatus).value1;

            //应付金额
            this.txt_orderPrice.Text = modelFinancePaid.orderPrice.ToString();

            //已付金额
            this.txt_paidPrice.Text = modelFinancePaid.paidPrice.ToString();

            //付款明细
            this.dataGridView1.DataSource = m_bllFinance.GetPaidDetailByPurchaseCode(m_purchaseCode);
            this.dataGridView1.Refresh();
        }
        #endregion

        private void btn_add_Click(object sender, EventArgs e)
        {
            decimal maxPaidMoney = ConvertUtils.ConvertToDecimal(this.txt_orderPrice.Text) - ConvertUtils.ConvertToDecimal(this.txt_paidPrice.Text);
            Form form = new FrmPaidDetailAdd(m_purchaseCode, maxPaidMoney);
            form.ShowDialog();
            init();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
