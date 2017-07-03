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

            if (e.KeyCode == Keys.F1)
            {
                CloseAllForm();
                Form form = new Sys.FrmSysUserDetail(9, LoginUserInfo.LoginUser.loginUser.userId);
                form.ShowDialog();
            }

            if (e.KeyCode == Keys.F2)
            {
                CloseAllForm();
                Form form = new Main.FrmTask(0);
                form.ShowDialog();
            }

            if (e.KeyCode == Keys.F10)
            {
                CloseAllForm();
                Form form = new Main.FrmMain();
                form.ShowDialog();
            }

            if (e.KeyCode == Keys.F11)
            {
                CloseAllForm();
                Form loginForm = new Login.FrmLogin();
                loginForm.ShowDialog();
            }
           
            if (e.KeyCode == Keys.F12)
            {
                LoginUserInfo.LoginUser.menuFrom.Hide();
                Form form = new Login.FrmLoginOut();
                form.ShowDialog();
            }

        }

        private  void CloseAllForm()
        {
            FormCollection collection = Application.OpenForms;

            foreach (Form form in collection)
            {
                form.Hide();
            }
        }
    }
}
