using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelStore : ModelBase
    {
        public int id { set; get; }
        public int factoryId { set; get; }
        public int goodsType { set; get; }
        public int saleOrderId { set; get; }
        public int purchaeOrderId { set; get; }
        public int productId { set; get; }
        public int materialsId { set; get; }
        public decimal num { set; get; }
        public int unit { set; get; }
        public DateTime expiresDate { set; get; }
        public int status { set; get; }
        public string remark { set; get; }
    }
}
