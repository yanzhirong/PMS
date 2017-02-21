using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum EnumSaleOrderStatus:int
    {
        WaitConfirm = 1,
        Producing = 2,
        WaitTransport = 3,
        Complete = 4,
        Cancel = 5,
    }
}
