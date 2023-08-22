<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="controls.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          Enter First no:  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
          Enter second no:   <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
          Answer: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="+" /> <asp:Button ID="Button2" OnClick="Button1_Click" runat="server" Text="-" /> <asp:Button ID="Button3" OnClick="Button1_Click" runat="server" Text="*" /> <asp:Button ID="Button4" OnClick="Button1_Click" runat="server" Text="/" />
        </div>
    </form>
</body>
</html>
