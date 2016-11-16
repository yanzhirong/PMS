using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelBase
    {
        public int isDelete { get; set; }
        public string createBy { get; set; }
        public DateTime createTime { get; set; }
        public string modifyBy { get; set; }
        public DateTime modifyTime { get; set; }
    }
}
