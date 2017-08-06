using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierTransaction.View
{
    public interface ICustomerCashView
    {
        string Id { get; set; }
        string Ones { get; set; }
        string Fives { get; set; }
        string Tens { get; set; }
        string Twenties { get; set; }
        string Fifties { get; set; }
        string Hundreds { get; set; }          
    }
}