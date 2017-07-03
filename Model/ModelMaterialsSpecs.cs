using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelMaterialsSpecs : ModelBase
    {
        public int id { set; get; }
        public int materialsId { set; get; }
        public string name { set; get; }
        public decimal weight { set; get; }
        public int num { set; get; }
    }
}
