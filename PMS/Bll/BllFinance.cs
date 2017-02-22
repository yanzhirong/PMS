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
    }
}
