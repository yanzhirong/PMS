using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal
{
    public class DalUser
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetAllRoles()
        {
            sql = @"select roleId itemKey,
                           roleName itemValue 
                      from m_role
                     where isDelete = 0
                     order by roleId";

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetUsers(string _name, int _roleId)
        {
            sbSql.Clear();
            sbSql.Append("select a.userId, ");
            sbSql.Append("       a.userName, ");
            sbSql.Append("       a.roleId, ");
            sbSql.Append("       b.roleName, ");
            sbSql.Append("       a.sex, ");
            sbSql.Append("       a.position, ");
            sbSql.Append("       a.mobile, ");
            sbSql.Append("       a.email, ");
            sbSql.Append("       a.createTime ");
            sbSql.Append("from m_user a ");
            sbSql.Append("join m_role b ");
            sbSql.Append("  on a.roleId = b.roleId ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and b.isDelete = 0 ");
            if(Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("  and a.userName like '%").Append(_name).Append("%' ");
            }
            if(_roleId > 0)
            {
                sbSql.Append("  and a.roleId =").Append(_roleId).Append(" ");
            }
            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }
    
    }
}
