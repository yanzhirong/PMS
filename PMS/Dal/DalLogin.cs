using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal
{
    public class DalLogin
    {
        public DataTable GetUser(string _name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from m_user");
            sb.Append(" ");
            string sql = @"select * 
                             from m_user
                            where userName = '{0}' 
                              and isDelete = 0";
            sql = string.Format(sql, _name);

            return Dal.DBHelper.Select(sql);
        }
    }
}
