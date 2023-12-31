﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication43.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="User ID:"></asp:Label>
 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="TextBox1" ErrorMessage="User id required"></asp:RequiredFieldValidator>

        <asp:CustomValidator ID="CustomValidator1" runat="server" OnServerValidate="UserCustomValidate"
            ControlToValidate="TextBox1"
            ErrorMessage="User ID should have atleast a capital, small and digit and should be greater than 5 and less
than 26 letters"
            SetFocusOnError="True"></asp:CustomValidator>
        </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>
