using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum EnumPurchaseOrderStatus:int
    {
        WaitConfirm = 1,
        Purchasing = 2,
        Complete = 3,
    }
}
