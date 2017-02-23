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
    public partial class FrmReceivedDetail : Form
    {
        private string m_orderCode;
        private string m_orderStatus;
        private int m_receiveId;

        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllFinance m_bllFinance = new BllFinance();
        private BllCode m_bllCode = new BllCode();

        public FrmReceivedDetail(string _orderCode, string _orderStatus, int _receiveId)
        {
            InitializeComponent();
            m_orderCode = _orderCode;
            m_orderStatus = _orderStatus;
            m_receiveId = _receiveId;
        }

        private void FrmReceivedDetail_Load(object sender, EventArgs e)
        {
            //初始化
            init();
        }

        private void FrmReceivedDetail_FormClosed(object sender, FormClosedEventArgs e)
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
            this.txt_orderCode.Text = m_orderCode;

            ModelFinanceReceive modelFinanceReceive = m_bllFinance.GetReceiveById(m_receiveId);
            
            //客户
            this.txt_customer.Text = m_bllCustomer.GetCustomerById(modelFinanceReceive.customerId).name;
            
            //订单状态
            this.txt_orderStatus.Text = m_orderStatus;

            //收款状态
            this.txt_receiveStatus.Text = m_bllCode.GetSubCode((int)Enum.EnumCode.ReceiveStatus, modelFinanceReceive.receivedStatus).value1;

            //应收金额
            this.txt_orderPrice.Text = modelFinanceReceive.orderPrice.ToString();

            //已收金额
            this.txt_receivedMoney.Text = modelFinanceReceive.receivedPrice.ToString();

            //收款明细
            this.dataGridView1.DataSource = m_bllFinance.GetReceivedDetailByOrderCode(m_orderCode);
            this.dataGridView1.Refresh();
        }
        #endregion

        private void btn_add_Click(object sender, EventArgs e)
        {
            decimal maxReceiveMoney = ConvertUtils.ConvertToDecimal(this.txt_orderPrice.Text) - ConvertUtils.ConvertToDecimal(this.txt_receivedMoney.Text);
            Form form = new FrmReceivedDetailAdd(m_orderCode, maxReceiveMoney);
            form.ShowDialog();
            init();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
