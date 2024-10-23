<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminPage.Master" AutoEventWireup="true" CodeBehind="BlogList.aspx.cs" Inherits="WebProject.Admin.BlogList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="page-title">Blog Listele</h3>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-borderless" AllowPaging="true" PageSize="10" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Blog ID" />
                        <asp:BoundField DataField="Title" HeaderText="Başlık" />
                        <asp:BoundField DataField="Summary" HeaderText="Özet" />
                        <asp:BoundField DataField="Date" HeaderText="Tarih" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:BoundField DataField="Categoryid" HeaderText="Kategori" />
                        <asp:BoundField DataField="Image" HeaderText="Fotoğraf" />
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
                                <h5 class="modal-title" id="editModalLabel">Blog Güncelle</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">
                                <asp:HiddenField ID="hiddenBlogId" runat="server" />
                                <div class="form-group">
                                    <label for="txtBlogTitle">Başlık</label>
                                    <asp:TextBox ID="txtBlogTitle" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtBlogSummary">Özet</label>
                                    <asp:TextBox ID="txtBlogSummary" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtBlogDate">Tarih</label>
                                    <asp:TextBox ID="txtBlogDate" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="ddlBlogCategory">Kategori</label>
                                    <asp:DropDownList ID="ddlBlogCategory" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label for="txtBlogImage">Fotoğraf</label>
                                    <asp:TextBox ID="txtBlogImage" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="txtBlogDetail">Detay</label>
                                    <asp:TextBox ID="txtBlogDetail" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
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
