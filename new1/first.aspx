<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="first.aspx.cs" Inherits="new1.first" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
          
            enter first number<asp:TextBox ID="txt_first" runat="server"></asp:TextBox>
       
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="swap" Width="132px" />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnTextChanged="CheckBoxList1_TextChanged">
                <asp:ListItem Value="sslc"></asp:ListItem>
                <asp:ListItem>plustwo</asp:ListItem>
                <asp:ListItem>bsc</asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="kk" ViewStateMode="Enabled" />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Image ID="Image1" runat="server" AlternateText="loading" ImageUrl="https://th.bing.com/th/id/OIP.M9AsZ7Sm6Qq-LXpY92Tt2AHaEK?pid=ImgDet&amp;rs=1" />
        </p>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
           
           
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Home</asp:LinkButton>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <br />
           
           
    </form>
</body>
</html>
