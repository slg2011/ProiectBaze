<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication3.Account.Login" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">
                <asp:TextBox ID="TextBoxUser" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Insert a user name" Font-Bold="True" Font-Strikeout="False" ForeColor="Red" ControlToValidate="TextBoxUser"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:TextBox ID="TextBoxPassword" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Insert a password" Font-Bold="True" Font-Strikeout="False" ForeColor="Red" ControlToValidate="TextBoxPassword"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-bottom: 0px;
        }
        .auto-style3 {
            width: 143px;
        }
        .auto-style4 {
            width: 5px;
        }
    </style>
</asp:Content>

