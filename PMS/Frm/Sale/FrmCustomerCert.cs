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
using Bll;
using Common.Tools;
using System.IO;

namespace PMS.Frm.Sale
{
    public partial class FrmCustomerCert : Main.BaseForm
    {
        private int m_customerId;
        private string m_customerName;

        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmCustomerCert(int _customerId, string _customerName)
        {
            InitializeComponent();
            m_customerId = _customerId;
            m_customerName = _customerName;
        }

        private void FrmCustomerCert_Load(object sender, EventArgs e)
        {
            //初始化
            init();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {           

            //初始化
            if (m_customerId > 0)
            {

                //客户名称
                this.txt_name.Text = m_customerName;

                this.dataGridView1.DataSource = m_bllCustomer.GetCustomerCertsByCustomerId(m_customerId);
                this.dataGridView1.Refresh();

            }

            this.txt_new_certName.Text = "";
            this.txt_new_certPath.Text = "";
        }
        #endregion

        private void FrmCustomerCert_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btn_new_add_Click(object sender, EventArgs e)
        {
            if (StringUtils.IsBlank(this.txt_new_certName.Text))
            {
                MsgUtils.ShowErrorMsg("请输入凭证名称！");
                this.txt_new_certName.Focus();
                return;
            }

            if (StringUtils.IsBlank(this.txt_new_certPath.Text))
            {
                MsgUtils.ShowErrorMsg("请选择凭证图片！");
                this.txt_new_certPath.Focus();
                return;
            }

            ModelCustomerCert model = new ModelCustomerCert();
            model.customerId = m_customerId;
            model.certName = this.txt_new_certName.Text.Trim();
            FileStream fs = new FileStream(this.txt_new_certPath.Text, FileMode.Open);
            byte[] imageBytes = new byte[fs.Length];
            BinaryReader br = new BinaryReader(fs);
            model.certImage = br.ReadBytes(Convert.ToInt32(fs.Length));
            model.isDelete = 0;
            model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.createTime = DateTime.Now;

            if (m_bllCustomer.AddCustomerCert(model))
            {
                init();
                MsgUtils.ShowInfoMsg("新增客户凭证成功！");
            }
            else
            {
                MsgUtils.ShowErrorMsg("新增客户凭证失败！");
            }

            return;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "*jpg|*.JPG|*jpeg|*.JPEG|*.GIF|*.GIF|*.BMP|*.BMP|*.PNG|*.PNG";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txt_new_certPath.Text = this.openFileDialog1.FileName;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //查看
            if (dataGridView1.Columns[e.ColumnIndex].Name == "reviewBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmCustomerCertPic(id);
                form.ShowDialog();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;

                if (id > 0)
                {
                    if(MsgUtils.ShowQustMsg("确认删除此凭证么？", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ModelCustomerCert model = new ModelCustomerCert();
                        model.id = id;
                        model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                        model.modifyTime = DateTime.Now;
                        if (m_bllCustomer.DeleteCustomerCert(model))
                        {
                            init();
                            MsgUtils.ShowInfoMsg("删除客户凭证成功！");
                        }
                        else
                        {
                            MsgUtils.ShowErrorMsg("删除客户凭证失败！");
                        }
                    }
                }

            }
        }

 
    }
}
