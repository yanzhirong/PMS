using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Dal
{
    public class DalUser
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetUser(string _name)
        {
            sql = @"select * 
                      from m_user
                     where userName = '{0}' 
                       and isDelete = 0";
            sql = string.Format(sql, _name);

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
            sbSql.Append("       a.createTime, ");
            sbSql.Append("       '修改' modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
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

        public DataTable GetUserById(int _userId)
        {
            sql = @"select * 
                      from m_user
                     where isDelete = 0
                       and userId = {0}";

            sql = String.Format(sql, _userId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetUserByName(string _userName)
        {
            sql = @"select * 
                      from m_user
                     where isDelete = 0
                       and userName = '{0}'";

            sql = String.Format(sql, _userName);

            return Dal.DBHelper.Select(sql);
        }

        public int AddUser(ModelUser _modelUser)
        {
            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       m_user ( ");
            sbSql.Append("       userName, ");
            sbSql.Append("       pwd, ");
            sbSql.Append("       roleId, ");
            sbSql.Append("       sex, ");
            sbSql.Append("       position, ");
            sbSql.Append("       mobile, ");
            sbSql.Append("       email, ");
            sbSql.Append("       birthday, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime, ");
            sbSql.Append("       modifyBy, ");
            sbSql.Append("       modifyTime ");
            sbSql.Append("       ) value ( ");
            sbSql.Append("      '" + _modelUser.userName + "', ");
            sbSql.Append("      '" + _modelUser.pwd + "', ");
            sbSql.Append("       " + _modelUser.roleId + ", ");
            sbSql.Append("      '" + _modelUser.sex + "', ");
            sbSql.Append("      '" + _modelUser.position + "', ");
            sbSql.Append("      '" + _modelUser.mobile + "', ");
            sbSql.Append("      '" + _modelUser.email + "', ");
            sbSql.Append("      '" + _modelUser.birthday + "', ");
            sbSql.Append("       " + _modelUser.isDelete + ", ");
            sbSql.Append("      '" + _modelUser.createBy + "', ");
            sbSql.Append("      '" + _modelUser.createTime + "', ");
            sbSql.Append("      '" + _modelUser.modifyBy + "', ");
            sbSql.Append("      '" + _modelUser.modifyTime + "')");

            return Dal.DBHelper.Excute(sbSql.ToString());
        }

        public int UpdateUser(ModelUser _modelUser, int _orgRoleId)
        {
            //用户信息变更
            sbSql.Clear();
            sbSql.Append("update m_user ");
            sbSql.Append("set userName = '" + _modelUser.userName + "',");
            sbSql.Append("    pwd = '" + _modelUser.pwd + "',");
            sbSql.Append("    roleId = " + _modelUser.roleId + ",");
            sbSql.Append("    sex = '" + _modelUser.sex + "',");
            sbSql.Append("    position = '" + _modelUser.position + "',");
            sbSql.Append("    mobile = '" + _modelUser.mobile + "',");
            sbSql.Append("    email = '" + _modelUser.email + "',");
            sbSql.Append("    birthday = '" + _modelUser.birthday + "',");
            sbSql.Append("    modifyBy = '" + _modelUser.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelUser.modifyTime + "' ");
            sbSql.Append("where userId = " + _modelUser.userId);

            return Dal.DBHelper.Excute(sbSql.ToString());
        }

        public int DeleteUser(ModelUser _modelUser)
        {
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
