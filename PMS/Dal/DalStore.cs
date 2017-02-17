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
    public class DalStore
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetStoreProductNum(int _factoryId, int _productId, DateTime _expiresDate)
        {
            sbSql.Clear();
            sbSql.Append("select a.num ");
            sbSql.Append("from p_product_input a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            sbSql.Append("  and a.productId = ").Append(_productId).Append(" ");
            sbSql.Append("  and a.expiresDate >= '").Append(_expiresDate).Append("' ");
            sbSql.Append("  and a.status = 1 ");
            sbSql.Append("  and a.num > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetStoreMaterialsNum(int _factoryId, int _materialsId, DateTime _expiresDate)
        {
            sbSql.Clear();
            sbSql.Append("select a.inputNum, ");
            sbSql.Append("       b.value2 unit ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("left join m_code b ");
            sbSql.Append("  on a.inputUnit = b.subCode ");
            sbSql.Append(" and b.code = 3 ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            sbSql.Append("  and a.materialsId = ").Append(_materialsId).Append(" ");
            sbSql.Append("  and a.expiresDate >= '").Append(_expiresDate).Append("' ");
            sbSql.Append("  and a.inputStatus = 1 ");
            sbSql.Append("  and a.inputNum > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductStore(string _productName, int _factoryId)
        {
            sbSql.Clear();
            sbSql.Append("select c.name productName, ");
            sbSql.Append("       d.name factoryName, ");
            sbSql.Append("       date_format(a.expiresDate, '%Y-%m-%d') expiresDate, ");
            sbSql.Append("       a.num ");
            sbSql.Append("from p_product_input a ");
            sbSql.Append("left join p_product c ");
            sbSql.Append("  on a.productId = c.id ");
            sbSql.Append("left join m_factory d ");
            sbSql.Append("  on a.factoryId = d.id ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            if (Common.Tools.StringUtils.IsNotBlank(_productName))
            {
                sbSql.Append("   and a.productId in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_productName).Append("%' or upper(searchKey) like '%").Append(_productName.ToUpper()).Append("%') ");
            } 
            sbSql.Append("  and a.status = 1 ");
            sbSql.Append("  and a.num > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsStore(string _materialsName, int _factoryId)
        {
            sbSql.Clear();
            sbSql.Append("select c.name materialsName, ");
            sbSql.Append("       d.name factoryName, ");
            sbSql.Append("       date_format(a.expiresDate, '%Y-%m-%d') expiresDate, ");
            sbSql.Append("       concat(a.inputNum, b.value1) numDisplay ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("left join m_code b ");
            sbSql.Append("  on a.inputUnit = b.subCode ");
            sbSql.Append(" and b.code = 3 ");
            sbSql.Append("left join p_materials c ");
            sbSql.Append("  on a.materialsId = c.id ");
            sbSql.Append("left join m_factory d ");
            sbSql.Append("  on a.factoryId = d.id ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            if (Common.Tools.StringUtils.IsNotBlank(_materialsName))
            {
                sbSql.Append("   and a.materialsId in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_materialsName).Append("%' or upper(searchKey) like '%").Append(_materialsName.ToUpper()).Append("%') ");
            }
            sbSql.Append("  and a.inputStatus = 1 ");
            sbSql.Append("  and a.inputNum > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsOutputLogByInputCode(string _inputCode)
        {
            sbSql.Clear();
            sbSql.Append("select * ");
            sbSql.Append("  from h_materials_output_log ");
            sbSql.Append(" where isDelete = 0 ");
            sbSql.Append("   and inputCode = '").Append(_inputCode).Append("' ");
            sbSql.Append(" order by id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsOutputLogByOutputCode(string _outputCode)
        {
            sbSql.Clear();
            sbSql.Append("select b.name factoryName, ");
            sbSql.Append("       c.name materialsName, ");
            sbSql.Append("       concat(a.outputNum, d.value1) numDisplay, ");
            sbSql.Append("       date_format(a.outputDate, '%Y-%m-%d') outputDate, ");
            sbSql.Append("       e.userName applyMember ");
            sbSql.Append("  from h_materials_output_log a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("    on a.factoryId = b.id ");
            sbSql.Append("  left join p_materials c ");
            sbSql.Append("    on a.materialsId = c.id ");
            sbSql.Append("  left join m_code d ");
            sbSql.Append("    on a.outputUnit = d.subCode ");
            sbSql.Append("   and d.code = 3 ");
            sbSql.Append("  left join m_user e ");
            sbSql.Append("    on a.applyMemberId = e.userId ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.outputCode = '").Append(_outputCode).Append("' ");
            sbSql.Append(" order by a.id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductOutputLogByInputCode(string _inputCode)
        {
            sbSql.Clear();
            sbSql.Append("select * ");
            sbSql.Append("  from h_product_output_log ");
            sbSql.Append(" where isDelete = 0 ");
            sbSql.Append("   and inputCode = '").Append(_inputCode).Append("' ");
            sbSql.Append(" order by id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductOutputLogByOutputCode(string _outputCode)
        {
            sbSql.Clear();
            sbSql.Append("select b.name factoryName, ");
            sbSql.Append("       c.name ProductName, ");
            sbSql.Append("       a.outputNum, ");
            sbSql.Append("       date_format(a.outputDate, '%Y-%m-%d') outputDate, ");
            sbSql.Append("       d.userName applyMember ");
            sbSql.Append("  from h_product_output_log a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("    on a.factoryId = b.id ");
            sbSql.Append("  left join p_product c ");
            sbSql.Append("    on a.productId = c.id ");
            sbSql.Append("  left join m_user d ");
            sbSql.Append("    on a.applyMemberId = d.userId ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.outputCode = '").Append(_outputCode).Append("' ");
            sbSql.Append(" order by a.id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }
    }
}
