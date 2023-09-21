<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavbarAdmin.Master" AutoEventWireup="true" CodeBehind="artistDetailPage.aspx.cs" Inherits="KevinErvanKenji_LabPSD.View.artistDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br /><br />
        <h1>Artist Detail</h1>
         <asp:GridView ID="MenuView" runat="server" OnRowDeleting="MenuView_RowDeleting" OnRowEditing="MenuView_RowEditing" OnSelectedIndexChanged="MenuView_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" HeaderText="Action" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
                </Columns>
            </asp:GridView>
        <br />
        <asp:Button ID="insertAlbumBtn" runat="server" Text="Insert Album" onclick="InsertBtn2_Click"/>
    </div>
</asp:Content>
