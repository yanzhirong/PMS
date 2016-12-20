using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Dal
{
    public class DalCustomer
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetCustomers(string _code, string _name, int _type, int _salerId)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.code, ");
            sbSql.Append("       a.name, ");
            sbSql.Append("       a.provinceName, ");
            sbSql.Append("       a.cityName, ");
            sbSql.Append("       a.telephone1, ");
            sbSql.Append("       a.manager, ");
            sbSql.Append("       a.mobile, ");
            sbSql.Append("       case type when 1 then '销售客户' else '供应商' end type, ");
            sbSql.Append("       b.userName, ");
            sbSql.Append("       '修改' modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from p_customer a ");
            sbSql.Append("left join m_user b ");
            sbSql.Append("  on a.salerId = b.userId ");
            sbSql.Append(" and b.isDelete = 0 ");
            sbSql.Append("where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_code))
            {
                sbSql.Append("  and a.code like '%").Append(_code).Append("%' ");
            } 
            if (Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("  and a.name like '%").Append(_name).Append("%' ");
            }
            if (_type > 0)
            {
                sbSql.Append("  and a.type = ").Append(_type).Append(" ");
            }
            if (_salerId > 0)
            {
                sbSql.Append("  and a.salerId = ").Append(_salerId).Append(" ");
            }
            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetCustomerById(int _customerId)
        {
            sql = @"select * 
                      from p_customer
                     where isDelete = 0
                       and id = {0}";

            sql = String.Format(sql, _customerId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetCustomerByCode(string _code)
        {
            sql = @"select * 
                      from p_customer
                     where isDelete = 0
                       and code = '{0}'";

            sql = String.Format(sql, _code);

            return Dal.DBHelper.Select(sql);
        }

        public int AddCustomer(ModelCustomer _model)
        {
            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_customer ( ");
            sbSql.Append("       code, ");
            sbSql.Append("       name, ");
            sbSql.Append("       country, ");
            sbSql.Append("       province, ");
            sbSql.Append("       provinceName, ");
            sbSql.Append("       city, ");
            sbSql.Append("       cityName, ");
            sbSql.Append("       district, ");
            sbSql.Append("       districtName, ");
            sbSql.Append("       address, ");
            sbSql.Append("       zip, ");
            sbSql.Append("       fax, ");
            sbSql.Append("       telephone1, ");
            sbSql.Append("       telephone2, ");
            sbSql.Append("       manager, ");
            sbSql.Append("       position, ");
            sbSql.Append("       mobile, ");
            sbSql.Append("       type, ");
            sbSql.Append("       salerId, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       creditLimit, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime, ");
            sbSql.Append("       modifyBy, ");
            sbSql.Append("       modifyTime ");
            sbSql.Append("       ) value ( ");
            sbSql.Append("      '" + _model.code + "', ");
            sbSql.Append("      '" + _model.name + "', ");
            sbSql.Append("      '" + _model.country + "', ");
            sbSql.Append("       " + _model.province + ", ");
            sbSql.Append("      '" + _model.provinceName + "', ");
            sbSql.Append("       " + _model.city + ", ");
            sbSql.Append("      '" + _model.cityName + "', ");
            sbSql.Append("       " + _model.district + ", ");
            sbSql.Append("      '" + _model.districtName + "', ");
            sbSql.Append("      '" + _model.address + "', ");
            sbSql.Append("      '" + _model.zip + "', ");
            sbSql.Append("      '" + _model.fax + "', ");
            sbSql.Append("      '" + _model.telephone1 + "', ");
            sbSql.Append("      '" + _model.telephone2 + "', ");
            sbSql.Append("      '" + _model.manager + "', ");
            sbSql.Append("      '" + _model.position + "', ");
            sbSql.Append("      '" + _model.mobile + "', ");
            sbSql.Append("       " + _model.type + ", ");
            sbSql.Append("       " + _model.salerId + ", ");
            sbSql.Append("      '" + _model.remark + "', ");
            sbSql.Append("       " + _model.creditLimit + ", ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "', ");
            sbSql.Append("      '" + _model.modifyBy + "', ");
            sbSql.Append("      '" + _model.modifyTime + "')");

            return Dal.DBHelper.Excute(sbSql.ToString());
        }

        public int UpdateCustomer(ModelCustomer _model)
        {
            sbSql.Clear();
            sbSql.Append("update p_customer ");
            sbSql.Append("set code = '" + _model.code + "',");
            sbSql.Append("    name = '" + _model.name + "',");
            sbSql.Append("    country = '" + _model.country + "',");
            sbSql.Append("    province = " + _model.province + ",");
            sbSql.Append("    provinceName = '" + _model.provinceName + "',");
            sbSql.Append("    city = " + _model.city + ",");
            sbSql.Append("    cityName = '" + _model.cityName + "',");
            sbSql.Append("    district = " + _model.district + ",");
            sbSql.Append("    districtName = '" + _model.districtName + "',");
            sbSql.Append("    address = '" + _model.address + "',");
            sbSql.Append("    zip = '" + _model.zip + "',");
            sbSql.Append("    fax = '" + _model.fax + "',");
            sbSql.Append("    telephone1 = '" + _model.telephone1 + "',");
            sbSql.Append("    telephone2 = '" + _model.telephone2 + "',");
            sbSql.Append("    manager = '" + _model.manager + "',");
            sbSql.Append("    position = '" + _model.position + "',");
            sbSql.Append("    mobile = '" + _model.mobile + "',");
            sbSql.Append("    type = " + _model.type + ",");
            sbSql.Append("    salerId = " + _model.salerId + ",");
            sbSql.Append("    remark = '" + _model.remark + "',");
            sbSql.Append("    creditLimit = " + _model.creditLimit + ",");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);

            return Dal.DBHelper.Excute(sbSql.ToString());
        }

        public int DeleteCustomer(ModelCustomer _model)
        {
            sbSql.Clear();
            sbSql.Append("update p_customer ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);

            return Dal.DBHelper.Excute(sbSql.ToString());
        }
    }
}
