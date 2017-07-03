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
            sql = @"select a.* 
                      from m_user a
                     inner join m_role b
                        on a.roleId = b.roleId   
                       and b.isDelete = 0    
                     where a.userName = '{0}' 
                       and a.isDelete = 0";
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

        public DataTable GetUserGroupByRoleType(int _roleType)
        {
            sql = @"select a.userId, a.userName 
                      from m_user a
                      join m_role b 
                        on a.roleId = b.roleId
                     where a.isDelete = 0
                       and b.isDelete = 0
                       and b.roleType = {0} 
                     order by a.userId ";
            sql = String.Format(sql, _roleType);
            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetUsersWithItem()
        {
            sql = @"select * 
                      from m_user
                     where isDelete = 0";

            return Dal.DBHelper.Select(sql);
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
            sbSql.Append("       telphone, ");
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
            sbSql.Append("      '" + _modelUser.telphone + "', ");
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
            sbSql.Append("    telphone = '" + _modelUser.telphone + "',");
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

        public DataTable GetTaskMaterialsExpired()
        {
            sbSql.Clear();
            sbSql.Append("select " + (int)Enum.EnumTaskType.MaterialsExpired + " taskType, ");
            sbSql.Append("       '原料过期提醒' taskName, ");
            sbSql.Append("       concat('【', m.name, '】即将于', date_format(mi.expiresDate, '%Y-%m-%d') ,'过期') taskContent ");
            sbSql.Append("from p_materials_input mi ");
            sbSql.Append("join p_materials m ");
            sbSql.Append("  on mi.materialsId = m.id ");
            sbSql.Append(" and m.isDelete = 0 ");
            sbSql.Append("where mi.isDelete = 0 ");
            sbSql.Append("  and datediff(date_format(mi.expiresDate, '%Y-%m-%d'), curdate()) <= (select value1 from m_code where code = " + (int)Enum.EnumCode.ExpiresDate + " and subCode = 1) ");
            sbSql.Append("order by datediff(date_format(mi.expiresDate, '%Y-%m-%d'), curdate()) ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetTaskMaterialsStockOut()
        {
            sbSql.Clear();
            sbSql.Append("select " + (int)Enum.EnumTaskType.MaterialsStockOut + " taskType, ");
            sbSql.Append("       '原料库存提醒' taskName, ");
            sbSql.Append("       concat('【', m.name, '】库存不足（库存：', ifnull(miw.stockWeight,0), '克）') taskContent ");
            sbSql.Append("  from p_materials m ");
            sbSql.Append("  left join ( ");
            sbSql.Append("	     select ");
            sbSql.Append("		    mi.materialsId, ");
            sbSql.Append("		    sum(mi.stockNum * ifnull(ms.weight, 1) * ifnull(ms.num, 1)) stockWeight ");
            sbSql.Append("	     from  p_materials_input mi ");
            sbSql.Append("	     left join r_materials_specs ms on mi.materialsId = ms.materialsId ");
            sbSql.Append("	      and mi.specsId = ms.id ");
            sbSql.Append("	      and ms.isDelete = 0 ");
            sbSql.Append("	    where mi.isDelete = 0 ");
            sbSql.Append("	      and mi.stockNum > 0 ");
            sbSql.Append("	      and mi.inputStatus = 1 ");
            sbSql.Append("	    group by mi.materialsId ) miw ");
            sbSql.Append("    on m.id = miw.materialsId ");
            sbSql.Append(" where m.isDelete = 0 ");
            sbSql.Append("   and m.type != 2 ");
            sbSql.Append("   and m.minStockNum >= ifnull(miw.stockWeight,0) ");
            sbSql.Append(" order by ifnull(miw.stockWeight,0) - m.minStockNum ");
            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetTaskProductExpired()
        {
            sbSql.Clear();
            sbSql.Append("select " + (int)Enum.EnumTaskType.ProductExpired + " taskType, ");
            sbSql.Append("       '成品过期提醒' taskName, ");
            sbSql.Append("       concat('【', p.name, '】即将于', date_format(pi.expiresDate, '%Y-%m-%d') ,'过期') taskContent ");
            sbSql.Append("from p_product_input pi ");
            sbSql.Append("join p_product p ");
            sbSql.Append("  on pi.productId = p.id ");
            sbSql.Append(" and p.isDelete = 0 ");
            sbSql.Append("where pi.isDelete = 0 ");
            sbSql.Append("  and datediff(date_format(pi.expiresDate, '%Y-%m-%d'), curdate()) <= (select value1 from m_code where code = " + (int)Enum.EnumCode.ExpiresDate + " and subCode = 2) ");
            sbSql.Append("order by datediff(date_format(pi.expiresDate, '%Y-%m-%d'), curdate()) ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetTaskProductStockOut()
        {
            sbSql.Clear();
            sbSql.Append("select " + (int)Enum.EnumTaskType.ProductStockOut + " taskType, ");
            sbSql.Append("       '成品库存提醒' taskName, ");
            sbSql.Append("       concat('【', p.name, '】库存不足（库存：', ifnull(piw.stockWeight,0), '克）') taskContent ");
            sbSql.Append("  from p_product p ");
            sbSql.Append("  left join ( ");
            sbSql.Append("	     select ");
            sbSql.Append("		    pi.productId, ");
            sbSql.Append("		    sum(pi.stockNum * ifnull(ps.weight, 1) * ifnull(ps.num, 1)) stockWeight ");
            sbSql.Append("	     from  p_product_input pi ");
            sbSql.Append("	     left join r_product_specs ps ");
            sbSql.Append("	            on pi.productId = ps.productId ");
            sbSql.Append("	           and pi.specsId = ps.id ");
            sbSql.Append("	           and ps.isDelete = 0 ");
            sbSql.Append("	    where pi.isDelete = 0 ");
            sbSql.Append("	      and pi.stockNum > 0 ");
            sbSql.Append("	      and pi.inputStatus = 1 ");
            sbSql.Append("	    group by pi.productId ) piw ");
            sbSql.Append("    on p.id = piw.productId ");
            sbSql.Append(" where p.isDelete = 0 ");
            sbSql.Append("   and p.minStockNum >= ifnull(piw.stockWeight,0) ");
            sbSql.Append(" order by ifnull(piw.stockWeight,0) - p.minStockNum ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetTaskProduceApply()
        {
            sbSql.Clear();
            sbSql.Clear();
            sbSql.Append("select " + (int)Enum.EnumTaskType.ProduceApply + " taskType, ");
            sbSql.Append("       '生产计划提醒' taskName, ");
            sbSql.Append("       concat('有', t1.cnt, '个新的生产计划') taskContent ");
            sbSql.Append("  from ( ");
            sbSql.Append("         select count(*) cnt ");
            sbSql.Append("           from p_produce_apply pa ");
            sbSql.Append("          where pa.isDelete = 0 ");
            sbSql.Append("            and pa.status = 0) t1 ");
            sbSql.Append("  where t1.cnt > 0 ");
            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetTaskPurchaseApply()
        {
            sbSql.Clear();
            sbSql.Append("select " + (int)Enum.EnumTaskType.PurchaseApply + " taskType, ");
            sbSql.Append("       '采购计划提醒' taskName, ");
            sbSql.Append("       concat('有', t1.cnt, '新的采购计划') taskContent ");
            sbSql.Append("  from ( ");
            sbSql.Append("         select count(*) cnt ");
            sbSql.Append("           from p_produce_apply pa ");
            sbSql.Append("          where pa.isDelete = 0 ");
            sbSql.Append("            and pa.status = 0) t1 ");
            sbSql.Append("  where t1.cnt > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }
    }
}
