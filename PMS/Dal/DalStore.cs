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
            sbSql.Append("select a.num, ");
            sbSql.Append("       b.value2 unit ");
            sbSql.Append("from p_product_in a ");
            sbSql.Append("left join m_code b ");
            sbSql.Append("  on a.unit = b.subCode ");
            sbSql.Append(" and b.code = 3 ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            sbSql.Append("  and a.productId = ").Append(_productId).Append(" ");
            sbSql.Append("  and a.expiresDate >= '").Append(_expiresDate).Append("' ");
            sbSql.Append("  and a.status = 0 ");
            sbSql.Append("  and a.num > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetStoreMaterialsNum(int _factoryId, int _materialsId, DateTime _expiresDate)
        {
            sbSql.Clear();
            sbSql.Append("select a.num, ");
            sbSql.Append("       b.value2 unit ");
            sbSql.Append("from p_materials_in a ");
            sbSql.Append("left join m_code b ");
            sbSql.Append("  on a.unit = b.subCode ");
            sbSql.Append(" and b.code = 3 ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            sbSql.Append("  and a.materialsId = ").Append(_materialsId).Append(" ");
            sbSql.Append("  and a.expiresDate >= '").Append(_expiresDate).Append("' ");
            sbSql.Append("  and a.status = 0 ");
            sbSql.Append("  and a.num > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }
    }
}
