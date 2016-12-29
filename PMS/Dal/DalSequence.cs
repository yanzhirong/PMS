using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Dal
{
    public class DalSequence
    {
        private static string sql;
        StringBuilder sbSql = new StringBuilder();
        List<string> listSql = new List<string>();

        public static int GetSequence(string _key)
        {
            sql = @"select * 
                      from m_role
                     where roleId = {0} 
                       and isDelete = 0";
            sql = string.Format(sql, _key);

            DataTable dt = Dal.DBHelper.Select(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                return (int)dt.Rows[0][0];
            }
            else
            {
                return 1;
            }
        }

    }
}
