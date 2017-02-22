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

        public DataTable GetSaleOrder(int _factoryId, int _customerId, int _salerId, string _name, int _orderStatus, DateTime _beginTime, DateTime _endTime)
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
            sbSql.Append("       case a.orderStatus when 1 then '确认' else '查看' end confirmBtn, ");
            sbSql.Append("       case a.orderStatus when 1 then '取消' else '查看' end cancelBtn ");
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
            if (Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("   and a.productId in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
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

        public DataTable GetSaleOrderExport(int _factoryId, int _customerId, int _salerId, string _name, int _orderStatus, DateTime _beginTime, DateTime _endTime)
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
            if (Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("   and a.productId in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
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

        public DataTable GetPurchaseOrder(int _factoryId, int _customerId, int _purchaserId, string _name, int _orderStatus, DateTime _beginTime, DateTime _endTime)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       e.name factoryName, ");
            sbSql.Append("       a.customerId, ");
            sbSql.Append("       c.name customerName, ");
            sbSql.Append("       b.userName purchaserName, ");
            sbSql.Append("       a.produceCode, ");
            sbSql.Append("       a.price orderPrice, ");
            sbSql.Append("       a.status orderStatusCode, ");
            sbSql.Append("       d.value1 orderStatus, ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') deliveryDate, ");
            sbSql.Append("       g.value1 paidStatus, ");
            sbSql.Append("       f.paidPrice paidPrice, ");
            sbSql.Append("       case a.status when 1 then '确认' else '查看' end confirmBtn, ");
            sbSql.Append("       case a.status when 1 then '取消' else '查看' end cancelBtn ");
            sbSql.Append("from p_purchase a ");
            sbSql.Append("left join m_user b ");
            sbSql.Append("  on a.purchaserId = b.userId ");
            sbSql.Append("left join p_customer c ");
            sbSql.Append("  on a.customerId = c.id ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.status = d.subCode ");
            sbSql.Append(" and d.code = 12 ");
            sbSql.Append("left join m_factory e ");
            sbSql.Append("  on a.factoryId = e.id ");
            sbSql.Append("left join p_finance_paid f ");
            sbSql.Append("  on a.purchaseCode = f.purchaseCode ");
            sbSql.Append("left join m_code g ");
            sbSql.Append("  on f.paidStatus = g.subCode ");
            sbSql.Append(" and g.code = 6 ");
            sbSql.Append("where a.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_customerId > 0)
            {
                sbSql.Append("  and a.customerId = ").Append(_customerId).Append(" ");
            }
            if (_purchaserId > 0)
            {
                sbSql.Append("  and a.purchaserId = ").Append(_purchaserId).Append(" ");
            }
            if (Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("   and a.materialsId in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
            }
            if (_orderStatus > 0)
            {
                sbSql.Append("  and a.status = ").Append(_orderStatus).Append(" ");
            }
            sbSql.Append("  and a.deliveryDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("  and a.deliveryDate <= '").Append(_endTime).Append("' ");
            sbSql.Append("order by a.status, a.deliveryDate");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetPurchaseOrderExport(int _factoryId, int _customerId, int _purchaserId, string _name, int _orderStatus, DateTime _beginTime, DateTime _endTime)
        {
            sbSql.Clear();
            sbSql.Append("select e.name 工厂, ");
            sbSql.Append("       c.name 客户, ");
            sbSql.Append("       b.userName 采购, ");
            sbSql.Append("       a.produceCode 采购单号, ");
            sbSql.Append("       a.price orderPrice 采购金额, ");
            sbSql.Append("       d.value1 采购状态, ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') 交货日, ");
            sbSql.Append("       g.value1 支付状态, ");
            sbSql.Append("       f.paidPrice 支付金额 ");
            sbSql.Append("from p_purchase a ");
            sbSql.Append("left join m_user b ");
            sbSql.Append("  on a.purchaserId = b.userId ");
            sbSql.Append("left join p_customer c ");
            sbSql.Append("  on a.customerId = c.id ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.status = d.subCode ");
            sbSql.Append(" and d.code = 12 ");
            sbSql.Append("left join m_factory e ");
            sbSql.Append("  on a.factoryId = e.id ");
            sbSql.Append("left join p_finance_paid f ");
            sbSql.Append("  on a.produceCode = f.produceCode ");
            sbSql.Append("left join m_code g ");
            sbSql.Append("  on f.paidStatus = g.subCode ");
            sbSql.Append(" and g.code = 6 ");
            sbSql.Append("where a.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_customerId > 0)
            {
                sbSql.Append("  and a.customerId = ").Append(_customerId).Append(" ");
            }
            if (_purchaserId > 0)
            {
                sbSql.Append("  and a.purchaserId = ").Append(_purchaserId).Append(" ");
            }
            if (Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("   and a.materialsId in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
            }
            if (_orderStatus > 0)
            {
                sbSql.Append("  and a.status = ").Append(_orderStatus).Append(" ");
            }
            sbSql.Append("  and a.deliveryDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("  and a.deliveryDate <= '").Append(_endTime).Append("' ");
            sbSql.Append("order by a.status, a.deliveryDate");

            return Dal.DBHelper.Select(sbSql.ToString());
        }
    }
}
