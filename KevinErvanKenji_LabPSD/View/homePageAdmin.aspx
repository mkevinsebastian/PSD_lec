<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="homePageAdmin.aspx.cs" Inherits="KevinErvanKenji_LabPSD.View.homePageAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br /> <br />
            <h1>Artist</h1>
            <asp:GridView ID="MenuView" runat="server" OnRowDeleting="MenuView_RowDeleting" OnRowEditing="MenuView_RowEditing" OnSelectedIndexChanged="MenuView_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" HeaderText="Action" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
                </Columns>
            </asp:GridView>
            <div>
                <br />
                <asp:Button ID="InsertArtBtn" runat="server" Text="Insert Artist" onclick="InsertArtBtn_Click"/>
            </div>
            <div>
                <br />
                <asp:Button ID="artDetailBtn" runat="server" Text="Artist Detail" onclick="artDetailBtn_Click"/>
            </div>
        </div>
</asp:Content>
