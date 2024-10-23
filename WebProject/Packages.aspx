<%@ Page Title="" Language="C#" MasterPageFile="~/ServicesPage.Master" AutoEventWireup="true" CodeBehind="Packages.aspx.cs" Inherits="WebProject.Packages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="section-tittle text-center">
                <span>FEATURED TOURS Packages</span>
                <h2>Favourite Places</h2>
            </div>
        </div>
    </div>

    <div class="row">

        <asp:Repeater ID="RepeaterPackages" runat="server">
            <ItemTemplate>
                <div class="col-xl-4 col-lg-4 col-md-6">
                    <div class="single-place mb-30">
                        <div class="place-img">
                            <img src='<%# Eval("Image") %>' alt="Featured Tour">
                        </div>
                        <div class="place-cap">
                            <div class="place-cap-top">
                                <span>
                                    <i class="fas fa-star"></i></span>
                                <h3>
                                    <a href="#"><%# Eval("Name") %></a>
                                </h3>
                                <p class="dolor">$<%# Eval("Price") %> <span>/ Per Person</span></p>
                            </div>
                            <div class="place-cap-bottom">
                                <ul>
                                    <li><i class="far fa-clock"></i><%# Eval("Duration") %> Gün </li>
                                    <li><i class="fas fa-map-marker-alt"></i><%# Eval("Location") %></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
