using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using Enum;

namespace Dal
{
    public class DalFinance
    {
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetSaleOrder(int _factoryId, int _customerId, int _salerId, string _productName, int _orderStatus, DateTime _beginTime, DateTime _endTime)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       e.name factoryName, ");
            sbSql.Append("       a.customerId, ");
            sbSql.Append("       c.name customerName, ");
            sbSql.Append("       b.userName salerName, ");
            sbSql.Append("       a.orderCode, ");
            sbSql.Append("       a.price orderPrice, ");
            sbSql.Append("       a.orderStatus orderStatusCode, ");
            sbSql.Append("       d.value1 orderStatus, ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') deliveryDate, ");
            sbSql.Append("       g.value1 receivedStatus, ");
            sbSql.Append("       f.receivedPrice receivedPrice, ");
            sbSql.Append("       case a.orderStatus when 4 then '查看' when 5 then '查看' else '确认' end excuteBtn ");
            sbSql.Append("from p_saleOrder a ");
            sbSql.Append("left join m_user b ");
            sbSql.Append("  on a.salerId = b.userId ");
            sbSql.Append("left join p_customer c ");
            sbSql.Append("  on a.customerId = c.id ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.orderStatus = d.subCode ");
            sbSql.Append(" and d.code = 7 ");
            sbSql.Append("left join m_factory e ");
            sbSql.Append("  on a.factoryId = e.id ");
            sbSql.Append("left join p_finance_receive f ");
            sbSql.Append("  on a.orderCode = f.orderCode ");
            sbSql.Append("left join m_code g ");
            sbSql.Append("  on f.receivedStatus = g.subCode ");
            sbSql.Append(" and g.code = 13 ");
            sbSql.Append("where a.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_customerId > 0)
            {
                sbSql.Append("  and a.customerId = ").Append(_customerId).Append(" ");
            }
            if (_salerId > 0)
            {
                sbSql.Append("  and a.salerId = ").Append(_salerId).Append(" ");
            }
            if (Common.Tools.StringUtils.IsNotBlank(_productName))
            {
                sbSql.Append("   and a.productId in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_productName).Append("%' or upper(searchKey) like '%").Append(_productName.ToUpper()).Append("%') ");
            }
            if (_orderStatus > 0)
            {
                sbSql.Append("  and a.orderStatus = ").Append(_orderStatus).Append(" ");
            }
            sbSql.Append("  and a.deliveryDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("  and a.deliveryDate <= '").Append(_endTime).Append("' ");
            sbSql.Append("order by a.orderStatus, a.deliveryDate");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetSaleOrderExport(int _factoryId, int _customerId, int _salerId, string _productName, int _orderStatus, DateTime _beginTime, DateTime _endTime)
        {
            sbSql.Clear();
            sbSql.Append("select e.name 工厂, ");
            sbSql.Append("       c.name 客户, ");
            sbSql.Append("       b.userName 销售, ");
            sbSql.Append("       a.orderCode 订单编号, ");
            sbSql.Append("       a.price 订单金额, ");
            sbSql.Append("       d.value1 订单状态, ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') 交货日期, ");
            sbSql.Append("       g.value1 收款状态, ");
            sbSql.Append("       f.receivedPrice 收款金额 ");
            sbSql.Append("from p_saleOrder a ");
            sbSql.Append("left join m_user b ");
            sbSql.Append("  on a.salerId = b.userId ");
            sbSql.Append("left join p_customer c ");
            sbSql.Append("  on a.customerId = c.id ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.orderStatus = d.subCode ");
            sbSql.Append(" and d.code = 7 ");
            sbSql.Append("left join m_factory e ");
            sbSql.Append("  on a.factoryId = e.id ");
            sbSql.Append("left join p_finance_receive f ");
            sbSql.Append("  on a.orderCode = f.orderCode ");
            sbSql.Append("left join m_code g ");
            sbSql.Append("  on f.receivedStatus = g.subCode ");
            sbSql.Append(" and g.code = 13 ");
            sbSql.Append("where a.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_customerId > 0)
            {
                sbSql.Append("  and a.customerId = ").Append(_customerId).Append(" ");
            }
            if (_salerId > 0)
            {
                sbSql.Append("  and a.salerId = ").Append(_salerId).Append(" ");
            }
            if (Common.Tools.StringUtils.IsNotBlank(_productName))
            {
                sbSql.Append("   and a.productId in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_productName).Append("%' or upper(searchKey) like '%").Append(_productName.ToUpper()).Append("%') ");
            }
            if (_orderStatus > 0)
            {
                sbSql.Append("  and a.orderStatus = ").Append(_orderStatus).Append(" ");
            }
            sbSql.Append("  and a.deliveryDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("  and a.deliveryDate <= '").Append(_endTime).Append("' ");
            sbSql.Append("order by a.orderStatus, a.deliveryDate");

            return Dal.DBHelper.Select(sbSql.ToString());
        }
    }
}
