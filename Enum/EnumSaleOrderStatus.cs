using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum EnumSaleOrderStatus:int
    {
        ProducingApply = 1,
        Producing = 2,
        Transporting = 3,
        Complete = 4,
        Cancel = 9,
    }
}
