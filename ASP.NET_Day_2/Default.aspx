<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NET_Day_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h3>Log In</h3>
        <p>Inserisci i tuoi dati qui sotto</p>

        <asp:Label ID="UsernameLabel" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="UsernameField" runat="server"></asp:TextBox> 

        <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PasswordField" runat="server"></asp:TextBox>
        
        <asp:Button ID="LogInButton" runat="server" Text="Log In" OnClick="handleLogIn" />   
    </main>

</asp:Content>
