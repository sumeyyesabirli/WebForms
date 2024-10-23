using System;

namespace WebProject.Admin
{
    public partial class BlogCategory : System.Web.UI.Page
    {
        private readonly ApplicationDbContext _context;
        public BlogCategory()
        {
            _context = new ApplicationDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected async void ButtonCategoryAdd_Click(object sender, EventArgs e)
        {

            var categoryName = TxtCategori.Text.Trim();
            if (string.IsNullOrEmpty(categoryName))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Lütfen bir kategori adı giriniz.');", true);
                return;
            }

            try
            {
                
                var category = new Entity.BlogCategory
                {
                    Name = categoryName
                };

                
                await _context.BlogCategories.AddAsync(category);
                await _context.SaveChangesAsync();

           
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Kategori başarıyla kaydedildi.');", true);
            }
            catch (Exception ex)
            {
    
                ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('Bir hata oluştu: {ex.Message}');", true);
            }
        }
    }
}
