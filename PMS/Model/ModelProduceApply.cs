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
        public decimal num { set; get; }
        public int unit { set; get; }
        public int saleOrderId { set; get; }
        public DateTime deliverDate { set; get; }
        public int applyType { set; get; }
        public string applyBy { set; get; }
        public DateTime applyDate { set; get; }
        public int status { set; get; }
        public string remark { set; get; }
    }
}
