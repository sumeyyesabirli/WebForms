using System;
using System.Linq;
using WebProject.Entity;

namespace WebProject
{
    public partial class BlogPage : System.Web.UI.Page
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindBlogPosts();
                BindCategories();
                BindRecentPosts();
            }
        }

        private void BindBlogPosts()
        {
            var blogPosts = _context.Blogs
                                    .Select(b => new
                                    {
                                        b.Title,
                                        b.Summary,
                                        Image = "/images/" + b.Image,
                                        b.Date,
                                        CategoryName = b.BlogCategory.Name,
                                        
                                    })
                                    .ToList();

            // Repeater'a verileri bağlıyoruz
            RepeaterBlog.DataSource = blogPosts;
            RepeaterBlog.DataBind();
        }

        private void BindCategories()
        {

            var categories = _context.BlogCategories
                                     .Select(c => new
                                     {
                                         c.Name,            
                                      
                                     })
                                     .ToList();

            RepeaterCategories.DataSource = categories;
            RepeaterCategories.DataBind();
        }

        private void BindRecentPosts()
        {
            
            var recentPosts = _context.Blogs
                                      .OrderByDescending(b => b.Date) 
                                      .Take(5)  
                                      .Select(b => new
                                      {
                                          b.Title,            
                                          Image = "/images/" + b.Image, 
                                          b.Date
                                      })
                                      .ToList();

            RepeaterRecentPosts.DataSource = recentPosts;
            RepeaterRecentPosts.DataBind();
        }
    }
}
