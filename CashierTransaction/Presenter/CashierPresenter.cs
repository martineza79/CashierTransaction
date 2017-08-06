using CashierTransaction.Models;
using CashierTransaction.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierTransaction.Presenter
{
    public class CashierPresenter 
    {
        ICustomerCashView View;

        public CashierPresenter(ICustomerCashView view)
        {
            this.View = view;                       
        }

        public bool TransactionPayment()
        {
            RegisterModel model = new RegisterModel();

            List<string> customerCash = new List<string>();
            customerCash.Insert(0, View.Id);
            customerCash.Insert(1, View.Ones);
            customerCash.Insert(2, View.Fives);
            customerCash.Insert(3, View.Tens);
            customerCash.Insert(4, View.Twenties);
            customerCash.Insert(5, View.Fifties);
            customerCash.Insert(6, View.Hundreds);

            return model.TransactionPayment(customerCash);
        }
    }
}