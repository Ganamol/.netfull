<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="secondproject.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 121px;
            width: 222px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:MultiView ID="MultiView1" runat="server">
            <br />
            <br />
            <br />
            <asp:View ID="View1" runat="server">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                <br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <textarea id="TextArea1" name="S1"></textarea>
            </asp:View>
            <br />
            <br />
            <br />
            <asp:View ID="View2" runat="server">
                <asp:GridView ID="GridView1" runat="server" Width="313px">
                    <Columns>
                        <asp:BoundField />
                        <asp:BoundField />
                        <asp:CheckBoxField />
                        <asp:HyperLinkField />
                    </Columns>
                </asp:GridView>
            </asp:View>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:MultiView>
        <div>
        </div>
        <p>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" ToolTip="enter your name"></asp:TextBox>
        </p>
    </form>
</body>
</html>
