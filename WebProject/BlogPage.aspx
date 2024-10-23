<%@ Page Title="" Language="C#" MasterPageFile="~/ServicesPage.Master" AutoEventWireup="true" CodeBehind="BlogPage.aspx.cs" Inherits="WebProject.BlogPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Blog</h2>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
        <!-- Blog Posts -->
        <div class="col-lg-8 mb-5 mb-lg-0">
            <div class="blog_left_sidebar">
                <!-- Repeater to display blog posts -->
                <asp:Repeater ID="RepeaterBlog" runat="server">
                    <ItemTemplate>
                        <article class="blog_item">
                            <div class="blog_item_img">
                                <!-- Blog image -->
                                <img class="card-img rounded-0" src='<%# Eval("Image") %>' alt="Blog Image">
                                <a href="#" class="blog_item_date">
                                    <h3><%# Eval("Date", "{0:dd}") %></h3>
                                    <p><%# Eval("Date", "{0:MMM}") %></p>
                                </a>
                            </div>

                            <div class="blog_details">
                                <a class="d-inline-block" href="single-blog.html">
                                    <h2><%# Eval("Title") %></h2>
                                </a>
                                <p><%# Eval("Summary") %></p>
                                <ul class="blog-info-link">
                                    <li><a href="#"><i class="fa fa-user"></i><%# Eval("CategoryName") %></a></li>
                                </ul>
                            </div>
                        </article>
                    </ItemTemplate>
                </asp:Repeater>

                <!-- Pagination if needed -->
                <nav class="blog-pagination justify-content-center d-flex">
                    <!-- Pagination logic goes here -->
                </nav>
            </div>
        </div>

        <!-- Category Listing (Right Sidebar) -->
        <div class="col-lg-4">
            <div class="blog_right_sidebar">
                <aside class="single_sidebar_widget post_category_widget">
                    <h4 class="widget_title">Categories</h4>
                    <ul class="list cat-list">
                        <!-- Repeater to display categories -->
                        <asp:Repeater ID="RepeaterCategories" runat="server">
                            <ItemTemplate>
                                <li>
                                    <a href="#" class="d-flex">
                                        <p><%# Eval("Name") %></p>
                                    </a>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </aside>

                <!-- Search Box -->
                <aside class="single_sidebar_widget search_widget">
                    <form action="#">
                        <div class="form-group">
                            <div class="input-group mb-3">
                                <input type="text" class="form-control" placeholder="Search Keyword"
                                    onfocus="this.placeholder = ''" onblur="this.placeholder = 'Search Keyword'">
                                <div class="input-group-append">
                                    <button class="btns" type="button"><i class="ti-search"></i></button>
                                </div>
                            </div>
                        </div>
                        <button class="button rounded-0 primary-bg text-white w-100 btn_1 boxed-btn"
                            type="submit">
                            Search</button>
                    </form>
                </aside>

                <!-- Recent Posts -->
                <aside class="single_sidebar_widget popular_post_widget">
                    <h3 class="widget_title">Recent Posts</h3>
                    <!-- Repeater to display recent posts -->
                    <asp:Repeater ID="RepeaterRecentPosts" runat="server">
                        <ItemTemplate>
                            <div class="media post_item">
                                <img src='<%# Eval("Image") %>' alt="Post Image" class="img-fluid">
                                <div class="media-body">
                                    <a href="single-blog.html">
                                        <h3><%# Eval("Title") %></h3>
                                    </a>
                                    <p><%# Eval("Date", "{0:dd MMM yyyy}") %></p>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </aside>

                <!-- Other sidebar content (Tag clouds, Instagram feeds, etc.) -->
                <aside class="single_sidebar_widget tag_cloud_widget">
                    <h4 class="widget_title">Tag Clouds</h4>
                    <ul class="list">
                        <li><a href="#">project</a></li>
                        <li><a href="#">love</a></li>
                        <li><a href="#">technology</a></li>
                        <li><a href="#">travel</a></li>
                    </ul>
                </aside>

                <!-- Newsletter Subscription -->
                <aside class="single_sidebar_widget newsletter_widget">
                    <h4 class="widget_title">Newsletter</h4>
                    <form action="#">
                        <div class="form-group">
                            <input type="email" class="form-control" placeholder="Enter email">
                        </div>
                        <button class="button rounded-0 primary-bg text-white w-100 btn_1 boxed-btn"
                            type="submit">
                            Subscribe</button>
                    </form>
                </aside>
            </div>
        </div>
    </div>
</asp:Content>
