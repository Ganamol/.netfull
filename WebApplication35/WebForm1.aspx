<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication35.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter first value:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="30px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter second value:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Height="36px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Dispaly" />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Result:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Mul" />
        </p>
    </form>
</body>
</html>
