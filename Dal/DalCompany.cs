using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Dal
{
    public class DalCompany
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetCompany()
        {
            sql = @"select * 
                      from m_company
                     order by id desc";
            
            return Dal.DBHelper.Select(sql);
        }

        public int UpdatecCompany(ModelCompany _modelCompany)
        {
            sbSql.Clear();
            sbSql.Append("update m_company ");
            sbSql.Append("set name = '" + _modelCompany.name + "',");
            sbSql.Append("    address = '" + _modelCompany.address + "',");
            sbSql.Append("    telphone = " + _modelCompany.telphone + ",");
            sbSql.Append("    homepage = '" + _modelCompany.homepage + "',");
            sbSql.Append("    fax = '" + _modelCompany.fax + "',");
            sbSql.Append("    email = '" + _modelCompany.email + "',");
            sbSql.Append("    zip = '" + _modelCompany.zip + "' ");
            sbSql.Append("where id = " + _modelCompany.id);

            return Dal.DBHelper.Excute(sbSql.ToString());
        }
    }
}
