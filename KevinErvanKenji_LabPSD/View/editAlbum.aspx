<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="editAlbum.aspx.cs" Inherits="KevinErvanKenji_LabPSD.View.editAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />

    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="nameEdit" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
    <asp:TextBox ID="descEdit" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
    <asp:TextBox ID="priceEdit" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Stock"></asp:Label>
    <asp:TextBox ID="stockEdit" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label>
    <asp:Image ID="Image1" runat="server" />
    <asp:FileUpload ID="imageUpload" runat="server"></asp:FileUpload>
    <br />
    <asp:Label ID="errorEdit" runat="server" Text=""></asp:Label><br />
    <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click"/><br />

</asp:Content>
