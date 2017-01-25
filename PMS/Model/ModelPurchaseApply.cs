﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelPurchaseApply : ModelBase
    {
        public int id { set; get; }
        public int factoryId { set; get; }
        public int materialsId { set; get; }
        public string materialsName { set; get; }
        public decimal num { set; get; }
        public int unit { set; get; }
        public DateTime deliveryDate { set; get; }
        public int status { set; get; }
        public string purchaseCode { set; get; }
        public string produceCode { set; get; }
        public int applyType { set; get; }
        public string applyBy { set; get; }
        public DateTime applyDate { set; get; }
        public string remark { set; get; }
    }
}
