﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProductMaterials : ModelBase
    {
        public int id { set; get; }
        public int productId { set; get; }
        public int materialsId { set; get; }
        public string searchKey { set; get; }
        public string materialsName { set; get; }
        public int materialsNum { set; get; }
        public int materialsUnit { set; get; }

    }
}
