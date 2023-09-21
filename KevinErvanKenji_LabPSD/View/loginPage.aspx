<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="KevinErvanKenji_LabPSD.loginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .regErrorlbl{
            color: red;
        }
    </style>
    <br /> <br />
    <asp:Label runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="emailBox" runat="server" OnTextChanged="emailBox_TextChanged"></asp:TextBox>
    <br />
    <asp:Label runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="passwordBox" runat="server" OnTextChanged="passwordBox_TextChanged"></asp:TextBox>
    <br />
    <asp:Label class="regErrorlbl" ID="errorLabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:CheckBox ID="CheckBox1" runat="server" />
    <asp:Label ID="rememberLabel" runat="server" Text="Remember me"></asp:Label>
    <br />
    <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
    
</asp:Content>
