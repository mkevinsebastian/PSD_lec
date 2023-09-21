<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBarAdmin.Master" AutoEventWireup="true" CodeBehind="albumDetail.aspx.cs" Inherits="KevinErvanKenji_LabPSD.View.albumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br /><br />
        <h1>Album Detail</h1>
         <asp:GridView ID="MenuView" runat="server" OnRowDeleting="MenuView_RowDeleting" OnRowEditing="MenuView_RowEditing" OnSelectedIndexChanged="MenuView_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowHeader="True" />
                </Columns>
            </asp:GridView>
        <br />
        <asp:Button ID="addCartBtn" runat="server" Text="Add Cart" onclick="addCartBtn_Click"/>
    </div>
</asp:Content>
