using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;

namespace WebProject.Admin
{
    public partial class AdminBlog : System.Web.UI.Page
    {
        private readonly ApplicationDbContext _context;

        public AdminBlog()
        {
            _context = new ApplicationDbContext();
        }

        private List<Entity.BlogCategory> categoryList;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa ilk kez yükleniyorsa kategorileri dolduruyoruz.
            if (!IsPostBack)
            {
                TextBlogDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                // Kategorileri çekip DropDownList'e bağlıyoruz.
                categoryList = _context.BlogCategories.Select(p => new Entity.BlogCategory { Id = p.Id, Name = p.Name }).ToList();
                DropDownListBlogCategory.DataSource = categoryList;
                DropDownListBlogCategory.DataTextField = "Name";
                DropDownListBlogCategory.DataValueField = "Id";
                DropDownListBlogCategory.DataBind();

                DropDownListBlogCategory.Items.Insert(0, new ListItem("Kategori Seç", "0"));
            }
        }

        protected void TextBlogDate_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonBlogAdd_Click(object sender, EventArgs e)
        {
            string filePath = null;

            if (FileUpload1.HasFile)
            {
                if (FileUpload1.PostedFile.ContentType == "image/jpeg" ||
                    FileUpload1.PostedFile.ContentType == "image/jpg" ||
                    FileUpload1.PostedFile.ContentType == "image/png")
                {
                    var photoName = Path.GetFileName(FileUpload1.FileName);
                    filePath = "~/images/" + photoName;
                    var serverPath = Server.MapPath(filePath);
                    FileUpload1.SaveAs(serverPath);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Yüklemeye çalıştığınız fotoğraf formatını kontrol ediniz');", true);
                    return;
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Lütfen Resim seçiniz');", true);
                return;
            }

            var selectedCategoryId = DropDownListBlogCategory.SelectedValue;
            if (selectedCategoryId == "0")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Lütfen bir kategori seçiniz.');", true);
                return;
            }

            var blogTitle = TxtLabelBlogTitle.Text.Trim();
            var blogSummary = TextBlogSummary.Text.Trim();
            var blogDate = TextBlogDate.Text;
            var blogDetail = TextBlogDetail.Text.Trim();

            var newBlog = new Entity.Blog
            {
                Title = blogTitle,
                Summary = blogSummary,
                Date = DateTime.Parse(blogDate),
                Detail = blogDetail,
                Categoryid = int.Parse(selectedCategoryId),
                Image = filePath
            };

            _context.Blogs.Add(newBlog);
            _context.SaveChanges();

            string script = "alert('Blog başarıyla eklendi.'); setTimeout(function(){ window.location = '" + Request.Url.AbsoluteUri + "'; }, 2000);";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
        }
    }
}
