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
        ICustomerInfoView View;

        public CashierPresenter(ICustomerInfoView view)
        {
            this.View = view;                       
        }

        public bool TransactionPayment()
        {
            RegisterModel model = new RegisterModel();

            List<string> myCustomerInfo = new List<string>();
            myCustomerInfo.Insert(0, View.Id);
            myCustomerInfo.Insert(1, View.FirstName);
            myCustomerInfo.Insert(2, View.LastName);
            myCustomerInfo.Insert(3, View.CardNumber);
            myCustomerInfo.Insert(4, View.CardExpire);
            myCustomerInfo.Insert(5, View.CardType);
            myCustomerInfo.Insert(6, View.CardCVN);

            return model.TransactionPayment(myCustomerInfo);
        }
    }
}