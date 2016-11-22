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
        public decimal unitVolume { set; get; }
        public decimal unitWeight { set; get; }
        public string morphology { set; get; }
        public string shelfLife { set; get; }
        public string expiredDays { set; get; }
        public string minStockNum { set; get; }

        public ModelProductPrice modelProductPrice { set; get; }

        public ModelProductSearch modelProductSearch { set; get; }
    }
}
