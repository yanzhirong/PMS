using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Common;

namespace Dal
{
    public static class DBHelper
    {

        public static DataTable Select(string sql)
        {
            try
            {
                MySqlCommand cmd = DbBase.getMysqlConn().CreateCommand();
                cmd.CommandText = sql;
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adp.Fill(ds);

                if (ds != null && ds.Tables.Count > 0)
                {
                    return ds.Tables[0];
                }
                else
                {
                    return null;
                }

            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
