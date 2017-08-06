<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerInfo.aspx.cs" Inherits="CashierTransaction.CustomerInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Customer Info</h1>
        <p>
            ID:
            <asp:TextBox ID="IdTB" runat="server"></asp:TextBox>
        </p>
        <p>
            First Name:
            <asp:TextBox ID="FirstNameTB" runat="server"></asp:TextBox>
        </p>
        <p>
            Last Name:
            <asp:TextBox ID="LastNameTB" runat="server"></asp:TextBox>
        </p>
        <p>
            Card Number:
            <asp:TextBox ID="CardNumberTB" runat="server"></asp:TextBox>
        </p>
        <p>
            Card Expire
            <asp:TextBox ID="CardExpireTB" runat="server"></asp:TextBox>
        </p>
        <p>
            Card Type:
            <asp:DropDownList ID="CardTypeDDL" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Visa</asp:ListItem>
                <asp:ListItem>Mastercard</asp:ListItem>
                <asp:ListItem>American Express</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Card CVN:
            <asp:TextBox ID="CardCVNTB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="SubmitTransactionPayment" runat="server" Text="Submit" OnClick="SubmitTransactionPayment_OnClick" />
        </p>
    </div>
    </form>
</body>
</html>
