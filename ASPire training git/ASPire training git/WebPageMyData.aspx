<%@ Page Title="" Language="C#" MasterPageFile="~/AspireMaster.Master" AutoEventWireup="true" CodeBehind="WebPageMyData.aspx.cs" Inherits="ASPire_training_git.WebPageMyData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="Content">
            <style>.contentWidth { width: 270px }</style>
            <h1>Mijn Gegevens</h1>
            <asp:Label ID="lblNotLoggedIn" runat="server" Text=""></asp:Label>
            <div id="loggedIn" style="display: none;" runat="server">
                <asp:Label AssociatedControlID="tbName" runat="server" Text="Naam:"></asp:Label>
                <br />
                <asp:TextBox ID="tbName" ReadOnly="True" runat="server" CssClass = "contentWidth"></asp:TextBox>
                <br />
                <br />
                <asp:Label AssociatedControlID="tbWeight" runat="server" Text="Gewicht:"></asp:Label>
                <br />
                <asp:TextBox ID="tbWeight" TextMode="Number" runat="server" min="0" max="500" CssClass = "contentWidth" step="0.1"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbWeight" ErrorMessage="Vul je gewicht in."></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label AssociatedControlID="tbLength" runat="server" Text="Lengte:"></asp:Label>
                <br />
                <asp:TextBox ID="tbLength" TextMode="Number" runat="server" min="0" max="250" CssClass = "contentWidth" step="0.1"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbLength" ErrorMessage="Vul je lengte in."></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label AssociatedControlID="lblSex" runat="server" Text="Geslacht:"></asp:Label>
                <br />
                <asp:Label ID="lblSex" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <asp:Label AssociatedControlID="tbEmail" runat="server" Text="E-mailadres:"></asp:Label>
                <br />
                <asp:TextBox ID="tbEmail" ReadOnly="True" runat="server" CssClass = "contentWidth"></asp:TextBox>
                <br />
                <br />
                <asp:Label AssociatedControlID="tbPhoneNumer" runat="server" Text="Telefoonnummer:"></asp:Label>
                <br />
                <asp:TextBox ID="tbPhoneNumer" runat="server" CssClass = "contentWidth"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbPhoneNumer" ErrorMessage="Vul je telefoonnummer in."></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label AssociatedControlID="tbExperience" runat="server" Text="Ervaring:"></asp:Label>
                <br />
                <asp:TextBox ID="tbExperience" TextMode="Number" runat="server" min="0" ReadOnly="True" max="10" CssClass = "contentWidth" step="1"/>
                <br />
                <br />
                <div id="Spierenkweker" style="display: none;" runat="server">
                    <asp:Label AssociatedControlID="tbVitamins" runat="server" Text="Vitaminen:"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbVitamins" runat="server" CssClass = "contentWidth"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label AssociatedControlID="tbMinerals" runat="server" Text="Mineralen:"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbMinerals" runat="server" CssClass = "contentWidth"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label AssociatedControlID="tbProteins" runat="server" Text="Eiwitten:"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbProteins" runat="server" CssClass = "contentWidth"></asp:TextBox>
                    <br />
                    <br />
                </div>
                <div id="Afvaller" style="display: none;" runat="server">
                    <asp:Label AssociatedControlID="tbDailyCalories" runat="server" Text="Dagelijkse calorieen:"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbDailyCalories" TextMode="Number" runat="server" min="0" max="10000" CssClass = "contentWidth" step="1"/>
                    <br />
                    <br />
                    <asp:Label AssociatedControlID="tbWeightGoal" runat="server" Text="Streefgewicht:"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbWeightGoal" TextMode="Number" runat="server" min="0" max="120" CssClass = "contentWidth" step="0.1"/>
                    <br />
                    <br />
                </div>
                <br />
                <asp:Button ID="btnUpdate" runat="server" Text="Aanpassen" CssClass = "contentWidth" OnClick="btnUpdate_OnClick"/>
                <br />
                <br />
            </div>
        </div>
    </form>
</asp:Content>
