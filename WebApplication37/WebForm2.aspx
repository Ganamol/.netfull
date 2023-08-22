<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication37.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="s_name" HeaderText="Name" />
                <asp:BoundField DataField="s_age" HeaderText="Age" />
                <asp:BoundField DataField="phone" HeaderText="phone" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
