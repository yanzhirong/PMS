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
    public partial class FrmSysConfig : Form
    {
        private BllCode m_bllCode = new BllCode();

        public FrmSysConfig()
        {
            InitializeComponent();
        }

        private void FrmSysUser_Load(object sender, EventArgs e)
        {
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

        }

        private void cmb_code_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = (int)((ModelItem)this.cmb_code.SelectedItem).itemKey;

            if (code > 0)
            {
                DataTable dt = m_bllCode.GetCodeList(code);
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Refresh();
            }
        }

 
    }
}
