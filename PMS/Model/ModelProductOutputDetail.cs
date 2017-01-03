using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProductOutputDetail : ModelBase
    {
        public int id { set; get; }
        public string outputCode { set; get; }
        public int productId { set; get; }
        public decimal productNum { set; get; }
        public int outputStatus { set; get; }
        public DateTime outputDate { set; get; }
    }
}
