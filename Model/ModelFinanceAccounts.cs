using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelFinanceAccounts : ModelBase
    {
        public int id { set; get; }
        public int customerId { set; get; }
        public int type { set; get; }
        public string orderCode { set; get; }
        public decimal curPricePlan { set; get; }
        public decimal curPrice { set; get; }
        public decimal totalPrice { set; get; }
    }
}
