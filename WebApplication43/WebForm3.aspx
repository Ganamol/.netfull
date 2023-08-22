<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication43.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Style="top: 239px; left: 75px; position: absolute;
            height: 22px; width: 128px" Text="Enter your Age:"></asp:Label>

        <asp:Label ID="Label2" runat="server" Style="top: 94px; left: 81px; position: absolute;
            height: 22px; width: 128px" Text="Enter your name:"></asp:Label>
    </div>
    <asp:TextBox ID="TextBox1" runat="server" Style="top: 95px; left: 250px; position: absolute;
        height: 22px; width: 128px; right: 428px;"></asp:TextBox>
    <p>
        <asp:TextBox ID="TextBox4" runat="server" Style="top: 195px; left: 249px; position: absolute;
            height: 22px; width: 127px; right: 430px;" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Style="top: 148px; left: 76px; position: absolute;
            height: 22px; width: 128px" Text="Enter Password:"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox3" runat="server" Style="top: 146px; left: 249px; position: absolute;
            height: 22px; width: 127px; right: 430px;" TextMode="Password"></asp:TextBox>
    </p>
   <p>
        <asp:Label ID="Label4" runat="server" Style="top: 197px; left: 75px; position: absolute;
            height: 22px; width: 128px" Text="Confirm Password:"></asp:Label>
    </p>
    <asp:TextBox ID="TextBox2" runat="server" Style="top: 236px; left: 250px; position: absolute;
        height: 22px; width: 127px; right: 429px;"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" Style="top: 197px; left: 522px;
        position: absolute; height: 22px; width: 17px" ErrorMessage="CompareValidator"
        ControlToCompare="TextBox3" ControlToValidate="TextBox4" ForeColor="Red" SetFocusOnError="True">*</asp:CompareValidator>
    <p>
        <asp:Button ID="Button1" runat="server" Style="top: 333px; left: 248px; position: absolute;
            height: 26px; width: 56px" Text="Submit" OnClick="Button1_Click" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style="top: 196px;
            left: 393px; position: absolute; height: 22px; width: 22px; right: 399px;" ErrorMessage="Confirm Password mandatory & should match password"
            ControlToValidate="TextBox4" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" Style="top: 235px; left: 388px;
            position: absolute; height: 22px; width: 156px; bottom: 288px; right: 468px;" ErrorMessage="age between 18-100"
            ControlToValidate="TextBox2" MaximumValue="100" MinimumValue="18" Type="Integer" ForeColor="Red" SetFocusOnError="True">*</asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Style="top: 92px;
            left: 393px; position: absolute; height: 22px; width: 156px" ErrorMessage="Name is required"
            ControlToValidate="TextBox1" ForeColor="Red">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Style="top: 146px;
            left: 391px; position: absolute; height: 22px; width: 156px" ErrorMessage="Password mandatory"
            ControlToValidate="TextBox3" ForeColor="Red">*</asp:RequiredFieldValidator>
    </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Style="top: 390px;
        left: 44px; position: absolute; height: 38px; width: 625px" />
    </form>
</body>
</html>
