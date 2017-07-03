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

        public DataTable GetAccounts(int _type, int _customerId, int _factoryId, DateTime _beginTime, DateTime _endTime)
        {
            DataTable dt = m_dalFinance.GetAccounts(_type, _customerId, _factoryId, _beginTime, _endTime);

            if (dt != null && dt.Rows.Count > 0)
            {
                decimal totalPrice = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    totalPrice = totalPrice + ConvertUtils.ConvertToDecimal(dr["curPricePlan"]) - ConvertUtils.ConvertToDecimal(dr["curPrice"]);
                    dr["totalPrice"] = totalPrice;
                }
            }
            return dt;
        }

        public DataTable GetAccountsExport(int _type, int _customerId, int _factoryId, DateTime _beginTime, DateTime _endTime)
        {
            DataTable dt = m_dalFinance.GetAccountsExport(_type, _customerId, _factoryId, _beginTime, _endTime);
            if (dt != null && dt.Rows.Count > 0)
            {
                decimal totalPrice = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (_type == 0)
                    {
                        totalPrice = totalPrice + ConvertUtils.ConvertToDecimal(dr["应收"]) - ConvertUtils.ConvertToDecimal(dr["实收"]);
                        dr["未收"] = totalPrice;
                    }
                    else
                    {
                        totalPrice = totalPrice + ConvertUtils.ConvertToDecimal(dr["应付"]) - ConvertUtils.ConvertToDecimal(dr["实付"]);
                        dr["未付"] = totalPrice;
                    }
                }
            }
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

        public Boolean AddReceivedDetail(ModelFinanceReceivedDetail _model, int _customerId)
        {
            int rtn = m_dalFinance.AddReceivedDetail(_model, _customerId);

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

        public Boolean AddPaidDetail(ModelFinancePaidDetail _model, int _customerId)
        {
            int rtn = m_dalFinance.AddPaidDetail(_model, _customerId);

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

        public ModelFinancePaid GetPaidByPurchaseCode(string _purchaseCode)
        {
            ModelFinancePaid model = new ModelFinancePaid();
            DataTable dt = m_dalFinance.GetPaidByPurchaseCode(_purchaseCode);
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

        public decimal GetReceivableMoneyByCustomerId(int _customerId, string _orderCode)
        {
            decimal rtn = 0;
            DataTable dt = m_dalFinance.GetReceivableMoneyByCustomerId(_customerId, _orderCode);
            if (dt != null && dt.Rows.Count > 0)
            {
                rtn = ConvertUtils.ConvertToDecimal(dt.Rows[0][0]);
            }

            return rtn;
        }
    }
}
