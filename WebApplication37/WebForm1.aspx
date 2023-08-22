<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication37.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label">NAME</asp:Label>
&nbsp;
        <asp:TextBox ID="TXT_NAME" runat="server"></asp:TextBox><br />
         <asp:Label ID="Label2" runat="server" Text="Label">AGE</asp:Label>
&nbsp;
        <asp:TextBox ID="TXT_AGE" runat="server"></asp:TextBox><br />
         <asp:Label ID="Label3" runat="server" Text="Label">PHONE</asp:Label>
&nbsp;
        <asp:TextBox ID="TXT_PHONE" runat="server"></asp:TextBox><br />
         <asp:Label ID="Label4" runat="server" Text="Label">EMAIL</asp:Label>
&nbsp;
        <asp:TextBox ID="TXT_email" runat="server"></asp:TextBox><br />

         <asp:Label ID="Label5" runat="server" Text="Label">PASSWORD</asp:Label>
&nbsp;
        <asp:TextBox ID="TXT_PASSWORD" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" Width="138px" />
        <br />
    </form>
</body>
</html>
