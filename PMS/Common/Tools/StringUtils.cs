using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tools
{
    public static class StringUtils
    {
        #region 判断字符串是否为空
        /// <summary>
        /// 判断字符串是否为空（空格也为空）
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean IsBlank(string value) 
        {
            if(value == null){
                return true;
            }

            if ("".Equals(value.Trim()))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断字符串是否为空（空格也为空）
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean IsNotBlank(string value)
        {
            return !IsBlank(value);
        }

        /// <summary>
        /// 判断字符串是否为空（空格不为空）
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean IsEmpty(string value)
        {
            if (value == null)
            {
                return true;
            }

            if ("".Equals(value))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断字符串是否为空（空格不为空）
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean IsNotEmpty(string value)
        {
            return !IsEmpty(value);
        }
        #endregion
    }
}
