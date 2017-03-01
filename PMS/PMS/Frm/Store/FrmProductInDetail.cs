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

namespace PMS.Frm.Store
{
    public partial class FrmProductInDetail : Main.BaseForm
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看）
        private int m_mode;
        private int m_productInId;
        private string m_inputCode;

        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllProduce m_bllProduce = new BllProduce();
        private BllProduct m_bllProduct = new BllProduct();
        private BllProductIn m_bllProductIn = new BllProductIn();
        private BllFactory m_bllFactory = new BllFactory();
        private BllCode m_bllCode = new BllCode();

        public FrmProductInDetail(int _mode, int _productInId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_productInId = _productInId;
        }

        private void FrmProductInDetail_Load(object sender, EventArgs e)
        {           
            //初始化
            init();
        }

        private void FrmProductInDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
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
            //入库类型
            List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.ProductInputType, false);
            WinCommon.BindComboBox(ref this.cmb_inputType, listItem, false);
            //入库产品
            listItem = m_bllProduct.GetProductItem("");
            WinCommon.BindComboBox(ref this.cmb_product, listItem);
            //入库工厂
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem);

            //初始化数据
            if (m_mode != 0 && m_productInId > 0)
            {

                ModelProductIn model = m_bllProductIn.GetProductInById(m_productInId);

                //入库单号
                m_inputCode = model.inputCode;

                //入库类型
                for (int i = 0; i < this.cmb_inputType.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_inputType.Items[i];
                    if (model.inputType == (int)modelItem.itemKey)
                    {
                        this.cmb_inputType.SelectedIndex = i;
                        break;
                    }
                }

                //入库状态
                this.cmb_inputStatus.SelectedIndex = model.inputStatus;

                //生产单号
                this.txt_produceCode.Text = model.produceCode;

                ModelProduce modelProduce = m_bllProduce.GetProduceyByProduceCode(model.produceCode);
                //生产数量
                this.txt_produceNum.Text = modelProduce.num.ToString();

                //生产日期
                this.dtp_produceDate.Value = ConvertUtils.ConvertToDate(model.produceDate, "yyyy-MM-dd");

                //过期日
                this.dtp_expiresDate.Value = ConvertUtils.ConvertToDate(model.expiresDate, "yyyy-MM-dd");

                //入库产品
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

                //入库数量
                this.txt_inputNum.Text = model.inputNum.ToString();

                //入库日期
                this.dtp_inputDate.Value = ConvertUtils.ConvertToDate(model.inputDate, "yyyy-MM-dd");

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
                grb_productIn.Enabled = true;
            }

            if (m_mode == 2)
            {
                this.btn_submit.Text = "确认删除";
            }

            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                grb_productIn.Enabled = false;
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

            ModelProductIn model = new ModelProductIn();
            model.id = m_productInId;
            model.inputCode = m_inputCode;
            model.inputType = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_inputType.SelectedItem).itemKey);
            model.inputStatus = this.cmb_inputStatus.SelectedIndex;

            model.produceCode = this.txt_produceCode.Text.Trim();
            model.produceDate = this.dtp_produceDate.Value;
            model.expiresDate = this.dtp_expiresDate.Value;

            model.factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            model.productId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_product.SelectedItem).itemKey);

            model.inputNum = ConvertUtils.ConvertToInt(this.txt_inputNum.Text.Trim());
            model.stockNum = ConvertUtils.ConvertToInt(this.txt_inputNum.Text.Trim());
            model.inputDate = this.dtp_inputDate.Value;

            model.remark = this.txt_remark.Text.Trim();

            model.isDelete = 0;
            model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.createTime = DateTime.Now;
            model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllProductIn.AddProductIn(model);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("新增入库单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("新增入库单成功！");
                    }
                }

                //返回列表
                this.Hide();

                return true;
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllProductIn.UpdateProductIn(model);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("修改入库单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("修改入库单成功！");
                        //返回列表
                        this.Hide();
                    }
                    return true;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllProductIn.DeleteProductIn(model);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("删除入库单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("删除入库单成功！");
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
            if (StringUtils.IsNotBlank(m_inputCode))
            {
                //修改
                if (m_mode == 1)
                {
                    if (m_bllProductIn.CheckUpdateDelete(m_inputCode) == false)
                    {
                        MsgUtils.ShowErrorMsg("已有部分产品出库，不可修改！");
                        return false;
                    }
                }

                //删除
                if (m_mode == 2)
                {
                    if (m_bllProductIn.CheckUpdateDelete(m_inputCode) == false)
                    {
                        MsgUtils.ShowErrorMsg("已有部分产品出库，不可删除！");
                        return false;
                    }
                }
            }

            // 新增或修改
            if (m_mode == 0 || m_mode == 1)
            {
                //入库类型
                if (this.cmb_inputType.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择入库类型！");
                    this.cmb_inputType.Focus();
                    return false;
                }

                //入库产品
                if(this.cmb_product.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择入库产品！");
                    this.cmb_product.Focus();
                    return false;
                }
                
                //工厂
                if (this.cmb_factory.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择入库工厂！");
                    this.cmb_factory.Focus();
                    return false;
                }

                //入库数量
                decimal inputNum = ConvertUtils.ConvertToDecimal(this.txt_inputNum.Text.Trim());
                if (inputNum <= 0)
                {
                    MsgUtils.ShowErrorMsg("请输入合适的入库数量！");
                    this.txt_inputNum.Focus();
                    return false;
                }
            }

            return true;
        }
        #endregion
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtp_produceDate_ValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_product.SelectedIndex >= 0)
            {
                int productId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_product.SelectedItem).itemKey);
                ModelProduct modelProduct = m_bllProduct.GetProductById(productId);

                this.dtp_expiresDate.Value = this.dtp_produceDate.Value.AddDays(modelProduct.expiredDays);
            }
        }

        private void cmb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_product.SelectedIndex >= 0)
            {
                int productId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_product.SelectedItem).itemKey);
                ModelProduct modelProduct = m_bllProduct.GetProductById(productId);

                this.dtp_expiresDate.Value = this.dtp_produceDate.Value.AddDays(modelProduct.expiredDays);
            }
        }

    }
}
