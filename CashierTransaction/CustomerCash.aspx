<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerCash.aspx.cs" Inherits="CashierTransaction.CustomerCash" %>

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
            <asp:TextBox ID="OnesTB" runat="server"></asp:TextBox>
        </p>
        <p>
            Fives:
            <asp:TextBox ID="FivesTB" runat="server"></asp:TextBox>
        </p>
        <p>
            Tens:
            <asp:TextBox ID="TensTB" runat="server"></asp:TextBox>
        </p>
        <p>
            Twenties:
            <asp:TextBox ID="TwentiesTB" runat="server"></asp:TextBox>
        </p>
        
        <p>
            Fifties:
            <asp:TextBox ID="FiftiesTB" runat="server"></asp:TextBox>
        </p>
        
        <p>
            Hundreds:
            <asp:TextBox ID="HundredsTB" runat="server"></asp:TextBox>
        </p>
        
        <p>
            <asp:Button ID="SubmitTransactionPayment" runat="server" Text="Submit" OnClick="SubmitTransactionPayment_OnClick" />
        </p>
    </div>
    </form>
</body>
</html>
