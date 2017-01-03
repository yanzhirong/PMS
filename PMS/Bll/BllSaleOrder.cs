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
            int seq = Bll.BllSeq.GetSeq("saleOrder");
            string orderCode = ConvertUtils.ConvertToDate(DateTime.Now, "yyyyMMddHHmmss") + "_" + seq;
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
            ModelProductOutput modelProductStoreOut = new ModelProductOutput();
            int seq = Bll.BllSeq.GetSeq("ProductOutPut");
            string outputCode = ConvertUtils.ConvertToDate(DateTime.Now, "yyyyMMddHHmmss") + "_" + seq;
            modelProductStoreOut.outputCode = outputCode;
            modelProductStoreOut.orderId = _modelSaleOrder.id;
            modelProductStoreOut.factoryId = _modelSaleOrder.factoryId;
            modelProductStoreOut.delieryDate = _modelSaleOrder.deliverDate;
            modelProductStoreOut.outputStatus = 0;
            modelProductStoreOut.isDelete = 0;
            modelProductStoreOut.createBy = _modelSaleOrder.modifyBy;
            modelProductStoreOut.createTime = _modelSaleOrder.modifyTime;

            List<ModelProductOutputDetail> listDetail = new List<ModelProductOutputDetail>();
            foreach (ModelSaleOrderDetail modelSaleOrderDetail in _modelSaleOrder.modelSaleOrderDetail)
            {
                ModelProductOutputDetail modelProductStoreOutDetail = new ModelProductOutputDetail();
                modelProductStoreOutDetail.outputCode = modelProductStoreOut.outputCode;
                modelProductStoreOutDetail.productId = modelSaleOrderDetail.productId;
                modelProductStoreOutDetail.productNum = modelSaleOrderDetail.num;
                modelProductStoreOutDetail.outputStatus = 0;
                modelProductStoreOutDetail.isDelete = 0;
                modelProductStoreOutDetail.createBy = modelProductStoreOut.createBy;
                modelProductStoreOutDetail.createTime = modelProductStoreOut.createTime;
                listDetail.Add(modelProductStoreOutDetail);
            }

            modelProductStoreOut.modelProductOutputDetail = listDetail;

            rtn = m_dalSaleOrder.ConfirmSaleOrder(_modelSaleOrder, modelProductStoreOut);

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteSaleOrder(ModelSaleOrder _model)
        {
            int rtn = 0;
            rtn = m_dalSaleOrder.DeleteSaleOrder(_model);

            return rtn == 0 ? false : true;
        }
    }

}
