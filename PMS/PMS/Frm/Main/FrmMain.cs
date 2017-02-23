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
using Common.Tools;

namespace PMS.Frm.Main
{
    public partial class FrmMain : Form
    {
        int x_start = 0;
        int y_start = 0;
        int x_count = 0;
        int y_count = 0;
        int x_max_count = 5;
        //int y_max_count = 5;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //显示登录者信息
            this.Text = "生产管理系统      (" + LoginUserInfo.LoginUser.loginUser.userName + "/" + LoginUserInfo.LoginUser.loginRole.roleName + ")";
            //动态生成菜单
            CreateMenu();
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            this.pnl_main.Left = (this.Width - this.pnl_main.Width) / 2;
            this.pnl_main.Top = (this.Height - this.pnl_main.Height) / 2;
        }

        #region 生成菜单 已废弃
        private void CreateMenu()
        {

            if (LoginUserInfo.LoginUser.loginMenu != null && LoginUserInfo.LoginUser.loginMenu.Count > 0)
            {
                foreach (ModelMenu menu in LoginUserInfo.LoginUser.loginMenu)
                {
                    // 一级菜单
                    if (menu.parentId == 0 && StringUtils.IsNotBlank(menu.checkBoxName))
                    {
                        Label label = new Label();
                        label.AutoSize = true;
                        label.Font = new Font(label.Font.FontFamily, 13, label.Font.Style);
                        label.Text = menu.menuName;
                        label.Location = GetPoint(true);
                        this.pnl_main.Controls.Add(label);
                        CreateMenuItem(menu.menuId);
                    }
                }
            }
        }
        private void CreateMenuItem(int parentId)
        {
            foreach (ModelMenu menu in LoginUserInfo.LoginUser.loginMenu)
            {
                // 二级菜单
                if (menu.parentId == parentId)
                {
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.AutoSize = true;
                    linkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
                    linkLabel.Text = "•" + menu.menuName.Trim();
                    linkLabel.Tag = menu.formName.Trim();
                    linkLabel.Click += new EventHandler(BindClickToInstinse);
                    linkLabel.Location = GetPoint(false);
                    this.pnl_main.Controls.Add(linkLabel);
                }
            }
        }

        private void BindClickToInstinse(object sender, EventArgs e)
        {
            LinkLabel linkLabel = sender as LinkLabel;

            string formName = linkLabel.Tag as string;
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

        private Point GetPoint(bool _isFather)
        {
            Point point = new Point();

            //换列
            if (_isFather)
            {
                x_count = x_count + 1;

                if (x_count % x_max_count == 0)
                {
                    x_start = 80;
                }
                else
                {
                    if (x_count / x_max_count == 0)
                    {
                        x_start = ((x_count -1) % x_max_count) * 150 + 80; ;
                    }
                    else
                    {
                        x_start = (x_count % x_max_count) * 150 + 80;
                    }
                }

                y_start = (x_count / x_max_count) * 200 + 30;

                this.pnl_main.Height = (x_count / x_max_count) * 200 + 220;

                if (x_count < x_max_count)
                {
                    this.pnl_main.Width = x_count * 150 + 100;
                }
            }
            else
            {
                y_start = y_start + 30;
            }

            if (_isFather)
            {
                point.X = x_start;
            }
            else
            {
                point.X = x_start + 5;
            }
            point.Y = y_start;

            return point;
        }
        #endregion

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

    }
}
