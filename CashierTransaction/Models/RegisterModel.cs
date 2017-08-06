using CashierTransaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierTransaction.Models
{
    public class RegisterModel : IRegisterModel
    {
        public bool TransactionPayment(List<string> CustomerCashBills)
        {
            try
            {
                CustomerCash customer = new CustomerCash();

                customer.Id = CustomerCashBills[0];
                customer.Ones= CustomerCashBills[1];
                customer.Fives = CustomerCashBills[2];
                customer.Tens= CustomerCashBills[3];
                customer.Twenties = CustomerCashBills[4];
                customer.Fifties = CustomerCashBills[5];
                customer.Hundreds = CustomerCashBills[6];
                return true;
            }
            catch 
            {

                return false;
            }
        }
    }
}