using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelMaterialsPrice : ModelBase
    {
        public int id { set; get; }
        public int materialsId { set; get; }
        public decimal price { set; get; }
        public int priceUnit { set; get; }

    }
}
