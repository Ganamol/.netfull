<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PROJECTSCHOOL.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:<asp:TextBox ID="TextBox1" runat="server" Height="38px" Width="187px"></asp:TextBox>
            <br />
            <br />
            Password:<asp:TextBox ID="TextBox2" runat="server" Height="23px" Width="190px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="145px" />
            <br />
        </div>
    </form>
</body>
</html>
