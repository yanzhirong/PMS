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
            sbSql.Append("from store a ");
            sbSql.Append("left join m_code b ");
            sbSql.Append("  on a.unit = d.subCode ");
            sbSql.Append(" and d.code = 3 ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            sbSql.Append("  and a.productId = ").Append(_productId).Append(" ");
            sbSql.Append("  and a.expiresDate >= '").Append(_expiresDate).Append("' ");
            sbSql.Append("  and a.goodsType = 0 ");
            sbSql.Append("  and a.status = 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

    }
}
