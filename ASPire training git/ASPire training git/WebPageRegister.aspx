<%@ Page Title="" Language="C#" MasterPageFile="~/AspireMaster.Master" AutoEventWireup="true" CodeBehind="WebPageRegister.aspx.cs" Inherits="ASPire_training_git.WebPageRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1" runat="server">
        <div class="Content">
            <style>.contentWidth { width: 270px }</style>

            <h1>Registreren</h1>
            <asp:Label AssociatedControlID="tbName" runat="server" Text="Naam:"></asp:Label>
            <br />
            <asp:TextBox ID="tbName" runat="server" CssClass = "contentWidth"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbName" ErrorMessage="Vul je naam in."></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label AssociatedControlID="passwPassword" runat="server" Font-Bold="True" Text="Wachtwoord:"></asp:Label>
            <br />
            <input id="passwPassword" type="password" runat="server" class = "contentWidth"/>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="passwPassword" ErrorMessage="Vul je wachtwoord in."></asp:RequiredFieldValidator>
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
            <asp:Label AssociatedControlID="ddlSex" runat="server" Text="Geslacht:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlSex" runat="server" CssClass = "contentWidth">
                <asp:ListItem Text="Vul hier uw geslacht in" Value="0"></asp:ListItem>
                <asp:ListItem Text="Man" Value="1"></asp:ListItem>
                <asp:ListItem Text="Vrouw" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <asp:RangeValidator runat="server" ControlToValidate="ddlSex" ErrorMessage="Kies een geslacht." MinimumValue="1" MaximumValue="2"></asp:RangeValidator>
            <br />
            <br />
            <asp:Label AssociatedControlID="tbEmail" runat="server" Text="E-mailadres:"></asp:Label>
            <br />
            <asp:TextBox ID="tbEmail" runat="server" CssClass = "contentWidth"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="tbEmail" ErrorMessage="Vul je email in."></asp:RequiredFieldValidator>
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
            <asp:TextBox ID="tbExperience" TextMode="Number" runat="server" min="0" max="10" CssClass = "contentWidth" step="1"/>
            <br />
            <br />
            <asp:Label AssociatedControlID="ddlGoal" runat="server" Text="Doel:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlGoal" runat="server" CssClass = "contentWidth" AutoPostBack="True" onselectedindexchanged="ddlGoal_OnSelectedIndexChanged">
                <asp:ListItem Text="Vul hier uw doel in" Value="0"></asp:ListItem>
                <asp:ListItem Text="Spierenkweker" Value="1"></asp:ListItem>
                <asp:ListItem Text="Afvallen" Value="2"></asp:ListItem>
                <asp:ListItem Text="Beide" Value="3"></asp:ListItem>
            </asp:DropDownList>
            <asp:RangeValidator runat="server" ControlToValidate="ddlGoal" ErrorMessage="Kies een doel." MinimumValue="1" MaximumValue="3"></asp:RangeValidator>
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
                <asp:TextBox ID="tbDailyCalories" TextMode="Number" runat="server" min="0" max="100000" CssClass = "contentWidth" step="1"/>
                <br />
                <br />
                <asp:Label AssociatedControlID="tbWeightGoal" runat="server" Text="Streefgewicht:"></asp:Label>
                <br />
                <asp:TextBox ID="tbWeightGoal" TextMode="Number" runat="server" min="0" max="120" CssClass = "contentWidth" step="0.1"/>
                <br />
                <br />
            </div>
            <br />
            <asp:Button ID="btnRegister" runat="server" Text="Registreren" CssClass = "contentWidth" OnClick="btnRegister_OnClick" />
            <br />
            <br />
        </div>
    </form>
</asp:Content>
