<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="arraylist1.aspx.cs" Inherits="basicnew.arraylist1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="83px" Width="129px"></asp:ListBox>
            <asp:ListBox ID="ListBox2" runat="server" Height="80px" Width="140px"></asp:ListBox>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="view" Width="60px" />
    </form>
</body>
</html>
