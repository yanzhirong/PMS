using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProductInQCDetail : ModelBase
    {
        public int id { set; get; }
        public string inputCode { set; get; }
        public string name { set; get; }
        public string target { set; get; }
        public int result { set; get; }
    }
}
