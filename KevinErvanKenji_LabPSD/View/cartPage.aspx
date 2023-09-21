<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavbarLogin.Master" AutoEventWireup="true" CodeBehind="cartPage.aspx.cs" Inherits="KevinErvanKenji_LabPSD.View.cartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /> <br />
    <h1>Cart</h1>
    <div>
        <table>
            <tr>
                <th>Album's Picture</th>
                <th>Album's Name</th>
                <th>Album's Quantity</th>
                <th>Album's Price</th>
            </tr>
            <% foreach (var x in allCart) { %>
                <td><% Response.Write("~/Assets/Albums"); %></td>
                <td><%= x.AlbumName %></td>
                <td><%= x.AlbumStock %></td>
                <td><%= x.AlbumPrice %></td>
            <% } %>
        </table>
        <br />
        <asp:Button ID="RemoveBtn" runat="server" Text="Remove" OnClick="RemoveBtnClick" />
        <br />
        <asp:Button ID="checkoutBtn" runat="server" Text="Checkout" OnClick="checkoutBtnClick" />
    </div>
</asp:Content>
