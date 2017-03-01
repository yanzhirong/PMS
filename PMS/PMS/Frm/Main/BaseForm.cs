using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.Frm.Main
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F10)
            {
                LoginUserInfo.LoginUser.currentFrom.Hide();
                Form form = new Main.FrmMain();
                form.ShowDialog();
            }

            if (e.KeyCode == Keys.F11)
            {
                LoginUserInfo.LoginUser.currentFrom.Hide();
                Form form = new Login.FrmLogin();
                form.ShowDialog();
            }
           
            if (e.KeyCode == Keys.F12)
            {
                LoginUserInfo.LoginUser.currentFrom.Hide();
                Form form = new Login.FrmLoginOut();
                form.ShowDialog();
            }

        }
    }
}
