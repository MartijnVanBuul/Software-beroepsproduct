<%@ Page Title="" Language="C#" MasterPageFile="~/AspireMaster.Master" AutoEventWireup="true" CodeBehind="WebPageLogIn.aspx.cs" Inherits="ASPire_training_git.WebPageLogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="Content">
            <style>.contentWidth { width: 270px }</style>

            <h1>Inloggen</h1>
            <asp:Label AssociatedControlID="tbEmailAddress" runat="server" Text="Email-adres:"></asp:Label>
            <br />
            <asp:TextBox ID="tbEmailAddress" runat="server" CssClass = "contentWidth"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbEmailAddress" ErrorMessage="Vul je e-mailadres in."></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label AssociatedControlID="passLogIn" runat="server" Text="wachtwoord:"></asp:Label>
            <br />
            <input id="passLogIn" type="password" runat="server" class="contentWidth"/>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="passLogIn" ErrorMessage="Vul je wachtwoord in."></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnLogIn" runat="server" Text="Log in" CssClass = "contentWidth" OnClick="btnLogIn_Click" />
            <br />
            <br />
            <asp:Label ID="lblFailedLogIn" runat="server" Text=""></asp:Label>
        </div>
    </form>
</asp:Content>
