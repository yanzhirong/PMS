using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enum;

namespace Model
{
    public class Result
    {
        // 返回值（0：成功；1：失败）
        public EnumResultCode resultCode { get; set; }

        // 返回信息
        public string resultMsg { get; set; }

    }
}
