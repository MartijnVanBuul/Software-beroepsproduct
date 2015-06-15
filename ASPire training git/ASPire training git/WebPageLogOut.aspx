<%@ Page Title="" Language="C#" MasterPageFile="~/AspireMaster.Master" AutoEventWireup="true" CodeBehind="WebPageLogOut.aspx.cs" Inherits="ASPire_training_git.WebPageLogOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="Content">
            <style>.contentWidth { width: 270px }</style>

            <h1>Uitloggen</h1>
            <asp:Label runat="server" Text="U bent succesvol uitgelogd."></asp:Label>
        </div>
    </form>
</asp:Content>
