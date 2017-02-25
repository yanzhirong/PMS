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
    public partial class FrmInventoryDetail : Form
    {
        //类型（0：产品；1：物料）
        private int m_type;
        private int m_inputId;

        private BllStore m_bllStore = new BllStore();
        private BllMaterialsIn m_bllMaterialsIn = new BllMaterialsIn();
        private BllProductIn m_bllProductIn = new BllProductIn();
        private BllProduct m_bllProduct = new BllProduct();
        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllFactory m_bllFactory = new BllFactory();
        private BllCode m_bllCode = new BllCode();

        public FrmInventoryDetail(int _type, int _inputId)
        {
            InitializeComponent();
            m_type = _type;
            m_inputId = _inputId;
        }

        private void FrmInventoryDetail_Load(object sender, EventArgs e)
        {           
            //初始化
            init();
        }

        private void FrmInventoryDetail_FormClosed(object sender, FormClosedEventArgs e)
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
            //产品库存
            if (m_type == 0)
            {
                ModelProductIn modelProductIn = m_bllProductIn.GetProductInById(m_inputId);

                this.txt_factory.Text = m_bllFactory.GetFactoryById(modelProductIn.factoryId).name;

                this.txt_name.Text = m_bllProduct.GetProductById(modelProductIn.productId).name;

                this.txt_inputNum.Text = modelProductIn.inputNum.ToString();

                this.txt_inputUnit.Visible = false;

                this.dtp_inputDate.Value = modelProductIn.inputDate;

                this.dtp_produceDate.Value = modelProductIn.produceDate;

                this.txt_stockNum.Text = modelProductIn.stockNum.ToString();

                this.cmb_uint.Visible = false;

                this.txt_remark.Text = "";
            }
            //物料库存
            else
            {
                ModelMaterialsIn modelMaterialsIn = m_bllMaterialsIn.GetMaterialsInById(m_inputId);

                this.txt_factory.Text = m_bllFactory.GetFactoryById(modelMaterialsIn.factoryId).name;

                this.txt_name.Text = m_bllMaterials.GetMaterialsById(modelMaterialsIn.materialsId).name;

                this.txt_inputNum.Text = modelMaterialsIn.inputNum.ToString();

                this.txt_inputUnit.Text = m_bllCode.GetSubCode((int)Enum.EnumCode.WeightUnit, modelMaterialsIn.inputUnit).value1;
                this.txt_inputUnit.Visible = true;

                this.dtp_inputDate.Value = modelMaterialsIn.inputDate;

                this.dtp_produceDate.Value = modelMaterialsIn.produceDate;

                this.txt_stockNum.Text = modelMaterialsIn.stockNum.ToString();

                this.cmb_uint.Visible = true;

                List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.WeightUnit, false);
                WinCommon.BindComboBox(ref this.cmb_uint, listItem);

                for (int i = 0; i < this.cmb_uint.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_uint.Items[i];
                    if (modelMaterialsIn.inputUnit == (int)modelItem.itemKey)
                    {
                        this.cmb_uint.SelectedIndex = i;
                        break;
                    }
                }

                this.txt_remark.Text = "";
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

            if (m_type == 0)
            {
                ModelInventoryProductLog modelInventoryProductLog = new ModelInventoryProductLog();
                ModelProductIn model = m_bllProductIn.GetProductInById(m_inputId);

                modelInventoryProductLog.inputCode = model.inputCode;
                modelInventoryProductLog.factoryId = model.factoryId;
                modelInventoryProductLog.productId = model.productId;
                modelInventoryProductLog.stockNumOld = model.stockNum;
                modelInventoryProductLog.produceDateOld = model.produceDate;
                modelInventoryProductLog.expiresDateOld = model.produceDate;

                model.produceDate = this.dtp_produceDate.Value;
                model.expiresDate = this.dtp_expiresDate.Value;
                model.stockNum = ConvertUtils.ConvertToInt(this.txt_stockNum.Text.Trim());
                model.remark = model.remark + "\n" + this.txt_remark.Text.Trim();
                model.isDelete = 0;
                model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                model.modifyTime = DateTime.Now;

                modelInventoryProductLog.stockNumNew = model.stockNum;
                modelInventoryProductLog.produceDateNew = model.produceDate;
                modelInventoryProductLog.expiresDateNew = model.expiresDate;
                modelInventoryProductLog.remark = this.txt_remark.Text.Trim();
                modelInventoryProductLog.isDelete = 0;
                modelInventoryProductLog.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                modelInventoryProductLog.createTime = DateTime.Now;

                rtn = m_bllStore.UpdateInventoryProduct(model, modelInventoryProductLog);
            }
            else
            {
                ModelInventoryMaterialsLog modelInventoryMaterialsLog = new ModelInventoryMaterialsLog();
                ModelMaterialsIn model = m_bllMaterialsIn.GetMaterialsInById(m_inputId);

                modelInventoryMaterialsLog.inputCode = model.inputCode;
                modelInventoryMaterialsLog.factoryId = model.factoryId;
                modelInventoryMaterialsLog.materialsId = model.materialsId;
                modelInventoryMaterialsLog.stockNumOld = model.stockNum;
                modelInventoryMaterialsLog.produceDateOld = model.produceDate;
                modelInventoryMaterialsLog.expiresDateOld = model.produceDate;

                model.produceDate = this.dtp_produceDate.Value;
                model.expiresDate = this.dtp_expiresDate.Value;
                model.stockNum = ConvertUtils.ConvertToDecimal(this.txt_stockNum.Text.Trim());
                model.remark =  model.remark + "\n" + this.txt_remark.Text.Trim();
                model.isDelete = 0;
                model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                model.modifyTime = DateTime.Now;

                modelInventoryMaterialsLog.stockNumNew = model.stockNum;
                modelInventoryMaterialsLog.produceDateNew = model.produceDate;
                modelInventoryMaterialsLog.expiresDateNew = model.expiresDate;
                modelInventoryMaterialsLog.remark = this.txt_remark.Text.Trim();
                modelInventoryMaterialsLog.isDelete = 0;
                modelInventoryMaterialsLog.createBy = LoginUserInfo.LoginUser.loginUser.userName;
                modelInventoryMaterialsLog.createTime = DateTime.Now;

                rtn = m_bllStore.UpdateInventoryMaterials(model, modelInventoryMaterialsLog);
            }

            if (rtn == true)
            {
                MsgUtils.ShowInfoMsg("更新库存成功！");
                this.Hide();
                return true;
            }
            else
            {
                MsgUtils.ShowErrorMsg("更新库存失败！");
                return false;
            }
        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean doCheck()
        {
            //产品库存
            if (m_type == 0)
            {
                //库存数量
                int stockNum = ConvertUtils.ConvertToInt(this.txt_stockNum.Text.Trim());
                if (stockNum <= 0)
                {
                    MsgUtils.ShowErrorMsg("请输入合适的库存数量！");
                    this.txt_stockNum.Focus();
                    return false;
                }

                if (stockNum > ConvertUtils.ConvertToInt(this.txt_inputNum.Text))
                {
                    MsgUtils.ShowErrorMsg("库存数不能大于入库数！");
                    this.txt_stockNum.Focus();
                    return false;
                }
            }
            //物料库存
            else
            {
                //库存数量
                decimal stockNum = ConvertUtils.ConvertToDecimal(this.txt_stockNum.Text.Trim());
                if (stockNum <= 0)
                {
                    MsgUtils.ShowErrorMsg("请输入合适的库存数量！");
                    this.txt_stockNum.Focus();
                    return false;
                }

                if (stockNum > ConvertUtils.ConvertToDecimal(this.txt_inputNum.Text))
                {
                    MsgUtils.ShowErrorMsg("库存数不能大于入库数！");
                    this.txt_stockNum.Focus();
                    return false;
                }
            }

            //备注
            if(StringUtils.IsBlank(this.txt_remark.Text.Trim()))
            {
                    MsgUtils.ShowErrorMsg("请输入备注！");
                    this.txt_remark.Focus();
                    return false;
            }

            return true;
        }
        #endregion
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
