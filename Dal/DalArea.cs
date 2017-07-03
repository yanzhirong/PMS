using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Dal
{
    public class DalArea
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetAllArea()
        {
            sql = @"select * 
                      from m_area
                     where isDelete = 0
                     order by areaId";

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetProvince()
        {
            sql = @"select * 
                      from m_area
                     where isDelete = 0
                       and areaLevel = 1
                     order by areaId";

            return Dal.DBHelper.Select(sql);
        }
    }
}
