﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelInventoryMaterialsLog : ModelBase
    {
        public int id { set; get; }
        public string inputCode { set; get; }
        public int factoryId { set; get; }
        public int materialsId { set; get; }
        public int unit { set; get; }
        public decimal stockNumOld { set; get; }
        public decimal stockNumNew { set; get; }
        public DateTime produceDateOld { set; get; }
        public DateTime produceDateNew { set; get; }
        public DateTime expiresDateOld { set; get; }
        public DateTime expiresDateNew { set; get; }
        public string remark { set; get; }
    }
}
