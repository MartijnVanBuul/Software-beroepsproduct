<%@ Page Title="" Language="C#" MasterPageFile="~/AspireMaster.Master" AutoEventWireup="true" CodeBehind="WebPageRegister.aspx.cs" Inherits="ASPire_training_git.WebPageRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1" runat="server">
        <div class="Content">
            <style>.contentWidth { width: 270px }</style>

            <h1>Registreren</h1>
            <br />
            <br />
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <br />
            <asp:TextBox ID="tbUsername" runat="server" CssClass = "contentWidth"></asp:TextBox>
            <br />
            <br />

            <asp:Button ID="btnRegister" runat="server" Text="Registreren" CssClass = "contentWidth" />
        </div>
    </form>
</asp:Content>
