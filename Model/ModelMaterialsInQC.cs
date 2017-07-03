using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelMaterialsInQC : ModelBase
    {
        public int id { set; get; }
        public string inputCode { set; get; }
        public int factoryId { set; get; }
        public int materialsId { set; get; }
        public int specsId { set; get; }
        public string QCName { set; get; }
        public byte[] QCImage { set; get; }
        public string remark { set; get; }
    }
}
