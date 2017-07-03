using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelFinanceReceivedDetail : ModelBase
    {
        public int id { set; get; }
        public string orderCode { set; get; }
        public decimal receivedMoney { set; get; }
        public DateTime receivedDate { set; get; }
        public int receivedType { set; get; }
        public string otherType { set; get; }
        public string remark { set; get; }
    }
}
