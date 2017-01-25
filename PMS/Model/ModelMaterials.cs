using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelMaterials : ModelBase
    {
        public int id { set; get; }
        public string name { set; get; }
        public string subName { set; get; }
        public int packingType { set; get; }
        public string packingRemark { set; get; }
        public decimal weight { set; get; }
        public int weightUnit { set; get; }
        public int morphology { set; get; }
        public int shelfLife { set; get; }
        public int expiredDays { set; get; }
        public int minStockNum { set; get; }
        public int type { set; get; }

        public ModelMaterialsPrice modelMaterialsPrice { set; get; }

        public ModelMaterialsSearch modelMaterialsSearch { set; get; }
    }
}
