using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelPurchase : ModelBase
    {
        public int id { set; get; }
        public string purchaseCode { set; get; }
        public int factoryId { set; get; }
        public int materialsId { set; get; }
        public string materialsName { set; get; }
        public decimal num { set; get; }
        public int unit { set; get; }
        public int customerId { set; get; }
        public int country { set; get; }
        public int province { set; get; }
        public string provinceName { set; get; }
        public int city { set; get; }
        public string cityName { set; get; }
        public int district { set; get; }
        public string districtName { set; get; }
        public string address { set; get; }
        public string manager { set; get; }
        public string telephone { set; get; }
        public DateTime deliveryDate { set; get; }
        public int status { set; get; }
        public string produceCode { set; get; }
        public int applyType { set; get; }
        public string applyBy { set; get; }
        public DateTime applyDate { set; get; }
        public int purchaserId { set; get; }
        public string cancelReason { set; get; }
        public string remark { set; get; }
        public decimal price { set; get; }
    }
}
