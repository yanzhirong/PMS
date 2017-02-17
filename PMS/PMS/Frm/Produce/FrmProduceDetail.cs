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

namespace PMS.Frm.Produce
{
    public partial class FrmProduceDetail : Form
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看）
        private int m_mode;
        private int m_produceId;

        private BllProduct m_bllProduct = new BllProduct();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();
        private BllProduce m_bllProduce = new BllProduce();

        public FrmProduceDetail(int _mode, int _produceId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_produceId = _produceId;
        }

        private void FrmProduceDetail_Load(object sender, EventArgs e)
        {
            //初始化
            init();
        }

        private void FrmProduceDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            doSubmit(true);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回列表
            this.Hide();
        }
                
        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {
            //下拉框
            //状态
            List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.ProduceStatus, false);
            if (m_mode != 3)
            {
                listItem.RemoveAt(listItem.Count - 1);
            }
            WinCommon.BindComboBox(ref this.cmb_status, listItem);
            //申请者
            listItem = m_bllUser.GetUsersWithItem();
            WinCommon.BindComboBox(ref cmb_applyBy, listItem);
            //产品
            listItem = m_bllProduct.GetProductItem("");
            WinCommon.BindComboBox(ref this.cmb_product, listItem);
            //工厂
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem);
 
            //初始化数据
            if (m_mode != 0 && m_produceId > 0)
            {
                ModelProduce model = m_bllProduce.GetProduceById(m_produceId);

                //生产编号
                this.txt_produceCode.Text = model.produceCode;

                //状态
                for (int i = 0; i < this.cmb_status.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_status.Items[i];
                    if (model.status == (int)modelItem.itemKey)
                    {
                        this.cmb_status.SelectedIndex = i;
                        break;
                    }
                }

                //申请者
                for (int i = 0; i < this.cmb_applyBy.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_applyBy.Items[i];
                    if (model.applyBy == modelItem.itemValue)
                    {
                        this.cmb_applyBy.SelectedIndex = i;
                        break;
                    }
                }
                //登陆者作为申请者
                if (this.cmb_applyBy.SelectedIndex < 0)
                {
                    for (int i = 0; i < this.cmb_applyBy.Items.Count; i++)
                    {
                        ModelItem modelItem = (ModelItem)this.cmb_applyBy.Items[i];
                        if (LoginUserInfo.LoginUser.loginUser.userId == (int)modelItem.itemKey)
                        {
                            this.cmb_applyBy.SelectedIndex = i;
                            break;
                        }
                    }
                }

                //申请日期
                this.dtp_applyDate.Value = ConvertUtils.ConvertToDate(model.applyDate, "yyyy-MM-dd");

                //产品
                for (int i = 0; i < this.cmb_product.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_product.Items[i];
                    if (model.productId == (int)modelItem.itemKey)
                    {
                        this.cmb_product.SelectedIndex = i;
                        break;
                    }
                }

                //工厂
                for (int i = 0; i < this.cmb_factory.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_factory.Items[i];
                    if (model.factoryId == (int)modelItem.itemKey)
                    {
                        this.cmb_factory.SelectedIndex = i;
                        break;
                    }
                }

                //数量
                this.txt_num.Text = model.num.ToString();

                //交货日期
                this.dtp_deliveryDate.Value = ConvertUtils.ConvertToDate(model.deliveryDate, "yyyy-MM-dd");

                //备注
                this.txt_remark.Text = model.remark;

            }

            //按钮处理
            this.btn_submit.Visible = true;
            this.btn_cancel.Visible = true;
            this.btn_close.Visible = false;
            if (m_mode == 3)
            {
                this.btn_submit.Visible = false;
                this.btn_cancel.Visible = false;
                this.btn_close.Visible = true;            
            }

            //新增修改时
            if (m_mode == 0 || m_mode == 1)
            {
                grb_produce.Enabled = true;
            }
            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                grb_produce.Enabled = false;
            }

        }
        #endregion

        #region 提交
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        private Boolean doSubmit(bool showMsg)
        {
            Boolean rtn = false;

            //检查
            if (doCheck() == false)
            {
                return false;
            }

            ModelProduce model = new ModelProduce();
            model.id = m_produceId;
            model.produceCode = this.txt_produceCode.Text.Trim();

            model.status = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_status.SelectedItem).itemKey);

            model.applyBy = ((ModelItem)this.cmb_applyBy.SelectedItem).itemValue;
            model.applyDate = this.dtp_applyDate.Value;

            model.productId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_product.SelectedItem).itemKey);
            model.factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            model.num = ConvertUtils.ConvertToInt(this.txt_num.Text.Trim());
            model.deliveryDate = this.dtp_deliveryDate.Value;

            model.remark = this.txt_remark.Text.Trim();

            model.isDelete = 0;
            model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.createTime = DateTime.Now;
            model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllProduce.AddProduce(model);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("新增生产单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("新增生产单成功！");
                    }

                    this.Hide();
                    return true;
                }
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllProduce.UpdateProduce(model);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("修改生产单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("修改生产单成功！");
                    }
                    this.Hide();
                    return true;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllProduce.DeleteProduce(model);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("删除生产单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("删除生产单成功！");
                    }
                    //返回列表
                    this.Hide();
                    return true;
                }
            }

            return true;
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

                //状态
                if (this.cmb_status.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择生产状态！");
                    this.cmb_status.Focus();
                    return false;
                }

                // 申请人
                if (this.cmb_applyBy.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择申请人！");
                    this.cmb_applyBy.Focus();
                    return false;
                }

                //产品
                if (this.cmb_product.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择产品！");
                    this.cmb_product.Focus();
                    return false;
                }

                //工厂
                if (this.cmb_factory.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择工厂！");
                    this.cmb_factory.Focus();
                    return false;
                }
                
                //数量
                decimal num = ConvertUtils.ConvertToDecimal(this.txt_num.Text.Trim());
                if (num <= 0)
                {
                    MsgUtils.ShowErrorMsg("请输入合适的生产数量！");
                    this.txt_num.Focus();
                    return false;
                }

            }

            return true;
        }
        #endregion

        private void btn_close_Click(object sender, EventArgs e)
        {
            //返回列表
            this.Hide();
        }
    }
}
