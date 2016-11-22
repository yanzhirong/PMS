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

namespace PMS.Frm.Sys
{
    public partial class FrmSysUserDetail : Form
    {
        //处理模式（0：新建；1：修改；2：删除）
        private int m_mode;
        //用户ID
        private int m_userId;
        //修改之前的角色ID
        private int m_orgRoleId;

        private BllUser m_bllUser = new BllUser();
        private BllRole m_bllRole = new BllRole();

        public FrmSysUserDetail(int _mode, int _userId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_userId = _userId;
        }

        private void FrmSysUserDetail_Load(object sender, EventArgs e)
        {
             //初始化
            init();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回用户列表
            Form frmSysUser = new FrmSysUser();
            WinCommon.ShowInMain(ref frmSysUser);
        }

        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {           
            //标题
            if (m_mode == 0)
            {
                this.lbl_title.Text = "用户管理-新增";
            }
            else if (m_mode == 1)
            {
                this.lbl_title.Text =  "用户管理-修改";
            }
            else
            {
                this.lbl_title.Text = "用户管理-删除";
            }

            //角色下拉框
            List<ModelItem> listRole = m_bllRole.GetAllRoles();
            WinCommon.BindComboBox(ref cmb_role, listRole);
            //性别下拉框
            List<ModelItem> listSex = new List<ModelItem>();
            listSex.Add(new ModelItem("1", "男"));
            listSex.Add(new ModelItem("2", "女"));
            WinCommon.BindComboBox(ref cmb_sex, listSex);


            //初始化(修改或者删除时)
            if (m_mode != 0 && m_userId > 0)
            {
                ModelUser modelUser = m_bllUser.GetUserById(m_userId);

                //用户名
                this.txt_name.Text = modelUser.userName;

                //密码
                this.txt_pwd.Text = modelUser.pwd;
                this.txt_pwd2.Text = modelUser.pwd;

                //角色
                for (int i = 0; i < this.cmb_role.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem) this.cmb_role.Items[i];
                    if (modelUser.roleId == (int)modelItem.itemKey)
                    {
                        this.cmb_role.SelectedIndex = i;
                        break;
                    }
                }
                m_orgRoleId = modelUser.roleId;

                //性别
                for (int i = 0; i < this.cmb_sex.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_sex.Items[i];
                    if (modelUser.sex == modelItem.itemValue)
                    {
                        this.cmb_sex.SelectedIndex = i;
                        break;
                    }
                } 

                //职位
                this.txt_position.Text = modelUser.position;

                //手机
                this.txt_mobile.Text = modelUser.mobile;

                //邮箱
                this.txt_email.Text = modelUser.email;

                //生日
                this.dtp_birthday.Value = modelUser.birthday;
            }

            //删除时，输入项不能修改
            if (m_mode == 2)
            {   //用户名
                this.txt_name.Enabled = false;

                //密码
                this.txt_pwd.Enabled = false;
                this.txt_pwd2.Enabled = false;

                //角色
                this.cmb_role.Enabled = false;

                //性别
                this.cmb_sex.Enabled = false;

                //职位
                this.txt_position.Enabled = false;

                //手机
                this.txt_mobile.Enabled = false;

                //邮箱
                this.txt_email.Enabled = false;

                //生日
                this.dtp_birthday.Enabled = false;
            }
        }
        #endregion

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        private void doSubmit()
        {
            Boolean rtn = false;

            //检查
            if (doCheck() == false)
            {
                return ;
            }

            ModelUser modelUser = new ModelUser();
            modelUser.userId = m_userId;
            modelUser.userName = this.txt_name.Text;
            modelUser.pwd = this.txt_pwd.Text;
            modelUser.roleId = (int)((ModelItem)this.cmb_role.SelectedItem).itemKey;
            modelUser.sex = ((ModelItem)this.cmb_sex.SelectedItem).itemValue;
            modelUser.position = this.txt_position.Text;
            modelUser.mobile = this.txt_mobile.Text;
            modelUser.email = this.txt_email.Text;
            modelUser.birthday = this.dtp_birthday.Value;
            modelUser.isDelete = 0;
            modelUser.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelUser.createTime = DateTime.Now;
            modelUser.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelUser.modifyTime = DateTime.Now;

            //新增用户
            if (m_mode == 0) 
            {
                rtn = m_bllUser.AddUser(modelUser);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("新增用户失败！");
                    return ;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("新增用户成功！");
                }

                //处理模式变为修改
                m_mode = 1;
                m_userId = m_bllUser.GetUserByName(this.txt_name.Text).userId;

                init();

                return;
            }

            //修改用户
            if (m_mode == 1)
            {
                rtn = m_bllUser.UpdateUser(modelUser, m_orgRoleId);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("修改用户失败！");
                    return;
                }

                if(LoginUserInfo.LoginUser.loginUser.userId == m_userId)
                {
                    MsgUtils.ShowInfoMsg("账号已修改，请重新登录。");
                    this.Parent.Parent.Hide();
                    Form frmLogin = new Frm.Login.FrmLogin();
                    frmLogin.Show();
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("修改用户成功！");
                    init();
                    return;
                }
            }

            //删除用户
            if(m_mode == 2)
            {
                rtn = m_bllUser.DeleteUser(modelUser);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("删除用户失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("删除用户成功！");

                    //返回用户列表
                    Form frmSysUser = new FrmSysUser();
                    WinCommon.ShowInMain(ref frmSysUser);
                    return;
                }
            }
        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean doCheck()
        {
            // 新增或修改用户
            if (m_mode == 0 || m_mode == 1)
            {

                //名称
                if (StringUtils.IsBlank(this.txt_name.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入用户名！");
                    this.txt_name.Focus();
                    return false;
                }
                ModelUser user = m_bllUser.GetUserByName(this.txt_name.Text);
                if(user.userId > 0 && user.userId != m_userId)
                {
                    MsgUtils.ShowErrorMsg("该用户已存在！");
                    this.txt_name.Focus();
                    return false;
                }

                //密码
                if (StringUtils.IsBlank(this.txt_pwd.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入密码！");
                    this.txt_pwd.Focus();
                    return false;
                }
                if (StringUtils.IsBlank(this.txt_pwd2.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入确认密码！");
                    this.txt_pwd2.Focus();
                    return false;
                }
                if (this.txt_pwd.Text != this.txt_pwd2.Text)
                {
                    MsgUtils.ShowErrorMsg("2次密码不一致！");
                    this.txt_pwd.Focus();
                    return false;
                }

                //角色
                if (this.cmb_role.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择角色！");
                    this.cmb_role.Focus();
                    return false;
                }
            }
            else
            {
                if (m_userId == LoginUserInfo.LoginUser.loginUser.userId)
                {
                    MsgUtils.ShowErrorMsg("不允许删除当前登录用户！");
                    return false;
                }
            }
            return true;
        }
        #endregion

    }
}
