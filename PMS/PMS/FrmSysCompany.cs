using Bll;
using Model;
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

namespace PMS
{
    public partial class FrmSysCompany : Form
    {
        private BllCompany m_bllCompany = new BllCompany();

        public FrmSysCompany()
        {
            InitializeComponent();
        }

        private void FrmSysUser_Load(object sender, EventArgs e)
        {
            //获取公司信息
            ModelCompany company = m_bllCompany.GetCompany();

            //初始化
            this.txt_id.Text = company.id.ToString();
            this.txt_name.Text = company.name;
            this.txt_address.Text = company.address;
            this.txt_telphone.Text = company.telphone;
            this.txt_homepage.Text = company.homepage;
            this.txt_email.Text = company.email;
            this.txt_fax.Text = company.fax;
            this.txt_zip.Text = company.zip;

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            if (StringUtils.IsBlank(this.txt_name.Text))
            {
                MsgUtils.ShowErrorMsg("请输入公司名称！");
                this.txt_name.Focus();
                return;
            }

            if (MsgUtils.ShowQustMsg("是否确认修改公司信息？", MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                ModelCompany company = new ModelCompany();
                company.id =  Convert.ToInt16(this.txt_id.Text);
                company.name = this.txt_name.Text;
                company.address = this.txt_address.Text;
                company.telphone = this.txt_telphone.Text;
                company.homepage = this.txt_homepage.Text;
                company.email = this.txt_email.Text;
                company.fax = this.txt_fax.Text;
                company.zip = this.txt_zip.Text;

                if (m_bllCompany.UpdatecCompany(company))
                {
                    MsgUtils.ShowInfoMsg("更新公司信息成功！");
                }
                else
                {
                    MsgUtils.ShowErrorMsg("更新公司信息失败！");
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回
            WinCommon.ReturnMain();
        }
    }
}
