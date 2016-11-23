using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProduct : ModelBase
    {
        public int id { set; get; }
        public int name { set; get; }
        public string subName { set; get; }
        public int packingType { set; get; }
        public string packingRemark { set; get; }
        public decimal weight { set; get; }
        public int weightUnit { set; get; }
        public int morphology { set; get; }
        public int shelfLife { set; get; }
        public int expiredDays { set; get; }
        public int minStockNum { set; get; }

        public ModelProductPrice modelProductPrice { set; get; }

        public ModelProductSearch modelProductSearch { set; get; }
    }
}
