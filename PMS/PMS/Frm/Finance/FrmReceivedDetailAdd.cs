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
    public partial class FrmReceivedDetailAdd : Main.BaseForm
    {
        private string m_orderCode;
        private decimal m_maxReceiveMoney;

        private BllFinance m_bllFinance = new BllFinance();
        private BllCode m_bllCode = new BllCode();

        public FrmReceivedDetailAdd(string _orderCode, decimal _maxReceiveMoney)
        {
            InitializeComponent();
            m_orderCode = _orderCode;
            m_maxReceiveMoney = _maxReceiveMoney;
        }

        private void FrmReceivedDetailAdd_Load(object sender, EventArgs e)
        {            
            //初始化
            init();
        }

        private void FrmReceivedDetailAdd_FormClosed(object sender, FormClosedEventArgs e)
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
            WinCommon.BindComboBox(ref this.cmb_receiveType, listItem);

            this.txt_receiveMoney.Text = m_maxReceiveMoney.ToString();
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

            ModelFinanceReceivedDetail model = new ModelFinanceReceivedDetail();

            model.orderCode = m_orderCode;
            model.receivedMoney = ConvertUtils.ConvertToDecimal(this.txt_receiveMoney.Text.Trim());
            model.receivedDate = this.dtp_receiveDate.Value;
            model.receivedType = (int)(((ModelItem)this.cmb_receiveType.SelectedItem).itemKey);
            model.otherType = this.txt_otherType.Text.Trim();
            model.remark = this.txt_remark.Text.Trim();

            model.isDelete = 0;
            model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.createTime = DateTime.Now;

            rtn = m_bllFinance.AddReceivedDetail(model);

            if (rtn == true)
            {
                MsgUtils.ShowInfoMsg("新增收款明细成功！");
                this.Hide();
                return;
            }
            else
            {
                MsgUtils.ShowInfoMsg("新增收款明细失败！");
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
            if (ConvertUtils.isNotNumberical(this.txt_receiveMoney.Text.Trim()))
            {
                MsgUtils.ShowErrorMsg("请输入正确的收款金额！");
                this.txt_receiveMoney.Focus();
                return false;
            }
            decimal receiveMoney = ConvertUtils.ConvertToDecimal(this.txt_receiveMoney.Text.Trim());
            if (receiveMoney > m_maxReceiveMoney)
            {
                MsgUtils.ShowErrorMsg("收款金额大于余款（" + m_maxReceiveMoney + ")！");
                this.txt_receiveMoney.Focus();
                return false;
            }

            //收款日期
            if (this.dtp_receiveDate.Value > DateTime.Now)
            {
                MsgUtils.ShowErrorMsg("收款日不得晚于今日！");
                this.dtp_receiveDate.Focus();
                return false;
            }

            //收款方式
            if (this.cmb_receiveType.SelectedIndex < 0)
            {
                MsgUtils.ShowErrorMsg("请选择收款方式！");
                this.cmb_receiveType.Focus();
                return false;
            }
            if ((int)(((ModelItem)this.cmb_receiveType.SelectedItem).itemKey) == (int)Enum.EnumSettlementType.Other)
            {
                if(StringUtils.IsBlank(this.txt_otherType.Text.Trim()))
                {
                    MsgUtils.ShowErrorMsg("请输入其他收款方式！");
                    this.txt_otherType.Focus();
                    return false;
                }
            }

            if (m_maxReceiveMoney <= 0)
            {
                if (MsgUtils.ShowQustMsg("已完成收款，是否确认继续！", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        private void txt_receiveMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
        }

    }
}
