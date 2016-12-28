using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelSaleOrder : ModelBase
    {
        public int id { set; get; }
        public string orderCode { set; get; }
        public int customerId { set; get; }
        public int salerId { set; get; }
        public decimal price { set; get; }
        public string priceRemark { set; get; }
        public int factoryId { set; get; }
        public int payStatus { set; get; }
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
        public string deliverDate { set; get; }
        public int orderStatus { set; get; }
        public string remark { set; get; }

        public ModelSaleOrderPay modelSaleOrderPay { set; get; }

        public List<ModelSaleOrderDetail> modelSaleOrderDetail { set; get; }
    }
}
