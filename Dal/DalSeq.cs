using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Common.Tools;

namespace Dal
{
    public class DalSeq
    {
        public static int GetSeq(string _key)
        {
            string procedureName = "p_GetSeq";
            List<MySqlParameter> listParam = new List<MySqlParameter>();

            MySqlParameter paramIn = new MySqlParameter();
            paramIn.ParameterName = "key_in";
            paramIn.MySqlDbType = MySqlDbType.VarChar;
            paramIn.Value = _key;
            paramIn.Direction = ParameterDirection.Input;
            listParam.Add(paramIn); 
            
            MySqlParameter paramOut = new MySqlParameter();
            paramOut.ParameterName = "seq_out";
            paramOut.MySqlDbType = MySqlDbType.Int32;
            paramOut.Direction = ParameterDirection.Output;

            listParam.Add(paramOut);

            DBHelper.ExcuteProcedure(procedureName, listParam);

            return ConvertUtils.ConvertToInt(paramOut.Value);
        }
    }
}
