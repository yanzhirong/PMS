using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Common.Tools;

namespace Common
{
    public static class DbBase
    {
        private static string serverIp = "";

        private static string dataBase = "pms";

        private static string userId = "pms";

        private static string pwd = "12345678";

        private static MySqlConnection conn;

        static DbBase()
        {
            serverIp = ConfigBase.GetAppConfig("ServerIP");

            if(StringUtils.IsBlank(serverIp)){
                return ;
            }

            InitConn();
        }

        private static string GetConnStr()
        {
            return "Server=" + serverIp + ";Database=" + dataBase + ";Uid=" + userId + ";Pwd=" + pwd + ";CharSet=utf8;"; 
        }

        private static void InitConn()
        {
            string connStr = GetConnStr();

            conn = new MySqlConnection(connStr);        

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {

            }
            finally
            {
            }
            
        }

        public static MySqlConnection getMysqlConn()
        {
            if (conn == null)
            {
                InitConn();
            }

            return conn;
        }

        public static void CloseConn()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }catch(Exception e){
            }
            finally{
            }
            
        }
    }
}
