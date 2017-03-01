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
    public partial class FrmPaidDetailAdd : Main.BaseForm
    {
        private string m_purchaseCode;
        private decimal m_maxPaidMoney;

        private BllFinance m_bllFinance = new BllFinance();
        private BllCode m_bllCode = new BllCode();

        public FrmPaidDetailAdd(string _purchaseCode, decimal _maxPaidMoney)
        {
            InitializeComponent();
            m_purchaseCode = _purchaseCode;
            m_maxPaidMoney = _maxPaidMoney;
        }

        private void FrmPaidDetailAdd_Load(object sender, EventArgs e)
        {            
            //初始化
            init();
        }

        private void FrmPaidDetailAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
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
            List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.Settlement, false);
            WinCommon.BindComboBox(ref this.cmb_paidType, listItem);

            this.txt_paidMoney.Text = m_maxPaidMoney.ToString();
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

            ModelFinancePaidDetail model = new ModelFinancePaidDetail();

            model.purchaseCode = m_purchaseCode;
            model.paidMoney = ConvertUtils.ConvertToDecimal(this.txt_paidMoney.Text.Trim());
            model.paidDate = this.dtp_paidDate.Value;
            model.paidType = (int)(((ModelItem)this.cmb_paidType.SelectedItem).itemKey);
            model.otherType = this.txt_otherType.Text.Trim();
            model.remark = this.txt_remark.Text.Trim();

            model.isDelete = 0;
            model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.createTime = DateTime.Now;

            rtn = m_bllFinance.AddPaidDetail(model);

            if (rtn == true)
            {
                MsgUtils.ShowInfoMsg("新增付款明细成功！");
                this.Hide();
                return;
            }
            else
            {
                MsgUtils.ShowInfoMsg("新增付款明细失败！");
                return;
            }

        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean doCheck()
        {
            //收款金额
            if (ConvertUtils.isNotNumberical(this.txt_paidMoney.Text.Trim()))
            {
                MsgUtils.ShowErrorMsg("请输入正确的付款金额！");
                this.txt_paidMoney.Focus();
                return false;
            }
            decimal paidMoney = ConvertUtils.ConvertToDecimal(this.txt_paidMoney.Text.Trim());
            if (paidMoney > m_maxPaidMoney)
            {
                MsgUtils.ShowErrorMsg("付款金额大于付款余款（" + m_maxPaidMoney + ")！");
                this.txt_paidMoney.Focus();
                return false;
            }

            //付款日期
            if (this.dtp_paidDate.Value > DateTime.Now)
            {
                MsgUtils.ShowErrorMsg("付款日不得晚于今日！");
                this.dtp_paidDate.Focus();
                return false;
            }

            //付款方式
            if (this.cmb_paidType.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择付款方式！");
                this.cmb_paidType.Focus();
                return false;
            }
            if ((int)(((ModelItem)this.cmb_paidType.SelectedItem).itemKey) == (int)Enum.EnumSettlementType.Other)
            {
                if(StringUtils.IsBlank(this.txt_otherType.Text.Trim()))
                {
                    MsgUtils.ShowErrorMsg("请输入其他收款方式！");
                    this.txt_otherType.Focus();
                    return false;
                }
            }

            if (m_maxPaidMoney <= 0)
            {
                if (MsgUtils.ShowQustMsg("已完成付款，是否确认继续！", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        private void txt_paidMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

    }
}
