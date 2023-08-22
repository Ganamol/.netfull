<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sort.aspx.cs" Inherits="basicnew.sort" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox3" runat="server"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="check" Width="123px" />
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            Search:</form>
</body>
</html>
