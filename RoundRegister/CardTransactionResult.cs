using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.RoundRegister
{
    /// <summary>
    /// Different Card Results
    /// </summary>
    public enum CardTransactionResult
    {
        Approved,
        Declined,
        InsuffientFunds,
        IncorrectPin,
        ReadError
    }
}
