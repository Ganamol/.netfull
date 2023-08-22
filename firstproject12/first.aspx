<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="first.aspx.cs" Inherits="firstproject12.first" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="74px">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" Height="20px" Width="73px">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server" Height="20px" Width="87px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="DOB" OnClick="Button1_Click" Width="79px" />
            <br />
            <br />
            <br />
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
</body>
</html>
