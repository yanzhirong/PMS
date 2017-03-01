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
    public partial class FrmMaterialsOutDetail : Main.BaseForm
    {
        //处理模式（0：新建；1：修改；2：删除；3：查看）
        private int m_mode;
        private int m_materialsOutId;
        private string m_outputCode;

        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllMaterialsOut m_bllMaterialsOut = new BllMaterialsOut();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private BllCode m_bllCode = new BllCode();

        public FrmMaterialsOutDetail(int _mode, int _materialsOutId)
        {
            InitializeComponent();
            m_mode = _mode;
            m_materialsOutId = _materialsOutId;
        }

        private void FrmMaterialsOutDetail_Load(object sender, EventArgs e)
        {           
            //初始化
            init();
        }

        private void FrmMaterialsOutDetail_FormClosed(object sender, FormClosedEventArgs e)
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
            //申请人
            List<ModelItem>  listItem = m_bllUser.GetUsersWithItem();
            WinCommon.BindComboBox(ref this.cmb_applyBy, listItem);
            //申请数量单位
            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.WeightUnit, false);
            WinCommon.BindComboBox(ref this.cmb_applyUnit, listItem);
            //入库物料
            listItem = m_bllMaterials.GetMaterialsItem("");
            WinCommon.BindComboBox(ref this.cmb_materials, listItem);
            //入库工厂
            listItem = m_bllFactory.GetFactoryItem();
            WinCommon.BindComboBox(ref this.cmb_factory, listItem);

            //初始化数据
            if (m_mode != 0 && m_materialsOutId > 0)
            {

                ModelMaterialsOutput model = m_bllMaterialsOut.GetMaterialsOutById(m_materialsOutId);

                //出库单号
                m_outputCode = model.outputCode;

                //出库类型
                this.cmb_outputType.SelectedIndex = model.outputType;

                //出库状态
                this.cmb_outputStatus.SelectedIndex = model.outputStatus;

                //生产编号
                this.txt_produceCode.Text = model.produceCode;

                //申请人
                for (int i = 0; i < this.cmb_applyBy.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_applyBy.Items[i];
                    if (model.applyMemberId == (int)modelItem.itemKey)
                    {
                        this.cmb_applyBy.SelectedIndex = i;
                        break;
                    }
                }

                //申请数量
                this.txt_applyNum.Text = model.outputNum.ToString();

                //申请数量单位
                for (int i = 0; i < this.cmb_applyUnit.Items.Count; i++)
                {
                    ModelItem modelItem = (ModelItem)this.cmb_applyUnit.Items[i];
                    if (model.outputUnit == (int)modelItem.itemKey)
                    {
                        this.cmb_applyUnit.SelectedIndex = i;
                        break;
                    }
                }

                //申请日期
                this.dtp_applyDate.Value = ConvertUtils.ConvertToDate(model.createTime, "yyyy-MM-dd");

                //出库物料
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

                //出库数量
                this.txt_outputNum.Text = m_bllMaterialsOut.GetOutputNum(m_outputCode);

                //出库日期
                this.dtp_outputDate.Value = ConvertUtils.ConvertToDate(model.outputDate, "yyyy-MM-dd"); 

                //备注
                this.txt_remark.Text = model.remark;
            }           

            //按钮处理
            this.btn_output.Visible = true;
            this.btn_cancel.Visible = true;
            this.btn_close.Visible = false;

            if (m_mode == 3)
            {
                this.btn_output.Visible = false;
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
                this.btn_output.Text = "确认删除";
            }

            //查看/删除时，各输入项不能修改
            if (m_mode == 2 || m_mode == 3)
            {
                grb_materialsIn.Enabled = false;
            }

            if (StringUtils.IsNotBlank(m_bllMaterialsOut.GetOutputNum(m_outputCode)))
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

            ModelMaterialsOutput modelMaterialsOutput = new ModelMaterialsOutput();
            modelMaterialsOutput.id = m_materialsOutId;
            modelMaterialsOutput.outputCode = m_outputCode;
            modelMaterialsOutput.outputType = this.cmb_outputType.SelectedIndex;
            modelMaterialsOutput.outputStatus = this.cmb_outputStatus.SelectedIndex;

            modelMaterialsOutput.produceCode = this.txt_produceCode.Text.Trim();
            modelMaterialsOutput.applyMemberId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_applyBy.SelectedItem).itemKey);
            modelMaterialsOutput.outputNum = ConvertUtils.ConvertToDecimal(this.txt_applyNum.Text.Trim());
            modelMaterialsOutput.outputUnit = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_applyUnit.SelectedItem).itemKey);
            modelMaterialsOutput.applyDate = this.dtp_applyDate.Value;

            modelMaterialsOutput.materialsId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_materials.SelectedItem).itemKey);
            modelMaterialsOutput.factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            modelMaterialsOutput.outputDate = this.dtp_outputDate.Value;
            modelMaterialsOutput.remark = this.txt_remark.Text.Trim();

            modelMaterialsOutput.isDelete = 0;
            modelMaterialsOutput.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelMaterialsOutput.createTime = DateTime.Now;
            modelMaterialsOutput.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
            modelMaterialsOutput.modifyTime = DateTime.Now;

            //新增
            if (m_mode == 0) 
            {
                rtn = m_bllMaterialsOut.AddMaterialsOut(modelMaterialsOutput);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("新增出库单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("新增出库单成功！");
                    }
                }

                //处理模式变为修改
                m_mode = 1;
                ModelMaterialsOutput newMaterialsOutput = m_bllMaterialsOut.GetMaterialsOutByOutputCode(modelMaterialsOutput.outputCode);
                m_materialsOutId = newMaterialsOutput.id;
                m_outputCode = modelMaterialsOutput.outputCode;
                this.Hide();
                return true;
            }

            //修改
            if (m_mode == 1)
            {
                rtn = m_bllMaterialsOut.UpdateMaterialsOut(modelMaterialsOutput);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("修改出库单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("修改出库单成功！");
                        m_outputCode = modelMaterialsOutput.outputCode;
                        this.Hide();
                    }
                    return true;
                }
            }

            //删除
            if(m_mode == 2)
            {
                rtn = m_bllMaterialsOut.DeleteMaterialsOut(modelMaterialsOutput);

                if (rtn == false)
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowErrorMsg("删除出库单失败！");
                    }
                    return false;
                }
                else
                {
                    if (showMsg == true)
                    {
                        MsgUtils.ShowInfoMsg("删除出库单成功！");
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
            if (StringUtils.IsNotBlank(m_outputCode))
            {
                //修改
                if (m_mode == 1)
                {
                    if (m_bllMaterialsOut.CheckUpdateDelete(m_outputCode) == false)
                    {
                        MsgUtils.ShowErrorMsg("已出库，不可修改！");
                        return false;
                    }
                }

                //删除
                if (m_mode == 2)
                {
                    if (m_bllMaterialsOut.CheckUpdateDelete(m_outputCode) == false)
                    {
                        MsgUtils.ShowErrorMsg("已出库，不可删除！");
                        return false;
                    }
                }
            }

            // 新增或修改
            if (m_mode == 0 || m_mode == 1)
            {
                //出库类型
                if (this.cmb_outputType.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择出库类型！");
                    this.cmb_outputType.Focus();
                    return false;
                }

                //出库状态
                if (this.cmb_outputStatus.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择出库状态！");
                    this.cmb_outputType.Focus();
                    return false;
                }
               
                //申请人
                if (this.cmb_applyBy.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择申请人！");
                    this.cmb_applyBy.Focus();
                    return false;
                }

                //申请数量
                decimal applyNum = ConvertUtils.ConvertToDecimal(this.txt_applyNum.Text.Trim());
                if (applyNum <= 0)
                {
                    MsgUtils.ShowErrorMsg("请输入合适的申请数量！");
                    this.txt_applyNum.Focus();
                    return false;
                }

                //申请数量单位
                if (this.cmb_applyUnit.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择申请数量单位！");
                    this.cmb_applyUnit.Focus();
                    return false;
                }

                //出库物料
                if(this.cmb_materials.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择出库物料！");
                    this.cmb_materials.Focus();
                    return false;
                }
                
                //工厂
                if (this.cmb_factory.SelectedIndex < 0)
                {
                    MsgUtils.ShowErrorMsg("请选择出库工厂！");
                    this.cmb_factory.Focus();
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

        private void btn_output_Click(object sender, EventArgs e)
        {
            //保存数据
            if (doSubmit(false) == false)
            {
                return;
            }

            int factoryId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_factory.SelectedItem).itemKey);
            int materialsId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_materials.SelectedItem).itemKey);

            Form form = new FrmMaterialsOutSelect(m_outputCode, factoryId, materialsId, ConvertUtils.ConvertToInt(((ModelItem)this.cmb_applyBy.SelectedItem).itemKey));
            form.ShowDialog();

            init();
        }

    }
}
