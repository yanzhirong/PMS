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
    public partial class FrmSysFactoryDetail : Form
    {
        private BllFactory m_bllFactory = new BllFactory();

        //处理模式（0：新建；1：修改；2：删除）
        private int m_mode;
        //用户ID
        private int m_factoryId;

        public FrmSysFactoryDetail(int _mode, int _factoryId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_factoryId = _factoryId;
        }

        private void FrmSysFactoryDetail_Load(object sender, EventArgs e)
        {
            init();
        }


        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(m_mode != 2)
            {
                if (StringUtils.IsBlank(this.txt_name.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入仓库名称！");
                    this.txt_name.Focus();
                    return;
                }

                if (m_mode == 0)
                {
                    if (m_bllFactory.GetFactoryByName(this.txt_name.Text.Trim()).id > 0)
                    {
                        MsgUtils.ShowErrorMsg("仓库已存在，请换个名称！");
                        this.txt_name.Focus();
                        return;
                    }
                }
            }

            ModelFactory factory = new ModelFactory();
            factory.id = m_factoryId;
            factory.name = this.txt_name.Text.Trim();
            factory.address = this.txt_address.Text.Trim();
            factory.telphone = this.txt_telphone.Text.Trim();
            factory.fax = this.txt_fax.Text.Trim();
            factory.zip = this.txt_zip.Text.Trim();
            factory.isDelete = 0;
            factory.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            factory.createTime = DateTime.Now;
            factory.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            factory.modifyTime = DateTime.Now;

            if(m_mode == 0)
            {
                if (m_bllFactory.AddFactory(factory) == true)
                {
                    MsgUtils.ShowInfoMsg("创建仓库成功！");
                    m_mode = 1;
                    m_factoryId = m_bllFactory.GetFactoryByName(this.txt_name.Text.Trim()).id;
                    init();
                    return;
                }
                else
                {
                    MsgUtils.ShowErrorMsg("创建仓库失败！");
                    return;

                }
            }
            else if (m_mode == 1)
            {
                if (m_bllFactory.UpdateFactory(factory) == true)
                {
                    MsgUtils.ShowInfoMsg("修改仓库成功！");
                    return;
                }
                else
                {
                    MsgUtils.ShowErrorMsg("修改仓库失败！");
                    return;
                }
            }
            else
            {
                if (m_bllFactory.DeleteFactory(factory) == true)
                {
                    MsgUtils.ShowInfoMsg("删除仓库成功！");
                    Form form = new FrmSysFactory();
                    WinCommon.ShowInMain(ref form);
                    return;
                }
                else
                {
                    MsgUtils.ShowErrorMsg("删除仓库失败！");
                    return;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回仓库列表
            Form form = new FrmSysFactory();
            WinCommon.ShowInMain(ref form);
        }

        private void init()
        {            
            //标题
            if (m_mode == 0)
            {
                this.lbl_title.Text = "仓库管理-新增";
            }
            else if (m_mode == 1)
            {
                this.lbl_title.Text = "仓库管理-修改";
            }
            else
            {
                this.lbl_title.Text = "仓库管理-删除";
            }

            //修改删除时，初始化页面
            if (m_mode > 0 && m_factoryId > 0)
            {
                ModelFactory factory = m_bllFactory.GetFactoryById(m_factoryId);

                this.txt_name.Text = factory.name;
                this.txt_address.Text = factory.address;
                this.txt_telphone.Text = factory.telphone;
                this.txt_fax.Text = factory.fax;
                this.txt_zip.Text = factory.zip;
            }

            if (m_mode == 2)
            {
                grb_factory.Enabled = false;
            }
        }
    }
}
