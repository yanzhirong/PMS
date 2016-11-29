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
                     where roleId = {0} 
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

        public DataTable GetRoles(string _name)
        {
            if (Common.Tools.StringUtils.IsBlank(_name))
            {
                sql = @"select roleId,
                               roleName,
                               case isFinance when 1 then '有' else '无' end isFinance,
                               createTime,
                               '修改' modifyBtn,
                               '删除' deleteBtn
                          from m_role
                         where isDelete = 0
                         order by modifyTime desc";
            }
            else
            {
                sql = @"select roleId,
                               roleName,
                               case isFinance when 1 then '有' else '无' end isFinance,
                               createTime,
                               '修改' modifyBtn,
                               '删除' deleteBtn
                          from m_role
                         where isDelete = 0
                           and roleName like '%{0}%'
                         order by modifyTime desc";

                sql = string.Format(sql, _name);
            }

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetRoleByName(string _name)
        {
            sql = @"select *
                      from m_role
                     where isDelete = 0
                       and roleName = '{0}'";

            sql = string.Format(sql, _name);

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
                               on a.menuId = b.menuId
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

        public int GetMenuIdByCheckBoxName(string _checkBoxName)
        {
            sql = @"select menuId  
                      from m_menu 
                    where isDelete = 0
                      and checkBoxName = '{0}'";

            sql = string.Format(sql, _checkBoxName);

            DataTable dt = Dal.DBHelper.Select(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                return (int)dt.Rows[0][0];
            }
            else
            {
                return 0;
            }
        }

        public int AddRole(ModelRole _modelRole, List<ModelMenu> _listMenu)
        {
            listSql.Clear();

            sbSql.Clear();
            sbSql.Append("insert into m_role ");
            sbSql.Append("(roleName, isFinance, isDelete, createBy, createTime, modifyBy, modifyTime) ");
            sbSql.Append(" value ( ");
            sbSql.Append("'" + _modelRole.roleName + "', ");
            sbSql.Append(_modelRole.isFinance + ", ");
            sbSql.Append(_modelRole.isDelete + ", ");
            sbSql.Append("'" + _modelRole.createBy + "', ");
            sbSql.Append("'" + _modelRole.createTime + "', ");
            sbSql.Append("'" + _modelRole.modifyBy + "', ");
            sbSql.Append("'" + _modelRole.modifyTime + "') ");

            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateRole(ModelRole _modelRole, List<ModelMenu> _listMenu)
        {
            listSql.Clear();

            sbSql.Clear();
            sbSql.Append("update m_role ");
            sbSql.Append("set isFinance = " + _modelRole.isFinance + ", ");
            sbSql.Append("    modifyBy = '" + _modelRole.modifyBy + "', ");
            sbSql.Append("    modifyTime = '" + _modelRole.modifyTime + "' ");
            sbSql.Append("where roleId = " + _modelRole.roleId + " ");
            listSql.Add(sbSql.ToString());

            sql = @"update r_role_menu
                       set isDelete = 1,
                           ModifyBy = '{0}', 
                           ModifyTime = '{1}'
                     where roleId = {2}";

            sql = string.Format(sql, _modelRole.modifyBy, DateTime.Now, _modelRole.roleId);
            listSql.Add(sql);

            foreach (ModelMenu menu in _listMenu)
            {
                sbSql.Clear();
                sbSql.Append("insert into r_role_menu ");
                sbSql.Append("(roleId, menuId, isDelete, createBy, createTime, modifyBy, modifyTime) ");
                sbSql.Append(" value ( ");
                sbSql.Append(_modelRole.roleId + ", ");
                sbSql.Append(menu.menuId + ", ");
                sbSql.Append(menu.isDelete + ", ");
                sbSql.Append("'" + menu.createBy + "', ");
                sbSql.Append("'" + menu.createTime + "', ");
                sbSql.Append("'" + menu.modifyBy + "', ");
                sbSql.Append("'" + menu.modifyTime + "') ");

                listSql.Add(sbSql.ToString());
            }

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int DeleteRole(ModelRole _modelRole)
        {
            listSql.Clear();

            sbSql.Clear();
            sbSql.Append("update m_role ");
            sbSql.Append("set isDelete = 1, ");
            sbSql.Append("    modifyBy = '" + _modelRole.modifyBy + "', ");
            sbSql.Append("    modifyTime = '" + _modelRole.modifyTime + "' ");
            sbSql.Append("where roleId = " + _modelRole.roleId + " ");

            listSql.Add(sbSql.ToString());

            sql = @"update r_role_menu
                       set isDelete = 1,
                           ModifyBy = '{0}', 
                           ModifyTime = '{1}'
                     where roleId = {2}";

            sql = string.Format(sql, _modelRole.modifyBy, DateTime.Now, _modelRole.roleId);
            listSql.Add(sql);

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateMenuByRoleId(ModelRole _modelRole, List<ModelMenu> _listMenu)
        {
            listSql.Clear();
            sql = @"update r_role_menu
                       set isDelete = 1,
                           ModifyBy = '{0}', 
                           ModifyTime = '{1}'
                     where roleId = {2}";

            sql = string.Format(sql, _modelRole.modifyBy, DateTime.Now, _modelRole.roleId);
            listSql.Add(sql);

            foreach (ModelMenu menu in _listMenu)
            {
                sbSql.Clear();
                sbSql.Append("insert into r_role_menu ");
                sbSql.Append("(roleId, menuId, isDelete, createBy, createTime, modifyBy, modifyTime) ");
                sbSql.Append(" value ( ");
                sbSql.Append(_modelRole.roleId + ", ");
                sbSql.Append(menu.menuId + ", ");
                sbSql.Append(menu.isDelete + ", ");
                sbSql.Append("'" + menu.createBy + "', ");
                sbSql.Append("'" + menu.createTime + "', ");
                sbSql.Append("'" + menu.modifyBy + "', ");
                sbSql.Append("'" + menu.modifyTime + "') ");

                listSql.Add(sbSql.ToString());
            }

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }
    }
}
