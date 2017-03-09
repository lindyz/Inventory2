<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Inventory2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h1><%: Title %>.</h1>
        <h2>Inventory of parts used for oil changes.</h2>
        <p class="lead">Check inventory weekly and order more as needed.</p>
</asp:Content>
