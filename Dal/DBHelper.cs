using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Common;
using Common.Tools;
using System.Data.SqlClient;

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

                MsgUtils.ShowErrorMsg(sql + "\n" + e.ToString());
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
                cmd.Parameters.Clear();
                int rtn = cmd.ExecuteNonQuery();
                return rtn;

            }
            catch (Exception e)
            {
                MsgUtils.ShowErrorMsg(sql + "\n" + e.ToString());
                return 0;
            }

        }

        public static int ExcuteParam(string sql, List<MySqlParameter> listParam)
        {
            try
            {
                MySqlCommand cmd = DbBase.getMysqlConn().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.Clear();

                if (listParam != null && listParam.Count > 0)
                {
                    foreach (MySqlParameter sqlParam in listParam)
                    {
                        cmd.Parameters.Add(sqlParam);
                    }
                }
                int rtn = cmd.ExecuteNonQuery();
                return rtn;

            }
            catch (Exception e)
            {
                MsgUtils.ShowErrorMsg(sql + "\n" + e.ToString());
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
                    cmd.Parameters.Clear();
                    cmd.ExecuteNonQuery();
                }
                mySqlTransaction.Commit();
                return 1;

            }
            catch (Exception e)
            {
                mySqlTransaction.Rollback();
                MsgUtils.ShowErrorMsg(e.ToString());
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
                MsgUtils.ShowErrorMsg(e.ToString());
            }

        }
    }

}
