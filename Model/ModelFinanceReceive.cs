using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelFinanceReceive : ModelBase
    {
        public int id { set; get; }
        public int customerId { set; get; }
        public int factoryId { set; get; }
        public string orderCode { set; get; }
        public decimal orderPrice { set; get; }
        public int salerId { set; get; }
        public int financeId { set; get; }
        public DateTime deliveryDate { set; get; }
        public decimal receivedPrice { set; get; }
        public int receivedStatus { set; get; }
        public string remark { set; get; }
    }
}
