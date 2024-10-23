using System;
using System.IO;
using WebProject.Entity;

namespace WebProject.Admin
{
    public partial class AdminPackages : System.Web.UI.Page
    {
        private readonly ApplicationDbContext _context;
        public AdminPackages()
        {
            _context = new ApplicationDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void ButtonPackagesAdd_Click(object sender, EventArgs e)
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

                    ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{photoName} veritabanına kaydedildi.');", true);
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

        
            string tourName = TxtTourName.Text;
            decimal tourPrice;
            string tourDuration = TextTourTime.Text;
            string tourLocation = TextTourLocation.Text;
            string tourDetail = TextTourDetail.Text;

            if (decimal.TryParse(TextTourCurrency.Text, out tourPrice))
            {
         
                var package = new Package
                {
                    Name = tourName,
                    Price = tourPrice,
                    Duration = tourDuration,
                    Location = tourLocation,
                    Detail = tourDetail,
                    Image = filePath 
                };

                await _context.Packages.AddAsync(package);
                await _context.SaveChangesAsync();

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Tur başarıyla kaydedildi.');", true);
            }
            else
            {

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Lütfen geçerli bir tur fiyatı girin.');", true);
            }
        }
    }
}
