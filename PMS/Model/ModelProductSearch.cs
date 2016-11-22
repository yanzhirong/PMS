using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProductSearch : ModelBase
    {
        public int id { set; get; }
        public int productId { set; get; }
        public string productName { set; get; }
        public string searchKey { set; get; }

    }
}
