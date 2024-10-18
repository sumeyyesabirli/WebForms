<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminPage.Master" AutoEventWireup="true" CodeBehind="BlogCategory.aspx.cs" Inherits="WebProject.Admin.BlogCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="page-title">Blog Kategori Ekle</h3>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="col-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <form class="forms-sample" runat="server">
                    <div class="form-group">
                        <label for="exampleInputName1">Kategori Ekle</label>
                        <asp:TextBox ID="TxtCategori" runat="server" CssClass="form-control" placeholder="Kategori Ekle"></asp:TextBox>
                    </div>
                    <asp:Button ID="ButtonPackagesAdd" runat="server" Text="Ekle" CssClass="btn btn-gradient-primary me-2" />
                </form>
            </div>
        </div>
    </div>
</asp:Content>
