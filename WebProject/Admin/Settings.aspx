<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminPage.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="WebProject.Admin.Settings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="page-title">Ayarlar Sayfası </h3>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="col-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <form class="forms-sample" runat="server">
                    <div class="form-group">
                        <label for="exampleInputName1">E-mail</label>
                        <asp:TextBox ID="TxtLabelSiteEmail" runat="server" CssClass="form-control" placeholder="E-mail Giriniz"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail3">Telefon</label>
                        <asp:TextBox ID="TextSitePhone" runat="server" CssClass="form-control" placeholder="Telefon"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputDate">Adres</label>
                        <asp:TextBox ID="TextSiteAddress" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100px" placeholder="Adres"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail3">X</label>
                        <asp:TextBox ID="TextSiteX" runat="server" CssClass="form-control" placeholder="X Adresniz"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail3">İnstagram</label>
                        <asp:TextBox ID="TextSiteInstagram" runat="server" CssClass="form-control" placeholder="İnstagram Adresiniz"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Logo Fotoğrafı Ekle</label>
                        <input type="file" name="img[]" class="file-upload-default">
                        <div class="input-group col-xs-12">
                            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control file-upload-info" placeholder="Fotoğraf Yükle" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="exampleTextarea1">Site Açıklaması</label>
                        <asp:TextBox ID="TextSiteDetail" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100px" placeholder="Site Açıklaması Ekle"></asp:TextBox>
                    </div>
                    <asp:Button ID="ButtonPackagesAdd" runat="server" Text="Ekle" CssClass="btn btn-gradient-primary me-2" />
                </form>
            </div>
        </div>
    </div>
</asp:Content>
