using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject.Admin
{
    public partial class BlogList : System.Web.UI.Page
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
                BindCategories();
            }
        }
        private void BindGridView()
        {
            var blogs = _context.Blogs.Select(b => new
            {
                b.Id,
                b.Title,
                b.Summary,
                b.Date,
                b.Categoryid,
                b.Image
            }).ToList();

            GridView1.DataSource = blogs;
            GridView1.DataBind();
        }

        private void BindCategories()
        {
            var categories = _context.BlogCategories.Select(c => new
            {
                c.Id,
                c.Name
            }).ToList();

            ddlBlogCategory.DataSource = categories;
            ddlBlogCategory.DataTextField = "Name";
            ddlBlogCategory.DataValueField = "Id";
            ddlBlogCategory.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Guncelle")
            {
                int blogId = Convert.ToInt32(e.CommandArgument);
                var blog = _context.Blogs.Find(blogId);

                if (blog != null)
                {
                    hiddenBlogId.Value = blog.Id.ToString();
                    txtBlogTitle.Text = blog.Title;
                    txtBlogSummary.Text = blog.Summary;
                    txtBlogDate.Text = blog.Date.ToString("dd/MM/yyyy");
                    ddlBlogCategory.SelectedValue = blog.Categoryid.ToString();
                    txtBlogImage.Text = blog.Image;
                    txtBlogDetail.Text = blog.Detail;
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }
            }
            else if (e.CommandName == "Sil")
            {
                int blogId = Convert.ToInt32(e.CommandArgument);
                var blog = _context.Blogs.Find(blogId);

                if (blog != null)
                {
                    _context.Blogs.Remove(blog);
                    _context.SaveChanges();
                    BindGridView();
                }
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            int blogId = Convert.ToInt32(hiddenBlogId.Value);
            var blog = _context.Blogs.Find(blogId);

            if (blog != null)
            {
                blog.Title = txtBlogTitle.Text.Trim();
                blog.Summary = txtBlogSummary.Text.Trim();
                blog.Date = DateTime.Parse(txtBlogDate.Text.Trim());
                blog.Categoryid = int.Parse(ddlBlogCategory.SelectedValue);
                blog.Image = txtBlogImage.Text.Trim();
                blog.Detail = txtBlogDetail.Text.Trim();

                _context.SaveChanges();
                BindGridView();
            }

            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "closeModal();", true);
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridView();
        }
    }
}
