using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierTransaction.View
{
    public interface ICustomerInfoView
    {
        string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string CardNumber { get; set; }
        string CardExpire { get; set; }
        string CardType { get; set; }
        string CardCVN { get; set; }          
    }
}