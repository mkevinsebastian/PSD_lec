<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="insertAlbum.aspx.cs" Inherits="KevinErvanKenji_LabPSD.View.insertAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br /> <br />
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
                <asp:Label ID="errorAlbum" runat="server"  Text=""></asp:Label>
                <br />
                <asp:Button ID="insertAlbumBtn" runat="server" Text="Insert Album" onclick="InsertBtn2_Click"/>
            </div>
        </div>
</asp:Content>
