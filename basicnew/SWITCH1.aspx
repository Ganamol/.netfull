<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SWITCH1.aspx.cs" Inherits="basicnew.SWITCH1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="CHECK" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="CHECK2" />
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
