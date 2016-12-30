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

        public Boolean ConfirmSaleOrder(ModelSaleOrder _model)
        {
            int rtn = 0;
            rtn = m_dalSaleOrder.UpdateSaleOrder(_model);

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
