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

namespace PMS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //this.pnl_main.Controls.Clear();
            //FrmMenu frmMenu = new FrmMenu();
            //frmMenu.TopLevel = false;
            //this.pnl_main.Controls.Add(frmMenu);
            //frmMenu.Show();


            //CreateMenuUtils.CreateMenu(ref menuStrip);

            CreateMenu();
            LoginUserInfo.LoginUser.mainPanel = this.pnl_main;
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {

        }

        private void CreateMenu()
        {
            menuStrip.Items.Clear();

            if (LoginUserInfo.LoginUser.loginMenu != null && LoginUserInfo.LoginUser.loginMenu.Count > 0)
            {
                foreach (ModelMenu menu in LoginUserInfo.LoginUser.loginMenu)
                {
                    // 一级菜单
                    if (menu.parentId == 0)
                    {
                        ToolStripMenuItem mi = new ToolStripMenuItem();
                        mi.Text = menu.menuName;
                        CreateMenuItem(mi, menu.menuId);
                        menuStrip.Items.Add((ToolStripItem)mi);
                    }
                }
            }
        }
        private void CreateMenuItem(ToolStripMenuItem mi, int parentId)
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

        private void BindClickToInstinse(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = sender as ToolStripMenuItem;
            if (mi.HasDropDownItems)//如果有下一级目录就不实例化
            {
                return;
            }
            string formName = mi.Tag as string;
            try
            {
                Form form = System.AppDomain.CurrentDomain.CreateInstanceFromAndUnwrap(Application.ExecutablePath, formName) as Form;
                WinCommon.ShowInMain(ref form);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }
    }
}
