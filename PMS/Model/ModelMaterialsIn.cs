using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelMaterialsIn : ModelBase
    {
        public int id { set; get; }
        public string inputCode { set; get; }
        public int factoryId { set; get; }
        public int materialsId { set; get; }
        public decimal inputNum { set; get; }
        public int inputUnit { set; get; }
        public decimal stockNum { set; get; }
        public DateTime produceDate { set; get; }
        public DateTime expiresDate { set; get; }
        public string purchaseCode { set; get; }
        public string purchaseBy { set; get; }
        public DateTime purchaseDate { set; get; }
        public decimal purchaseNum { set; get; }
        public int purchaseUnit { set; get; }
        public int customerId { set; get; }
        public int inputType { set; get; }
        public int inputStatus { set; get; }
        public DateTime inputDate { set; get; }
        public string remark { set; get; }
    }
}
