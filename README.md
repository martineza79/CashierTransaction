# CashierTransaction

Web Form app illustrating an analogy between a transaction in a store to following the Model View Presenter (MVP) architecture in a Web Form. In a store transaction, a customer(View) gives a cashier(Presenter) cash to purchase the item(s). The cashier places the cash in the register(Model). The customer does not retrieve or place cash in the register(unless they are robbing the store). Similarly, this Web Form app shows how the Presenter(CashierPresenter) holds the logic and performs the CRUD operations between the View(CashierInfo) and the Model(RegisterModel).

Using MVP allows developers to minimize code in view and code-behind files and follow the Single Responsibility Principle by pushing logic to the Presenter. This makes the app loosely coupled to facilitate unit testing.

In this example, XUnit and Rhino Mocks are used to test the Transaction Payment in the Presenter(CashierPresenter).
