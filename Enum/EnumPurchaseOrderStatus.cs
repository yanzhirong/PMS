using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum EnumPurchaseOrderStatus:int
    {
        WaitPurchaseConfirm = 1,
        Purchasing = 2,
        WaitInput = 3,
        Complete = 4,
        Cancel = 5,
    }
}
