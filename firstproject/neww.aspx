<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="neww.aspx.cs" Inherits="firstproject.neww" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>hello</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" BackColor="#FF3399" OnClick="Button1_Click" Text="save" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>aa</asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        <asp:Image ID="Image1" runat="server" />
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:CheckBox ID="male_id" runat="server" Text="hobbies" />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </form>
</body>
</html>
