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
        public string name { set; get; }
        public string subName { set; get; }
        public int packingType { set; get; }
        public string packingRemark { set; get; }
        public int dangerClasses { set; get; }
        public string excuteStandard { set; get; }
        public string CAS { set; get; }
        public string FEMA { set; get; }
        public int morphology { set; get; }
        public int shelfLife { set; get; }
        public int expiredDays { set; get; }
        public decimal minStockNum { set; get; }

        public ModelProductSearch modelProductSearch { set; get; }

        public List<ModelProductMaterials> modelProductMaterials { set; get; }

        public List<ModelProductPrice> modelProductPrice { set; get; }
    }
}
