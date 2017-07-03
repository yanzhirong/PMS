using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelPurchaseDetail : ModelBase
    {
        public int id { set; get; }
        public string inputCode { set; get; }
        public string purchaseCode { set; get; }
        public int materialsId { set; get; }
        public int specsId { set; get; }
        public string materialsName { set; get; }
        public int num { set; get; }
        public decimal price { set; get; }
        public DateTime deliveryDate { set; get; }
        public string produceCode { set; get; }
        public int applyType { set; get; }
        public string applyBy { set; get; }
        public DateTime applyDate { set; get; }
    }
}
