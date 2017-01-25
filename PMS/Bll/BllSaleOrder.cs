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
    public class BllSaleOrder : Bll.BllBase
    {
        private DalSaleOrder m_dalSaleOrder = new DalSaleOrder();
        private BllCode m_bllCode = new BllCode();
        private BllStroe m_bllStore = new BllStroe();
        private BllProduct m_bllProduct = new BllProduct();
        private BllProductOut m_bllProductOut = new BllProductOut();
        private BllProduce m_bllProduce = new BllProduce();
        
        public DataTable GetSaleOrders(String _code, String _name, int _salerId, int _status, DateTime _beginTime, DateTime _endTime, int _roleType)
        {
            DataTable dt = m_dalSaleOrder.GetSaleOrders(_code, _name, _salerId, _status, _beginTime, _endTime, _roleType);

            return dt;
        }

        public ModelSaleOrder GetSaleOrderByOrderCode(string _orderCode)
        {
            ModelSaleOrder model = new ModelSaleOrder();

            DataTable dt = m_dalSaleOrder.GetSaleOrderByOrderCode(_orderCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                model = ModelUtils<ModelSaleOrder>.FillModel(dt.Rows[0]);               
            }
            return model;
        }

        public ModelSaleOrder GetSaleOrderById(int _id)
        {
            ModelSaleOrder model = new ModelSaleOrder();

            DataTable dt = m_dalSaleOrder.GetSaleOrderById(_id);

            if (dt != null && dt.Rows.Count > 0)
            {
                model = ModelUtils<ModelSaleOrder>.FillModel(dt.Rows[0]);

                DataTable dtPay = m_dalSaleOrder.GetSaleOrderPayByOrderCode(model.orderCode);

                if(dtPay != null && dtPay.Rows.Count > 0)
                {
                    ModelSaleOrderPay modelPay = ModelUtils<ModelSaleOrderPay>.FillModel(dtPay.Rows[0]);
                    model.modelSaleOrderPay = modelPay;
                }

                DataTable dtDetail = m_dalSaleOrder.GetSaleOrderDetailByOrderCode(model.orderCode);

                if (dtDetail != null && dtDetail.Rows.Count > 0)
                {
                    List<ModelSaleOrderDetail> modelDetail = ModelUtils<ModelSaleOrderDetail>.FillModel(dtDetail);
                    model.modelSaleOrderDetail = modelDetail;
                }
            }
            return model;
        }

        public DataTable GetSaleOrderDetailByOrderCode(string _orderCode)
        {
            return m_dalSaleOrder.GetSaleOrderDetailByOrderCode(_orderCode);
        }

        public Boolean AddSaleOrder(ModelSaleOrder _model)
        {
            int rtn = 0;
            string orderCode = BllSeq.GetCode("saleOrderCode");
            _model.orderCode = orderCode;
            _model.orderStatus = (int)Enum.EnumSaleOrderStatus.WaitConfirm;
            rtn = m_dalSaleOrder.AddSaleOrder(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateSaleOrder(ModelSaleOrder _model)
        {
            int rtn = 0;
            rtn = m_dalSaleOrder.UpdateSaleOrder(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean ConfirmSaleOrder(ModelSaleOrder _modelSaleOrder)
        {
            int rtn = 0;

            //等待出库
            _modelSaleOrder.orderStatus = (int)Enum.EnumSaleOrderStatus.WaitTransport;

            //出库申请单
            ModelProductOutput modelProductOutput = new ModelProductOutput();
            string outputCode = BllSeq.GetCode("productOutCode");
            modelProductOutput.outputCode = outputCode;
            modelProductOutput.orderCode = _modelSaleOrder.orderCode;
            modelProductOutput.factoryId = _modelSaleOrder.factoryId;
            modelProductOutput.customerId = _modelSaleOrder.customerId;
            modelProductOutput.salerId = _modelSaleOrder.salerId;
            modelProductOutput.country = _modelSaleOrder.country;
            modelProductOutput.province = _modelSaleOrder.province;
            modelProductOutput.provinceName = _modelSaleOrder.provinceName;
            modelProductOutput.city = _modelSaleOrder.city;
            modelProductOutput.cityName = _modelSaleOrder.cityName;
            modelProductOutput.district = _modelSaleOrder.district;
            modelProductOutput.districtName = _modelSaleOrder.districtName;
            modelProductOutput.address = _modelSaleOrder.address;
            modelProductOutput.manager = _modelSaleOrder.manager;
            modelProductOutput.telephone = _modelSaleOrder.telephone;
            modelProductOutput.deliveryDate = _modelSaleOrder.deliveryDate;
            modelProductOutput.outputStatus = 0;
            modelProductOutput.outputType = 0;
            modelProductOutput.applyMemberId = _modelSaleOrder.salerId;
            modelProductOutput.isDelete = 0;
            modelProductOutput.createBy = _modelSaleOrder.modifyBy;
            modelProductOutput.createTime = _modelSaleOrder.modifyTime;

            List<ModelProductOutputDetail> listDetail = new List<ModelProductOutputDetail>();
            foreach (ModelSaleOrderDetail modelSaleOrderDetail in _modelSaleOrder.modelSaleOrderDetail)
            {
                ModelProductOutputDetail modelProductStoreOutDetail = new ModelProductOutputDetail();
                modelProductStoreOutDetail.outputCode = modelProductOutput.outputCode;
                modelProductStoreOutDetail.productId = modelSaleOrderDetail.productId;
                modelProductStoreOutDetail.productNum = modelSaleOrderDetail.num;
                modelProductStoreOutDetail.productUnit = modelSaleOrderDetail.unit;
                modelProductStoreOutDetail.outputStatus = 0;
                modelProductStoreOutDetail.isDelete = 0;
                modelProductStoreOutDetail.createBy = modelProductOutput.createBy;
                modelProductStoreOutDetail.createTime = modelProductOutput.createTime;
                listDetail.Add(modelProductStoreOutDetail);
            }

            modelProductOutput.modelProductOutputDetail = listDetail;

            rtn = m_dalSaleOrder.ConfirmSaleOrder(_modelSaleOrder, modelProductOutput);

            return rtn == 0 ? false : true;
        }

        public string CheckStore(ModelSaleOrder _model)
        {
            StringBuilder sb = new StringBuilder();

            List<ModelSaleOrderDetail> listSaleProduct = _model.modelSaleOrderDetail;
            foreach (ModelSaleOrderDetail saleProduct in listSaleProduct)
            {
                //销售商品的数量（单位:克）
                decimal saleNum = ConvertUtils.ConvertToDecimal(saleProduct.num) * m_bllCode.GetWeightUnit(saleProduct.unit);

                //查询商品库存（单位:克）
                decimal storeNum = m_bllStore.GetStoreProductNum(_model.factoryId, saleProduct.productId, _model.deliveryDate);

                if (saleNum > storeNum)
                {
                    ModelProduct modelProduct = m_bllProduct.GetProductById(saleProduct.productId);
                    sb.Append(modelProduct.name).Append(",");
                }
            }

            string rtn = sb.ToString();

            if (StringUtils.IsNotBlank(rtn))
            {
                rtn = rtn.Substring(0, rtn.Length - 1);
            }
            return rtn;
        }

        public Boolean AddProduceApply(ModelSaleOrder _model)
        {
            List<ModelProduceApply> listProduceApply = new List<ModelProduceApply>();

            foreach (ModelSaleOrderDetail saleProduct in _model.modelSaleOrderDetail)
            {
                //销售商品的数量（单位:克）
                decimal saleNum = ConvertUtils.ConvertToDecimal(saleProduct.num) * m_bllCode.GetWeightUnit(saleProduct.unit);

                //查询商品库存（单位:克）
                decimal storeNum = m_bllStore.GetStoreProductNum(_model.factoryId, saleProduct.productId, _model.deliveryDate);

                if (saleNum > storeNum)
                {
                    ModelProduceApply modelProduceApply = new ModelProduceApply();
                    modelProduceApply.factoryId = _model.factoryId;
                    modelProduceApply.productId = saleProduct.productId;
                    modelProduceApply.num = ConvertUtils.ConvertToDecimal((saleNum - storeNum) / m_bllCode.GetWeightUnit(saleProduct.unit));
                    modelProduceApply.unit = saleProduct.unit;
                    modelProduceApply.saleOrderCode =_model.orderCode;
                    modelProduceApply.outputCode = m_bllProductOut.GetProductOutrByOrderCode(_model.orderCode).outputCode;
                    modelProduceApply.deliveryDate = _model.deliveryDate;
                    modelProduceApply.applyType = 0;
                    modelProduceApply.applyBy = _model.modifyBy;
                    modelProduceApply.applyDate = DateTime.Now;
                    modelProduceApply.status = 0;
                    modelProduceApply.isDelete = 0;
                    modelProduceApply.createBy = _model.modifyBy;
                    modelProduceApply.createTime = DateTime.Now;

                    listProduceApply.Add(modelProduceApply);
                }
            }

            if (listProduceApply.Count > 0)
            {
                return m_bllProduce.AddProduceApply(listProduceApply);
            }
            return true;
        }

        public Boolean DeleteSaleOrder(ModelSaleOrder _model)
        {
            int rtn = 0;
            rtn = m_dalSaleOrder.DeleteSaleOrder(_model);

            return rtn == 0 ? false : true;
        }
    }

}
