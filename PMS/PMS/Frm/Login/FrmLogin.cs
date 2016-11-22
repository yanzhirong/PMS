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
using Bll;
using Model;

namespace PMS.Frm.Login
{
    public partial class FrmLogin : Form
    {
        BllLogin m_bllLogin = new BllLogin();

        public FrmLogin()
        {
            InitializeComponent();

            this.txt_name.Text = "admin";
            this.txt_pwd.Text = "admin";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (StringUtils.IsBlank(txt_name.Text))
            {
                MsgUtils.ShowWarnMsg("请输入用户名！");
                txt_name.Focus();
                return;
            }

            if (StringUtils.IsBlank(txt_pwd.Text))
            {
                MsgUtils.ShowWarnMsg("请输入密码！");
                txt_pwd.Focus();
                return;
            }

            m_bllLogin.DoLogin(txt_name.Text.Trim(), txt_pwd.Text.Trim());

            Result result = m_bllLogin.result;
            if (result.resultCode == Common.Enum.EnumResultCode.Success)
            {
                LoginUserInfo.LoginUser.loginUser = m_bllLogin.GetLoginUser(txt_name.Text.Trim());
                LoginUserInfo.LoginUser.loginRole = m_bllLogin.GetLoginRole(LoginUserInfo.LoginUser.loginUser.roleId);
                LoginUserInfo.LoginUser.loginMenu = m_bllLogin.GetLoginMenu(LoginUserInfo.LoginUser.loginUser.roleId);
                this.Hide();
                Form frmMain = new Frm.Main.FrmMain();
                frmMain.Show();
            }
            else
            {
                MsgUtils.ShowWarnMsg(result.resultMsg);
                txt_pwd.Text = "";
                return;
            }

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }
    }
}
