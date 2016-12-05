using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.Frm.Product
{
    public partial class FrmProductManage : Form
    {
        public FrmProductManage()
        {
            InitializeComponent();
        }

        private void FrmProductManage_Load(object sender, EventArgs e)
        {
            WinCommon.CreateMenu(ref this.menuStrip1);
        }
    }
}
