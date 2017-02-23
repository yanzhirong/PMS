using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelFinancePaidDetail : ModelBase
    {
        public int id { set; get; }
        public string purchaseCode { set; get; }
        public decimal paidMoney { set; get; }
        public DateTime paidDate { set; get; }
        public int paidType { set; get; }
        public string otherType { set; get; }
        public string remark { set; get; }
    }
}
