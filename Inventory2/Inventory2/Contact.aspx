<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Inventory2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        32 E 14th St<br />
        New Albany IN 47150<br />
        <abbr title="Phone">P:</abbr>
        812-981-5400
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:TigerTruckLines@gmail.com">TigerTruckLines@gmail.com</a><br />
    </address>
</asp:Content>
