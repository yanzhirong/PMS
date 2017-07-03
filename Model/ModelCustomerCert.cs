using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelCustomerCert : ModelBase
    {
        public int id { set; get; }
        public int customerId { set; get; }
        public string customerName { set; get; }
        public string certName { set; get; }
        public byte[] certImage { set; get; }
    }
}
