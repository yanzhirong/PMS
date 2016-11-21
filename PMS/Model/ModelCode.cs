using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelCode : ModelBase
    {
        public int id { set; get; }
        public string code { set; get; }
        public string subCode { set; get; }
        public string value1 { set; get; }
        public string value2 { set; get; }
        public string value3 { set; get; }
        public string remark { set; get; }

    }
}
