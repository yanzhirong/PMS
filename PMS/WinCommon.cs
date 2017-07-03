using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Common.Tools;
using System.IO;

namespace PMS
{
    public static class WinCommon
    {
        #region Excel打印
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);
        [DllImport("kernel32.dll")]
        public static extern int OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        public const int PROCESS_ALL_ACCESS = 0x1F0FFF;
        public const int PROCESS_VM_READ = 0x0010;
        public const int PROCESS_VM_WRITE = 0x0020;
        public static int pid = 0;

        public static Boolean OpenExcelTpl(string strFilePath, out Excel.Application xlApp, out Excel.Workbook workbook)
        {
            bool rtn = false;
            //定义
            xlApp = new Excel.Application();
            workbook = xlApp.Workbooks.Add(strFilePath);

            try
            {
                if (xlApp == null)
                {
                    MsgUtils.ShowErrorMsg("无法创建Excel对象，可能您的电脑未安装Excel！");
                    return rtn;
                }

                //获取Excel App的句柄
                IntPtr hwnd = new IntPtr(xlApp.Hwnd);
                //通过Windows API获取Excel进程ID
                GetWindowThreadProcessId(hwnd, out pid);

                workbook = xlApp.Workbooks.Add(strFilePath); //目标文件

                Excel.Worksheet worksheet = workbook.Worksheets[1];

                rtn = true;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (rtn == false)
                {
                    //强制结束Excel进程
                    if (xlApp != null && pid > 0)
                    {
                        int ExcelProcess;
                        ExcelProcess = OpenProcess(PROCESS_VM_READ | PROCESS_VM_WRITE, false, pid);
                        //判断进程是否仍然存在
                        if (ExcelProcess > 0)
                        {
                            try
                            {
                                //通过进程ID,找到进程
                                System.Diagnostics.Process process = System.Diagnostics.Process.GetProcessById(pid);
                                //Kill 进程
                                process.Kill();
                            }
                            catch (Exception)
                            {
                                //强制结束Excel进程失败,可以记录一下日志.
                            }
                        }
                    }
                }
            }

            return rtn;
        }

        public static Boolean PrintExcel(Excel.Application xlApp, Excel.Workbook workbook)
        {
            bool rtn = false;

            //获取Excel App的句柄
            IntPtr hwnd = new IntPtr(xlApp.Hwnd);
            //通过Windows API获取Excel进程ID
            GetWindowThreadProcessId(hwnd, out pid);

            try
            {
                xlApp.Visible = false;
                xlApp.UserControl = true;
                xlApp.DisplayAlerts = false;

                workbook.PrintOut();

                //关闭Excel
                System.Windows.Forms.Application.DoEvents();
                xlApp.DisplayAlerts = false;
                xlApp.Visible = false;
                xlApp.Application.Quit();
                xlApp.Quit();

                MsgUtils.ShowInfoMsg("打印完成。");

                rtn = true;
            }
            catch (Exception ex)
            {
                rtn = false;
            }
            finally
            {
                //强制结束Excel进程
                if (xlApp != null && pid > 0)
                {
                    int ExcelProcess;
                    ExcelProcess = OpenProcess(PROCESS_VM_READ | PROCESS_VM_WRITE, false, pid);
                    //判断进程是否仍然存在
                    if (ExcelProcess > 0)
                    {
                        try
                        {
                            //通过进程ID,找到进程
                            System.Diagnostics.Process process = System.Diagnostics.Process.GetProcessById(pid);
                            //Kill 进程
                            process.Kill();
                        }
                        catch (Exception)
                        {
                            //强制结束Excel进程失败,可以记录一下日志.
                        }
                    }
                }
            }
            return rtn;
        }
        #endregion

        #region 动态生产菜单
        public static void CreateMenu(ref MenuStrip menuStrip)
        {
            // LoginUserInfo.LoginUser.menuFrom = (Form)currentForm;

            menuStrip.Font = new Font(menuStrip.Font.FontFamily, 10, menuStrip.Font.Style);
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
                LoginUserInfo.LoginUser.menuFrom.Hide();
                Form form = System.AppDomain.CurrentDomain.CreateInstanceFromAndUnwrap(Application.ExecutablePath, formName) as Form;
                form.Text = "生产管理系统 --> " + form.Text + "     (" + LoginUserInfo.LoginUser.loginUser.userName + "/" + LoginUserInfo.LoginUser.loginRole.roleName + ")";
                form.ShowDialog();
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

        #region 在主窗口中显示子窗口 废弃
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

        #region 退出程序
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
        #endregion

        #region 输入控制
        /// <summary>
        /// 仅限英文数字
        /// </summary>
        /// <param name="_char"></param>
        /// <returns></returns>
        public static Boolean IsOnlyEnNum(char _char)
        {
           if (char.IsDigit(_char) || char.IsLetter(_char))
            {
                return false;
            }

            if ( _char == 8 || _char == 45)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

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

        #region 权限判断
        public static bool IsAdmin(int _roleType)
        {
            if (_roleType == (int)Enum.EnumRoleType.Admin)
            {
                return true;
            }

            return false;
        }
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
        public static bool IsProducer(int _roleType)
        {
            if (_roleType == (int)Enum.EnumRoleType.Purducer)
            {
                return true;
            }
            if (_roleType == (int)Enum.EnumRoleType.Admin)
            {
                return true;
            }

            return false;
        }
        public static bool IsPurchaser(int _roleType)
        {
            if (_roleType == (int)Enum.EnumRoleType.Purchase)
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
