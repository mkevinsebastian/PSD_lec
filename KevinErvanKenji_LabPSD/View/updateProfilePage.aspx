<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="updateProfilePage.aspx.cs" Inherits="KevinErvanKenji_LabPSD.View.updateProfilePage" %>
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
    <asp:TextBox ID="nameUpdate" runat="server"></asp:TextBox>
    <br /> 
    <asp:Label ID="Label2" runat="server" Text="Email:  "></asp:Label>
    <asp:TextBox ID="emailUpdate" runat="server"></asp:TextBox>
    <br /> 
    <asp:Label ID="Label3" runat="server" Text="Select Gender"></asp:Label>
    <br /> 
    <asp:RadioButtonList ID="updGender" runat="server">
    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Address:    "></asp:Label>
    <asp:TextBox ID="addressUpdate" runat="server"></asp:TextBox>
    <br /> 
    <asp:Label ID="Label5" runat="server" Text="Password:   "></asp:Label>
    <asp:TextBox ID="passwordUpdate" runat="server" type="password"></asp:TextBox>
    <br /> 
    <asp:Label class="regErrorlabel" ID="updateError" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
</asp:Content>
