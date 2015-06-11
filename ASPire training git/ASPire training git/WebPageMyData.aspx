<%@ Page Title="" Language="C#" MasterPageFile="~/AspireMaster.Master" AutoEventWireup="true" CodeBehind="WebPageMyData.aspx.cs" Inherits="ASPire_training_git.WebPageMyData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="Content">
            <style>.contentWidth { width: 270px }</style>

            <h1>Mijn Gegevens</h1>
            <br />
            <br />
            <asp:Label AssociatedControlID="tbName" runat="server" Text="Naam:"></asp:Label>
            <br />
            <asp:TextBox ID="tbName" runat="server" CssClass = "contentWidth"></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" Font-Bold="True" Text="Wachtwoord:"></asp:Label>
            <br />
            <input id="passwPassword" type="password" class = "contentWidth"/>
            <br />
            <br />
            <asp:Label AssociatedControlID="tbWeight" runat="server" Text="Gewicht:"></asp:Label>
            <br />
            <asp:TextBox ID="tbWeight" TextMode="Number" runat="server" min="0" max="500" CssClass = "contentWidth" step="1"/>
            <br />
            <br />
            <asp:Label AssociatedControlID="tbLength" runat="server" Text="Lengte:"></asp:Label>
            <br />
            <asp:TextBox ID="tbLength" TextMode="Number" runat="server" min="0" max="250" CssClass = "contentWidth" step="1"/>
            <br />
            <br />
            <asp:Label AssociatedControlID="ddlSex" runat="server" Text="Geslacht:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlSex" runat="server" CssClass = "contentWidth">
                <asp:ListItem Text="Vul hier uw geslacht in" Value="0"></asp:ListItem>
                <asp:ListItem Text="Man" Value="1"></asp:ListItem>
                <asp:ListItem Text="Vrouw" Value="2"></asp:ListItem>
                <asp:ListItem Text="Overige" Value="3"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label AssociatedControlID="calBirthday" runat="server" Text="Geboortedatum:"></asp:Label>
            <br />
            <asp:Calendar ID="calBirthday" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Label AssociatedControlID="tbEmail" runat="server" Text="E-mailadres:"></asp:Label>
            <br />
            <asp:TextBox ID="tbEmail" runat="server" CssClass = "contentWidth"></asp:TextBox>
            <br />
            <br />
            <asp:Label AssociatedControlID="tbPhoneNumer" runat="server" Text="Telefoonnummer:"></asp:Label>
            <br />
            <asp:TextBox ID="tbPhoneNumer" runat="server" CssClass = "contentWidth"></asp:TextBox>
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
                <asp:TextBox ID="tbDailyCalories" TextMode="Number" runat="server" min="0" max="10" CssClass = "contentWidth" step="1"/>
                <br />
                <br />
                <asp:Label AssociatedControlID="tbWeightGoal" runat="server" Text="Streefgewicht:"></asp:Label>
                <br />
                <asp:TextBox ID="tbWeightGoal" TextMode="Number" runat="server" min="0" max="10" CssClass = "contentWidth" step="1"/>
                <br />
                <br />
            </div>
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Aanpassen" CssClass = "contentWidth" />
            <br />
            <br />
        </div>
    </form>
</asp:Content>
