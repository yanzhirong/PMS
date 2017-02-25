using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.Data;
using Common.Tools;
using Model;

namespace Bll
{
    public class BllPurchase : Bll.BllBase
    {

        private BllCode m_bllCode = new BllCode();
        private DalPurchase m_dalPurchase = new DalPurchase();

        public Boolean AddPurchaseApply(List<ModelPurchaseApply> _listPurchaseApply)
        {
            int rtn = 0;
            rtn = m_dalPurchase.AddPurchaseApply(_listPurchaseApply);

            return rtn == 0 ? false : true;
        }

        public DataTable GetPurchaseApply(string _materialsName, int _factoryId, int _applyStatus, DateTime _beginTime, DateTime _endTime)
        {
            return m_dalPurchase.GetPurchaseApply(_materialsName, _factoryId, _applyStatus, _beginTime, _endTime);
        }

        public ModelPurchaseApply GetPurchaseApplyByProcudeCodeAndMaterialsId(string _produceCode, int _materialsId)
        {
            ModelPurchaseApply model = new ModelPurchaseApply();

            DataTable dt = m_dalPurchase.GetPurchaseApplyByProcudeCodeAndMaterialsId(_produceCode, _materialsId);

            if (dt != null && dt.Rows.Count > 0)
            {
                model = ModelUtils<ModelPurchaseApply>.FillModel(dt.Rows[0]);
            }
            return model;
        }

        public DataTable GetPurchase(string _materialsName, int _factoryId, DateTime _beginTime, DateTime _endTime, int _status, int _type)
        {
            return m_dalPurchase.GetPurchase(_materialsName, _factoryId, _beginTime, _endTime, _status, _type);
        }

        public Result SubmitPurchaseApply(List<Dictionary<string, object>> _listApply,int _purchaserid, string _loginName)
        {

            Result returnResult = new Result();

            //更新采购申请表用（key：申请ID；value：生产单号）
            Dictionary<int, string> dcApply = new Dictionary<int, string>();
            //新建采购用（key：工厂ID；value：采购信息）
            Dictionary<int, object> dcFactory = new Dictionary<int, object>();

            foreach (Dictionary<string, object> apply in _listApply)
            {
                int applyId = ConvertUtils.ConvertToInt(apply["applyId"]);
                int factoryId = ConvertUtils.ConvertToInt(apply["factoryId"]);
                int materialsId = ConvertUtils.ConvertToInt(apply["materialsId"]);
                decimal applyNum = ConvertUtils.ConvertToDecimal(apply["num"]);
                int applyUnit = ConvertUtils.ConvertToInt(apply["unit"]);
                DateTime deliveryDate = ConvertUtils.ConvertToDate(apply["deliveryDate"], "yyyy-MM-dd");
                string applyBy = ConvertUtils.ConvertToString(apply["applyBy"]);
                DateTime applyDate = ConvertUtils.ConvertToDate(apply["applyDate"], "yyyy-MM-dd");
                string produceCode = ConvertUtils.ConvertToString(apply["produceCode"]);

                //采购信息（key：物料ID；value：采购信息【生产单号，采购数量，采购单位】)
                Dictionary<int, object> dcPurchase;
                if (dcFactory.ContainsKey(factoryId))
                {
                    dcPurchase = (Dictionary<int, object>)dcFactory[factoryId];

                    ModelPurchase modelPurchase;
                    if (dcPurchase.ContainsKey(materialsId))
                    {
                        modelPurchase = (ModelPurchase)dcPurchase[materialsId];

                        int unit = modelPurchase.unit;
                        decimal num = modelPurchase.num;

                        applyNum = applyNum * m_bllCode.GetWeightUnit(applyUnit);
                        num = num * m_bllCode.GetWeightUnit(unit);
                        num = num + applyNum;
                        num = num / m_bllCode.GetWeightUnit(unit);

                        modelPurchase.num = num;

                        if (DateTime.Compare(deliveryDate, modelPurchase.deliveryDate) < 0)
                        {
                            modelPurchase.deliveryDate = deliveryDate;
                        }
                        dcApply.Add(applyId, modelPurchase.purchaseCode);
                    }
                    else
                    {
                        string purchaseCode = BllSeq.GetCode("purchaseCode");

                        modelPurchase = new ModelPurchase();
                        modelPurchase.factoryId = factoryId;
                        modelPurchase.materialsId = materialsId;
                        modelPurchase.purchaseCode = purchaseCode;
                        modelPurchase.produceCode = produceCode;
                        modelPurchase.num = applyNum;
                        modelPurchase.unit = applyUnit;
                        modelPurchase.status = (int)Enum.EnumPurchaseOrderStatus.WaitPurchaseConfirm;
                        modelPurchase.applyBy = applyBy;
                        modelPurchase.applyDate = applyDate;
                        modelPurchase.deliveryDate = deliveryDate;
                        modelPurchase.purchaserId = _purchaserid;
                        modelPurchase.isDelete = 0;
                        modelPurchase.createBy = _loginName;
                        modelPurchase.createTime = DateTime.Now;

                        dcPurchase.Add(materialsId, modelPurchase);
                        dcApply.Add(applyId, purchaseCode);
                    }
                }
                else
                {
                    string purchaseCode = BllSeq.GetCode("purchaseCode");

                    dcPurchase = new Dictionary<int, object>();

                    ModelPurchase modelPurchase = new ModelPurchase();
                    modelPurchase.factoryId = factoryId;
                    modelPurchase.materialsId = materialsId;
                    modelPurchase.purchaseCode = purchaseCode;
                    modelPurchase.produceCode = produceCode;
                    modelPurchase.num = applyNum;
                    modelPurchase.unit = applyUnit;
                    modelPurchase.status = (int)Enum.EnumPurchaseOrderStatus.WaitPurchaseConfirm;
                    modelPurchase.applyBy = applyBy;
                    modelPurchase.applyDate = applyDate;
                    modelPurchase.deliveryDate = deliveryDate;
                    modelPurchase.purchaserId = _purchaserid;
                    modelPurchase.isDelete = 0;
                    modelPurchase.createBy = _loginName;
                    modelPurchase.createTime = DateTime.Now;

                    dcPurchase.Add(materialsId, modelPurchase);
                    dcFactory.Add(factoryId, dcPurchase);
                    dcApply.Add(applyId, purchaseCode);
                }
            }
            int rtn = m_dalPurchase.SubmitPurchaseApply(dcApply, dcFactory);

            if (rtn > 0)
            {
                returnResult.resultCode = Enum.EnumResultCode.Success;
            }
            else
            {
                returnResult.resultCode = Enum.EnumResultCode.Failed;
            }

            return returnResult;
        }
        
        public Boolean CancelProduceApply(List<ModelPurchaseApply> _listCancelApply)
        {
            int rtn = m_dalPurchase.CancelProduceApply(_listCancelApply);

            return rtn > 0 ? true : false;
        }

        public ModelPurchase GetPurchaseById(int _purchaseId)
        {
            DataTable dt = m_dalPurchase.GetPurchaseById(_purchaseId);

            if (dt != null && dt.Rows.Count > 0)
            {
                return Common.Tools.ModelUtils<ModelPurchase>.FillModel(dt.Rows[0]);
            }

            return new ModelPurchase();
        }

        public ModelPurchase GetPurchaseByPurchaseCode(string _purchaseCode)
        {
            DataTable dt = m_dalPurchase.GetPurchaseByPurchaseCode(_purchaseCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                return Common.Tools.ModelUtils<ModelPurchase>.FillModel(dt.Rows[0]);
            }

            return new ModelPurchase();
        }
        
        public Boolean AddPurchase(ModelPurchase _model)
        {
            _model.purchaseCode = BllSeq.GetCode("purchaseCode");
            int rtn = m_dalPurchase.AddPurchase(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdatePurchase(ModelPurchase _model)
        {
            int rtn = m_dalPurchase.UpdatePurchase(_model);

            return rtn > 0 ? true : false;
        }

        public Boolean ConfirmPurchase(ModelPurchase _model)
        {
            int rtn = m_dalPurchase.ConfirmPurchase(_model);

            return rtn > 0 ? true : false;
        }

        public Boolean CancelPurchase(ModelPurchase _model)
        {
            int rtn = m_dalPurchase.CancelPurchase(_model);

            return rtn > 0 ? true : false;
        }

        public Boolean DeletePurchase(ModelPurchase _model)
        {
            int rtn = m_dalPurchase.DeletePurchase(_model);

            return rtn > 0 ? true : false;
        }

        /// <summary>
        /// 检查采购单是否已入库或已支付（0：未入库未支付【可编辑删除】；1：已入库【不可编辑删除】；2：已支付【不可编辑删除】）
        /// </summary>
        /// <param name="_purchaseId"></param>
        /// <returns></returns>
        public int CheckUpdateDelete(int _purchaseId)
        {
            ModelPurchase modelPurchase = GetPurchaseById(_purchaseId);

            if (StringUtils.IsBlank(modelPurchase.purchaseCode) == true)
            {
                return 0;
            }

            //查询是否已经入库
            DataTable dt = m_dalPurchase.GetCompleteInByPurchaseCode(modelPurchase.purchaseCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                return 1;
            }

            //查询是否已经支付
            dt = m_dalPurchase.GetPaidByPurchaseCode(modelPurchase.purchaseCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                return 2;
            }
            return 0;
        }
    }
}
