using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelArea
    {
        public int areaId { set; get; }
        public string areaName { set; get; }
        public string zipCode { set; get; }
        public int areaLevel { set; get; }
        public int parentId { set; get; }
    }
}
