using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelSaleOrderPay : ModelBase
    {
        public int id { set; get; }
        public string orderCode { set; get; }
        public decimal payMoney { set; get; }
        public int payType { set; get; }
        public string payTime { set; get; }
        public string payCode { set; get; }
        public string bankAccout { set; get; }
        public string payee { set; get; }
        public string remark { set; get; }

    }
}
