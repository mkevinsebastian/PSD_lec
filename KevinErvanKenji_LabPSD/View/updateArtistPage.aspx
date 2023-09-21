<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="updateArtistPage.aspx.cs" Inherits="KevinErvanKenji_LabPSD.View.updateArtistPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br /> <br />
        <h1>Insert Artist</h1>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Artist Name: "></asp:Label>
                <asp:TextBox ID="nameArtist" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Image"></asp:Label>
                <asp:FileUpload ID="artistImg" runat="server" />
            </div>
           <div>
                <asp:Label ID="errorArtist" runat="server"  Text=""></asp:Label>
                <br />
                <asp:Button ID="updateArtistBtn" runat="server" Text="Update Artist" onclick="updateArtistBtn_Click"/>
            </div>
        </div>
</asp:Content>
