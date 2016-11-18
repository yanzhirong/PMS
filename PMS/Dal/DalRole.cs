using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Dal
{
    public class DalRole
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();
        List<string> listSql = new List<string>();
     
        public DataTable GetRoleById(int _roleId)
        {
            sql = @"select * 
                      from m_role
                     where userName = '{0}' 
                       and isDelete = 0";
            sql = string.Format(sql, _roleId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetAllRoles()
        {
            sql = @"select roleId itemKey,
                           roleName itemValue 
                      from m_role
                     where isDelete = 0
                     order by roleId";

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetLoginMenuByRoleId(int _roleId)
        {
            //admin
            if (_roleId == 1)
            {
                sql = @"select * 
                          from m_menu a
                         where isDelete = 0
                         order by sort";
            }
            else
            {
                sql = @"select a.* 
                          from m_menu a
                               join r_role_menu b
                               on a.roleId = b.roleId
                         where b.roleId = {0} 
                           and b.isDelete = 0
                           and a.isDelete = 0
                         order by a.sort";
            }
            sql = string.Format(sql, _roleId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMenuByRoleId(int _roleId)
        {
            sql = @"select a.*,
                           case when b.id > 0 then 1 else 0 end isChecked  
                     from m_menu a
                          left join r_role_menu b
                          on a.menuId = b.menuId
                          and b.isDelete = 0
                          and b.roleId = {0} 
                    where a.isDelete = 0
                    order by a.sort";
            
            sql = string.Format(sql, _roleId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMenuIdByCheckBoxName(string _checkBoxName)
        {
            sql = @"select menuId  
                      from m_menu 
                    where isDelete = 0
                      and checkBoxName = '{0}'";

            sql = string.Format(sql, _checkBoxName);

            return Dal.DBHelper.Select(sql);
        }

        public int UpdateMenuByRoleId(int _roleId, List<ModelMenu> _listMenu, string _loginUserId)
        {
            listSql.Clear();
            sql = @"update r_role_menu
                       set isDelete = 1,
                           ModifyBy = '{0}', 
                           ModifyTime = '{1}'
                     where roleId = {2}";

            sql = string.Format(sql, _loginUserId, DateTime.Now, _roleId);
            listSql.Add(sql);

            sbSql.Clear();
            sbSql.Append("update m_user ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelUser.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelUser.modifyTime + "' ");
            sbSql.Append("where userId = " + _modelUser.userId);

            return Dal.DBHelper.Excute(sbSql.ToString());
        }
    }
}
