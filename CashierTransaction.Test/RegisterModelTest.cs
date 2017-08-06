using CashierTransaction.View;
using CashierTransaction.Presenter;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CashierTransaction.Test
{
    public class RegisterPresenterTest
    {
        ICustomerCashView View;

        [Fact]
        public void TransactionPayment_RegisterModelVariableBindsWithMyCustomerInfo_ReturnsEqual()
        {
            // Act
            View = MockRepository.GenerateMock<ICustomerCashView>();

            //Arrange
            View.Expect(v => v.Ones).IgnoreArguments(); // Expect is a Rhino Mock method
            new CashierPresenter(View);

            //Assert
            View.VerifyAllExpectations(); // XUnit assert

        }

        [Fact]
        private void TransactionPayment_RegisterModelVariableBindsWithMyCustomerInfo_ReturnsFirstName()
        {
            View = MockRepository.GenerateMock<ICustomerCashView>();
            View.Expect(v => v.Ones == View.Ones);
            CashierPresenter presenter = new CashierPresenter(View);
            presenter.TransactionPayment();

            Assert.Equal("5", View.Ones);
        }
    }
}
