using CashierTransaction.Presenter;
using CashierTransaction.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CashierTransaction
{
    public partial class CustomerInfo : Page, ICustomerInfoView
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitTransactionPayment_OnClick(object sender, EventArgs e)
        {
            CashierPresenter presenter = new CashierPresenter(this);

            if (presenter.TransactionPayment())
            {
                Response.Redirect("~/PaymentComplete.aspx");
            }

            else
            {
                Response.Write("An Error Occurred");
            }
        }

        public string Id
        {
            get { return IdTB.Text; }
            set { IdTB.Text = value; }
        }

        public string FirstName
        {
            get { return FirstNameTB.Text; }
            set { FirstNameTB.Text = value; }
        }

        public string LastName
        {
            get { return LastNameTB.Text; }
            set { LastNameTB.Text = value; }
        }

        public string CardNumber
        {
            get { return CardNumberTB.Text; }
            set { CardNumberTB.Text = value; }
        }

        public string CardExpire
        {
            get { return CardExpireTB.Text; }
            set { CardExpireTB.Text = value; }
        }

        public string CardCVN
        {
            get { return CardCVNTB.Text; }
            set { CardCVNTB.Text = value; }
        }

        public string CardType
        {
            get { return CardTypeDDL.Text; }
            set { CardTypeDDL.Text = value; }
        }
    }
}