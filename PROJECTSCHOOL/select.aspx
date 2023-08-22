<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="select.aspx.cs" Inherits="PROJECTSCHOOL.select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="r_id" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2"  >
                                <Columns>
                                    <asp:BoundField DataField="r_id" HeaderText="Id" ReadOnly="True" />
                                    <asp:BoundField DataField="fname" HeaderText="F Name" />
                                    <asp:BoundField DataField="lname" HeaderText="L Name" />
                                    <asp:BoundField DataField="email" HeaderText="Email" />
                                    <asp:BoundField DataField="gender" HeaderText="Gender" />
                                    <asp:BoundField DataField="phone" HeaderText="Phone" />
                                    <asp:BoundField DataField="pwd" HeaderText="password" />
                                    <asp:TemplateField>
                                      <ItemTemplate>
                                         
                                          <asp:Button ID="Button2" OnClick="Button2_Click"  Class="btn-primary" runat="server" Text="EDIT" CommandArgument='<%# Eval("r_id") %>'/>
                                         
                                          <br />
                                      </ItemTemplate>
                                        <ControlStyle BackColor="#009900" />
                                    </asp:TemplateField>
                                   
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:Button ID="Button3" OnClick="Button3_Click" runat="server" Text="DELETE" CommandArgument='<%# Eval("r_id") %>' />
                                        </ItemTemplate>
                                        <ControlStyle BackColor="Red" />
                                    </asp:TemplateField>
                                   
                                    <asp:CommandField />
                                   
                                </Columns>
                                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                                <SortedDescendingHeaderStyle BackColor="#93451F" />
                            </asp:GridView>
        <br />
        
    </form>
</body>
      <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>
</html>
