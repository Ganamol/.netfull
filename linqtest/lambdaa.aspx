<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lambdaa.aspx.cs" Inherits="linqtest.lambdaa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" ForeColor="Red" OnClick="Button1_Click" Text="lambda" />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    </form>
</body>
</html>
