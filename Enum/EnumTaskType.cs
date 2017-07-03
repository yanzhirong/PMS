using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum EnumTaskType:int
    {
        MaterialsExpired = 1,
        MaterialsStockOut = 2,
        ProductExpired = 3,
        ProductStockOut = 4,
        ProduceApply = 5,
        PurchaseApply = 6,
    }
}
