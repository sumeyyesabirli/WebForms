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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // tek satır yorum yapar
            /*
             Çoklu yorum yapmanıza yarar.
             */

            //DEĞİŞKENLER (Variables)
            //Bilgisayar belleğinde verilerin tutulmasını sağlayan yapılardır.

            byte a = 250;
            byte b = 253;

            short urunAdedi = 4500;
            int sayi = 126800;

            double ondalikSayi = 456.34;
            float ondalikSayi1 = 123.45f;
            decimal ondalikSayi2 = 34.45m;

            char karakter = 'a';
            string metin = "Kuzey Mollaoğlu";

            int sonuc = 560 + 43;
            int kalan = 5600 % 4;

            string deger;



            deger = "Caner Mollaoğlu";


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //textboxlarda bulunan değerleri alarak değişkenlere atayacağız.

            //text adlı property'nin get özelliğini kullandın.
            string urunAdi = txtUrunAdi.Text;


            //Tür Dönüşümü
            //string to integer

            //int urunFiyati = txtUrunFiyati.Text;
            int urunFiyati = Convert.ToInt32(txtUrunFiyati.Text);

            //int a=Convert.ToInt32("123");

            double yeniUrunFiyati = urunFiyati * 1.15;

            //integer to string

            string deger = yeniUrunFiyati.ToString();
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            string productName = txtUrunAdi.Text;
            double unitPrice = Convert.ToDouble(txtUrunFiyati.Text);

            double newUnitPrice = unitPrice * 1.35;


            //lblMesaj.Text = productName + " adlı ürünün yeni fiyatı: " + newUnitPrice;

            lblMesaj.Text = $"{productName} adlı ürünün yeni fiyatı {newUnitPrice} TL'dir.";
        }
    }
}
