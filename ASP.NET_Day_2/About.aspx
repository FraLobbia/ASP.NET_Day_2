<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ASP.NET_Day_2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <p id="datiUtente" runat="server"></p>
        <asp:Button ID="LogOutButton" runat="server" Text="Log Out" OnClick="LogOutButton_Click" />
    </main>
</asp:Content>
