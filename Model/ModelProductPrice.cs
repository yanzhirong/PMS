using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProductPrice : ModelBase
    {
        public int id { set; get; }
        public int productId { set; get; }
        public int specsId { set; get; }
        public decimal minPrice { set; get; }
        public decimal advisePrice { set; get; }
        public int priceUnit { set; get; }

    }
}
