using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelMaterialsSearch : ModelBase
    {
        public int id { set; get; }
        public int materialsId { set; get; }
        public string materialsName { set; get; }
        public string searchKey { set; get; }

    }
}
