using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Tools;
using Dal;

namespace Bll
{
    public class BllSeq
    {
        public static int GetSeq(string _key)
        {
   
            if(StringUtils.IsBlank(_key))
            {
                return 0;
            } else {
                return DalSeq.GetSeq(_key);
            }
        }
    }
}
