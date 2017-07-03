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
        private BllProduct m_bllProduct = new BllProduct();
        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllFactory m_bllFactory = new BllFactory();
        private BllUser m_bllUser = new BllUser();
        private DalPurchase m_dalPurchase = new DalPurchase();
        private DalMaterials m_dalMaterials = new DalMaterials();

        public Boolean AddPurchaseApply(List<ModelPurchaseApply> _listPurchaseApply)
        {
            int rtn = 0;
            rtn = m_dalPurchase.AddPurchaseApply(_listPurchaseApply);

            return rtn == 0 ? false : true;
        }

        public DataTable GetPurchaseApply(string _materialsName, int _factoryId, DateTime _beginTime, DateTime _endTime)
        {
            return m_dalPurchase.GetPurchaseApply(_materialsName, _factoryId, _beginTime, _endTime);
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

        public DataTable GetPurchaseDetailByPurchaseCode(string _purchaseCode)
        {
            return m_dalPurchase.GetPurchaseDetailByPurchaseCode(_purchaseCode);
        }
        
        public Result SubmitPurchaseApply(List<Dictionary<string, object>> _listApply,int _purchaserid, int _loginUserId)
        {

            Result returnResult = new Result();

            ModelUser modelUser = m_bllUser.GetUserById(_loginUserId);


            //更新采购申请表用（key：申请ID；value：生产单号）
            Dictionary<int, string> dcApply = new Dictionary<int, string>();
            //新建采购用（key：工厂ID；value：采购信息）
            Dictionary<int, object> dcFactory = new Dictionary<int, object>();

            foreach (Dictionary<string, object> apply in _listApply)
            {
                int applyId = ConvertUtils.ConvertToInt(apply["applyId"]);
                int factoryId = ConvertUtils.ConvertToInt(apply["factoryId"]);
                int customerId = ConvertUtils.ConvertToInt(apply["customerId"]);
                int materialsId = ConvertUtils.ConvertToInt(apply["materialsId"]);
                int specsId = ConvertUtils.ConvertToInt(apply["specsId"]);
                int purchaseNum = ConvertUtils.ConvertToInt(apply["purchaseNum"]);
                decimal purchasePrice = ConvertUtils.ConvertToDecimal(apply["purchasePrice"]);
                decimal applyNum = ConvertUtils.ConvertToDecimal(apply["num"]);
                DateTime deliveryDate = ConvertUtils.ConvertToDate(apply["deliveryDate"], "yyyy-MM-dd");
                string applyBy = ConvertUtils.ConvertToString(apply["applyBy"]);
                DateTime applyDate = ConvertUtils.ConvertToDate(apply["applyDate"], "yyyy-MM-dd");
                string produceCode = ConvertUtils.ConvertToString(apply["produceCode"]);

                //采购信息（key：原料ID；value：采购信息【生产单号，采购数量】)
                Dictionary<int, object> dcCustomer;
                if (dcFactory.ContainsKey(factoryId))
                {
                    dcCustomer = (Dictionary<int, object>)dcFactory[factoryId];

                    ModelPurchase modelPurchase;
                    if (dcCustomer.ContainsKey(customerId))
                    {
                        modelPurchase = (ModelPurchase)dcCustomer[customerId];

                        List<ModelPurchaseDetail> litsModelPurchaseDetail = modelPurchase.modelPurchaseDetail;

                        bool isAdd = false;
                        foreach (ModelPurchaseDetail modelPurchaseDetail in litsModelPurchaseDetail)
                        {
                            if (modelPurchaseDetail.materialsId == materialsId)
                            {
                                modelPurchaseDetail.num = modelPurchaseDetail.num + purchaseNum;

                                if (DateTime.Compare(deliveryDate, modelPurchaseDetail.deliveryDate) < 0)
                                {
                                    modelPurchaseDetail.deliveryDate = deliveryDate;
                                }

                                if (DateTime.Compare(deliveryDate, modelPurchase.deliveryDate) < 0)
                                {
                                    modelPurchase.deliveryDate = deliveryDate;
                                }

                                dcApply.Add(applyId, modelPurchaseDetail.purchaseCode);

                                isAdd = true;
                                break;
                            }

                        }
                        if (isAdd == false)
                        {
                            ModelPurchaseDetail modelPurchaseDetail = new ModelPurchaseDetail();
                            modelPurchaseDetail.materialsId = materialsId;
                            modelPurchaseDetail.specsId = specsId;
                            modelPurchaseDetail.purchaseCode = modelPurchase.purchaseCode;
                            modelPurchaseDetail.inputCode = BllSeq.GetCode("ylrk", "materialsInCode");
                            modelPurchaseDetail.produceCode = produceCode;
                            modelPurchaseDetail.num = purchaseNum;
                            modelPurchaseDetail.price = purchasePrice;
                            modelPurchaseDetail.applyBy = applyBy;
                            modelPurchaseDetail.applyDate = applyDate;
                            modelPurchaseDetail.deliveryDate = deliveryDate;
                            modelPurchaseDetail.isDelete = 0;
                            modelPurchaseDetail.createBy = modelUser.userName;
                            modelPurchaseDetail.createTime = DateTime.Now;
                            litsModelPurchaseDetail.Add(modelPurchaseDetail);

                            dcApply.Add(applyId, modelPurchase.purchaseCode);
                        }

                        modelPurchase.price = modelPurchase.price + purchasePrice * purchaseNum;
                    }
                    else
                    {
                        string purchaseCode = BllSeq.GetCode("cgdd", "purchaseCode");
                        modelPurchase = new ModelPurchase();
                        ModelFactory modelFactory = m_bllFactory.GetFactoryById(factoryId);

                        modelPurchase.factoryId = factoryId;
                        modelPurchase.customerId = customerId;
                        modelPurchase.purchaseCode = purchaseCode;
                        modelPurchase.deliveryDate = deliveryDate;
                        modelPurchase.purchaserId = _purchaserid;
                        modelPurchase.purchaseDate = DateTime.Now;
                        modelPurchase.price = purchasePrice * purchaseNum;
                        modelPurchase.payType = (int)Enum.EnumPayType.HDFK;
                        modelPurchase.status = (int)Enum.EnumPurchaseOrderStatus.Purchasing;
                        modelPurchase.country = modelFactory.country;
                        modelPurchase.province = modelFactory.province;
                        modelPurchase.provinceName = modelFactory.provinceName;
                        modelPurchase.city = modelFactory.city;
                        modelPurchase.cityName = modelFactory.cityName;
                        modelPurchase.district = modelFactory.district;
                        modelPurchase.districtName = modelFactory.districtName;
                        modelPurchase.address = modelFactory.address;
                        modelPurchase.manager = modelUser.userName;
                        modelPurchase.telephone = modelUser.telphone;
                        modelPurchase.isDelete = 0;
                        modelPurchase.createBy = modelUser.userName;
                        modelPurchase.createTime = DateTime.Now;

                        List<ModelPurchaseDetail> litsModelPurchaseDetail = new List<ModelPurchaseDetail>();
                        ModelPurchaseDetail modelPurchaseDetail = new ModelPurchaseDetail();
                        modelPurchaseDetail.materialsId = materialsId;
                        modelPurchaseDetail.specsId = specsId;
                        modelPurchaseDetail.purchaseCode = modelPurchase.purchaseCode;
                        modelPurchaseDetail.inputCode = BllSeq.GetCode("ylrk", "materialsInCode");
                        modelPurchaseDetail.produceCode = produceCode;
                        modelPurchaseDetail.num = purchaseNum;
                        modelPurchaseDetail.price = purchasePrice;
                        modelPurchaseDetail.applyBy = applyBy;
                        modelPurchaseDetail.applyDate = applyDate;
                        modelPurchaseDetail.deliveryDate = deliveryDate;
                        modelPurchaseDetail.isDelete = 0;
                        modelPurchaseDetail.createBy = modelUser.userName;
                        modelPurchaseDetail.createTime = DateTime.Now;
                        litsModelPurchaseDetail.Add(modelPurchaseDetail);

                        modelPurchase.modelPurchaseDetail = litsModelPurchaseDetail;
                        dcCustomer.Add(customerId, modelPurchase);
                        dcApply.Add(applyId, modelPurchase.purchaseCode);

                    }
                }
                else
                {
                    dcCustomer = new Dictionary<int, object>(); 
                    string purchaseCode = BllSeq.GetCode("cgdd", "purchaseCode");
                    ModelPurchase modelPurchase = new ModelPurchase();
                    ModelFactory modelFactory = m_bllFactory.GetFactoryById(factoryId);

                    modelPurchase.factoryId = factoryId;
                    modelPurchase.customerId = customerId;
                    modelPurchase.purchaseCode = purchaseCode;
                    modelPurchase.deliveryDate = deliveryDate;
                    modelPurchase.purchaserId = _purchaserid;
                    modelPurchase.purchaseDate = DateTime.Now;
                    modelPurchase.price = purchasePrice * purchaseNum;
                    modelPurchase.payType = (int)Enum.EnumPayType.HDFK;
                    modelPurchase.status = (int)Enum.EnumPurchaseOrderStatus.Purchasing;
                    modelPurchase.country = modelFactory.country;
                    modelPurchase.province = modelFactory.province;
                    modelPurchase.provinceName = modelFactory.provinceName;
                    modelPurchase.city = modelFactory.city;
                    modelPurchase.cityName = modelFactory.cityName;
                    modelPurchase.district = modelFactory.district;
                    modelPurchase.districtName = modelFactory.districtName;
                    modelPurchase.address = modelFactory.address;
                    modelPurchase.manager = modelUser.userName;
                    modelPurchase.telephone = modelUser.telphone;
                    modelPurchase.isDelete = 0;
                    modelPurchase.createBy = modelUser.userName;
                    modelPurchase.createTime = DateTime.Now;

                    List<ModelPurchaseDetail> litsModelPurchaseDetail = new List<ModelPurchaseDetail>();
                    ModelPurchaseDetail modelPurchaseDetail = new ModelPurchaseDetail();
                    modelPurchaseDetail.materialsId = materialsId;
                    modelPurchaseDetail.specsId = specsId;
                    modelPurchaseDetail.purchaseCode = modelPurchase.purchaseCode;
                    modelPurchaseDetail.inputCode = BllSeq.GetCode("ylrk", "materialsInCode");
                    modelPurchaseDetail.produceCode = produceCode;
                    modelPurchaseDetail.num = purchaseNum;
                    modelPurchaseDetail.price = purchasePrice;
                    modelPurchaseDetail.applyBy = applyBy;
                    modelPurchaseDetail.applyDate = applyDate;
                    modelPurchaseDetail.deliveryDate = deliveryDate;
                    modelPurchaseDetail.isDelete = 0;
                    modelPurchaseDetail.createBy = modelUser.userName;
                    modelPurchaseDetail.createTime = DateTime.Now;
                    litsModelPurchaseDetail.Add(modelPurchaseDetail);

                    modelPurchase.modelPurchaseDetail = litsModelPurchaseDetail;
                    dcCustomer.Add(customerId, modelPurchase);
                    dcFactory.Add(factoryId, dcCustomer);
                    dcApply.Add(applyId, purchaseCode);
                }
            }

            int rtn = m_dalPurchase.SubmitPurchaseApply(dcApply, dcFactory);

            if (rtn > 0)
            {
                returnResult.resultCode = Enum.EnumResultCode.Success;

                List<ModelMaterialsPrice> listModelMaterialsPrice = new List<ModelMaterialsPrice>();

                //设置原料价格（采购价格）
                foreach (KeyValuePair<int, object> kvp_factory in dcFactory)
                {
                    Dictionary<int, object> dcPurchase = (Dictionary<int, object>)kvp_factory.Value;

                    foreach (KeyValuePair<int, object> kvp_purchase in dcPurchase)
                    {

                        ModelPurchase modelPurchase = (ModelPurchase)kvp_purchase.Value;
                        foreach (ModelPurchaseDetail modelDetail in modelPurchase.modelPurchaseDetail)
                        {

                            ModelMaterialsPrice modelMaterialsPrice = new ModelMaterialsPrice();
                            modelMaterialsPrice.materialsId = modelDetail.materialsId;
                            modelMaterialsPrice.specsId = modelDetail.specsId;
                            modelMaterialsPrice.price = modelDetail.price;
                            modelMaterialsPrice.isDelete = 0;
                            modelMaterialsPrice.createBy = modelPurchase.createBy;
                            modelMaterialsPrice.createTime = modelPurchase.createTime;
                            modelMaterialsPrice.modifyBy = modelPurchase.modifyBy;
                            modelMaterialsPrice.modifyTime = modelPurchase.modifyTime;

                            listModelMaterialsPrice.Add(modelMaterialsPrice);
                        }
                    }
                }
                m_dalMaterials.UpdateMaterialsPrice(listModelMaterialsPrice);

                //设置成品价格（原料价格）
                List<ModelProductPrice> listModelProductPrice = new List<ModelProductPrice>();
                foreach (KeyValuePair<int, object> kvp_factory in dcFactory)
                {
                    Dictionary<int, object> dcPurchase = (Dictionary<int, object>)kvp_factory.Value;

                    foreach (KeyValuePair<int, object> kvp_purchase in dcPurchase)
                    {

                        ModelPurchase modelPurchase = (ModelPurchase)kvp_purchase.Value;
                        foreach (ModelPurchaseDetail modelDetail in modelPurchase.modelPurchaseDetail)
                        {
                            DataTable dtProductSpecs = m_bllProduct.GetProductSpecsByMaterialsId(modelDetail.materialsId);
                            if (dtProductSpecs != null && dtProductSpecs.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dtProductSpecs.Rows)
                                {
                                    int productId = ConvertUtils.ConvertToInt(dr["productId"]);
                                    int specsId = ConvertUtils.ConvertToInt(dr["specsId"]);
                                    decimal weight = ConvertUtils.ConvertToDecimal(dr["weight"]);
                                    int num = ConvertUtils.ConvertToInt(dr["num"]);

                                    DataTable dtProductMaterials = m_bllProduct.GetProductMaterialsById(productId);
                                    if (dtProductMaterials != null && dtProductMaterials.Rows.Count > 0)
                                    {
                                        decimal unitProductPrice = 0;
                                        foreach (DataRow drMaterials in dtProductMaterials.Rows)
                                        {
                                            int materialsId = ConvertUtils.ConvertToInt(drMaterials["materialsId"]);
                                            decimal percent = ConvertUtils.ConvertToDecimal(drMaterials["percent"]);

                                            decimal unitMaterialsPrice = 0;
                                            ModelMaterialsPrice modelMaterialsPrice = m_bllMaterials.GetMaterialsPriceByMaterialsId(materialsId);
                                            if (modelMaterialsPrice.specsId > 0)
                                            {
                                                ModelMaterialsSpecs modelMaterialsSpecs = m_bllMaterials.GetMaterialsSpecsById(modelMaterialsPrice.specsId);
                                                unitMaterialsPrice = ConvertUtils.ConvertToDecimal(modelMaterialsPrice.price / (modelMaterialsSpecs.weight * modelMaterialsSpecs.num),4);
                                            }
                                            else
                                            {
                                                unitMaterialsPrice = modelMaterialsPrice.price;
                                            }

                                            unitProductPrice = unitProductPrice + ConvertUtils.ConvertToDecimal(unitMaterialsPrice * percent / 100, 4);
                                        }

                                        decimal productPrice = ConvertUtils.ConvertToDecimal(unitProductPrice * weight * num);

                                        ModelProductPrice modelProductPrice = new ModelProductPrice();
                                        modelProductPrice.productId = productId;
                                        modelProductPrice.specsId = specsId;
                                        modelProductPrice.minPrice = productPrice * ConvertUtils.ConvertToDecimal(m_bllCode.GetSubCode((int)Enum.EnumCode.AdvisePrice, 1).value1);
                                        modelProductPrice.advisePrice = productPrice * ConvertUtils.ConvertToDecimal(m_bllCode.GetSubCode((int)Enum.EnumCode.AdvisePrice, 2).value1);
                                        modelProductPrice.isDelete = 0;
                                        modelProductPrice.createBy = modelPurchase.createBy;
                                        modelProductPrice.createTime = DateTime.Now;
                                        modelProductPrice.modifyBy = modelPurchase.createBy;
                                        modelProductPrice.modifyTime = DateTime.Now;

                                        listModelProductPrice.Add(modelProductPrice);
                                    }

                                }
                            }
                        }
                    }
                }
                m_bllProduct.UpdateProductPrice(listModelProductPrice);

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
        
        public string AddPurchase(ModelPurchase _model)
        {
            string rtnStr = "";

            _model.purchaseCode = BllSeq.GetCode("cgdd", "purchaseCode");
            int rtn = m_dalPurchase.AddPurchase(_model);

            if (rtn > 0)
            {
                rtnStr = _model.purchaseCode;

                List<ModelMaterialsPrice> listModelMaterialsPrice = new List<ModelMaterialsPrice>();

                //设置原料价格（采购价格）
                foreach (ModelPurchaseDetail modelDetail in _model.modelPurchaseDetail)
                {
                    ModelMaterialsPrice modelMaterialsPrice = new ModelMaterialsPrice();
                    modelMaterialsPrice.materialsId = modelDetail.materialsId;
                    modelMaterialsPrice.specsId = modelDetail.specsId;
                    modelMaterialsPrice.price = modelDetail.price;
                    modelMaterialsPrice.isDelete = 0;
                    modelMaterialsPrice.createBy = _model.createBy;
                    modelMaterialsPrice.createTime = _model.createTime;
                    modelMaterialsPrice.modifyBy = _model.modifyBy;
                    modelMaterialsPrice.modifyTime = _model.modifyTime;

                    listModelMaterialsPrice.Add(modelMaterialsPrice);

                }
                m_dalMaterials.UpdateMaterialsPrice(listModelMaterialsPrice);

                //设置成品价格（原料价格）
                List<ModelProductPrice> listModelProductPrice = new List<ModelProductPrice>();
                foreach (ModelPurchaseDetail modelDetail in _model.modelPurchaseDetail)
                {
                    DataTable dtProductSpecs = m_bllProduct.GetProductSpecsByMaterialsId(modelDetail.materialsId);
                    if (dtProductSpecs != null && dtProductSpecs.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtProductSpecs.Rows)
                        {
                            int productId = ConvertUtils.ConvertToInt(dr["productId"]);
                            int specsId = ConvertUtils.ConvertToInt(dr["specsId"]);
                            decimal weight = ConvertUtils.ConvertToDecimal(dr["weight"]);
                            int num = ConvertUtils.ConvertToInt(dr["num"]);

                            DataTable dtProductMaterials = m_bllProduct.GetProductMaterialsById(productId);
                            if (dtProductMaterials != null && dtProductMaterials.Rows.Count > 0)
                            {
                                decimal unitProductPrice = 0;
                                foreach (DataRow drMaterials in dtProductMaterials.Rows)
                                {
                                    int materialsId = ConvertUtils.ConvertToInt(drMaterials["materialsId"]);
                                    decimal percent = ConvertUtils.ConvertToDecimal(drMaterials["percent"]);

                                    decimal unitMaterialsPrice = 0;
                                    ModelMaterialsPrice modelMaterialsPrice = m_bllMaterials.GetMaterialsPriceByMaterialsId(materialsId);
                                    if (modelMaterialsPrice.specsId > 0)
                                    {
                                        ModelMaterialsSpecs modelMaterialsSpecs = m_bllMaterials.GetMaterialsSpecsById(modelMaterialsPrice.specsId);
                                        unitMaterialsPrice = ConvertUtils.ConvertToDecimal(modelMaterialsPrice.price / (modelMaterialsSpecs.weight * modelMaterialsSpecs.num), 4);
                                    }
                                    else
                                    {
                                        unitMaterialsPrice = modelMaterialsPrice.price;
                                    }

                                    unitProductPrice = unitProductPrice + ConvertUtils.ConvertToDecimal(unitMaterialsPrice * percent / 100, 4);
                                }

                                decimal productPrice = ConvertUtils.ConvertToDecimal(unitProductPrice * weight * num);

                                ModelProductPrice modelProductPrice = new ModelProductPrice();
                                modelProductPrice.productId = productId;
                                modelProductPrice.specsId = specsId;
                                modelProductPrice.minPrice = productPrice * ConvertUtils.ConvertToDecimal(m_bllCode.GetSubCode((int)Enum.EnumCode.AdvisePrice, 1).value1);
                                modelProductPrice.advisePrice = productPrice * ConvertUtils.ConvertToDecimal(m_bllCode.GetSubCode((int)Enum.EnumCode.AdvisePrice, 2).value1);
                                modelProductPrice.isDelete = 0;
                                modelProductPrice.createBy = _model.modifyBy;
                                modelProductPrice.createTime = DateTime.Now;
                                modelProductPrice.modifyBy = _model.modifyBy;
                                modelProductPrice.modifyTime = DateTime.Now;

                                listModelProductPrice.Add(modelProductPrice);
                            }

                        }
                    }
                }
                m_bllProduct.UpdateProductPrice(listModelProductPrice);
            }

            return rtnStr;
        }

        public Boolean UpdatePurchase(ModelPurchase _model)
        {
            int rtn = m_dalPurchase.UpdatePurchase(_model);

            if (rtn > 0)
            {
                //设置原料价格（采购价格）
                List<ModelMaterialsPrice> listModelMaterialsPrice = new List<ModelMaterialsPrice>();

                foreach (ModelPurchaseDetail modelDetail in _model.modelPurchaseDetail)
                {
                    ModelMaterialsPrice modelMaterialsPrice = new ModelMaterialsPrice();
                    modelMaterialsPrice.materialsId = modelDetail.materialsId;
                    modelMaterialsPrice.specsId = modelDetail.specsId;
                    modelMaterialsPrice.price = modelDetail.price;
                    modelMaterialsPrice.isDelete = 0;
                    modelMaterialsPrice.createBy = _model.createBy;
                    modelMaterialsPrice.createTime = _model.createTime;
                    modelMaterialsPrice.modifyBy = _model.modifyBy;
                    modelMaterialsPrice.modifyTime = _model.modifyTime;

                    listModelMaterialsPrice.Add(modelMaterialsPrice);
                }
                rtn = m_dalMaterials.UpdateMaterialsPrice(listModelMaterialsPrice);

                //设置成品价格（原料价格）
                List<ModelProductPrice> listModelProductPrice = new List<ModelProductPrice>();
                foreach (ModelPurchaseDetail modelDetail in _model.modelPurchaseDetail)
                {
                    DataTable dtProductSpecs = m_bllProduct.GetProductSpecsByMaterialsId(modelDetail.materialsId);
                    if (dtProductSpecs != null && dtProductSpecs.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtProductSpecs.Rows)
                        {
                            int productId = ConvertUtils.ConvertToInt(dr["productId"]);
                            int specsId = ConvertUtils.ConvertToInt(dr["specsId"]);
                            decimal weight = ConvertUtils.ConvertToDecimal(dr["weight"]);
                            int num = ConvertUtils.ConvertToInt(dr["num"]);

                            DataTable dtProductMaterials = m_bllProduct.GetProductMaterialsById(productId);
                            if (dtProductMaterials != null && dtProductMaterials.Rows.Count > 0)
                            {
                                decimal unitProductPrice = 0;
                                foreach (DataRow drMaterials in dtProductMaterials.Rows)
                                {
                                    int materialsId = ConvertUtils.ConvertToInt(drMaterials["materialsId"]);
                                    decimal percent = ConvertUtils.ConvertToDecimal(drMaterials["percent"]);

                                    decimal unitMaterialsPrice = 0;
                                    ModelMaterialsPrice modelMaterialsPrice = m_bllMaterials.GetMaterialsPriceByMaterialsId(materialsId);
                                    if (modelMaterialsPrice.specsId > 0)
                                    {
                                        ModelMaterialsSpecs modelMaterialsSpecs = m_bllMaterials.GetMaterialsSpecsById(modelMaterialsPrice.specsId);
                                        unitMaterialsPrice = ConvertUtils.ConvertToDecimal(modelMaterialsPrice.price / (modelMaterialsSpecs.weight * modelMaterialsSpecs.num), 4);
                                    }
                                    else
                                    {
                                        unitMaterialsPrice = modelMaterialsPrice.price;
                                    }

                                    unitProductPrice = unitProductPrice + ConvertUtils.ConvertToDecimal(unitMaterialsPrice * percent / 100, 4);
                                }

                                decimal productPrice = ConvertUtils.ConvertToDecimal(unitProductPrice * weight * num);

                                ModelProductPrice modelProductPrice = new ModelProductPrice();
                                modelProductPrice.productId = productId;
                                modelProductPrice.specsId = specsId;
                                modelProductPrice.minPrice = productPrice * ConvertUtils.ConvertToDecimal(m_bllCode.GetSubCode((int)Enum.EnumCode.AdvisePrice, 1).value1);
                                modelProductPrice.advisePrice = productPrice * ConvertUtils.ConvertToDecimal(m_bllCode.GetSubCode((int)Enum.EnumCode.AdvisePrice, 2).value1);
                                modelProductPrice.isDelete = 0;
                                modelProductPrice.createBy = _model.modifyBy;
                                modelProductPrice.createTime = DateTime.Now;
                                modelProductPrice.modifyBy = _model.modifyBy;
                                modelProductPrice.modifyTime = DateTime.Now;

                                listModelProductPrice.Add(modelProductPrice);
                            }

                        }
                    }
                }
                m_bllProduct.UpdateProductPrice(listModelProductPrice);
            }
            return rtn > 0 ? true : false;
        }

        //public Boolean ConfirmPurchase(ModelPurchase _model)
        //{
        //    int rtn = m_dalPurchase.ConfirmPurchase(_model);

        //    return rtn > 0 ? true : false;
        //}

        public Boolean CancelPurchase(ModelPurchase _model)
        {
            int rtn = m_dalPurchase.CancelPurchase(_model);

            return rtn > 0 ? true : false;
        }

        public Boolean DeletePurchase(ModelPurchase _model)
        {
            int rtn = m_dalPurchase.DeletePurchase(_model);

            if (rtn > 0)
            {
                 //设置原料价格（采购价格）
                List<ModelMaterialsPrice> listModelMaterialsPrice = new List<ModelMaterialsPrice>();

                foreach (ModelPurchaseDetail modelDetail in _model.modelPurchaseDetail)
                {
                    //恢复原料价格
                    ModelPurchaseDetail modelPurchaseDetail = GetLastPurchase(modelDetail.materialsId, modelDetail.specsId);
                    if (modelPurchaseDetail.id > 0)
                    {
                        ModelMaterialsPrice modelMaterialsPrice = new ModelMaterialsPrice();
                        modelMaterialsPrice.materialsId = modelDetail.materialsId;
                        modelMaterialsPrice.specsId = modelDetail.specsId;
                        modelMaterialsPrice.price = modelPurchaseDetail.price;
                        modelMaterialsPrice.isDelete = 0;
                        modelMaterialsPrice.createBy = _model.createBy;
                        modelMaterialsPrice.createTime = _model.createTime;
                        modelMaterialsPrice.modifyBy = _model.modifyBy;
                        modelMaterialsPrice.modifyTime = _model.modifyTime;

                        listModelMaterialsPrice.Add(modelMaterialsPrice);
                    }
                }

                rtn = m_dalMaterials.UpdateMaterialsPrice(listModelMaterialsPrice); 
            }

            return rtn > 0 ? true : false;
        }

        public ModelPurchaseDetail GetLastPurchase(int _materialsId, int _specsId)
        {
            DataTable dt = m_dalPurchase.GetLastPurchase(_materialsId, _specsId);

            if (dt != null && dt.Rows.Count > 0)
            {
                return Common.Tools.ModelUtils<ModelPurchaseDetail>.FillModel(dt.Rows[0]);
            }

            return new ModelPurchaseDetail();
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


        public Boolean AddPurchaseDetail(int _factoryId, int _customerId, ModelPurchaseDetail _model)
        {
            int rtn = 0;
            rtn = m_dalPurchase.AddPurchaseDetail(_factoryId, _customerId, _model);

            return rtn == 0 ? false : true;
        }

        public Boolean DetelePurchaseDetail(ModelPurchaseDetail _model)
        {
            int rtn = 0;
            rtn = m_dalPurchase.DetelePurchaseDetail(_model);

            return rtn == 0 ? false : true;
        }
    }
}
