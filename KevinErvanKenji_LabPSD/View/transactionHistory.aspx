<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavbarLogin.Master" AutoEventWireup="true" CodeBehind="transactionHistory.aspx.cs" Inherits="KevinErvanKenji_LabPSD.View.cartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /> <br />
    <h1>Transaction History</h1>
    <div>
        <table >
            <tr>
                <th>Transaction ID</th>
                <th>Transaction Date</th>
            </tr>
            <% foreach (var x in allTH) { %>
                <tr>
                    <td><% Response.Write(x.TransactionID); %></td>
                    <td> <%= x.TransactionDate %></td>
                </tr>                
            <% } %>
        </table>
        <br />
        <table>
            <tr>
                <th>Customer Name</th>
            </tr>
            <% foreach (var x in allCustomer{ %>
            <tr>
                <td><% Response.Write(x.CustomerName); %></td>         
            </tr>                
            <% } %>
        </table> 
        <br />
        <table>
            <tr>
                <th>Album's Picture</th>
                <th>Album's Name</th>
                <th>Album's Quantity</th>
                <th>Album's Price</th>
            </tr>
            <% foreach (var x in allAlbum) { %>
                <td><% Response.Write("~/Assets/Albums"); %></td>
                <td><%= x.AlbumName %></td>
                <td><%= x.AlbumStock %></td>
                <td><%= x.AlbumPrice %></td>
            <% } %>
        </table>
    </div>
    
</asp:Content>
