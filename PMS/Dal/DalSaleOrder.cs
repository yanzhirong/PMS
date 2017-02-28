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
    public class DalSaleOrder
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetSaleOrders(String _code, String _name, int _salerId, int _status, DateTime _beginTime, DateTime _endTime, int _roleType)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.orderCode, ");
            sbSql.Append("       b.userName salerName, ");
            sbSql.Append("       c.name customerName, ");
            sbSql.Append("       concat(a.provinceName,a.cityName,a.districtName,a.address) orderAddress, ");
            sbSql.Append("       date_format(a.createTime, '%Y-%m-%d') orderDate, ");
            sbSql.Append("       a.orderStatus orderStatusCode, ");
            sbSql.Append("       d.value1 orderStatus, ");
            sbSql.Append("       case a.orderStatus when 1 then '编辑' else '查看' end modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from p_saleOrder a ");
            sbSql.Append("left join m_user b ");
            sbSql.Append("  on a.salerId = b.userId ");
            sbSql.Append("inner join p_customer c ");
            sbSql.Append("  on a.customerId = c.id ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.orderStatus = d.subCode ");
            sbSql.Append(" and d.code = 7 ");
            sbSql.Append("where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_code))
            {
                sbSql.Append("  and b.code like '%").Append(_code).Append("%' ");
            } 
            if (Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("  and b.name like '%").Append(_name).Append("%' ");
            }
            if (_salerId > 0)
            {
                sbSql.Append("  and a.salerId = ").Append(_salerId).Append(" ");
            }
            if (_status > 0)
            {
                sbSql.Append("  and a.orderStatus = ").Append(_status).Append(" ");
            }
            sbSql.Append("  and a.createTime >= '").Append(_beginTime).Append("' ");
            sbSql.Append("  and a.createTime <= '").Append(_endTime).Append("' ");
            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetSaleOrderById(int _id)
        {
            sql = @"select * 
                      from p_saleOrder
                     where isDelete = 0
                       and id = {0}";

            sql = String.Format(sql, _id);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetSaleOrderByOrderCode(string _orderCode)
        {
            sql = @"select * 
                      from p_saleOrder
                     where isDelete = 0
                       and orderCode = '{0}'";

            sql = String.Format(sql, _orderCode);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetSaleOrderDetailByOrderCode(string _orderCode)
        {
            sql = @"select id,searchKey,productId,num,remark,orderCode,price 
                      from r_saleOrder_Detail
                     where isDelete = 0
                       and orderCode = '{0}'";

            sql = String.Format(sql, _orderCode);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetSaleOrderPayByOrderCode(string _orderCode)
        {
            sql = @"select * 
                      from r_saleOrder_Pay
                     where isDelete = 0
                       and orderCode = '{0}'";

            sql = String.Format(sql, _orderCode);

            return Dal.DBHelper.Select(sql);
        }

        public int AddSaleOrder(ModelSaleOrder _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_saleOrder ( ");
            sbSql.Append("       orderCode, ");
            sbSql.Append("       customerId, ");
            sbSql.Append("       salerId, ");
            sbSql.Append("       price, ");
            sbSql.Append("       priceRemark, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       payStatus, ");
            sbSql.Append("       country, ");
            sbSql.Append("       province, ");
            sbSql.Append("       provinceName, ");
            sbSql.Append("       city, ");
            sbSql.Append("       cityName, ");
            sbSql.Append("       district, ");
            sbSql.Append("       districtName, ");
            sbSql.Append("       address, ");
            sbSql.Append("       manager, ");
            sbSql.Append("       telephone, ");
            sbSql.Append("       deliveryDate, ");
            sbSql.Append("       orderStatus, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime, ");
            sbSql.Append("       modifyBy, ");
            sbSql.Append("       modifyTime ");
            sbSql.Append("       ) values ( ");
            sbSql.Append("      '" + _model.orderCode + "', ");
            sbSql.Append("       " + _model.customerId + ", ");
            sbSql.Append("       " + _model.salerId + ", ");
            sbSql.Append("       " + _model.price + ", ");
            sbSql.Append("      '" + _model.priceRemark + "', ");
            sbSql.Append("       " + _model.factoryId + ", ");
            sbSql.Append("      '" + _model.payStatus + "', ");
            sbSql.Append("       " + _model.country + ", ");
            sbSql.Append("       " + _model.province + ", ");
            sbSql.Append("      '" + _model.provinceName + "', ");
            sbSql.Append("       " + _model.city + ", ");
            sbSql.Append("      '" + _model.cityName + "', ");
            sbSql.Append("       " + _model.district + ", ");
            sbSql.Append("      '" + _model.districtName + "', ");
            sbSql.Append("      '" + _model.address + "', ");
            sbSql.Append("      '" + _model.manager + "', ");
            sbSql.Append("      '" + _model.telephone + "', ");
            sbSql.Append("      '" + _model.deliveryDate + "', ");
            sbSql.Append("       " + _model.orderStatus + ", ");
            sbSql.Append("      '" + _model.remark + "', ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "', ");
            sbSql.Append("      '" + _model.modifyBy + "', ");
            sbSql.Append("      '" + _model.modifyTime + "')");
            listSql.Add(sbSql.ToString());

            foreach (ModelSaleOrderDetail modelDetail in _model.modelSaleOrderDetail)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       r_saleOrder_Detail ( ");
                sbSql.Append("       orderCode, ");
                sbSql.Append("       searchKey, ");
                sbSql.Append("       productId, ");
                sbSql.Append("       num, ");
                sbSql.Append("       price, ");
                sbSql.Append("       remark, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime, ");
                sbSql.Append("       modifyBy, ");
                sbSql.Append("       modifyTime ");
                sbSql.Append("       ) values ( ");
                sbSql.Append("      '" + _model.orderCode + "', ");
                sbSql.Append("      '" + modelDetail.searchKey + "', ");
                sbSql.Append("       " + modelDetail.productId + ", ");
                sbSql.Append("       " + modelDetail.num + ", ");
                sbSql.Append("       " + modelDetail.price + ", ");
                sbSql.Append("      '" + modelDetail.remark + "', ");
                sbSql.Append("       " + _model.isDelete + ", ");
                sbSql.Append("      '" + _model.createBy + "', ");
                sbSql.Append("      '" + _model.createTime + "', ");
                sbSql.Append("      '" + _model.modifyBy + "', ");
                sbSql.Append("      '" + _model.modifyTime + "')");
                listSql.Add(sbSql.ToString());

            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateSaleOrder(ModelSaleOrder _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_saleOrder ");
            sbSql.Append("set customerId = " + _model.customerId + ",");
            sbSql.Append("    salerId = " + _model.salerId + ",");
            sbSql.Append("    price = " + _model.price + ",");
            sbSql.Append("    priceRemark = '" + _model.priceRemark + "',");
            sbSql.Append("    factoryId = " + _model.factoryId + ",");
            sbSql.Append("    payStatus = " + _model.payStatus + ",");
            sbSql.Append("    country = '" + _model.country + "',");
            sbSql.Append("    province = " + _model.province + ",");
            sbSql.Append("    provinceName = '" + _model.provinceName + "',");
            sbSql.Append("    city = " + _model.city + ",");
            sbSql.Append("    cityName = '" + _model.cityName + "',");
            sbSql.Append("    district = " + _model.district + ",");
            sbSql.Append("    districtName = '" + _model.districtName + "',");
            sbSql.Append("    address = '" + _model.address + "',");
            sbSql.Append("    manager = '" + _model.manager + "',");
            sbSql.Append("    telephone = '" + _model.telephone + "',");
            sbSql.Append("    deliveryDate = '" + _model.deliveryDate + "',");
            sbSql.Append("    orderStatus = " + _model.orderStatus + ",");
            sbSql.Append("    remark = '" + _model.remark + "',");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_saleOrder_Detail ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where orderCode = '" + _model.orderCode + "' ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            foreach (ModelSaleOrderDetail modelDetail in _model.modelSaleOrderDetail)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       r_saleOrder_Detail ( ");
                sbSql.Append("       orderCode, ");
                sbSql.Append("       searchKey, ");
                sbSql.Append("       productId, ");
                sbSql.Append("       num, ");
                sbSql.Append("       price, ");
                sbSql.Append("       remark, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime ");
                sbSql.Append("       ) values ( ");
                sbSql.Append("      '" + _model.orderCode + "', ");
                sbSql.Append("      '" + modelDetail.searchKey + "', ");
                sbSql.Append("       " + modelDetail.productId + ", ");
                sbSql.Append("       " + modelDetail.num + ", ");
                sbSql.Append("       " + modelDetail.price + ", ");
                sbSql.Append("      '" + modelDetail.remark + "', ");
                sbSql.Append("       " + _model.isDelete + ", ");
                sbSql.Append("      '" + _model.createBy + "', ");
                sbSql.Append("      '" + _model.createTime + "')");
                listSql.Add(sbSql.ToString());

            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int ConfirmSaleOrder(ModelSaleOrder _modelSaleOrder, ModelProductOutput _modelProductOutput, ModelFinanceReceive _modelFinanceReceive)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_saleOrder ");
            sbSql.Append("set price = " + _modelSaleOrder.price + ",");
            sbSql.Append("    priceRemark = '" + _modelSaleOrder.priceRemark + "',");
            sbSql.Append("    factoryId = " + _modelSaleOrder.factoryId + ",");
            sbSql.Append("    orderStatus = " + _modelSaleOrder.orderStatus + ",");
            sbSql.Append("    remark = '" + _modelSaleOrder.remark + "',");
            sbSql.Append("    modifyBy = '" + _modelSaleOrder.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelSaleOrder.modifyTime + "' ");
            sbSql.Append("where id = " + _modelSaleOrder.id);
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_product_output ( ");
            sbSql.Append("       outputCode, ");
            sbSql.Append("       orderCode, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       customerId, ");
            sbSql.Append("       salerId, ");
            sbSql.Append("       country, ");
            sbSql.Append("       province, ");
            sbSql.Append("       provinceName, ");
            sbSql.Append("       city, ");
            sbSql.Append("       cityName, ");
            sbSql.Append("       district, ");
            sbSql.Append("       districtName, ");
            sbSql.Append("       address, ");
            sbSql.Append("       manager, ");
            sbSql.Append("       telephone, ");
            sbSql.Append("       deliveryDate, ");
            sbSql.Append("       outputStatus, ");
            sbSql.Append("       outputType, ");
            sbSql.Append("       applyMemberId, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime ");
            sbSql.Append("       ) values ( ");
            sbSql.Append("      '" + _modelProductOutput.outputCode + "', ");
            sbSql.Append("      '" + _modelProductOutput.orderCode + "', ");
            sbSql.Append("       " + _modelProductOutput.factoryId + ", ");
            sbSql.Append("       " + _modelProductOutput.customerId + ", ");
            sbSql.Append("       " + _modelProductOutput.salerId + ", ");
            sbSql.Append("       " + _modelProductOutput.country + ", ");
            sbSql.Append("       " + _modelProductOutput.province + ", ");
            sbSql.Append("      '" + _modelProductOutput.provinceName + "', ");
            sbSql.Append("       " + _modelProductOutput.city + ", ");
            sbSql.Append("      '" + _modelProductOutput.cityName + "', ");
            sbSql.Append("       " + _modelProductOutput.district + ", ");
            sbSql.Append("      '" + _modelProductOutput.districtName + "', ");
            sbSql.Append("      '" + _modelProductOutput.address + "', ");
            sbSql.Append("      '" + _modelProductOutput.manager + "', ");
            sbSql.Append("      '" + _modelProductOutput.telephone + "', ");
            sbSql.Append("      '" + _modelProductOutput.deliveryDate + "', ");
            sbSql.Append("       " + _modelProductOutput.outputStatus + ", ");
            sbSql.Append("       " + _modelProductOutput.outputType + ", ");
            sbSql.Append("       " + _modelProductOutput.applyMemberId + ", ");
            sbSql.Append("       " + _modelProductOutput.isDelete + ", ");
            sbSql.Append("      '" + _modelProductOutput.createBy + "', ");
            sbSql.Append("      '" + _modelProductOutput.createTime + "')");
            listSql.Add(sbSql.ToString());

            foreach (ModelProductOutputDetail modelProductOutputDetail in _modelProductOutput.modelProductOutputDetail)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       r_product_output_detail ( ");
                sbSql.Append("       outputCode, ");
                sbSql.Append("       productId, ");
                sbSql.Append("       productNum, ");
                sbSql.Append("       outputStatus, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime ");
                sbSql.Append("       ) values ( ");
                sbSql.Append("      '" + modelProductOutputDetail.outputCode + "', ");
                sbSql.Append("       " + modelProductOutputDetail.productId + ", ");
                sbSql.Append("       " + modelProductOutputDetail.productNum + ", ");
                sbSql.Append("       " + modelProductOutputDetail.outputStatus + ", ");
                sbSql.Append("       " + modelProductOutputDetail.isDelete + ", ");
                sbSql.Append("      '" + modelProductOutputDetail.createBy + "', ");
                sbSql.Append("      '" + modelProductOutputDetail.createTime + "')");
                listSql.Add(sbSql.ToString());
            }

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_finance_receive ( ");
            sbSql.Append("       customerId, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       orderCode, ");
            sbSql.Append("       receivedStatus, ");
            sbSql.Append("       orderPrice, ");
            sbSql.Append("       salerId, ");
            sbSql.Append("       financeId, ");
            sbSql.Append("       deliveryDate, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime ");
            sbSql.Append("       ) values ( ");
            sbSql.Append("       " + _modelFinanceReceive.customerId + ", ");
            sbSql.Append("       " + _modelFinanceReceive.factoryId + ", ");
            sbSql.Append("      '" + _modelFinanceReceive.orderCode + "', ");
            sbSql.Append("       " + (int)Enum.EnumReceiveStatus.NoReceive + ", ");
            sbSql.Append("       " + _modelFinanceReceive.orderPrice + ", ");
            sbSql.Append("       " + _modelFinanceReceive.salerId + ", ");
            sbSql.Append("       " + _modelFinanceReceive.financeId + ", ");
            sbSql.Append("      '" + _modelFinanceReceive.deliveryDate + "', ");
            sbSql.Append("      '" + _modelFinanceReceive.remark + "', ");
            sbSql.Append("       " + _modelFinanceReceive.isDelete + ", ");
            sbSql.Append("      '" + _modelFinanceReceive.createBy + "', ");
            sbSql.Append("      '" + _modelFinanceReceive.createTime + "')");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int DeleteSaleOrder(ModelSaleOrder _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_saleOrder ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_saleOrder_Pay ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where orderCode = '" + _model.orderCode + "' ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_saleOrder_Detail ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where orderCode = '" + _model.orderCode + "' ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int CancelSaleOrder(ModelSaleOrder _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_saleOrder ");
            sbSql.Append("set orderStatus = " + (int)Enum.EnumSaleOrderStatus.Cancel + ",");
            sbSql.Append("    cancelReason = '" + _model.cancelReason + "',");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_saleOrder_Pay ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where orderCode = '" + _model.orderCode + "' ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_saleOrder_Detail ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where orderCode = '" + _model.orderCode + "' ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateSaleOrderStatus(List<ModelSaleOrder> _listSaleOrder)
        {
            List<string> listSql = new List<string>();

            foreach (ModelSaleOrder modelSaleOrder in _listSaleOrder)
            {
                sbSql.Clear();
                sbSql.Append("update p_saleOrder ");
                sbSql.Append("set orderStatus = " + modelSaleOrder.orderStatus + ",");
                sbSql.Append("    modifyBy = '" + modelSaleOrder.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + modelSaleOrder.modifyTime + "' ");
                sbSql.Append("where orderCode = '" + modelSaleOrder.orderCode + "' ");
                sbSql.Append("  and isDelete = 0 ");
                listSql.Add(sbSql.ToString());
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);

        }
    }
}
