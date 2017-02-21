using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelInventoryProductLog : ModelBase
    {
        public int id { set; get; }
        public string inputCode { set; get; }
        public int factoryId { set; get; }
        public int productId { set; get; }
        public int stockNumOld { set; get; }
        public int stockNumNew { set; get; }
        public DateTime produceDateOld { set; get; }
        public DateTime produceDateNew { set; get; }
        public DateTime expiresDateOld { set; get; }
        public DateTime expiresDateNew { set; get; }
        public string remark { set; get; }
    }
}
