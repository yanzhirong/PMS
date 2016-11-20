using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace PMS
{
    public static class WinCommon
    {

        #region 动态生产菜单（已废弃）
        public static void CreateMenu(ref MenuStrip menuStrip)
        {
            menuStrip.Items.Clear();

            if (LoginUserInfo.LoginUser.loginMenu != null && LoginUserInfo.LoginUser.loginMenu.Count > 0)
            {
                foreach (ModelMenu menu in LoginUserInfo.LoginUser.loginMenu)
                {
                    // 一级菜单
                    if(menu.parentId == 0){
                        ToolStripMenuItem mi = new ToolStripMenuItem();
                        mi.Text = menu.menuName;
                        CreateMenuItem(mi, menu.menuId);
                        menuStrip.Items.Add((ToolStripItem)mi);
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
                    mitem.Text = menu.menuName;
                    mitem.Tag = menu.formName;
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
                Form f = System.AppDomain.CurrentDomain.CreateInstanceFromAndUnwrap(Application.ExecutablePath, formName) as Form;
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    
        #region 绑定下拉框
        public static void BindComboBox(ref ComboBox target, List<ModelItem> listItem) 
        {
            if (listItem == null || listItem.Count <= 0)
            {
                return;
            }

            target.Items.Clear();
            foreach(ModelItem item in listItem)
            {
                target.Items.Add(item);
            }
            target.DisplayMember = "itemValue";
            target.ValueMember = "itemKey";
        }
        #endregion

        /// <summary>
        /// 在主窗口中显示子窗口
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="form"></param>
        public static void ShowInMain(ref Form form)
        {
            LoginUserInfo.LoginUser.mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.Left = 3;
            form.Top = 3;

            LoginUserInfo.LoginUser.mainPanel.Parent.Width = form.Width + 22;
            LoginUserInfo.LoginUser.mainPanel.Width = form.Width + 10;
            LoginUserInfo.LoginUser.mainPanel.Parent.Height = form.Height + 24 + 46;
            LoginUserInfo.LoginUser.mainPanel.Height = form.Height + 12 + 46;
            LoginUserInfo.LoginUser.mainPanel.Parent.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - LoginUserInfo.LoginUser.mainPanel.Parent.Width / 2;
            LoginUserInfo.LoginUser.mainPanel.Parent.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - LoginUserInfo.LoginUser.mainPanel.Parent.Height / 2;

            LinkLabel logout = (LinkLabel)LoginUserInfo.LoginUser.mainPanel.Parent.Controls.Find("lnk_logout", false)[0];
            logout.Left = LoginUserInfo.LoginUser.mainPanel.Parent.Width - logout.Width - 30;
            //Label lbl = (Label)LoginUserInfo.LoginUser.mainPanel.Parent.Controls.Find("lbl_loginInfo", false)[0];
            //lbl.Left = btn.Left - lbl.Width - 20;
            //form.Width = LoginUserInfo.LoginUser.mainPanel.Width - 6;
            //form.Height = LoginUserInfo.LoginUser.mainPanel.Height - 6;
            LoginUserInfo.LoginUser.mainPanel.Controls.Add(form);
            form.Show();
        }

        /// <summary>
        /// 主窗口中显示空白
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="form"></param>
        public static void ReturnMain()
        {
            LoginUserInfo.LoginUser.mainPanel.Controls.Clear();
            LoginUserInfo.LoginUser.mainPanel.Refresh();
        }
        /// <summary>
        /// 退出程序
        /// </summary>
        public static void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}
