using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelCompany : ModelBase
    {
        public int id { set; get; }
        public string name { set; get; }
        public string address { set; get; }
        public string telphone { set; get; }
        public string homepage { set; get; }
        public string fax { set; get; }
        public string email { set; get; }
        public string zip { set; get; }
    }
}
