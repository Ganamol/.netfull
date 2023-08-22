<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="radio1.aspx.cs" Inherits="firstnew.radio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:CheckBox ID="CheckBox1" runat="server" Text="sslc" />
        <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="plustwo" />
        <asp:CheckBox ID="CheckBox3" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" Text="degree" />
        <div>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View" Width="67px" />
            <asp:ListBox ID="ListBox1" runat="server" Height="153px" Width="262px"></asp:ListBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
