using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProductOutput : ModelBase
    {
        public int id { set; get; }
        public string outputCode { set; get; }
        public string orderCode { set; get; }
        public int factoryId { set; get; }
        public int customerId { set; get; }
        public int salerId { set; get; }
        public DateTime deliveryDate { set; get; }
        public int country { set; get; }
        public int province { set; get; }
        public string provinceName { set; get; }
        public int city { set; get; }
        public string cityName { set; get; }
        public int district { set; get; }
        public string districtName { set; get; }
        public string address { set; get; }
        public string manager { set; get; }
        public string telephone { set; get; }
        public int outputStatus { set; get; }
        public DateTime outputDate { set; get; }
        public int outputType { set; get; }
        public int applyMemberId { set; get; }
        public List<ModelProductOutputDetail> modelProductOutputDetail { set; get; }
    }
}
