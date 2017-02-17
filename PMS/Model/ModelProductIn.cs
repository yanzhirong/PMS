using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProductIn : ModelBase
    {
        public int id { set; get; }
        public string inputCode { set; get; }
        public int factoryId { set; get; }
        public int productId { set; get; }
        public int num { set; get; }
        public DateTime produceDate { set; get; }
        public DateTime expiresDate { set; get; }
        public string produceCode { set; get; }
        public int type { set; get; }
        public int status { set; get; }
        public DateTime inputDate { set; get; }
        public string remark { set; get; }
    }
}
