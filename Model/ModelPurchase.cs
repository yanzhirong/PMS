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
        public int customerId { set; get; }
        public int payType { set; get; }
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
        public int purchaserId { set; get; }
        public DateTime purchaseDate { set; get; }
        public string cancelReason { set; get; }
        public string remark { set; get; }
        public decimal price { set; get; }

        public List<ModelPurchaseDetail> modelPurchaseDetail { set; get; }
    }
}
