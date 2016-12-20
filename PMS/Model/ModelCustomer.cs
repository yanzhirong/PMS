using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelCustomer : ModelBase
    {
        public int id { set; get; }
        public string code { set; get; }
        public string name { set; get; }
        public string country { set; get; }
        public int province { set; get; }
        public int city { set; get; }
        public int district { set; get; }
        public string provinceName { set; get; }
        public string cityName { set; get; }
        public string districtName { set; get; }
        public string address { set; get; }
        public string zip { set; get; }
        public string fax { set; get; }
        public string telephone1 { set; get; }
        public string telephone2 { set; get; }
        public string manager { set; get; }
        public string position { set; get; }
        public string mobile { set; get; }
        public int type { set; get; }
        public int salerId { set; get; }
        public string remark { set; get; }
        public decimal creditLimit { set; get; }
    }
}
