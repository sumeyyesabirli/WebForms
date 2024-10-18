using System;
using System.IO;
using WebProject.Entity;

namespace WebProject.Admin
{
    public partial class AdminPackages : System.Web.UI.Page
    {
        private readonly ApplicationDbContext _context;
        string filePath;
        

        public AdminPackages()
        {
            // Initialize the context in the constructor
            _context = new ApplicationDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected async void ButtonPackagesPhotoAdd_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                if (FileUpload1.PostedFile.ContentType == "image/jpeg" ||
                    FileUpload1.PostedFile.ContentType == "image/jpg" ||
                    FileUpload1.PostedFile.ContentType == "image/png")
                {
                    var photoName = FileUpload1.FileName;
                    var filePath = Server.MapPath("~/images/" + photoName);
                    FileUpload1.SaveAs(filePath);

                    // Veritabanı bağlantısı ve kaydetme
                    var package = new Package
                    {
                        Image = filePath  // Save the file path as string
                    };
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{photoName} ve veritabanına kaydedildi.');", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Yüklemeye çalıştığınız fotoğraf formatını kontrol ediniz');", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Lütfen Resim seçiniz');", true);
            }
        }

        protected async void ButtonPackagesAdd_Click(object sender, EventArgs e)
        {
            string filePath = null; // filePath'i metodun başında tanımlayın

            if (FileUpload1.HasFile)
            {
                if (FileUpload1.PostedFile.ContentType == "image/jpeg" ||
                    FileUpload1.PostedFile.ContentType == "image/jpg" ||
                    FileUpload1.PostedFile.ContentType == "image/png")
                {
                    var photoName = Path.GetFileName(FileUpload1.FileName);
                    filePath = "~/images/" + photoName; // Sanal yol
                    var serverPath = Server.MapPath(filePath); // Fiziksel yol
                    FileUpload1.SaveAs(serverPath);

                    ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{photoName} veritabanına kaydedildi.');", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Yüklemeye çalıştığınız fotoğraf formatını kontrol ediniz');", true);
                    return; // Hata durumunda işlemi sonlandırın
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Lütfen Resim seçiniz');", true);
                return; // Hata durumunda işlemi sonlandırın
            }

            // Formdan gelen diğer verileri alın
            string tourName = TxtTourName.Text;
            decimal tourPrice;
            string tourDuration = TextTourTime.Text;
            string tourLocation = TextTourLocation.Text;
            string tourDetail = TextTourDetail.Text;

            // Tur fiyatının geçerli olup olmadığını kontrol edin
            if (decimal.TryParse(TextTourCurrency.Text, out tourPrice))
            {
                // Veritabanına ekleme işlemi
                var package = new Package
                {
                    Name = tourName,
                    Price = tourPrice,
                    Duration = tourDuration,
                    Location = tourLocation,
                    Detail = tourDetail,
                    Image = filePath // Burada sanal yolu kaydediyoruz
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
