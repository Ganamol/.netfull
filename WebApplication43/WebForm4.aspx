<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication43.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter name" ControlToValidate="TextBox1" SetFocusOnError="True">*</asp:RequiredFieldValidator>
      
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
      
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        
        </div>
    </form>
</body>
</html>
