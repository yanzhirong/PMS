using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum EnumSettlementType : int
    {
        Cash = 1,
        CashCheque  = 2,
        TransferCheque = 3,
        Telegraphic = 4,
        BankDraft = 5,
        AcceptanceDraft = 6,
        OnlineBank = 7,
        Other = 8,
    }
}
