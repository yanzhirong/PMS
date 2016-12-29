using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelSaleOrderDetail : ModelBase
    {
        public int id { set; get; }
        public string orderCode { set; get; }
        public int productId { set; get; }
        public string searchKey { set; get; }
        public decimal num { set; get; }
        public int unit { set; get; }
        public decimal price { set; get; }
        public string remark { set; get; }

    }
}
