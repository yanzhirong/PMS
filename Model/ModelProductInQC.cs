using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProductInQC : ModelBase
    {
        public int id { set; get; }
        public string inputCode { set; get; }
        public int inspecterId { set; get; }
        public int checkerId { set; get; }
        public DateTime inspectDate { set; get; }
        public int inspectResult { set; get; }
        public List<ModelProductInQCDetail> modelProductInQCDetail { get; set; }

    }
}
