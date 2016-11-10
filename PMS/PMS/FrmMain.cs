using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.pnl_menu.Controls.Clear();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.TopLevel = false;
            this.pnl_menu.Controls.Add(frmMenu);
            frmMenu.Show();

        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
    
        }
    }
}
