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
using Enum;

namespace PMS.Frm.Login
{
    public partial class FrmLogin : Form
    {
        BllLogin m_bllLogin = new BllLogin();
        BllCode m_bllCode = new BllCode();

        public FrmLogin()
        {
            InitializeComponent();

            //this.txt_name.Text = "admin";
            //this.txt_pwd.Text = "admin";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            doLogin(true);
        }

        private void doLogin(bool showMsg)
        {
            if (StringUtils.IsBlank(txt_name.Text))
            {
                if (showMsg)
                {
                    MsgUtils.ShowWarnMsg("请输入用户名！");
                }
                txt_name.Focus();
                return;
            }

            if (StringUtils.IsBlank(txt_pwd.Text))
            {
                if (showMsg)
                {
                    MsgUtils.ShowWarnMsg("请输入密码！");
                }
                txt_pwd.Focus();
                return;
            }

            m_bllLogin.DoLogin(txt_name.Text.Trim(), txt_pwd.Text.Trim());

            Result result = m_bllLogin.result;
            if (result.resultCode == EnumResultCode.Success)
            {
                LoginUserInfo.LoginUser.loginUser = m_bllLogin.GetLoginUser(txt_name.Text.Trim());
                LoginUserInfo.LoginUser.loginRole = m_bllLogin.GetLoginRole(LoginUserInfo.LoginUser.loginUser.roleId);
                LoginUserInfo.LoginUser.loginMenu = m_bllLogin.GetLoginMenu(LoginUserInfo.LoginUser.loginUser.roleId, LoginUserInfo.LoginUser.loginRole.roleType);
                this.Hide();

                bool showTask = false;
                DataTable dt = m_bllCode.GetCodeList((int)Enum.EnumCode.TaskType);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (showTask)
                        {
                            break;
                        }

                        string[] roleTypes = ConvertUtils.ConvertToString(dr["value2"]).Split(',');
                        for(int i = 0; i < roleTypes.Length; i++)
                        {
                            if (LoginUserInfo.LoginUser.loginRole.roleType == ConvertUtils.ConvertToInt(roleTypes[i]) || WinCommon.IsAdmin(LoginUserInfo.LoginUser.loginRole.roleType))
                            {
                                showTask = true;
                                break;
                            }
                        }

                        if (showTask)
                        {
                            DataTable dtTask = m_bllLogin.GetTask(ConvertUtils.ConvertToInt(dr["subCode"]));

                            if (!(dtTask != null && dtTask.Rows.Count > 0))
                            {
                                showTask = false;
                            }
                        }

                    }
                }

                if (showTask)
                {
                    Form form = new Frm.Main.FrmTask(1);
                    form.Show();
                }
                else
                {
                    Form form = new Frm.Main.FrmMain();
                    form.Show();
                }
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

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doLogin(false);
            }
        }

        private void txt_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doLogin(false);
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = WinCommon.IsOnlyEnNum(e.KeyChar);

        }

        private void txt_pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = WinCommon.IsOnlyEnNum(e.KeyChar);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FormCollection collection = Application.OpenForms;

            foreach (Form form in collection)
            {
                if (form.Name != "FrmLogin")
                {
                    form.Hide();
                }
            }

            this.txt_name.Focus();
        }
    }
}
