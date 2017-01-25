using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum EnumProduceOrderStatus:int
    {
        Producing = 1,
        MaterialsPurchasing = 2,
        WaitTransport = 3,
        Complete = 4,
    }
}
