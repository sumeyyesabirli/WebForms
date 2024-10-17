<%@ Page Title="" Language="C#" MasterPageFile="~/ServicesPage.Master" AutoEventWireup="true" CodeBehind="ContactPages.aspx.cs" Inherits="WebProject.ContactPages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>İletişim</h2>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <div class="d-none d-sm-block mb-5 pb-4">
            <div id="map" style="height: 480px; position: relative; overflow: hidden;">
                <!-- Google Haritalar içeriği -->
            </div>

            <script>
                function initMap() {
                    var uluru = {
                        lat: -25.363,
                        lng: 131.044
                    };
                    var grayStyles = [{
                        featureType: "all",
                        stylers: [{
                            saturation: -90
                        },
                        {
                            lightness: 50
                        }
                        ]
                    },
                    {
                        elementType: 'labels.text.fill',
                        stylers: [{
                            color: '#ccdee9'
                        }]
                    }
                    ];
                    var map = new google.maps.Map(document.getElementById('map'), {
                        center: {
                            lat: -31.197,
                            lng: 150.744
                        },
                        zoom: 9,
                        styles: grayStyles,
                        scrollwheel: false
                    });
                }
            </script>
            <script src="https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY&callback=initMap">
            </script>
        </div>

        <div class="row">
            <div class="col-12">
                <h2 class="contact-title">Bizimle İletişime Geçin</h2>
            </div>
            <div class="col-lg-8">
                <form class="form-contact contact_form" action="contact_process.php" method="post" id="contactForm" novalidate="novalidate" runat="server">
                    <div class="row">
                        <div class="col-12">
                            <div class="form-group">
                                <asp:TextBox ID="TextContactLocation" runat="server" CssClass="form-control w-100" placeholder="Konum"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-sm-6">
                            <div class="form-group">
                                <asp:TextBox ID="TextContactName" runat="server" CssClass="form-control valid" placeholder="Adınızı ve Soyadınızı Giriniz"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-sm-6">
                            <div class="form-group">
                                <asp:TextBox ID="TextContactEmail" runat="server" CssClass="form-control valid" placeholder="E-posta Adresinizi Giriniz"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-12">
                            <div class="form-group">
                                <asp:TextBox ID="TextContactSubject" runat="server" CssClass="form-control valid" placeholder="Konu Giriniz"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group mt-3">
                        <asp:Button ID="ButtonContactAdd" runat="server" CssClass="button button-contactForm boxed-btn" Text="Gönder" />
                    </div>
                </form>
            </div>
            <div class="col-lg-3 offset-lg-1">
                <div class="media contact-info">
                    <span class="contact-info__icon"><i class="ti-home"></i></span>
                    <div class="media-body">
                        <h3>Buttonwood, Kaliforniya.</h3>
                        <p>Rosemead, CA 91770</p>
                    </div>
                </div>
                <div class="media contact-info">
                    <span class="contact-info__icon"><i class="ti-tablet"></i></span>
                    <div class="media-body">
                        <h3>+1 253 565 2365</h3>
                        <p>Pazartesi - Cuma 9:00 - 18:00</p>
                    </div>
                </div>
                <div class="media contact-info">
                    <span class="contact-info__icon"><i class="ti-email"></i></span>
                    <div class="media-body">
                        <h3>destek@colorlib.com</h3>
                        <p>Bize istediğiniz zaman sorularınızı gönderin!</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
