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

namespace PMS.Frm.Sale
{
    public partial class FrmOrderDetail : Form
    {
        //处理模式（0：新建；1：修改；2：删除）
        private int m_mode;
        //原来ID
        private int m_customerId;

        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmOrderDetail(int _mode, int _customerId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_customerId = _customerId;
        }

        private void FrmCustomerDetail_Load(object sender, EventArgs e)
        {
            LoginUserInfo.LoginUser.currentFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //登录者是销售
            if (LoginUserInfo.LoginUser.loginRole.roleType == 1)
            {
                if (m_mode == 0)
                {
                    for (int i = 0; i < this.cmb_saler.Items.Count; i++)
                    {
                        if (LoginUserInfo.LoginUser.loginUser.userId == (int)((ModelItem)this.cmb_saler.Items[i]).itemKey)
                        {
                            this.cmb_saler.SelectedIndex = i;
                        }
                    }
                }

                this.cmb_customer.SelectedIndex = 1;
                this.cmb_customer.Enabled = false;

                this.cmb_saler.Enabled = false;
            }
            else if (LoginUserInfo.LoginUser.loginRole.roleType == 2)  //登录者是采购
            {
                this.cmb_customer.SelectedIndex = 2;
                this.cmb_customer.Enabled = false;

                this.lbl_saler.Visible = false;
                this.cmb_saler.Visible = false;
            }
            
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
            Form form = new FrmCustomerManage();
            this.Hide();
            form.ShowDialog();
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
                this.lbl_title.Text = "客户信息设定-新增";
            }
            else if (m_mode == 1)
            {
                this.lbl_title.Text = "客户信息设定-修改";
            }
            else
            {
                this.lbl_title.Text = "客户信息设定-删除";
            }

            //下拉框
            //销售
            List<ModelItem> listItem = m_bllUser.GetUserGroupByRoleType(1);
            WinCommon.BindComboBox(ref cmb_saler, listItem);
            //省市区
            WinCommon.BindComboBox(ref cmb_province, BllArea.GetProvince());
            WinCommon.BindComboBox(ref cmb_city, null);
            WinCommon.BindComboBox(ref cmb_district, null);

            //初始化(修改或者删除时)
            if (m_mode != 0 && m_customerId > 0)
            {
                ModelCustomer model = m_bllCustomer.GetCustomerById(m_customerId);

                //客户类型
                this.cmb_customer.SelectedIndex = model.type;

                //销售
                for (int i = 0; i < this.cmb_saler.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_saler.Items[i];
                    if (model.salerId == (int)modelItem.itemKey)
                    {
                        this.cmb_saler.SelectedIndex = i;
                        break;
                    }
                }

                //代码
                this.txt_orderCode.Text = model.code;

                //名称
                this.txt_name.Text = model.name;

                //省
                for (int i = 0; i < this.cmb_province.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_province.Items[i];
                    if (model.province == (int)modelItem.itemKey)
                    {
                        this.cmb_province.SelectedIndex = i;
                        break;
                    }
                }

                //市
                for (int i = 0; i < this.cmb_city.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_city.Items[i];
                    if (model.city == (int)modelItem.itemKey)
                    {
                        this.cmb_city.SelectedIndex = i;
                        break;
                    }
                }

                //区
                for (int i = 0; i < this.cmb_district.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_district.Items[i];
                    if (model.district == (int)modelItem.itemKey)
                    {
                        this.cmb_district.SelectedIndex = i;
                        break;
                    }
                }
                //地址
                this.txt_address.Text = model.address;
                //联系电话
                this.txt_telephone1.Text = model.telephone1;
                //备用电话
                this.txt_telephone2.Text = model.telephone2;
                //传真
                this.txt_fax.Text = model.fax;
                //邮编
                this.txt_zip.Text = model.zip;
                //联系人
                this.txt_manager.Text = model.manager;
                //职位
                this.txt_position.Text = model.position;
                //手机
                this.txt_mobile.Text = model.mobile;
                //备注
                this.txt_remark.Text = model.remark;
                //信用额度
                this.txt_creditLimit.Text = model.creditLimit.ToString();
            }

            //删除时，输入项不能修改
            if (m_mode == 2)
            {
                grb_customer.Enabled = false;
            }
            else
            {
                grb_customer.Enabled = true;
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

            ModelCustomer modelCustomer = new ModelCustomer();
            modelCustomer.id = m_customerId;
            modelCustomer.code = this.txt_orderCode.Text.Trim();
            modelCustomer.name = this.txt_name.Text.Trim();
            modelCustomer.type = this.cmb_customer.SelectedIndex;
            modelCustomer.salerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_saler.SelectedItem).itemKey);

            modelCustomer.province = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_province.SelectedItem).itemKey);
            modelCustomer.city = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_city.SelectedItem).itemKey);
            modelCustomer.district = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_district.SelectedItem).itemKey);
            modelCustomer.provinceName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_province.SelectedItem).itemValue);
            modelCustomer.cityName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_city.SelectedItem).itemValue);
            modelCustomer.districtName = ConvertUtils.ConvertToString(((ModelItem)this.cmb_district.SelectedItem).itemValue);
            modelCustomer.address = this.txt_address.Text.Trim();

            modelCustomer.telephone1 = this.txt_telephone1.Text.Trim();
            modelCustomer.telephone2 = this.txt_telephone2.Text.Trim();
            modelCustomer.fax = this.txt_fax.Text.Trim();
            modelCustomer.zip = this.txt_zip.Text.Trim();

            modelCustomer.manager = this.txt_manager.Text.Trim();
            modelCustomer.position = this.txt_position.Text.Trim();
            modelCustomer.mobile = this.txt_mobile.Text.Trim();

            modelCustomer.remark = this.txt_remark.Text.Trim();
            modelCustomer.creditLimit = ConvertUtils.ConvertToDecimal(this.txt_creditLimit.Text.Trim());

            modelCustomer.isDelete = 0;
            modelCustomer.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelCustomer.createTime = DateTime.Now;
            modelCustomer.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelCustomer.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllCustomer.AddCustomer(modelCustomer);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("新增客户失败！");
                    return ;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("新增客户成功！");
                }

                //处理模式变为修改
                m_mode = 1;
                m_customerId = m_bllCustomer.GetCustomerByCode(this.txt_orderCode.Text).id;

                init();

                return;
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllCustomer.UpdateCustomer(modelCustomer);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("修改客户失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("修改客户成功！");
                    init();
                    return;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllCustomer.DeleteCustomer(modelCustomer);

                if (rtn == false)
                {
                    MsgUtils.ShowErrorMsg("删除客户失败！");
                    return;
                }
                else
                {
                    MsgUtils.ShowInfoMsg("删除客户成功！");

                    //返回用户列表
                    Form form = new FrmCustomerManage();
                    this.Hide();
                    form.ShowDialog();
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
            // 新增或修改
            if (m_mode == 0 || m_mode == 1)
            {
                //类型
                if (this.cmb_customer.SelectedIndex <= 0)
                {
                    MsgUtils.ShowErrorMsg("请选择客户类型！");
                    this.cmb_customer.Focus();
                    return false;
                }

                //销售(销售客户时必须)
                if(this.cmb_customer.SelectedIndex == 1)
                {
                    if(this.cmb_saler.SelectedIndex < 0)
                    {
                        MsgUtils.ShowErrorMsg("请选择销售！");
                        this.cmb_saler.Focus();
                        return false;
                    }
                }
                //代码
                if (StringUtils.IsBlank(this.txt_orderCode.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入客户代码！");
                    this.txt_orderCode.Focus();
                    return false;
                }
                ModelCustomer  customer = m_bllCustomer.GetCustomerByCode(this.txt_orderCode.Text);
                if (customer.id > 0 && customer.id != m_customerId)
                {
                    MsgUtils.ShowErrorMsg("该客户已存在！");
                    this.txt_orderCode.Focus();
                    return false;
                }

                //名称
                if (StringUtils.IsBlank(this.txt_name.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入客户名称！");
                    this.txt_name.Focus();
                    return false;
                }

                //省
                if (this.cmb_province.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择省！");
                    this.cmb_province.Focus();
                    return false;
                }
                //市
                if (this.cmb_city.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择市！");
                    this.cmb_city.Focus();
                    return false;
                }
                //区
                if (this.cmb_district.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择区！");
                    this.cmb_district.Focus();
                    return false;
                }
                //地址
                if (StringUtils.IsBlank(this.txt_address.Text))
                {
                    MsgUtils.ShowErrorMsg("请输入客户地址！");
                    this.txt_address.Focus();
                    return false;
                }
            }

            return true;
        }
        #endregion

        private void FrmOrderDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void txt_creditLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //仅限数字
            e.Handled = WinCommon.IsOnlyDouble(e.KeyChar);
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

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            int type = this.cmb_customer.SelectedIndex;
            if (type != 1)
            {
                this.lbl_saler.Visible = false;
                this.cmb_saler.Visible = false;
            }
            else
            {
                this.lbl_saler.Visible = true;
                this.cmb_saler.Visible = true;
            }
        }

    }
}
