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
    public partial class FrmLoginOut : Form
    {

        public FrmLoginOut()
        {
            InitializeComponent();
            WinCommon.Exit();
        }     

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }   
    }
}
