using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelMaterialsOutputDetail : ModelBase
    {
        public int id { set; get; }
        public string outputCode { set; get; }
        public int materialsId { set; get; }
        public int specsId { set; get; }
        public decimal requestOutputWeight { set; get; }
        public int requestOutputNum { set; get; }
        public int realityOutputNum { set; get; }
        public int outputStatus { set; get; }
        public DateTime outputDate { set; get; }
        public int outputType { set; get; }
        public string remark { set; get; }
    }
}
