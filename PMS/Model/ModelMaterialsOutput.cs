using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelMaterialsOutput : ModelBase
    {
        public int id { set; get; }
        public string outputCode { set; get; }
        public string produceCode { set; get; }
        public int factoryId { set; get; }
        public int materialsId { set; get; }
        public DateTime applyDate { set; get; }
        public decimal outputNum { set; get; }
        public int outputUnit { set; get; }
        public int outputStatus { set; get; }
        public DateTime outputDate { set; get; }
        public int outputType { set; get; }
        public int applyMemberId { set; get; }
        public string remark { set; get; }
    }
}
