using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Dal
{
    public class DalFactory
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetFactory(string _name)
        {
            sql = @"select id,
                           name,
                           address,
                           telphone,
                           fax,
                           zip,
                           '修改' modifyBtn,
                           '删除' deleteBtn
                      from m_factory
                     where name like '%{0}%'
                       and isDelete = 0
                     order by modifyTime desc";

            sql = string.Format(sql, _name);
            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetFactoryItem()
        {
            sbSql.Clear();
            sbSql.Append("select ");
            sbSql.Append("       id itemKey, ");
            sbSql.Append("       name itemValue ");
            sbSql.Append("  from m_factory");
            sbSql.Append(" where isDelete = 0 ");
            sbSql.Append(" order by id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetFactoryById(int _factoryId)
        {
            sql = @"select *
                      from m_factory
                     where id = {0}
                       and isDelete = 0";

            sql = string.Format(sql, _factoryId);
            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetFactoryByName(string _factoryName)
        {
            sql = @"select *
                      from m_factory
                     where name = '{0}'
                       and isDelete = 0";

            sql = string.Format(sql, _factoryName);
            return Dal.DBHelper.Select(sql);
        }
        public int AddFactory(ModelFactory _modelFactory)
        {
            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       m_factory ( ");
            sbSql.Append("       name, ");
            sbSql.Append("       address, ");
            sbSql.Append("       telphone, ");
            sbSql.Append("       homepage, ");
            sbSql.Append("       fax, ");
            sbSql.Append("       email, ");
            sbSql.Append("       zip, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime, ");
            sbSql.Append("       modifyBy, ");
            sbSql.Append("       modifyTime ");
            sbSql.Append("       ) value ( ");
            sbSql.Append("      '" + _modelFactory.name + "', ");
            sbSql.Append("      '" + _modelFactory.address + "', ");
            sbSql.Append("      '" + _modelFactory.telphone + "', ");
            sbSql.Append("      '" + _modelFactory.homepage + "', ");
            sbSql.Append("      '" + _modelFactory.fax + "', ");
            sbSql.Append("      '" + _modelFactory.email + "', ");
            sbSql.Append("      '" + _modelFactory.zip + "', ");
            sbSql.Append("       " + _modelFactory.isDelete + ", ");
            sbSql.Append("      '" + _modelFactory.createBy + "', ");
            sbSql.Append("      '" + _modelFactory.createTime + "', ");
            sbSql.Append("      '" + _modelFactory.modifyBy + "', ");
            sbSql.Append("      '" + _modelFactory.modifyTime + "')");

            return Dal.DBHelper.Excute(sbSql.ToString());
        }

        public int UpdateFactory(ModelFactory _modelFactory)
        {
            //用户信息变更
            sbSql.Clear();
            sbSql.Append("update m_factory ");
            sbSql.Append("set name = '" + _modelFactory.name + "',");
            sbSql.Append("    address = '" + _modelFactory.address + "',");
            sbSql.Append("    telphone = '" + _modelFactory.telphone + "',");
            sbSql.Append("    homepage = '" + _modelFactory.homepage + "',");
            sbSql.Append("    fax = '" + _modelFactory.fax + "',");
            sbSql.Append("    email = '" + _modelFactory.email + "',");
            sbSql.Append("    zip = '" + _modelFactory.zip + "',");
            sbSql.Append("    modifyBy = '" + _modelFactory.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelFactory.modifyTime + "' ");
            sbSql.Append("where id = " + _modelFactory.id);

            return Dal.DBHelper.Excute(sbSql.ToString());
        }

        public int DeleteFactory(ModelFactory _modelFactory)
        {
            sbSql.Clear();
            sbSql.Append("update m_factory ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelFactory.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelFactory.modifyTime + "' ");
            sbSql.Append("where id = " + _modelFactory.id);

            return Dal.DBHelper.Excute(sbSql.ToString());
        }
    }
}
