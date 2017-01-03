using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProductOutput : ModelBase
    {
        public int id { set; get; }
        public string outputCode { set; get; }
        public int orderId { set; get; }
        public int factoryId { set; get; }
        public DateTime delieryDate { set; get; }
        public int outputStatus { set; get; }
        public DateTime outputDate { set; get; }
        public List<ModelProductOutputDetail> modelProductOutputDetail { set; get; }
    }
}
