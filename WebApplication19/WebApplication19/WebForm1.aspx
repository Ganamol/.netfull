<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication19.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Image ID="Image1" runat="server" ImageUrl="https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__480.jpg" />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="141px" />
    </form>
</body>
</html>
