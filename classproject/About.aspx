<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="classproject.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
.    <center>
    <table>
        <tr>
            <td>Name:</td><td><input type="text" /><br />
            </td>
        </tr>
          <tr>
            <td>Age:</td><td><input type="text" /><br />
            </td>
        </tr>
          <tr>
            <td>Address:</td><td><input type="text" /><br />
            </td>
        </tr>
          <tr>
            <td>Phone:</td><td><input type="text" /><br />
            </td>
        </tr>
          <tr>
            <td>Password:</td><td><input type="text" /><br />
            </td>
        </tr>
        <tr>
            <td>
                <button>Save</button>
            </td>
        </tr>
    </table></center>
</asp:Content>
