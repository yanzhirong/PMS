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
    public class DalProductOut
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetProductOut(String _productName, String _customerName, DateTime _beginTime, DateTime _endTime, int _orderStatus, int _outputStatus, int _outputType)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.orderCode, ");
            sbSql.Append("       b.userName salerName, ");
            sbSql.Append("       c.name customerName, ");
            sbSql.Append("       concat(a.provinceName,a.cityName,a.districtName,a.address) orderAddress, ");
            sbSql.Append("       date_format(a.delieryDate, '%Y-%m-%d') delieryDate, ");
            sbSql.Append("       d.value1 orderStatus, ");
            sbSql.Append("       a.outputStatus outputStatusCode, ");
            sbSql.Append("       a.outputType outputType, ");
            sbSql.Append("       case a.outputStatus when 0 then '请求出库' else '完成出库' end outputStatus, ");
            sbSql.Append("       case a.outputStatus when 0 then '修改' else '查看' end modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from p_product_output a ");
            sbSql.Append("left join m_user b ");
            sbSql.Append("  on a.salerId = b.userId ");
            sbSql.Append("inner join p_customer c ");
            sbSql.Append("  on a.customerId = c.id ");
            sbSql.Append("left join p_saleorder d ");
            sbSql.Append("  on a.orderId = d.id ");
            sbSql.Append("left join m_code e ");
            sbSql.Append("  on d.orderStatus = e.subCode ");
            sbSql.Append(" and d.code = 7 ");
            sbSql.Append("where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_productName))
            {
                sbSql.Append("  and a.outputCode in ( ");
                sbSql.Append("                        select distinct t1.outputCode ");
                sbSql.Append("                          from r_product_output_detail t1");
                sbSql.Append("                          join p_product t2 on t1.productId = t2.productId ");
                sbSql.Append("                         where t1.isDelete = 0 ");
                sbSql.Append("                           and t2.isDelete = 0 ");
                sbSql.Append("                           and t2.name like '%").Append(_productName).Append("%')");
            }
            if (Common.Tools.StringUtils.IsNotBlank(_customerName))
            {
                sbSql.Append("  and c.name like '%").Append(_customerName).Append("%' ");
            }
            if (_orderStatus > 0)
            {
                sbSql.Append("  and d.orderStatus = ").Append(_orderStatus).Append(" ");
            } 
            if (_outputType > -1)
            {
                sbSql.Append("  and a.outputType = ").Append(_outputType).Append(" ");
            }
            if (_outputStatus > -1)
            {
                sbSql.Append("  and a.outputStatus = ").Append(_outputStatus).Append(" ");
            }
            sbSql.Append("  and a.delieryDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("  and a.delieryDate <= '").Append(_endTime).Append("' ");
            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductOutById(int _productOutId)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("from p_product_output a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.id = ").Append(_productOutId).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductOutDetailById(int _productOutDetailId)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("from r_product_output_detail a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.id = ").Append(_productOutDetailId).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductOutrByOutputCode(string _outputCode)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("from p_product_output a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.outputCode = '").Append(_outputCode).Append("'");

            return Dal.DBHelper.Select(sbSql.ToString());
        }
        
        public DataTable GetProductOutDetailByOutputCode(string _outputCode)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.productId, ");
            sbSql.Append("       a.productNum, ");
            sbSql.Append("       a.productUnit, ");
            sbSql.Append("       a.outputStatus, ");
            sbSql.Append("       a.outputType, ");
            sbSql.Append("       a.outputDate, ");
            sbSql.Append("       a.logisticsOrder, ");
            sbSql.Append("       a.remark ");
            sbSql.Append("from r_product_output_detail a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.outputCode = ").Append(_outputCode).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public int AddProductOut(ModelProductOutput _model)
        {
            List<string> listSql = new List<string>();

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
            sbSql.Append("      '" + _model.outputCode + "', ");
            sbSql.Append("      '" + _model.orderCode + "', ");
            sbSql.Append("       " + _model.factoryId + ", ");
            sbSql.Append("       " + _model.customerId + ", ");
            sbSql.Append("       " + _model.salerId + ", ");
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
            sbSql.Append("       " + _model.outputStatus + ", ");
            sbSql.Append("       " + _model.outputType + ", ");
            sbSql.Append("       " + _model.applyMemberId + ", ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());

            //foreach (ModelProductOutputDetail modelProductOutputDetail in _model.modelProductOutputDetail)
            //{
            //    sbSql.Clear();
            //    sbSql.Append("insert into ");
            //    sbSql.Append("       r_product_output_detail ( ");
            //    sbSql.Append("       outputCode, ");
            //    sbSql.Append("       productId, ");
            //    sbSql.Append("       productNum, ");
            //    sbSql.Append("       productUnit, ");
            //    sbSql.Append("       outputStatus, ");
            //    sbSql.Append("       outputDate, ");
            //    sbSql.Append("       outputType, ");
            //    sbSql.Append("       logisticsOrder, ");
            //    sbSql.Append("       remark, ");
            //    sbSql.Append("       isDelete, ");
            //    sbSql.Append("       createBy, ");
            //    sbSql.Append("       createTime ");
            //    sbSql.Append("       ) values ( ");
            //    sbSql.Append("      '" + modelProductOutputDetail.outputCode + "', ");
            //    sbSql.Append("       " + modelProductOutputDetail.productId + ", ");
            //    sbSql.Append("       " + modelProductOutputDetail.productNum + ", ");
            //    sbSql.Append("       " + modelProductOutputDetail.productUnit + ", ");
            //    sbSql.Append("       " + modelProductOutputDetail.outputStatus + ", ");
            //    sbSql.Append("      '" + modelProductOutputDetail.outputDate + "', ");
            //    sbSql.Append("       " + modelProductOutputDetail.outputType + ", ");
            //    sbSql.Append("      '" + modelProductOutputDetail.logisticsOrder + "', ");
            //    sbSql.Append("      '" + modelProductOutputDetail.remark + "', ");
            //    sbSql.Append("       " + modelProductOutputDetail.isDelete + ", ");
            //    sbSql.Append("      '" + modelProductOutputDetail.createBy + "', ");
            //    sbSql.Append("      '" + modelProductOutputDetail.createTime + "')");
            //    listSql.Add(sbSql.ToString());
            //}

            //sbSql.Clear();
            //sbSql.Append("update p_product_output ");
            //sbSql.Append("   set outputStatus = 1, ");
            //sbSql.Append("       modifyBy = '").Append(_model.modifyBy).Append("', ");
            //sbSql.Append("       modifyTime = '").Append(_model.modifyTime).Append("' ");
            //sbSql.Append(" where id = ").Append(_model.id).Append(" ");
            //sbSql.Append("   and (select min(outputStatus) ");
            //sbSql.Append("          from r_product_output_detail ");
            //sbSql.Append("         where isDelete = 0 ");
            //sbSql.Append("           and outputCode = '").Append(_model.outputCode).Append("') = 1");
            //listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateProductOut(ModelProductOutput _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_product_output ");
            sbSql.Append("set outputCode = '" + _model.outputCode + "',");
            sbSql.Append("    orderCode = '" + _model.orderCode + "',");
            sbSql.Append("    factoryId = " + _model.factoryId + ",");
            sbSql.Append("    customerId = " + _model.customerId + ",");
            sbSql.Append("    factoryId = " + _model.factoryId + ",");
            sbSql.Append("    salerId = " + _model.salerId + ",");
            sbSql.Append("    country = " + _model.country + ",");
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
            sbSql.Append("    outputStatus = " + _model.outputStatus + ",");
            sbSql.Append("    outputType = " + _model.outputType + ",");
            sbSql.Append("    applyMemberId = " + _model.applyMemberId + ",");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int DeleteProductOut(ModelProductOutput _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_product_output ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());
            
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }
    }
}
