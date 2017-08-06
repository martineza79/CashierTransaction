using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTransaction.Models
{
    public interface IRegisterModel
    {
        bool TransactionPayment(List<string> CustomerInfo);
    }
}
