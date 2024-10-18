<%@ Page Title="Paket Listesi" Language="C#" MasterPageFile="~/Admin/AdminPage.Master" AutoEventWireup="true" CodeBehind="PackagesList.aspx.cs" Inherits="WebProject.Admin.PackagesList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="page-title">Paket Listesi</h3>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-borderless" AllowPaging="true" PageSize="10" OnPageIndexChanging="GridView1_PageIndexChanging">

    </asp:GridView>
        </form>
</asp:Content>
