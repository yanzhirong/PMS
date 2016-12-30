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
                cmd.CommandType = CommandType.Text;
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

          
        public static int Excute(string sql)
        {
            try
            {
                MySqlCommand cmd = DbBase.getMysqlConn().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                int rtn = cmd.ExecuteNonQuery();
                return rtn;

            }
            catch (Exception e)
            {
                return 0;
            }

        }

        public static int ExcuteTransaction(List<string> listSql)
        {
            MySqlTransaction mySqlTransaction = DbBase.getMysqlConn().BeginTransaction();
            try
            {
                MySqlCommand cmd = DbBase.getMysqlConn().CreateCommand();
                cmd.Transaction = mySqlTransaction;
                cmd.CommandType = CommandType.Text;
                foreach (string sql in listSql)
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                mySqlTransaction.Commit();
                return 1;

            }
            catch (Exception e)
            {
                mySqlTransaction.Rollback();
                return 0;
            }

        }

        public static void ExcuteProcedure(string _procedurename, List<MySqlParameter> paramValues)
        {
            try
            {
                MySqlCommand cmd = DbBase.getMysqlConn().CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = _procedurename;
                foreach (MySqlParameter param in paramValues)
                {
                    cmd.Parameters.Add(param);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }

        }
    }

}
