<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="updateAlbumPage.aspx.cs" Inherits="KevinErvanKenji_LabPSD.View.updateAlbumPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br /> <br />
        <h1>Update Album</h1>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="nameAlbum" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
                <asp:TextBox ID="descAlbum" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
                <asp:TextBox ID="priceAlbum" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Stock"></asp:Label>
                <asp:TextBox ID="stockAlbum" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Image"></asp:Label>
                <asp:FileUpload ID="albumImg" runat="server" />
            </div>
            <div>
                <br />
                <asp:Label ID="errorAlbum" runat="server" Text=""></asp:Label>
                <asp:Button ID="updateAlbumBtn" runat="server" Text="Update Album" onclick="updateAlbumBtn_Click"/>
            </div>
        </div>
</asp:Content>
