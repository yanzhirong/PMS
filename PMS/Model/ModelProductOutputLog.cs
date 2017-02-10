using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProductOutputLog : ModelBase
    {
        public int id { set; get; }
        public string outputCode { set; get; }
        public string inputCode { set; get; }
        public int factoryId { set; get; }
        public int productId { set; get; }
        public decimal outputNum { set; get; }
        public int outputUnit { set; get; }
        public int applyMemberId { set; get; }
        public DateTime outputDate { set; get; }
    }
}
