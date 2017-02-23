using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Diagnostics;

namespace PMS
{
    public static class WinCommon
    {

        #region 动态生产菜单
        public static void CreateMenu(ref MenuStrip menuStrip)
        {
            // LoginUserInfo.LoginUser.currentFrom = (Form)currentForm;

            menuStrip.Items.Clear();

            if (LoginUserInfo.LoginUser.loginMenu != null && LoginUserInfo.LoginUser.loginMenu.Count > 0)
            {
                foreach (ModelMenu menu in LoginUserInfo.LoginUser.loginMenu)
                {
                    // 一级菜单
                    if(menu.parentId == 0){
                        ToolStripMenuItem mitem = new ToolStripMenuItem();
                        mitem.Text = menu.menuName;
                        CreateMenuItem(mitem, menu.menuId);
                        menuStrip.Items.Add((ToolStripItem)mitem);
                        if (!Common.Tools.StringUtils.IsBlank(menu.formName))
                        {
                            mitem.Tag = menu.formName;
                            mitem.Click += new EventHandler(BindClickToInstinse);
                        }
                    }
                }
            }
        }
        public static void CreateMenuItem(ToolStripMenuItem mi, int parentId)
        {
            foreach (ModelMenu menu in LoginUserInfo.LoginUser.loginMenu)
            {
                // 二级菜单
                if (menu.parentId == parentId)
                {
                    ToolStripMenuItem mitem = new ToolStripMenuItem();
                    mitem.Text = menu.menuName.Trim();
                    mitem.Tag = menu.formName.Trim();
                    mi.DropDownItems.Add(mitem);
                    mitem.Click += new EventHandler(BindClickToInstinse);
                }
            }
        }

        public static void BindClickToInstinse(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = sender as ToolStripMenuItem;
            if (mi.HasDropDownItems)//如果有下一级目录就不实例化
            {
                return;
            }
            string formName = mi.Tag as string;
            try
            {
                LoginUserInfo.LoginUser.currentFrom.Hide();
                Form f = System.AppDomain.CurrentDomain.CreateInstanceFromAndUnwrap(Application.ExecutablePath, formName) as Form;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    
        #region 绑定下拉框
        public static void BindComboBox(ref ComboBox target, List<ModelItem> listItem, bool AddBlank = false) 
        {
            if (listItem == null || listItem.Count <= 0)
            {
                return;
            }

            target.Items.Clear();

            if (AddBlank == true)
            {
                ModelItem blankItem = new ModelItem();
                target.Items.Add(blankItem);
            }
            foreach(ModelItem item in listItem)
            {
                target.Items.Add(item);
            }
            target.DisplayMember = "itemValue";
            target.ValueMember = "itemKey";
        }
        #endregion

        #region 废弃
        /// <summary>
        /// 在主窗口中显示子窗口
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="form"></param>
        public static void ShowInMain(ref Form form)
        {
            form.TopLevel = false;
            form.Left = 3;
            form.Top = 3;

            LoginUserInfo.LoginUser.mainPanel.Parent.Width = form.Width + 22;
            LoginUserInfo.LoginUser.mainPanel.Width = form.Width + 10;
            LoginUserInfo.LoginUser.mainPanel.Parent.Height = form.Height + 24 + 46;
            LoginUserInfo.LoginUser.mainPanel.Height = form.Height + 12 + 46;
            LoginUserInfo.LoginUser.mainPanel.Parent.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - LoginUserInfo.LoginUser.mainPanel.Parent.Width / 2;
            LoginUserInfo.LoginUser.mainPanel.Parent.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - LoginUserInfo.LoginUser.mainPanel.Parent.Height / 2;

            //LinkLabel logout = (LinkLabel)LoginUserInfo.LoginUser.mainPanel.Parent.Controls.Find("lnk_logout", false)[0];
            //logout.Left = LoginUserInfo.LoginUser.mainPanel.Parent.Width - logout.Width - 30;
            //Label lbl = (Label)LoginUserInfo.LoginUser.mainPanel.Parent.Controls.Find("lbl_loginInfo", false)[0];
            //lbl.Left = btn.Left - lbl.Width - 20;
            //form.Width = LoginUserInfo.LoginUser.mainPanel.Width - 6;
            //form.Height = LoginUserInfo.LoginUser.mainPanel.Height - 6;

            LoginUserInfo.LoginUser.mainPanel.Parent.Text = "生产管理系统 --> " + form.Text + "     (" + LoginUserInfo.LoginUser.loginUser.userName + "/" + LoginUserInfo.LoginUser.loginRole.roleName + ")";
            LoginUserInfo.LoginUser.mainPanel.Controls.Clear();
            LoginUserInfo.LoginUser.mainPanel.Controls.Add(form);

            // LoginUserInfo.LoginUser.mainPanel.Parent.Hide();
            form.Show();
            //LoginUserInfo.LoginUser.mainPanel.Parent.Show();
            //form.Show();
        }

        /// <summary>
        /// 主窗口中显示空白
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="form"></param>
        public static void ReturnMain()
        {
            LoginUserInfo.LoginUser.mainPanel.Parent.Text = "生产管理系统" + "     (" + LoginUserInfo.LoginUser.loginUser.userName + "/" + LoginUserInfo.LoginUser.loginRole.roleName + ")";
            LoginUserInfo.LoginUser.mainPanel.Controls.Clear();
            LoginUserInfo.LoginUser.mainPanel.Refresh();
        }
        #endregion

        /// <summary>
        /// 退出程序
        /// </summary>
        public static void Exit()
        {
            //关闭Excel
            foreach (Process p in Process.GetProcessesByName("Excel"))
            {
                if (string.IsNullOrEmpty(p.MainWindowTitle))
                {
                    p.Kill();
                }
            }

            System.Environment.Exit(0);
        }


        #region 输入控制
        /// <summary>
        /// 仅限数字（整数)
        /// </summary>
        /// <param name="_char"></param>
        /// <returns></returns>
        public static Boolean IsOnlyInt(char _char)
        {
            if (!((_char >= 48 && _char <= 57) || _char == 8 || _char == 45))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 仅限数字（浮点数)
        /// </summary>
        /// <param name="_char"></param>
        /// <returns></returns>
        public static Boolean IsOnlyDouble(char _char)
        {
            if (!((_char >= 48 && _char <= 57) || _char == 8 || _char ==45 || _char == 46))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 判断是否具有财务权限
        public static bool IsFinance(int _roleType)
        {
            if (_roleType == (int)Enum.EnumRoleType.Finance)
            {
                return true;
            }
            if (_roleType == (int)Enum.EnumRoleType.Admin)
            {
                return true;
            }

            return false;
        }
        #endregion

    }
}
