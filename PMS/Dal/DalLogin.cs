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
        string sql;

        public DataTable GetUser(string _name)
        {
            sql = @"select * 
                      from m_user
                     where userName = '{0}' 
                       and isDelete = 0";
            sql = string.Format(sql, _name);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetRole(int _roleId)
        {
            sql = @"select * 
                      from m_role
                     where userName = '{0}' 
                       and isDelete = 0";
            sql = string.Format(sql, _roleId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMenu(int _roleId)
        {
            //admin
            if (_roleId == 1)
            {
                sql = @"select * 
                          from m_menu a
                         where isDelete = 0";
            }
            else
            {
                sql = @"select a.* 
                          from m_menu a
                               join r_role_menu b
                               on a.roleId = b.roleId
                         where b.roleId = {0} 
                           and b.isDelete = 0
                           and a.isDelete = 0";
            }
            sql = string.Format(sql, _roleId);

            return Dal.DBHelper.Select(sql);
        }
    }
}
