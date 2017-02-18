using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelTransfer : ModelBase
    {
        public int id { set; get; }
        public string transferCode { set; get; }
        public int type { set; get; }
        public int productId { set; get; }
        public int materialsId { set; get; }
        public decimal num { set; get; }
        public int unit { set; get; }
        public int fromFactoryId { set; get; }
        public int toFactoryId { set; get; }
        public int applyMemberId { set; get; }
        public DateTime applyDate { set; get; }
        public int transferMemberId { set; get; }
        public DateTime transferDate { set; get; }
        public string remark { set; get; }
    }
}
