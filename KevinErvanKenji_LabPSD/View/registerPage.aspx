<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="registerPage.aspx.cs" Inherits="KevinErvanKenji_LabPSD.registerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .regErrorlabel{
            color: red;
        }
    </style>
    <br /><br />
     <asp:Label ID="Label1" runat="server" Text="Name:  "></asp:Label>
    <asp:TextBox ID="nameReg" runat="server"></asp:TextBox>
    <br /> 
    <asp:Label ID="Label2" runat="server" Text="Email:  "></asp:Label>
    <asp:TextBox ID="emailReg" runat="server"></asp:TextBox>
    <br /> 
    <asp:Label ID="Label3" runat="server" Text="Select Gender"></asp:Label>
    <br /> 
    <asp:RadioButtonList ID="regGender" runat="server">
    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Address:    "></asp:Label>
    <asp:TextBox ID="addressReg" runat="server"></asp:TextBox>
    <br /> 
    <asp:Label ID="Label5" runat="server" Text="Password:   "></asp:Label>
    <asp:TextBox ID="passwordReg" runat="server" type="password"></asp:TextBox>
    <br /> 
    <asp:Label class="regErrorlabel" ID="regError" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="regBtn" runat="server" Text="Register" OnClick="regBtn_Click" />
</asp:Content>
