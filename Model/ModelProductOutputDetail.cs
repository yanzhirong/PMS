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
        public int specsId { set; get; }
        public int productNum { set; get; }
        public int realityOutputNum { set; get; }
        public int outputStatus { set; get; }
        public DateTime outputDate { set; get; }
        public int outputType { set; get; }
        public string logisticsOrder { set; get; }
        public string remark { set; get; }
    }
}
