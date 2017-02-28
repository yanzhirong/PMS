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
        private BllStore m_bllStore = new BllStore();
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
            string orderCode = BllSeq.GetCode("saleCode");
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

        public Boolean ConfirmSaleOrder(ModelSaleOrder _modelSaleOrder, int _loginId)
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
                modelProductStoreOutDetail.outputStatus = 0;
                modelProductStoreOutDetail.isDelete = 0;
                modelProductStoreOutDetail.createBy = modelProductOutput.createBy;
                modelProductStoreOutDetail.createTime = modelProductOutput.createTime;
                listDetail.Add(modelProductStoreOutDetail);
            }

            modelProductOutput.modelProductOutputDetail = listDetail;

            // 应收
            ModelFinanceReceive modelFinanceReceive = new ModelFinanceReceive();
            modelFinanceReceive.customerId = _modelSaleOrder.customerId;
            modelFinanceReceive.factoryId = _modelSaleOrder.factoryId;
            modelFinanceReceive.orderCode = _modelSaleOrder.orderCode;
            modelFinanceReceive.orderPrice = _modelSaleOrder.price;
            modelFinanceReceive.salerId = _modelSaleOrder.salerId;
            modelFinanceReceive.financeId = _loginId;
            modelFinanceReceive.deliveryDate = _modelSaleOrder.deliveryDate;
            modelFinanceReceive.remark = "";
            modelFinanceReceive.isDelete = 0;
            modelFinanceReceive.createBy = _modelSaleOrder.modifyBy;
            modelFinanceReceive.createTime = _modelSaleOrder.modifyTime;

            rtn = m_dalSaleOrder.ConfirmSaleOrder(_modelSaleOrder, modelProductOutput, modelFinanceReceive);

            return rtn == 0 ? false : true;
        }

        public string CheckStore(ModelSaleOrder _model)
        {
            StringBuilder sb = new StringBuilder();

            List<ModelSaleOrderDetail> listSaleProduct = _model.modelSaleOrderDetail;
            foreach (ModelSaleOrderDetail saleProduct in listSaleProduct)
            {

                //查询产品库存（单位:克）
                int storeNum = m_bllStore.GetStoreProductNum(_model.factoryId, saleProduct.productId, _model.deliveryDate);

                //销售产品的数量 > 产品库存
                if (saleProduct.num > storeNum)
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
                //查询产品库存数量
                int storeNum = m_bllStore.GetStoreProductNum(_model.factoryId, saleProduct.productId, _model.deliveryDate);

                // 订单中的销售数>库存数
                if (saleProduct.num > storeNum)
                {
                    ModelProduceApply modelProduceApply = new ModelProduceApply();
                    modelProduceApply.factoryId = _model.factoryId;
                    modelProduceApply.productId = saleProduct.productId;
                    modelProduceApply.num = saleProduct.num - storeNum;
                    modelProduceApply.saleOrderCode =_model.orderCode;
                    modelProduceApply.outputCode = m_bllProductOut.GetProductOutByOrderCode(_model.orderCode).outputCode;
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

        public Boolean CancelSaleOrder(ModelSaleOrder _model)
        {
            int rtn = 0;
            rtn = m_dalSaleOrder.CancelSaleOrder(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateSaleOrderStatus(List<ModelSaleOrder> _listSaleOrder)
        {
            int rtn = 0;
            rtn = m_dalSaleOrder.UpdateSaleOrderStatus(_listSaleOrder);

            return rtn == 0 ? false : true;
        }
    }

}
