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
    public partial class CustomerCash : Page, ICustomerCashView
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

        public string Ones
        {
            get { return OnesTB.Text; }
            set { OnesTB.Text = value; }
        }

        public string Fives
        {
            get { return FivesTB.Text; }
            set { FivesTB.Text = value; }
        }

        public string Tens
        {
            get { return TensTB.Text; }
            set { TensTB.Text = value; }
        }

        public string Twenties
        {
            get { return TwentiesTB.Text; }
            set { TwentiesTB.Text = value; }
        }

        public string Fifties
        {
            get { return FiftiesTB.Text; }
            set { FiftiesTB.Text = value; }
        }

        public string Hundreds
        {
            get { return HundredsTB.Text; }
            set { HundredsTB.Text = value; }
        }
    }
}