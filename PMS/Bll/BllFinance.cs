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
    public class BllFinance : Bll.BllBase
    {
        private DalFinance m_dalFinance = new DalFinance();

        public DataTable GetSaleOrder(int _factoryId, int _customerId, int _salerId, string _name, int _orderStatus, DateTime _beginTime, DateTime _endTime)
        {
            DataTable dt = m_dalFinance.GetSaleOrder(_factoryId, _customerId, _salerId, _name, _orderStatus, _beginTime, _endTime);

            return dt;
        }
        public DataTable GetSaleOrderExport(int _factoryId, int _customerId, int _salerId, string _name, int _orderStatus, DateTime _beginTime, DateTime _endTime)
        {
            DataTable dt = m_dalFinance.GetSaleOrderExport(_factoryId, _customerId, _salerId, _name, _orderStatus, _beginTime, _endTime);

            return dt;
        }

        public DataTable GetPurchaseOrder(int _factoryId, int _customerId, int _salerId, string _name, int _orderStatus, DateTime _beginTime, DateTime _endTime)
        {
            DataTable dt = m_dalFinance.GetPurchaseOrder(_factoryId, _customerId, _salerId, _name, _orderStatus, _beginTime, _endTime);

            return dt;
        }

        public DataTable GetPurchaseOrderExport(int _factoryId, int _customerId, int _salerId, string _name, int _orderStatus, DateTime _beginTime, DateTime _endTime)
        {
            DataTable dt = m_dalFinance.GetPurchaseOrderExport(_factoryId, _customerId, _salerId, _name, _orderStatus, _beginTime, _endTime);

            return dt;
        }

        public Boolean AddReceivedDetail(ModelFinanceReceivedDetail _model)
        {
            int rtn = m_dalFinance.AddReceivedDetail(_model);

            return rtn > 0 ? true : false;
        }

        public ModelFinanceReceive GetReceiveById(int _receiveId)
        {
            ModelFinanceReceive model = new ModelFinanceReceive();
            DataTable dt = m_dalFinance.GetReceiveById(_receiveId);
            if (dt != null && dt.Rows.Count > 0)
            {
                model = ModelUtils<ModelFinanceReceive>.FillModel(dt.Rows[0]);
            }

            return model;
        }

        public DataTable GetReceivedDetailByOrderCode(string _orderCode)
        {
            return m_dalFinance.GetReceivedDetailByOrderCode(_orderCode);
        }

        public DataTable GetReceive(int _factoryId, int _customerId, int _salerId, string _name, int _orderStatus, int _receiveStatus)
        {
            DataTable dt = m_dalFinance.GetReceive(_factoryId, _customerId, _salerId, _name, _orderStatus, _receiveStatus);

            return dt;
        }

        public DataTable GetReceiveExport(int _factoryId, int _customerId, int _salerId, string _name, int _orderStatus, int _receiveStatus)
        {
            DataTable dt = m_dalFinance.GetReceiveExport(_factoryId, _customerId, _salerId, _name, _orderStatus, _receiveStatus);

            return dt;
        }

        public Boolean AddPaidDetail(ModelFinancePaidDetail _model)
        {
            int rtn = m_dalFinance.AddPaidDetail(_model);

            return rtn > 0 ? true : false;
        }

        public ModelFinancePaid GetPaidById(int _paidId)
        {
            ModelFinancePaid model = new ModelFinancePaid();
            DataTable dt = m_dalFinance.GetPaidById(_paidId);
            if (dt != null && dt.Rows.Count > 0)
            {
                model = ModelUtils<ModelFinancePaid>.FillModel(dt.Rows[0]);
            }

            return model;
        }

        public DataTable GetPaidDetailByPurchaseCode(string _purchaseCode)
        {
            return m_dalFinance.GetPaidDetailByPurchaseCode(_purchaseCode);
        }

        public DataTable GetPaid(int _factoryId, int _customerId, int _userId, string _name, int _purchaseStatus, int _paidStatus)
        {
            DataTable dt = m_dalFinance.GetPaid(_factoryId, _customerId, _userId, _name, _purchaseStatus, _paidStatus);

            return dt;
        }
        public DataTable GetPaidExport(int _factoryId, int _customerId, int _userId, string _name, int _purchaseStatus, int _paidStatus)
        {
            DataTable dt = m_dalFinance.GetPaidExport(_factoryId, _customerId, _userId, _name, _purchaseStatus, _paidStatus);

            return dt;
        }
    }
}
