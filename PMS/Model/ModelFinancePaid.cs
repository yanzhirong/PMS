using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelFinancePaid : ModelBase
    {
        public int id { set; get; }
        public int customerId { set; get; }
        public int factoryId { set; get; }
        public int materialsId { set; get; }
        public decimal num { set; get; }
        public int unit { set; get; }
        public decimal orderPrice { set; get; }
        public string purchaseCode { set; get; }
        public string purchaseBy { set; get; }
        public DateTime purchaseDate { set; get; }
        public decimal paidPrice { set; get; }
        public int paidStatus { set; get; }
        public string remark { set; get; }
    }
}
