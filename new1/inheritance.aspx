<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inheritance.aspx.cs" Inherits="new1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button4" Width="20%" runat="server" OnClick="Button1_Click" Text="+" />
        </p>
    </form>
</body>
</html>
