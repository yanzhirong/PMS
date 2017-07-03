using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelCustomerPaid : ModelBase
    {
        public int id { set; get; }
        public int customerId { set; get; }
        public string customerName { set; get; }
        public string bank { set; get; }
        public string subBank { set; get; }
        public string bankAccount { set; get; }
        public string bankAccountName { set; get; }
        public string bankAccountMobile { set; get; }
        public string alipayName { set; get; }
        public string alipayAccount { set; get; }
        public string alipayMobile { set; get; }
        public decimal creditLimit { set; get; }
        public string remark { set; get; }
    }
}
