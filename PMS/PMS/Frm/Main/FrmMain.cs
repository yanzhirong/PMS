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
        string iconFolder = "";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            iconFolder = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")) + "\\";

            //显示登录者信息
            this.Text = "生产管理系统      (" + LoginUserInfo.LoginUser.loginUser.userName + "/" + LoginUserInfo.LoginUser.loginRole.roleName + ")";
            //动态生成菜单
            CreateMenu();
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //this.pnl_main.Left = (this.Width - this.pnl_main.Width) / 2;
            //this.pnl_main.Top = (this.Height - this.pnl_main.Height) / 2;
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
                        Point point = GetPoint(true);
                        if (StringUtils.IsNotBlank(menu.iconPath))
                        {
                            PictureBox pb = new PictureBox();
                            pb.Width = 35;
                            pb.Height = 35;
                            pb.SizeMode = PictureBoxSizeMode.Zoom;
                            pb.Image = new Bitmap(iconFolder + menu.iconPath); ;
                            pb.Location = new Point(point.X, point.Y);
                            this.pnl_main.Controls.Add(pb);
                        }
                        Label label = new Label();
                        label.AutoSize = true;
                        label.Font = new Font(label.Font.FontFamily, 13, label.Font.Style);
                        label.Text = menu.menuName;
                        label.Location = new Point(point.X + 40, point.Y+5);
                        //label.Location = GetPoint(true);
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
                    Point point = GetPoint(false);
                    if (StringUtils.IsNotBlank(menu.iconPath))
                    {
                        PictureBox pb = new PictureBox();
                        pb.Width = 25;
                        pb.Height = 25;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Image = new Bitmap(iconFolder + menu.iconPath); ;
                        pb.Location = new Point(point.X, point.Y);
                        this.pnl_main.Controls.Add(pb);
                    }
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.AutoSize = true;
                    linkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
                    //linkLabel.Text = "•" + menu.menuName.Trim();
                    linkLabel.Text = menu.menuName.Trim();
                    linkLabel.Font = new Font(linkLabel.Font.FontFamily, 11, linkLabel.Font.Style);
                    linkLabel.Tag = menu.formName.Trim();
                    linkLabel.Click += new EventHandler(BindClickToInstinse);
                    linkLabel.Location = new Point(point.X + 25, point.Y+8);
                    //linkLabel.Location = GetPoint(false);
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
                    x_start = 20;
                }
                else
                {
                    if (x_count / x_max_count == 0)
                    {
                        x_start = ((x_count -1) % x_max_count) * 180 + 20;
                    }
                    else
                    {
                        x_start = (x_count % x_max_count) * 180 + 20;
                    }
                }

                y_start = (x_count / x_max_count) * 250 + 30;

                //this.pnl_main.Height = (x_count / x_max_count) * 200 + 220;

                //if (x_count < x_max_count)
                //{
                //    this.pnl_main.Width = x_count * 180 + 100;
                //}
            }
            else
            {
                y_start = y_start + 38;
            }

            if (_isFather)
            {
                point.X = x_start;
            }
            else
            {
                point.X = x_start + 20;
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
