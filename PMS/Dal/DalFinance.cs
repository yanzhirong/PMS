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

        public int AddReceivedDetail(ModelFinanceReceivedDetail _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       r_finance_receive_detail ( ");
            sbSql.Append("       orderCode, ");
            sbSql.Append("       receivedMoney, ");
            sbSql.Append("       receivedDate, ");
            sbSql.Append("       receivedType, ");
            sbSql.Append("       otherType, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime");
            sbSql.Append("       ) value ( ");
            sbSql.Append("      '" + _model.orderCode + "', ");
            sbSql.Append("       " + _model.receivedMoney + ", ");
            sbSql.Append("      '" + _model.receivedDate + "', ");
            sbSql.Append("       " + _model.receivedType + ", ");
            sbSql.Append("      '" + _model.otherType + "', ");
            sbSql.Append("      '" + _model.remark + "', ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_finance_receive ");
            sbSql.Append("set receivedPrice = ifnull(receivedPrice,0) + " + _model.receivedMoney + ",");
            sbSql.Append("    receivedStatus = " + (int)Enum.EnumReceiveStatus.Receiving + ",");
            sbSql.Append("    modifyBy = '" + _model.createBy + "',");
            sbSql.Append("    modifyTime = '" + _model.createTime + "' ");
            sbSql.Append("where orderCode = '" + _model.orderCode + "' ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_finance_receive ");
            sbSql.Append("set receivedStatus = " + (int)Enum.EnumReceiveStatus.Complete + ",");
            sbSql.Append("    modifyBy = '" + _model.createBy + "',");
            sbSql.Append("    modifyTime = '" + _model.createTime + "' ");
            sbSql.Append("where orderCode = '" + _model.orderCode + "' ");
            sbSql.Append("  and receivedPrice >= orderPrice ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public DataTable GetReceiveById(int _receiveId)
        {
            sbSql.Clear();
            sbSql.Append("select * ");
            sbSql.Append("  from p_finance_receive ");
            sbSql.Append(" where isDelete = 0 ");
            sbSql.Append("   and id = ").Append(_receiveId).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetReceivedDetailByOrderCode(string _orderCode)
        {
            sbSql.Clear();
            sbSql.Append("select ");
            sbSql.Append("       a.receivedMoney, ");
            sbSql.Append("       date_format(a.receivedDate, '%Y-%m-%d') receivedDate, ");
            sbSql.Append("       case a.receivedType when " + (int)Enum.EnumSettlementType.Other + " then a.otherType else b.value1 end receivedType, ");
            sbSql.Append("       a.remark ");
            sbSql.Append("  from r_finance_receive_detail a");
            sbSql.Append("  left join m_code b ");
            sbSql.Append("    on a.receivedType = b.subCode ");
            sbSql.Append("   and b.code = 5 ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.orderCode = '").Append(_orderCode).Append("' ");
            sbSql.Append(" order by a.receivedDate ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetReceive(int _factoryId, int _customerId, int _salerId, string _name, int _orderStatus, int _receiveStatus)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       e.name factoryName, ");
            sbSql.Append("       c.name customerName, ");
            sbSql.Append("       b.userName salerName, ");
            sbSql.Append("       a.orderCode orderCode, ");
            sbSql.Append("       g.value1 orderStatus, ");
            sbSql.Append("       a.orderPrice orderPrice, ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') deliveryDate, ");
            sbSql.Append("       d.value1 receivedStatus, ");
            sbSql.Append("       a.receivedPrice receivedPrice, ");
            sbSql.Append("       '查看' receiveDetail, ");
            sbSql.Append("       a.customerId ");
            sbSql.Append("from p_finance_receive a ");
            sbSql.Append("left join m_user b ");
            sbSql.Append("  on a.salerId = b.userId ");
            sbSql.Append("left join p_customer c ");
            sbSql.Append("  on a.customerId = c.id ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.receivedStatus = d.subCode ");
            sbSql.Append(" and d.code = 13 ");
            sbSql.Append("left join m_factory e ");
            sbSql.Append("  on a.factoryId = e.id ");
            sbSql.Append("left join p_saleorder f ");
            sbSql.Append("  on a.orderCode = f.orderCode ");
            sbSql.Append("left join m_code g ");
            sbSql.Append("  on f.orderStatus = g.subCode ");
            sbSql.Append(" and g.code = 7 ");
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
                sbSql.Append("  and f.orderStatus = ").Append(_orderStatus).Append(" ");
            }
            if (_receiveStatus > 0)
            {
                sbSql.Append("  and a.receivedStatus = ").Append(_receiveStatus).Append(" ");
            }
            sbSql.Append("order by a.receivedStatus, f.orderStatus desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetReceiveExport(int _factoryId, int _customerId, int _salerId, string _name, int _orderStatus, int _receiveStatus)
        {
            sbSql.Clear();
            sbSql.Append("select e.name 工厂, ");
            sbSql.Append("       c.name 客户, ");
            sbSql.Append("       b.userName 销售, ");
            sbSql.Append("       a.orderCode 订单编号, ");
            sbSql.Append("       a.orderPrice 订单金额, ");
            sbSql.Append("       g.value1 订单状态, ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') 交货日期, ");
            sbSql.Append("       d.value1 收款状态, ");
            sbSql.Append("       a.receivedPrice 收款金额 ");
            sbSql.Append("from p_finance_receive a ");
            sbSql.Append("left join m_user b ");
            sbSql.Append("  on a.salerId = b.userId ");
            sbSql.Append("left join p_customer c ");
            sbSql.Append("  on a.customerId = c.id ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.receivedStatus = d.subCode ");
            sbSql.Append(" and d.code = 13 ");
            sbSql.Append("left join m_factory e ");
            sbSql.Append("  on a.factoryId = e.id ");
            sbSql.Append("left join p_saleorder f ");
            sbSql.Append("  on a.orderCode = f.orderCode ");
            sbSql.Append("left join m_code g ");
            sbSql.Append("  on f.orderStatus = g.subCode ");
            sbSql.Append(" and g.code = 7 ");
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
                sbSql.Append("  and f.orderStatus = ").Append(_orderStatus).Append(" ");
            }
            if (_receiveStatus > 0)
            {
                sbSql.Append("  and a.receivedStatus = ").Append(_receiveStatus).Append(" ");
            }
            sbSql.Append("order by a.receivedStatus, f.orderStatus desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public int AddPaidDetail(ModelFinancePaidDetail _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       r_finance_paid_detail ( ");
            sbSql.Append("       purchaseCode, ");
            sbSql.Append("       paidMoney, ");
            sbSql.Append("       paidDate, ");
            sbSql.Append("       paidType, ");
            sbSql.Append("       otherType, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime");
            sbSql.Append("       ) value ( ");
            sbSql.Append("      '" + _model.purchaseCode + "', ");
            sbSql.Append("       " + _model.paidMoney + ", ");
            sbSql.Append("      '" + _model.paidDate + "', ");
            sbSql.Append("       " + _model.paidType + ", ");
            sbSql.Append("      '" + _model.otherType + "', ");
            sbSql.Append("      '" + _model.remark + "', ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_finance_paid ");
            sbSql.Append("set paidPrice = ifnull(paidPrice,0) + " + _model.paidMoney + ",");
            sbSql.Append("    paidStatus = " + (int)Enum.EnumPayStatus.Paying + ",");
            sbSql.Append("    modifyBy = '" + _model.createBy + "',");
            sbSql.Append("    modifyTime = '" + _model.createTime + "' ");
            sbSql.Append("where purchaseCode = '" + _model.purchaseCode + "' ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_finance_paid ");
            sbSql.Append("set paidStatus = " + (int)Enum.EnumPayStatus.Complete + ",");
            sbSql.Append("    modifyBy = '" + _model.createBy + "',");
            sbSql.Append("    modifyTime = '" + _model.createTime + "' ");
            sbSql.Append("where purchaseCode = '" + _model.purchaseCode + "' ");
            sbSql.Append("  and paidPrice >= orderPrice ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public DataTable GetPaidById(int _paidId)
        {
            sbSql.Clear();
            sbSql.Append("select * ");
            sbSql.Append("  from p_finance_paid ");
            sbSql.Append(" where isDelete = 0 ");
            sbSql.Append("   and id = ").Append(_paidId).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetPaidDetailByPurchaseCode(string _purchaseCode)
        {
            sbSql.Clear();
            sbSql.Append("select ");
            sbSql.Append("       a.paidMoney, ");
            sbSql.Append("       date_format(a.paidDate, '%Y-%m-%d') paidDate, ");
            sbSql.Append("       case a.paidType when " + (int)Enum.EnumSettlementType.Other + " then a.otherType else b.value1 end paidType, ");
            sbSql.Append("       a.remark ");
            sbSql.Append("  from r_finance_paid_detail a");
            sbSql.Append("  left join m_code b ");
            sbSql.Append("    on a.paidType = b.subCode ");
            sbSql.Append("   and b.code = 5 ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.purchaseCode = '").Append(_purchaseCode).Append("' ");
            sbSql.Append(" order by a.paidDate ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetPaid(int _factoryId, int _customerId, int _userId, string _name, int _purchaseStatus, int _paidStatus)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       e.name factoryName, ");
            sbSql.Append("       c.name customerName, ");
            sbSql.Append("       a.purchaseBy purchaserName, ");
            sbSql.Append("       a.purchaseCode purchaseCode, ");
            sbSql.Append("       g.value1 orderStatus, ");
            sbSql.Append("       a.orderPrice orderPrice, ");
            sbSql.Append("       date_format(a.purchaseDate, '%Y-%m-%d') purchaseDate, ");
            sbSql.Append("       d.value1 paidStatus, ");
            sbSql.Append("       a.paidPrice paidPrice, ");
            sbSql.Append("       '查看' paidDetail, ");
            sbSql.Append("       a.customerId ");
            sbSql.Append("from p_finance_paid a ");
            sbSql.Append("left join m_user b ");
            sbSql.Append("  on a.purchaseBy = b.userName ");
            sbSql.Append("left join p_customer c ");
            sbSql.Append("  on a.customerId = c.id ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.paidStatus = d.subCode ");
            sbSql.Append(" and d.code = 6 ");
            sbSql.Append("left join m_factory e ");
            sbSql.Append("  on a.factoryId = e.id ");
            sbSql.Append("left join p_purchase f ");
            sbSql.Append("  on a.purchaseCode = f.purchaseCode ");
            sbSql.Append("left join m_code g ");
            sbSql.Append("  on f.status = g.subCode ");
            sbSql.Append(" and g.code = 12 ");
            sbSql.Append("where a.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_customerId > 0)
            {
                sbSql.Append("  and a.customerId = ").Append(_customerId).Append(" ");
            }
            if (_userId > 0)
            {
                sbSql.Append("  and b.userId = ").Append(_userId).Append(" ");
            }
            if (Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("   and a.materialsId in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
            }
            if (_purchaseStatus > 0)
            {
                sbSql.Append("  and f.status = ").Append(_purchaseStatus).Append(" ");
            }
            if (_paidStatus > 0)
            {
                sbSql.Append("  and a.paidStatus = ").Append(_paidStatus).Append(" ");
            }
            sbSql.Append("order by a.paidStatus, f.status desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetPaidExport(int _factoryId, int _customerId, int _userId, string _name, int _purchaseStatus, int _paidStatus)
        {
            sbSql.Clear();
            sbSql.Append("select e.name 工厂, ");
            sbSql.Append("       c.name 客户, ");
            sbSql.Append("       a.purchaseBy 采购, ");
            sbSql.Append("       a.purchaseCode 订单编号, ");
            sbSql.Append("       g.value1 订单状态, ");
            sbSql.Append("       a.orderPrice 订单金额, ");
            sbSql.Append("       date_format(a.purchaseDate, '%Y-%m-%d') 采购日期, ");
            sbSql.Append("       d.value1 付款状态, ");
            sbSql.Append("       a.paidPrice 付款金额 ");
            sbSql.Append("from p_finance_paid a ");
            sbSql.Append("left join m_user b ");
            sbSql.Append("  on a.purchaseBy = b.userName ");
            sbSql.Append("left join p_customer c ");
            sbSql.Append("  on a.customerId = c.id ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.paidStatus = d.subCode ");
            sbSql.Append(" and d.code = 6 ");
            sbSql.Append("left join m_factory e ");
            sbSql.Append("  on a.factoryId = e.id ");
            sbSql.Append("left join p_purchase f ");
            sbSql.Append("  on a.purchaseCode = f.purchaseCode ");
            sbSql.Append("left join m_code g ");
            sbSql.Append("  on f.status = g.subCode ");
            sbSql.Append(" and g.code = 12 ");
            sbSql.Append("where a.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_customerId > 0)
            {
                sbSql.Append("  and a.customerId = ").Append(_customerId).Append(" ");
            }
            if (_userId > 0)
            {
                sbSql.Append("  and b.userId = ").Append(_userId).Append(" ");
            }
            if (Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("   and a.materialsId in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
            }
            if (_purchaseStatus > 0)
            {
                sbSql.Append("  and f.status = ").Append(_purchaseStatus).Append(" ");
            }
            if (_paidStatus > 0)
            {
                sbSql.Append("  and a.paidStatus = ").Append(_paidStatus).Append(" ");
            }
            sbSql.Append("order by a.paidStatus, f.status desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }
    }
}
