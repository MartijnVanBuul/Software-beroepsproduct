<%@ Page Title="" Language="C#" MasterPageFile="~/AspireMaster.Master" AutoEventWireup="true" CodeBehind="WebPageLogIn.aspx.cs" Inherits="ASPire_training_git.WebPageLogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="Content">
            <style>.contentWidth { width: 270px }</style>

            <h1>Inloggen</h1>
            <br />
            <br />
            <asp:Label ID="lblNaam" runat="server" Text="Naam:"></asp:Label>
            <br />
            <asp:TextBox ID="tbNaam" runat="server" CssClass = "contentWidth"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="wachtwoord:"></asp:Label>
            <br />
            <asp:TextBox ID="tbPassword" runat="server" CssClass = "contentWidth"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnLogIn" runat="server" Text="Log in" CssClass = "contentWidth" OnClick="btnLogIn_Click" />
        </div>
    </form>
</asp:Content>
