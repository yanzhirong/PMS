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
    public class BllProduce : Bll.BllBase
    {
        private BllCode m_bllCode = new BllCode();
        private BllProduct m_bllProduct = new BllProduct();
        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllStore m_bllStore = new BllStore();
        private DalProduce m_dalProduce = new DalProduce();

        public Boolean AddProduceApply(List<ModelProduceApply> _listProduceApply)
        {
            int rtn = 0;
            rtn = m_dalProduce.AddProduceApply(_listProduceApply);

            return rtn == 0 ? false : true;
        }

        public ModelProduceApply GetProduceApplyByOutputCodeAndProductId(string _outputCode, int _productId)
        {
            DataTable dt = m_dalProduce.GetProduceApplyByOutputCodeAndProductId(_outputCode, _productId);
            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelProduceApply>.FillModel(dt.Rows[0]);
            }

            return new ModelProduceApply();
        }

        public DataTable GetProduceApplyByProduceCode(string _produceCode)
        {
            return m_dalProduce.GetProduceApplyByProduceCode(_produceCode);
        }

        public DataTable GetProduceApplyBySaleOrderCode(string _saleOrderCode)
        {
            return m_dalProduce.GetProduceApplyBySaleOrderCode(_saleOrderCode);
        }

        public DataTable GetProduceApply(string _productName, int _factoryId, int _applyType, int _applyStatus, DateTime _beginTime, DateTime _endTime)
        {
            return m_dalProduce.GetProduceApply(_productName, _factoryId, _applyType, _applyStatus, _beginTime, _endTime);
        }

        public DataTable GetProduce(string _productName, int _factoryId, int _Status, DateTime _beginTime, DateTime _endTime)
        {
            return m_dalProduce.GetProduce(_productName, _factoryId, _Status, _beginTime, _endTime);
        }

        public ModelProduce GetProduceyByProduceCode(string _produceCode)
        {
            DataTable dt = m_dalProduce.GetProduceyByProduceCode(_produceCode);
            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelProduce>.FillModel(dt.Rows[0]);
            }

            return new ModelProduce();
        }

        public Result SubmitProduceApply(List<Dictionary<string, object>> _listApply, string _loginName)
        {

            Result returnResult = new Result();

            //更新生产申请表用（key：申请ID；value：生产单号）
            Dictionary<int, string> dcApply = new Dictionary<int, string>();
            //新建生产用（key：工厂ID；value：产品信息）
            Dictionary<int, object> dcFactory = new Dictionary<int, object>();

            foreach (Dictionary<string, object> apply in _listApply)
            {
                int applyId = ConvertUtils.ConvertToInt(apply["applyId"]);
                int factoryId = ConvertUtils.ConvertToInt(apply["factoryId"]);
                int productId = ConvertUtils.ConvertToInt(apply["productId"]);
                int applyNum = ConvertUtils.ConvertToInt(apply["num"]);
                DateTime deliveryDate = ConvertUtils.ConvertToDate(apply["deliveryDate"], "yyyy-MM-dd");
                string applyBy = ConvertUtils.ConvertToString(apply["applyBy"]);
                int applyMemberId = ConvertUtils.ConvertToInt(apply["applyMemberId"]);
                DateTime applyDate = ConvertUtils.ConvertToDate(apply["applyDate"], "yyyy-MM-dd");

                //产品信息（key：产品ID；value：生产信息【生产单号，生产数量】)
                Dictionary<int, object> dcProduct;
                if (dcFactory.ContainsKey(factoryId))
                {
                    dcProduct = (Dictionary<int, object>)dcFactory[factoryId];

                    ModelProduce modelProduce;
                    if (dcProduct.ContainsKey(productId))
                    {
                        modelProduce = (ModelProduce)dcProduct[productId];

                        // 生产数量累加
                        modelProduce.num = modelProduce.num + applyNum;

                        //交货日选最早的
                        if (DateTime.Compare(deliveryDate, modelProduce.deliveryDate) < 0)
                        {
                            modelProduce.deliveryDate = deliveryDate;
                        }
                        dcApply.Add(applyId, modelProduce.produceCode);
                    }
                    else
                    {
                        string produceCode = BllSeq.GetCode("produceCode");

                        modelProduce = new ModelProduce();
                        modelProduce.factoryId = factoryId;
                        modelProduce.productId = productId;
                        modelProduce.produceCode = produceCode;
                        modelProduce.num = applyNum;
                        modelProduce.status = (int)Enum.EnumProduceOrderStatus.Producing;
                        modelProduce.applyMemberId = applyMemberId;
                        modelProduce.applyBy = applyBy;
                        modelProduce.applyDate = applyDate;
                        modelProduce.deliveryDate = deliveryDate;
                        modelProduce.isDelete = 0;
                        modelProduce.createBy = _loginName;
                        modelProduce.createTime = DateTime.Now;

                        dcProduct.Add(productId, modelProduce);
                        dcApply.Add(applyId, produceCode);
                    }
                }
                else
                {
                    string produceCode = BllSeq.GetCode("produceCode");

                    dcProduct = new Dictionary<int, object>();

                    ModelProduce modelProduce = new ModelProduce();
                    modelProduce.factoryId = factoryId;
                    modelProduce.productId = productId;
                    modelProduce.produceCode = produceCode;
                    modelProduce.num = applyNum;
                    modelProduce.status = (int)Enum.EnumProduceOrderStatus.Producing;
                    modelProduce.applyMemberId = applyMemberId;
                    modelProduce.applyBy = applyBy;
                    modelProduce.applyDate = applyDate;
                    modelProduce.deliveryDate = deliveryDate;
                    modelProduce.isDelete = 0;
                    modelProduce.createBy = _loginName;
                    modelProduce.createTime = DateTime.Now;

                    dcProduct.Add(productId, modelProduce);
                    dcFactory.Add(factoryId, dcProduct);
                    dcApply.Add(applyId, produceCode);
                }
            }

            //生成物料出库申请单
            Dictionary<int, object> dcFactoryOutput = new Dictionary<int, object>();
            foreach (KeyValuePair<int, object> kvp_factory in dcFactory)            {

                int factoryId = kvp_factory.Key;

                Dictionary<int, object> dcProduct = (Dictionary<int, object>)kvp_factory.Value;

                foreach (KeyValuePair<int, object> kvp_product in dcProduct)
                {
                    ModelProduce modelProduce = (ModelProduce)kvp_product.Value;
                    //产品ID
                    int productId = modelProduce.productId;
                    
                    // 产品信息
                    ModelProduct modelProduct = m_bllProduct.GetProductById(productId);

                    DataTable dtMaterials = m_bllProduct.GetProductMaterialsById(productId);

                    if (dtMaterials != null && dtMaterials.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtMaterials.Rows)
                        {
                            int materialsId = ConvertUtils.ConvertToInt(dr["materialsId"]);

                            ModelMaterialsOutput modelMaterialsOutput;
                            Dictionary<int, ModelMaterialsOutput> dcMaterialsOutput;

                            if (dcFactoryOutput.ContainsKey(factoryId))
                            {
                                dcMaterialsOutput = (Dictionary<int, ModelMaterialsOutput>)dcFactoryOutput[factoryId];

                                if (dcMaterialsOutput.ContainsKey(materialsId))
                                {
                                    modelMaterialsOutput = (ModelMaterialsOutput)dcMaterialsOutput[materialsId];

                                    // 已统计的物料出库重量，并转为克
                                    decimal outputNum = modelMaterialsOutput.outputNum;
                                    outputNum = outputNum * m_bllCode.GetWeightUnit(modelMaterialsOutput.outputUnit);

                                    // 追加的物料出库重量，并转为克
                                    decimal AddOutputNum = modelProduce.num * modelProduct.weight * ConvertUtils.ConvertToDecimal(dr["percent"]) / 100;
                                    AddOutputNum = AddOutputNum * m_bllCode.GetWeightUnit(modelProduct.weightUnit);

                                    // 统计完后的出库重量，并转为选择的单位
                                    outputNum = outputNum + AddOutputNum;
                                    outputNum = outputNum / m_bllCode.GetWeightUnit(modelMaterialsOutput.outputUnit);

                                    modelMaterialsOutput.outputNum = outputNum;

                                }
                                else
                                {
                                    modelMaterialsOutput = new ModelMaterialsOutput();
                                    modelMaterialsOutput.outputCode = BllSeq.GetCode("materialsOutputCode");
                                    modelMaterialsOutput.produceCode = modelProduce.produceCode;
                                    modelMaterialsOutput.factoryId = kvp_factory.Key;
                                    modelMaterialsOutput.materialsId = ConvertUtils.ConvertToInt(dr["materialsId"]);
                                    modelMaterialsOutput.outputNum = modelProduce.num * modelProduct.weight * ConvertUtils.ConvertToDecimal(dr["percent"]) / 100;
                                    modelMaterialsOutput.outputUnit = modelProduct.weightUnit;
                                    modelMaterialsOutput.outputStatus = 0;
                                    modelMaterialsOutput.outputType = 0;
                                    modelMaterialsOutput.applyMemberId = modelProduce.applyMemberId;
                                    modelMaterialsOutput.applyDate = DateTime.Now;
                                    modelMaterialsOutput.remark = "";
                                    modelMaterialsOutput.isDelete = 0;
                                    modelMaterialsOutput.createBy = _loginName;
                                    modelMaterialsOutput.createTime = DateTime.Now;

                                    dcMaterialsOutput.Add(materialsId, modelMaterialsOutput);
                                }
                            }
                            else
                            {
                                dcMaterialsOutput = new Dictionary<int, ModelMaterialsOutput>();

                                modelMaterialsOutput = new ModelMaterialsOutput();
                                modelMaterialsOutput.outputCode = BllSeq.GetCode("materialsOutputCode");
                                modelMaterialsOutput.produceCode = modelProduce.produceCode;
                                modelMaterialsOutput.factoryId = kvp_factory.Key;
                                modelMaterialsOutput.materialsId = ConvertUtils.ConvertToInt(dr["materialsId"]);
                                modelMaterialsOutput.outputNum = modelProduce.num * modelProduct.weight * ConvertUtils.ConvertToDecimal(dr["percent"]) / 100;
                                modelMaterialsOutput.outputUnit = modelProduct.weightUnit;
                                modelMaterialsOutput.outputStatus = 0;
                                modelMaterialsOutput.outputType = 0;
                                modelMaterialsOutput.applyMemberId = modelProduce.applyMemberId;
                                modelMaterialsOutput.applyDate = DateTime.Now;
                                modelMaterialsOutput.remark = "";
                                modelMaterialsOutput.isDelete = 0;
                                modelMaterialsOutput.createBy = _loginName;
                                modelMaterialsOutput.createTime = DateTime.Now;

                                dcMaterialsOutput.Add(materialsId, modelMaterialsOutput);
                                dcFactoryOutput.Add(factoryId, dcMaterialsOutput);
                            }                            
                        }
                    }

                }
            }

            int rtn = m_dalProduce.SubmitProduceApply(dcApply, dcFactory, dcFactoryOutput);

            if (rtn > 0)
            {
                returnResult.resultCode = Enum.EnumResultCode.Success;
                returnResult.resultObj = dcFactory;
            }
            else
            {
                returnResult.resultCode = Enum.EnumResultCode.Failed;
            }

            return returnResult;
        }

        public List<ModelPurchaseApply> CheckProduceMaterial(Dictionary<int, object> _dcProduce, string _loginUserName)
        {
            List<ModelPurchaseApply> listPurchaseApply = new List<ModelPurchaseApply>();

            foreach (KeyValuePair<int, object> kvp_factory in _dcProduce)
            {
                Dictionary<int, object> dcProduct = (Dictionary<int, object>)kvp_factory.Value;
                foreach (KeyValuePair<int, object> kvp_product in dcProduct)
                {
                    int productId = kvp_product.Key;
                    ModelProduce modelProduce = (ModelProduce) kvp_product.Value;
                    ModelProduct modelProduct = m_bllProduct.GetProductById(productId); ;

                    //产品数量（克）
                    decimal num = modelProduce.num * modelProduct.weight * m_bllCode.GetWeightUnit(modelProduct.weightUnit);

                    //交货日
                    DateTime deliveryDate = modelProduce.deliveryDate;

                    //工厂ID
                    int factoryId = modelProduce.factoryId;

                    DataTable dtMaterial = m_bllProduct.GetProductMaterialsById(productId);
                    if (dtMaterial != null && dtMaterial.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtMaterial.Rows)
                        {
                            //物料ID
                            int materialsId = ConvertUtils.ConvertToInt(dr["materialsId"]);
                            ModelMaterials modelMaterials = m_bllMaterials.GetMaterialsById(materialsId);

                            //物料类型为自制物料的无需采购
                            if(modelMaterials.type == 1)
                            {
                                continue;
                            }

                            //物料需求量（克）
                            decimal materialsNum = num * ConvertUtils.ConvertToDecimal(dr["percent"]) / 100;

                            //查询库存（克）
                            decimal materialsStoreNum = m_bllStore.GetStoreMaterialsNum(factoryId, materialsId, deliveryDate);

                            //库存不足，需采购
                            if (materialsNum > materialsStoreNum)
                            {
                                ModelPurchaseApply modelPurchaseApply = new ModelPurchaseApply();
                                modelPurchaseApply.factoryId = factoryId;
                                modelPurchaseApply.materialsId = materialsId;
                                modelPurchaseApply.materialsName = modelMaterials.name;
                                modelPurchaseApply.num = (materialsNum - materialsStoreNum) / m_bllCode.GetWeightUnit(modelProduct.weightUnit);
                                modelPurchaseApply.unit = modelProduct.weightUnit;
                                modelPurchaseApply.applyType = 0;
                                modelPurchaseApply.applyBy = _loginUserName;
                                modelPurchaseApply.applyDate = DateTime.Now;
                                modelPurchaseApply.produceCode = modelProduce.produceCode;
                                modelPurchaseApply.deliveryDate = modelProduce.deliveryDate;
                                modelPurchaseApply.isDelete = 0;
                                modelPurchaseApply.createBy = _loginUserName;
                                modelPurchaseApply.createTime = DateTime.Now;

                                listPurchaseApply.Add(modelPurchaseApply);
                            }
                        }
                    }
                }
            }
            return listPurchaseApply;
        }

        public Boolean CancelProduceApply(List<ModelProduceApply> _listCancelApply)
        {
            int rtn = m_dalProduce.CancelProduceApply(_listCancelApply);

            return rtn > 0 ? true : false;
        }

        public ModelProduce GetProduceById(int _produceId)
        {
            ModelProduce modelProduce = new ModelProduce();

            DataTable dt = m_dalProduce.GetProduceById(_produceId);

            if (dt != null && dt.Rows.Count > 0)
            {
                modelProduce = ModelUtils<ModelProduce>.FillModel(dt.Rows[0]);
            }

            return modelProduce;
        }

        public Boolean AddProduce(ModelProduce _model)
        {
            int rtn = 0;

            _model.produceCode = BllSeq.GetCode("produceCode");

            // 已生产的作成入库单
            if (_model.status == (int)Enum.EnumProduceOrderStatus.Produced)
            {
                ModelProductIn modelProductIn = new ModelProductIn();

                modelProductIn.inputCode = BllSeq.GetCode("productInCode");
                modelProductIn.factoryId = _model.factoryId;
                modelProductIn.productId = _model.productId;
                modelProductIn.inputNum = _model.num;
                modelProductIn.stockNum = _model.num;
                modelProductIn.produceDate = DateTime.Now;
                modelProductIn.expiresDate = DateTime.Now.AddDays(m_bllProduct.GetProductById(_model.productId).expiredDays);
                modelProductIn.produceCode = _model.produceCode;
                modelProductIn.inputType = (int)Enum.EnumProductInType.Produce;
                modelProductIn.inputStatus = 0;
                modelProductIn.isDelete = 0;
                modelProductIn.createBy = _model.createBy;
                modelProductIn.createTime = _model.createTime;

                rtn = m_dalProduce.AddProduce(_model, modelProductIn);
            }
            else
            {
                rtn = m_dalProduce.AddProduce(_model, null);
            }


            return rtn > 0 ? true : false;
        }

        public Boolean UpdateProduce(ModelProduce _model)
        {
            int rtn = 0;

            // 已生产的作成入库单
            if (_model.status == (int)Enum.EnumProduceOrderStatus.Produced)
            {
                ModelProductIn modelProductIn = new ModelProductIn();

                modelProductIn.inputCode = BllSeq.GetCode("productInCode");
                modelProductIn.factoryId = _model.factoryId;
                modelProductIn.productId = _model.productId;
                modelProductIn.inputNum = _model.num;
                modelProductIn.stockNum = _model.num;
                modelProductIn.produceDate = DateTime.Now;
                modelProductIn.expiresDate = DateTime.Now.AddDays(m_bllProduct.GetProductById(_model.productId).expiredDays);
                modelProductIn.produceCode = _model.produceCode;
                modelProductIn.inputType = (int)Enum.EnumProductInType.Produce;
                modelProductIn.inputStatus = 0;
                modelProductIn.isDelete = 0;
                modelProductIn.createBy = _model.createBy;
                modelProductIn.createTime = _model.createTime;

                rtn = m_dalProduce.UpdateProduce(_model, modelProductIn);
            }
            else
            {
                rtn = m_dalProduce.UpdateProduce(_model, null);
            } 

            return rtn > 0 ? true : false;
        }

        public Boolean DeleteProduce(ModelProduce _model)
        {
            int rtn = m_dalProduce.DeleteProduce(_model);

            return rtn > 0 ? true : false;
        }
    }
}
