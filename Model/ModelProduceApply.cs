using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProduceApply : ModelBase
    {
        public int id { set; get; }
        public int factoryId { set; get; }
        public int productId { set; get; }
        public int specsId { set; get; }
        public int num { set; get; }
        public string saleOrderCode { set; get; }
        public string outputCode { set; get; }
        public DateTime deliveryDate { set; get; }
        public int applyType { set; get; }
        public string applyBy { set; get; }
        public DateTime applyDate { set; get; }
        public int status { set; get; }
        public string remark { set; get; }
        public string produceCode { set; get; }
    }
}
