using CashierTransaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierTransaction.Models
{
    public class RegisterModel : IRegisterModel
    {
        public bool TransactionPayment(List<string> CustomerInfo)
        {
            try
            {
                CustomerInfo customer = new CustomerInfo();

                customer.Id = CustomerInfo[0];
                customer.FirstName = CustomerInfo[1];
                customer.LastName = CustomerInfo[2];
                customer.CardNumber = CustomerInfo[3];
                customer.CardExpire = CustomerInfo[4];
                customer.CardType = CustomerInfo[5];
                customer.CardCVN = CustomerInfo[6];
                return true;
            }
            catch 
            {

                return false;
            }
        }
    }
}