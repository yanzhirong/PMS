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
    public partial class FrmMaterialsInDetail : Form
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看）
        private int m_mode;
        private int m_materialsInId;
        private string m_inputCode;

        private BllCustomer m_bllCustomer = new BllCustomer();
        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllMaterialsIn m_bllMaterialsIn = new BllMaterialsIn();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmMaterialsInDetail(int _mode, int _materialsInId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_materialsInId = _materialsInId;
        }

        private void FrmMaterialsInDetail_Load(object sender, EventArgs e)
        {           
            //初始化
            init();
        }

        private void FrmMaterialsInDetail_FormClosed(object sender, FormClosedEventArgs e)
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
            //入库类型
            List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.MaterialsInputType, false);
            WinCommon.BindComboBox(ref this.cmb_inputType, listItem, false);
            //采购员
            listItem = m_bllUser.GetUsersWithItem();
            WinCommon.BindComboBox(ref this.cmb_purchaseBy, listItem);
            //采购数量单位
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.WeightUnit, false);
            WinCommon.BindComboBox(ref this.cmb_purchaseUnit, listItem);
            //供应商
            listItem = m_bllCustomer.GetSupplier();
            WinCommon.BindComboBox(ref this.cmb_supplier, listItem);
            //入库物料
            listItem = m_bllMaterials.GetMaterialsItem("");
            WinCommon.BindComboBox(ref this.cmb_materials, listItem);
            //入库工厂
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem);
            //入库数量单位
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.WeightUnit, false);
            WinCommon.BindComboBox(ref this.cmb_inputUint, listItem, false);

            //初始化数据
            if (m_mode != 0 && m_materialsInId > 0)
            {

                ModelMaterialsIn model = m_bllMaterialsIn.GetMaterialsInById(m_materialsInId);

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

                //采购单编号
                this.txt_purchaseCode.Text = model.purchaseCode;

                //采购员
                for (int i = 0; i < this.cmb_purchaseBy.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_purchaseBy.Items[i];
                    if (model.purchaseBy == modelItem.itemValue)
                    {
                        this.cmb_purchaseBy.SelectedIndex = i;
                        break;
                    }
                }

                //采购数量
                this.txt_purchaseNum.Text = model.purchaseNum.ToString();

                //采购数量单位
                for (int i = 0; i < this.cmb_purchaseUnit.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_purchaseUnit.Items[i];
                    if (model.purchaseUnit == (int)modelItem.itemKey)
                    {
                        this.cmb_purchaseUnit.SelectedIndex = i;
                        break;
                    }
                }

                //采购日期
                this.dtp_purchaseDate.Value = ConvertUtils.ConvertToDate(model.purchaseDate, "yyyy-MM-dd");

                //供应商
                for (int i = 0; i < this.cmb_supplier.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_supplier.Items[i];
                    if (model.customerId == (int)modelItem.itemKey)
                    {
                        this.cmb_supplier.SelectedIndex = i;
                        break;
                    }
                }

                //生产日期
                this.dtp_produceDate.Value = ConvertUtils.ConvertToDate(model.produceDate, "yyyy-MM-dd"); 

                //入库物料
                for (int i = 0; i < this.cmb_materials.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_materials.Items[i];
                    if (model.materialsId == (int)modelItem.itemKey)
                    {
                        this.cmb_materials.SelectedIndex = i;
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

                //入库数量单位
                for (int i = 0; i < this.cmb_inputUint.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_inputUint.Items[i];
                    if (model.inputUnit == (int)modelItem.itemKey)
                    {
                        this.cmb_inputUint.SelectedIndex = i;
                        break;
                    }
                }

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
                grb_materialsIn.Enabled = true;
            }

            if (m_mode == 2)
            {
                this.btn_submit.Text = "确认删除";
            }

            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                grb_materialsIn.Enabled = false;
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

            ModelMaterialsIn modelMaterialsIn = new ModelMaterialsIn();
            modelMaterialsIn.id = m_materialsInId;
            modelMaterialsIn.inputCode = m_inputCode;
            modelMaterialsIn.inputType = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_inputType.SelectedItem).itemKey);
            modelMaterialsIn.inputStatus = this.cmb_inputStatus.SelectedIndex;

            modelMaterialsIn.purchaseCode = this.txt_purchaseCode.Text.Trim();
            if (this.cmb_purchaseBy.SelectedIndex >= 0)
            {
                modelMaterialsIn.purchaseBy = ((ModelItem)this.cmb_purchaseBy.SelectedItem).itemValue;
            }
            modelMaterialsIn.purchaseNum = ConvertUtils.ConvertToDecimal(this.txt_purchaseNum.Text.Trim());
            if (this.cmb_purchaseUnit.SelectedIndex >= 0)
            {
                modelMaterialsIn.purchaseUnit = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_purchaseUnit.SelectedItem).itemKey);
            }
            modelMaterialsIn.purchaseDate = this.dtp_produceDate.Value;

            modelMaterialsIn.customerId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_supplier.SelectedItem).itemKey);
            modelMaterialsIn.factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);

            modelMaterialsIn.materialsId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_materials.SelectedItem).itemKey);
            modelMaterialsIn.produceDate = this.dtp_produceDate.Value;
            ModelMaterials materials = m_bllMaterials.GetMaterialsById(modelMaterialsIn.materialsId);
            modelMaterialsIn.expiresDate = this.dtp_produceDate.Value.AddDays(materials.expiredDays);

            modelMaterialsIn.inputNum = ConvertUtils.ConvertToDecimal(this.txt_inputNum.Text.Trim());
            modelMaterialsIn.stockNum = ConvertUtils.ConvertToDecimal(this.txt_inputNum.Text.Trim());
            modelMaterialsIn.inputUnit = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_inputUint.SelectedItem).itemKey);
            modelMaterialsIn.inputDate = this.dtp_inputDate.Value;

            modelMaterialsIn.remark = this.txt_remark.Text.Trim();

            modelMaterialsIn.isDelete = 0;
            modelMaterialsIn.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelMaterialsIn.createTime = DateTime.Now;
            modelMaterialsIn.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelMaterialsIn.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllMaterialsIn.AddMaterialsIn(modelMaterialsIn);

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

                //处理模式变为修改
                m_mode = 1;
                ModelMaterialsIn newMaterialsIn = m_bllMaterialsIn.GetMaterialsInByInputCode(modelMaterialsIn.inputCode);
                m_materialsInId = newMaterialsIn.id;
                m_inputCode = modelMaterialsIn.inputCode;
                //返回列表
                this.Hide();

                return true;
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllMaterialsIn.UpdateMaterialsIn(modelMaterialsIn);

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
                        m_inputCode = modelMaterialsIn.inputCode;
                        //返回列表
                        this.Hide();
                    }
                    return true;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllMaterialsIn.DeleteMaterialsIn(modelMaterialsIn);

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
                    //Form form = new FrmMaterialsIn();
                    this.Hide();
                    //form.ShowDialog();
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
            if(StringUtils.IsNotBlank(m_inputCode))
            {
                //修改
                if (m_mode == 1)
                {
                    if (m_bllMaterialsIn.CheckUpdateDelete(m_inputCode) == false)
                    {
                        MsgUtils.ShowErrorMsg("已有部分物料出库，不可修改！");
                        return false;
                    }
                }

                //删除
                if (m_mode == 2)
                {
                    if (m_bllMaterialsIn.CheckUpdateDelete(m_inputCode) == false)
                    {
                        MsgUtils.ShowErrorMsg("已有部分物料出库，不可删除！");
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
                
                //供应商
                if (this.cmb_supplier.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择供应商！");
                    this.cmb_supplier.Focus();
                    return false;
                }

                //入库物料
                if(this.cmb_materials.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择入库物料！");
                    this.cmb_materials.Focus();
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

                //入库数量单位
                if (this.cmb_inputUint.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择入库数量单位！");
                    this.cmb_inputUint.Focus();
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

    }
}
