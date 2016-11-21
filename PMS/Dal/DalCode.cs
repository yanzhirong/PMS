using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Dal
{
    public class DalCode
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetCode(string _code, Boolean _isSearchBlank)
        {
            if (_isSearchBlank)
            {
                sql = @"select * 
                      from m_code
                     where code = '{0}'
                       and isDelete = 0
                     order by id desc";

                sql = string.Format(sql, _code);
            }
            else
            {
                sql = @"select * 
                      from m_code
                     where code = '{0}'
                       and subCode is not null
                       and subCode != ''
                       and isDelete = 0
                     order by id desc";

                sql = string.Format(sql, _code);
            }

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetSubCode(string _code, string _subCode)
        {
            sql = @"select * 
                      from m_code
                     where code = '{0}'
                       and subCode = '{1}'
                       and isDelete = 0
                     order by id desc";

            sql = string.Format(sql, _code, _subCode);

            return Dal.DBHelper.Select(sql);
        }
    }
}
