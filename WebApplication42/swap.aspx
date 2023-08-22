<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="swap.aspx.cs" Inherits="WebApplication42.swap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            enter first number</div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        enter second number<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Swap" OnClick="Button1_Click" />
        <br />
&nbsp;
        <br />
        first:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        second:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
    </form>
</body>
</html>
