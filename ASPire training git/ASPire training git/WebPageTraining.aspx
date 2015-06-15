<%@ Page Title="" Language="C#" MasterPageFile="~/AspireMaster.Master" AutoEventWireup="true" CodeBehind="WebPageTraining.aspx.cs" Inherits="ASPire_training_git.WebPageTraining" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="Content">
            <style>.contentWidth { width: 270px }</style>
            <style>.contentMargin {margin-left: 80px}</style>
            <h1>Training</h1>
            <asp:Label AssociatedControlID="ddlExercise" runat="server" Text="Oefening:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlExercise" runat="server" CssClass = "contentWidth"></asp:DropDownList>
            <asp:TextBox ID="tbExercise" runat="server" CssClass="contentWidth contentMargin" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label AssociatedControlID="ddlRoutines" runat="server" Text="Routines:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlRoutines" runat="server" CssClass = "contentWidth"></asp:DropDownList>
            <asp:TextBox ID="tbRoutines" runat="server" CssClass="contentWidth contentMargin" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label AssociatedControlID="ddlLocations" runat="server" Text="Locaties:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlLocations" runat="server" CssClass = "contentWidth"></asp:DropDownList>
            <asp:TextBox ID="tbLocations" runat="server" CssClass="contentWidth contentMargin" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label AssociatedControlID="ddlInstruments" runat="server" Text="Instrumenten:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlInstruments" runat="server" CssClass = "contentWidth"></asp:DropDownList>
            <asp:TextBox ID="tbInstruments" runat="server" CssClass="contentWidth contentMargin" ReadOnly="True"></asp:TextBox>
        </div>
    </form>
</asp:Content>
