<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="PROJECTSCHOOL.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Enter Fname:<asp:TextBox ID="fname" runat="server"></asp:TextBox>
        <div>
        </div>
        Enter Lname:<asp:TextBox ID="lname" runat="server"></asp:TextBox>
        <p>
            Enter Age:<asp:TextBox ID="age" runat="server"></asp:TextBox>
            </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Select Gender"></asp:Label>
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Male" />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Female" />
        </p>
        Enter Email:<asp:TextBox ID="email" runat="server" OnTextChanged="email_TextChanged"></asp:TextBox>
        <p>
            Enter Password<asp:TextBox ID="password" runat="server"></asp:TextBox>
            </p>
        <p>
            Enter Phone<asp:TextBox ID="phone" runat="server"></asp:TextBox>
            </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="UPDATE" Width="135px" style="height: 26px" />
        </p>
        
    </form>
</body>
</html>
