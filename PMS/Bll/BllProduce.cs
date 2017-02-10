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

        public DataTable GetProduceApply(string _productName, int _factoryId, int _applyType, int _applyStatus, DateTime beginTime, DateTime _endTime)
        {
            return m_dalProduce.GetProduceApply(_productName, _factoryId, _applyType, _applyStatus, beginTime, _endTime);
        }

        public Result SubmitProduceApply(List<Dictionary<string, object>> _listApply, string _loginName)
        {

            Result returnResult = new Result();

            //更新生产申请表用（key：申请ID；value：生产单号）
            Dictionary<int, string> dcApply = new Dictionary<int, string>();
            //新建生产用（key：工厂ID；value：商品信息）
            Dictionary<int, object> dcFactory = new Dictionary<int, object>();

            foreach (Dictionary<string, object> apply in _listApply)
            {
                int applyId = ConvertUtils.ConvertToInt(apply["applyId"]);
                int factoryId = ConvertUtils.ConvertToInt(apply["factoryId"]);
                int productId = ConvertUtils.ConvertToInt(apply["productId"]);
                decimal applyNum = ConvertUtils.ConvertToDecimal(apply["num"]);
                int applyUnit = ConvertUtils.ConvertToInt(apply["unit"]);
                DateTime deliveryDate = ConvertUtils.ConvertToDate(apply["deliveryDate"], "yyyy-MM-dd");
                string applyBy = ConvertUtils.ConvertToString(apply["applyBy"]);
                int applyMemberId = ConvertUtils.ConvertToInt(apply["applyMemberId"]);
                DateTime applyDate = ConvertUtils.ConvertToDate(apply["applyDate"], "yyyy-MM-dd");

                //商品信息（key：商品ID；value：生产信息【生产单号，生产数量，数量单位】)
                Dictionary<int, object> dcProduct;
                if (dcFactory.ContainsKey(factoryId))
                {
                    dcProduct = (Dictionary<int, object>)dcFactory[factoryId];

                    ModelProduce modelProduce;
                    if (dcProduct.ContainsKey(productId))
                    {
                        modelProduce = (ModelProduce)dcProduct[productId];

                        int unit = modelProduce.unit;
                        decimal num = modelProduce.num;

                        applyNum = applyNum * m_bllCode.GetWeightUnit(applyUnit);
                        num = num * m_bllCode.GetWeightUnit(unit);
                        num = num + applyNum;
                        num = num / m_bllCode.GetWeightUnit(unit);

                        modelProduce.num = num;

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
                        modelProduce.unit = applyUnit;
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
                    modelProduce.unit = applyUnit;
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
            //List<ModelMaterialsOutput> listMaterialsOutput = new List<ModelMaterialsOutput>();
            foreach (KeyValuePair<int, object> kvp_factory in dcFactory)            {

                int factoryId = kvp_factory.Key;

                Dictionary<int, object> dcProduct = (Dictionary<int, object>)kvp_factory.Value;

                foreach (KeyValuePair<int, object> kvp_product in dcProduct)
                {
                    ModelProduce modelProduce = (ModelProduce)kvp_product.Value;
                    //商品ID
                    int productId = modelProduce.productId;
                    
                    //ModelMaterialsOutput modelMaterialsOutput = new ModelMaterialsOutput();
                    //modelMaterialsOutput.outputCode = BllSeq.GetCode("materialsOutputCode");
                    //modelMaterialsOutput.produceCode = modelProduce.produceCode;
                    //modelMaterialsOutput.factoryId = kvp_factory.Key;
                    //modelMaterialsOutput.materialsId = kvp_product.Key;
                    //modelMaterialsOutput.deliveryDate = modelProduce.deliveryDate;
                    //modelMaterialsOutput.outputStatus = 0;
                    //modelMaterialsOutput.outputType = 0;
                    //modelMaterialsOutput.outputDate = DateTime.Now;
                    //modelMaterialsOutput.applyBy = modelProduce.applyBy;
                    //modelMaterialsOutput.remark = "";
                    //modelMaterialsOutput.isDelete = 0;
                    //modelMaterialsOutput.createBy = _loginName;
                    //modelMaterialsOutput.createTime = DateTime.Now;

                    //List<ModelMaterialsOutputDetail> listMaterialsOutputDetail = new List<ModelMaterialsOutputDetail>();
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

                                    decimal outputNum = modelMaterialsOutput.outputNum;
                                    outputNum = outputNum * m_bllCode.GetWeightUnit(modelMaterialsOutput.outputUnit);

                                    decimal AddOutputNum = modelProduce.num * ConvertUtils.ConvertToDecimal(dr["percent"]) / 100;
                                    AddOutputNum = AddOutputNum * m_bllCode.GetWeightUnit(modelProduce.unit);

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
                                    modelMaterialsOutput.outputNum = modelProduce.num * ConvertUtils.ConvertToDecimal(dr["percent"]) / 100;
                                    modelMaterialsOutput.outputUnit = modelProduce.unit;
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
                                modelMaterialsOutput.outputNum = modelProduce.num * ConvertUtils.ConvertToDecimal(dr["percent"]) / 100;
                                modelMaterialsOutput.outputUnit = modelProduce.unit;
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

                            //ModelMaterialsOutputDetail modelMaterialsOutputDetail = new ModelMaterialsOutputDetail();

                            //modelMaterialsOutputDetail.outputCode = modelMaterialsOutput.outputCode;
                            //modelMaterialsOutputDetail.materialstId = ConvertUtils.ConvertToInt(dr["materialsId"]);
                            //modelMaterialsOutputDetail.materialsNum = modelProduce.num * ConvertUtils.ConvertToDecimal(dr["percent"]) / 100;
                            //modelMaterialsOutputDetail.materialsUnit = modelProduce.unit;
                            //modelMaterialsOutputDetail.outputStatus = 0;
                            //modelMaterialsOutputDetail.outputDate = DateTime.Now;
                            //modelMaterialsOutputDetail.remark = "";
                            //modelMaterialsOutputDetail.isDelete = 0;
                            //modelMaterialsOutputDetail.createBy = _loginName;
                            //modelMaterialsOutputDetail.createTime = DateTime.Now;

                            //listMaterialsOutputDetail.Add(modelMaterialsOutputDetail);
                        }
                    }

                    //modelMaterialsOutput.modelMaterialsOutputDetail = listMaterialsOutputDetail;
                    //listMaterialsOutput.Add(modelMaterialsOutput);
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

                    decimal num = modelProduce.num;
                    int unit = modelProduce.unit;
                    //商品数量（克）
                    num = num * m_bllCode.GetWeightUnit(unit);

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
                                modelPurchaseApply.num = (materialsNum - materialsStoreNum) / m_bllCode.GetWeightUnit(unit);
                                modelPurchaseApply.unit = unit;
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

    }
}
