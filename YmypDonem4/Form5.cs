using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YmypDonem4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            /*
             OBJECT ORIENTED PROGRAMMING (Nesne Tabanlı Programlama)

             */

            string urunAdi = "HP Laptop";
            int stokMiktari = 5000;
            string aciklama = "Çok güzel bir ürün";
            double birimFiyati = 56000.45;


            string productName = "Iphone 14 Pro Max";
            short stockQuantity = 450;
            string description = "Güzel bir ürün";
            int birimFiyat = 56000;



        }

        Product urun1 = new Product();
        Product urun2;
        private void button1_Click(object sender, EventArgs e)
        {
            //Product adlı classtan (sınıftan) bir nesne oluşturalım

            //Product sınıfının bir örneğini (INSTANCE) oluşturuyoruz:

            //Product urun1 = new Product();
            urun1.ProductID = 101;
            urun1.ProductName = "HP Laptop";
            urun1.Description = "Çok güzel bir ürün.";
            urun1.UnitPrice = 125000.56;

            //Product urun2 = new Product()
            urun2 = new Product()
            {
                ProductName = "Iphone 14 Pro Max",
                UnitPrice = 120000,
                Description = "Pek Güzel",
                ProductID = 102,
                Stock = 459
            };
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            //lstListe.Items.Add(urun1.ProductName);
            //lstListe.Items.Add(urun2.ProductName);

            foreach (var item in YeniListe)
            {
                //lstListe.Items.Add(item.ProductName);
                lstListe.Items.Add($"{item.ProductID}-{item.ProductName}/{item.UnitPrice}");
            }
        }

        //Generic List
        List<Product> YeniListe = new List<Product>();
        private void button2_Click(object sender, EventArgs e)
        {
            Product p1 = new Product()
            {
                ProductName = "Iphone 14 Pro Max",
                UnitPrice = 120000,
                Description = "Pek Güzel",
                ProductID = 1,
                Stock = 100
            };

            Product p2 = new Product()
            {
                ProductName = "Iphone 13",
                UnitPrice = 12000,
                Description = "Güzel",
                ProductID = 2,
                Stock = 200
            };

            Product[] UrunListesi = new Product[2];

            UrunListesi[0] = p1;
            UrunListesi[1] = p2;

            YeniListe.Add(p1);
            YeniListe.Add(p2);

            //YeniListe.Remove(p1);
            //YeniListe.Clear();
            //YeniListe.Contains(p1);


        }
    }
}
