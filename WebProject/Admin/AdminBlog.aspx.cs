using System;

namespace WebProject.Admin
{
    public partial class AdminBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBlogDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected void TextBlogDate_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}