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

namespace PMS.Frm.Sys
{
    public partial class FrmSysConfig : Form
    {
        private BllCode m_bllCode = new BllCode();

        public FrmSysConfig()
        {
            InitializeComponent();
        }

        private void FrmSysUser_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            init();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            //检查
            if(StringUtils.IsBlank(this.txt_newParam.Text))
            {
                MsgUtils.ShowErrorMsg("请输入参数名！");
                this.txt_newParam.Focus();
                return;
            }

            if (m_bllCode.GetCodeByName(this.txt_newParam.Text).id > 0)
            {
                MsgUtils.ShowErrorMsg("参数名已存在！");
                this.txt_newParam.Focus();
                return;
            }

            ModelCode modelCode = new ModelCode();
            modelCode.remark = this.txt_newParam.Text.Trim();
            modelCode.isDelete = 0;
            modelCode.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelCode.createTime = DateTime.Now;
            modelCode.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelCode.modifyTime = DateTime.Now;

            if (m_bllCode.AddCode(modelCode) == true)
            {
                MsgUtils.ShowInfoMsg("新增参数成功！");
                init();
                return;
            }
            else
            {
                MsgUtils.ShowErrorMsg("新增参数失败！");
                return;
            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void init()
        {
            //参数下拉框
            List<ModelItem> listItem = m_bllCode.GetAllCodeName();
            WinCommon.BindComboBox(ref cmb_code, listItem);

            this.txt_newParam.Text = "";

            DataTable dt = m_bllCode.GetCodeList(0);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();

            this.btn_submit.Enabled = false;

            this.dataGridView1.AllowUserToAddRows = false;

        }

        private void cmb_code_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = this.cmb_code.SelectedItem == null ? 0 : (int)((ModelItem)this.cmb_code.SelectedItem).itemKey;

            if (code > 0)
            {
                DataTable dt = m_bllCode.GetCodeList(code);
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Refresh();

                this.btn_submit.Enabled = true;
                this.dataGridView1.AllowUserToAddRows = true;
            }
            else
            {
                DataTable dt = m_bllCode.GetCodeList(0);
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Refresh();
                this.btn_submit.Enabled = false;
                this.dataGridView1.AllowUserToAddRows = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回
            WinCommon.ReturnMain();

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            int code = this.cmb_code.SelectedItem == null ? 0 : (int)((ModelItem)this.cmb_code.SelectedItem).itemKey;

            if (code <= 0)
            {
                MsgUtils.ShowErrorMsg("请选择参数！");
                this.cmb_code.Focus();
                return;
            }

            List<ModelCode> listCode = new List<ModelCode>();

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                ModelCode modelCode = new ModelCode();

                modelCode.id = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[0].Value);
                modelCode.code = code;
                modelCode.subCode = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[i].Cells[2].Value); ;
                modelCode.value1 = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells[3].Value);
                modelCode.value2 = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells[4].Value);
                modelCode.value3 = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells[5].Value);
                modelCode.remark = ConvertUtils.ConvertToString(this.dataGridView1.Rows[i].Cells[6].Value);
                modelCode.isDelete = 0;
                modelCode.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                modelCode.createTime = DateTime.Now;
                modelCode.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                modelCode.modifyTime = DateTime.Now;

                if (StringUtils.IsBlank(modelCode.value1) && StringUtils.IsBlank(modelCode.value2) && StringUtils.IsBlank(modelCode.value3))
                {
                    continue;
                }
                listCode.Add(modelCode);
            }

            if(m_bllCode.UpdateCode(listCode) == true)
            {
                MsgUtils.ShowInfoMsg("参数更新成功！");
                init();
                return;
            }else{
                MsgUtils.ShowErrorMsg("参数更新失败！");
                return;
            }
        }

        private void FrmSysConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

 
    }
}
