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
        public int materialstId { set; get; }
        public decimal materialsNum { set; get; }
        public int materialsUnit { set; get; }
        public int outputStatus { set; get; }
        public DateTime outputDate { set; get; }
        public string remark { set; get; }
    }
}
