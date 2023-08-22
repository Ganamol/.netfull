<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="secondproject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" BackColor="#00FFCC"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="save" />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:Image ID="Image1" runat="server" />
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>apple</asp:ListItem>
            <asp:ListItem>orange</asp:ListItem>
            <asp:ListItem>grapes</asp:ListItem>
        </asp:ListBox>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>kerala</asp:ListItem>
            <asp:ListItem>karnataka</asp:ListItem>
        </asp:DropDownList>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="subjects" />
        <asp:Localize ID="Localize1" runat="server"></asp:Localize>
        <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="female" />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>drawing</asp:ListItem>
            <asp:ListItem>painting</asp:ListItem>
            <asp:ListItem>singing</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Image ID="Image2" runat="server" ImageUrl="https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__480.jpg" />
        <asp:BulletedList ID="BulletedList1" runat="server" Font-Bold="True" ForeColor="Gray">
            <asp:ListItem>add</asp:ListItem>
            <asp:ListItem>delete</asp:ListItem>
            <asp:ListItem>merge</asp:ListItem>
        </asp:BulletedList>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>others</asp:ListItem>
            <asp:ListItem>female</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="male" />
    </form>
</body>
</html>
