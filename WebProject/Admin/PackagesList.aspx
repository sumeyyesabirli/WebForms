<%@ Page Title="Paket Listesi" Language="C#" MasterPageFile="~/Admin/AdminPage.Master" AutoEventWireup="true" CodeBehind="PackagesList.aspx.cs" Inherits="WebProject.Admin.PackagesList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="page-title">Paket Listesi</h3>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-borderless" AllowPaging="true" PageSize="10" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Paket ID" />
                        <asp:BoundField DataField="Name" HeaderText="Paket Adı" />
                        <asp:BoundField DataField="Price" HeaderText="Fiyat" />
                        <asp:BoundField DataField="Duration" HeaderText="Süre" />
                        <asp:BoundField DataField="Location" HeaderText="Konum" />
                        <asp:BoundField DataField="Image" HeaderText="Fotoğraf" />
                        <asp:BoundField DataField="Detail" HeaderText="Detay" />

                        <asp:TemplateField HeaderText="İşlemler">
                            <ItemTemplate>
                                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" CommandName="Guncelle" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-primary" />
                                <asp:Button ID="btnSil" runat="server" Text="Sil" CommandName="Sil" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-danger" OnClientClick="return confirm('Silmek istediğinize emin misiniz?');" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

                <div class="modal fade" id="editModal" tabindex="-1" role="dialog" aria-labelledby="editModalLabel" aria-hidden="true">
                    <div class="modal-dialog" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title" id="editModalLabel">Paket Güncelle</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">
                                <asp:HiddenField ID="hiddenPackageId" runat="server" />
                                <div class="form-group">
                                    <label for="txtPackageName">Paket Adı</label>
                                    <asp:TextBox ID="txtPackageName" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtPrice">Fiyat</label>
                                    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtDuration">Süre</label>
                                    <asp:TextBox ID="txtDuration" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtLocation">Konum</label>
                                    <asp:TextBox ID="txtLocation" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <asp:Button ID="btnSave" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="btnSave_Click" />
                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Kapat</button>
                            </div>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnSave" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
    </form>


    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>


    <script type="text/javascript">
        function openModal() {
            $('#editModal').modal('show');
        }

        function closeModal() {
            $('#editModal').modal('hide');
        }
    </script>

</asp:Content>
