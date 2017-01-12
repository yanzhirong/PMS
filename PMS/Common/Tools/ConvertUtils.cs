using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tools
{
    public static class ConvertUtils
    {
        public static int ConvertToInt(object _object)
        {
            int value = 0;

            if (_object == null)
            {
                return 0;
            }

            if (_object is DBNull)
            {
                return 0;
            }

            if (_object.GetType() == typeof(string))
            {
                if (StringUtils.IsBlank(_object.ToString()))
                {
                    return 0;
                }
            }

            try
            {
                value = Convert.ToInt32(_object);
            }
            catch (Exception e)
            {
            }

            return value;
        }

        public static decimal ConvertToDecimal(object _object)
        {
            decimal value = 0;

            if (_object == null)
            {
                return 0;
            }

            if (_object is DBNull)
            {
                return 0;
            }

            if (_object.GetType() == typeof(string))
            {
                if (StringUtils.IsBlank(_object.ToString()))
                {
                    return 0;
                }
            }

            try
            {
                value = Convert.ToDecimal(_object);
                value = Decimal.Round(value, 2);    //保留2位小数
            }
            catch (Exception e)
            {
            }

            return value;
        }
        public static string ConvertToString(object _object)
        {
            string value = "";

            if (_object == null)
            {
                return "";
            }

            if (_object is DBNull)
            {
                return "";
            }

            try
            {
                value = Convert.ToString(_object);
            }
            catch (Exception e)
            {
            }

            return value;
        }

        public static string ConvertToDate(DateTime _object, string _format)
        {
            string value = "";

            if (_object == null)
            {
                return "";
            }

            try
            {
                value = _object.ToString(_format);
            }
            catch (Exception e)
            {
            }

            return value;
        }
    }
}
