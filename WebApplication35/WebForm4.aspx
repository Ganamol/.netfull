<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication35.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gen" Text="Male" />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gen" Text="Female" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
