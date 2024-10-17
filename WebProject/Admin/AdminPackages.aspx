<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminPage.Master" AutoEventWireup="true" CodeBehind="AdminPackages.aspx.cs" Inherits="WebProject.Admin.AdminPackages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="page-title">Paket Ekle</h3>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="col-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <form class="forms-sample" runat="server">
                    <div class="form-group">
                        <label for="exampleInputName1">Tur Adı</label>
                        <asp:TextBox ID="TxtTourName" runat="server" CssClass="form-control" placeholder="Tur Adı"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail3">Tur Fiyati</label>
                        <asp:TextBox ID="TextTourCurrency" runat="server" CssClass="form-control" placeholder="Tur Fiyati"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword4">Tur Süresi</label>
                        <asp:TextBox ID="TextTourTime" runat="server" CssClass="form-control" placeholder="Tur Süresi"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword4">Tur Konumu</label>
                        <asp:TextBox ID="TextTourLocation" runat="server" CssClass="form-control" placeholder="Tur Konumu"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Fotoğraf Ekle</label>
                        <input type="file" name="img[]" class="file-upload-default">
                        <div class="input-group col-xs-12">
                            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control file-upload-info" placeholder="Fotoğraf Yükle" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="exampleTextarea1">Tur Detayı</label>
                        <asp:TextBox ID="TextTourDetail" runat="server" CssClass="form-control" TextMode="MultiLine" Height="100px" placeholder="Tur Detayı"></asp:TextBox>
                    </div>
                    <asp:Button ID="ButtonPackagesAdd" runat="server" Text="Ekle" CssClass="btn btn-gradient-primary me-2" />
                </form>
            </div>
        </div>
    </div>
</asp:Content>
