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

namespace PMS.Frm.Sale
{
    public partial class FrmCustomerPaid : Form
    {
        private int m_customerId;
        private string m_customerName;

        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmCustomerPaid(int _customerId, string _customerName)
        {
            InitializeComponent();
            m_customerId = _customerId;
            m_customerName = _customerName;
        }

        private void FrmCustomerPaid_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            
            //初始化
            init();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {           

            //初始化
            if (m_customerId > 0)
            {
                ModelCustomerPaid model = m_bllCustomer.GetCustomerPaidById(m_customerId);

                //客户名称
                this.txt_name.Text = m_customerName;

                //开户银行
                this.txt_bank.Text = model.bank;
                //开户支行
                this.txt_subBank.Text = model.subBank;
                //银行账户
                this.txt_bankAccount.Text = model.bankAccount;
                //账户姓名
                this.txt_bankName.Text = model.bankAccountName;
                //账户手机
                this.txt_bankMobile.Text = model.bankAccountMobile;

                //支付宝账户
                this.txt_alipayAccount.Text = model.alipayAccount;
                //支付宝姓名
                this.txt_alipayName.Text = model.alipayName;
                //支付宝手机
                this.txt_alipayMobile.Text = model.alipayMobile;

                //备注
                this.txt_remark.Text = model.remark;
                //信用额度
                this.txt_creditLimit.Text = model.creditLimit.ToString();
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
            Boolean rtn = false;

            //检查
            if (doCheck() == false)
            {
                return ;
            }

            ModelCustomerPaid modelCustomerPaid = new ModelCustomerPaid();
            modelCustomerPaid.customerId = m_customerId;
            modelCustomerPaid.customerName = m_customerName;

            modelCustomerPaid.bank = this.txt_bank.Text.Trim();
            modelCustomerPaid.subBank = this.txt_subBank.Text.Trim();
            modelCustomerPaid.bankAccount = this.txt_bankAccount.Text.Trim();
            modelCustomerPaid.bankAccountName = this.txt_bankName.Text.Trim();
            modelCustomerPaid.bankAccountMobile = this.txt_bankMobile.Text.Trim();

            modelCustomerPaid.alipayAccount = this.txt_alipayAccount.Text.Trim();
            modelCustomerPaid.alipayName = this.txt_alipayName.Text.Trim();
            modelCustomerPaid.alipayMobile = this.txt_alipayMobile.Text.Trim();

            modelCustomerPaid.remark = this.txt_remark.Text.Trim();
            modelCustomerPaid.creditLimit = ConvertUtils.ConvertToDecimal(this.txt_creditLimit.Text.Trim());

            modelCustomerPaid.isDelete = 0;
            modelCustomerPaid.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelCustomerPaid.createTime = DateTime.Now;
            modelCustomerPaid.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelCustomerPaid.modifyTime = DateTime.Now;

            rtn = m_bllCustomer.AddUpdateCustomerPaid(modelCustomerPaid);

            if (rtn == false)
            {
                MsgUtils.ShowErrorMsg("更新客户支付信息失败！");
                return ;
            }
            else
            {
                MsgUtils.ShowInfoMsg("更新客户支付信息成功！");
                this.Hide();
            }

            return;
        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean doCheck()
        {
            ModelCustomer model = m_bllCustomer.GetCustomerById(m_customerId);

            //销售客户
            if (model.type == 1)
            {
                //信用额度
                decimal creditLimit = ConvertUtils.ConvertToDecimal(this.txt_creditLimit.Text.Trim());
                if (creditLimit <= 0)
                {
                    MsgUtils.ShowErrorMsg("请输入信用额度！");
                    this.txt_creditLimit.Focus();
                    return false;
                }
            }

            return true;
        }
        #endregion

        private void FrmCustomerPaid_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void txt_creditLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

    }
}
