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
    public partial class FrmSysFactoryDetail : Main.BaseForm
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
                    MsgUtils.ShowErrorMsg("请输入工厂名称！");
                    this.txt_name.Focus();
                    return;
                }

                //省
                if (this.cmb_province.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择省！");
                    this.cmb_province.Focus();
                    return;
                }
                //市
                if (this.cmb_city.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择市！");
                    this.cmb_city.Focus();
                    return;
                }
                //区
                if (this.cmb_district.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择区！");
                    this.cmb_district.Focus();
                    return;
                }
                //地址
                if (StringUtils.IsBlank(this.txt_address.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入地址！");
                    this.txt_address.Focus();
                    return;
                }

                if (m_mode == 0)
                {
                    if (m_bllFactory.GetFactoryByName(this.txt_name.Text.Trim()).id > 0)
                    {
                        MsgUtils.ShowErrorMsg("工厂已存在，请换个名称！");
                        this.txt_name.Focus();
                        return;
                    }
                }
            }

            ModelFactory factory = new ModelFactory();
            factory.id = m_factoryId;
            factory.name = this.txt_name.Text.Trim();
            factory.province = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_province.SelectedItem).itemKey);
            factory.city = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_city.SelectedItem).itemKey);
            factory.district = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_district.SelectedItem).itemKey);
            factory.provinceName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_province.SelectedItem).itemValue);
            factory.cityName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_city.SelectedItem).itemValue);
            factory.districtName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_district.SelectedItem).itemValue);
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
                    MsgUtils.ShowInfoMsg("创建工厂成功！");
                    m_mode = 1;
                    m_factoryId = m_bllFactory.GetFactoryByName(this.txt_name.Text.Trim()).id;
                    this.Hide();
                    return;
                }
                else
                {
                    MsgUtils.ShowErrorMsg("创建工厂失败！");
                    return;

                }
            }
            else if (m_mode == 1)
            {
                if (m_bllFactory.UpdateFactory(factory) == true)
                {
                    MsgUtils.ShowInfoMsg("修改工厂成功！");
                    this.Hide();
                    return;
                }
                else
                {
                    MsgUtils.ShowErrorMsg("修改工厂失败！");
                    return;
                }
            }
            else
            {
                if (m_bllFactory.DeleteFactory(factory) == true)
                {
                    MsgUtils.ShowInfoMsg("删除工厂成功！");
                    this.Hide();
                    return;
                }
                else
                {
                    MsgUtils.ShowErrorMsg("删除工厂失败！");
                    return;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回工厂列表
            this.Hide();
        }

        private void init()
        {
            //省市区
            WinCommon.BindComboBox(ref cmb_province, BllArea.GetProvince());
            WinCommon.BindComboBox(ref cmb_city, null);
            WinCommon.BindComboBox(ref cmb_district, null);

            //修改删除时，初始化页面
            if (m_mode > 0 && m_factoryId > 0)
            {
                ModelFactory factory = m_bllFactory.GetFactoryById(m_factoryId);

                this.txt_name.Text = factory.name;
                //省
                for (int i = 0; i < this.cmb_province.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_province.Items[i];
                    if (factory.province == (int)modelItem.itemKey)
                    {
                        this.cmb_province.SelectedIndex = i;
                        break;
                    }
                }

                //市
                for (int i = 0; i < this.cmb_city.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_city.Items[i];
                    if (factory.city == (int)modelItem.itemKey)
                    {
                        this.cmb_city.SelectedIndex = i;
                        break;
                    }
                }

                //区
                for (int i = 0; i < this.cmb_district.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_district.Items[i];
                    if (factory.district == (int)modelItem.itemKey)
                    {
                        this.cmb_district.SelectedIndex = i;
                        break;
                    }
                }

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

        private void FrmSysFactoryDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void cmb_province_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cmb_city.Items.Clear();
            this.cmb_district.Items.Clear();

            if (this.cmb_province.SelectedIndex < 0)
            {
                return;
            }

            int province = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_province.SelectedItem).itemKey);

            WinCommon.BindComboBox(ref this.cmb_city, BllArea.GetCity(province));
        }

        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cmb_district.Items.Clear();

            if (this.cmb_city.SelectedIndex < 0)
            {
                return;
            }

            int city = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_city.SelectedItem).itemKey);

            WinCommon.BindComboBox(ref this.cmb_district, BllArea.GetDistrict(city));
        }
    }
}
