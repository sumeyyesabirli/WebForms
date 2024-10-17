<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminPage.Master" AutoEventWireup="true" CodeBehind="AdminBlog.aspx.cs" Inherits="WebProject.Admin.AdminBlog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="page-title">Blog Ekle</h3>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="col-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <form class="forms-sample" runat="server">
                    <div class="form-group">
                        <label for="exampleInputName1">Başlık</label>
                        <asp:TextBox ID="TxtLabelBlogTitle" runat="server" CssClass="form-control" placeholder="Başlık"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail3">Özet</label>
                        <asp:TextBox ID="TextBlogSummary" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100px" placeholder="Blog Özeti"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputDate">Tarih</label>
                        <asp:TextBox ID="TextBlogDate" runat="server" CssClass="form-control" ReadOnly="true" OnTextChanged="TextBlogDate_TextChanged"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword4">Kategori</label>
                        <asp:DropDownList ID="DropDownListBlogCategory" runat="server" CssClass="form-control" placeholder="Kategori"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Blog Fotoğrafı Ekle</label>
                        <input type="file" name="img[]" class="file-upload-default">
                        <div class="input-group col-xs-12">
                            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control file-upload-info" placeholder="Fotoğraf Yükle" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="exampleTextarea1">Blog Detayı</label>
                        <asp:TextBox ID="TextBlogDetail" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100px" placeholder="Blog Detayı"></asp:TextBox>
                    </div>
                    <asp:Button ID="ButtonPackagesAdd" runat="server" Text="Ekle" CssClass="btn btn-gradient-primary me-2" />
                </form>
            </div>
        </div>
    </div>
</asp:Content>
