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
    public partial class FinalSorusu : Form
    {
        // Producları tutan bir Liste
        List<Product> products = new List<Product>();
        //diziye aktarmak için 
        string[] arrayProducts;

        public FinalSorusu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //veriler dolu mu boş mu kontrolü
            if (txtProdName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Alanları tam doldurun");
            }
            else
            {
                //Product nesnesi oluşturuypruz
                Product newProduct = new Product();
                newProduct.ProductID = products.Count + 1;
                newProduct.ProductName = txtProdName.Text;
                newProduct.Stock = Convert.ToInt32(txtQuantity.Text);
                newProduct.UnitPrice = Convert.ToDouble(txtPrice.Text);

                products.Add(newProduct);

                MessageBox.Show($"{newProduct.ProductName} ürünü eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TextBox'ların içini temizleme
                txtProdName.Text = "";
                txtQuantity.Text = "";
                txtPrice.Text = "";
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //ürünleri listeleme 
            Listele();
        }

        private void btnDiziyeAktar_Click(object sender, EventArgs e)
        {
           //product sayısnı diziye ekleme
            arrayProducts = new string[products.Count];
            //ListBox temizleme
            lstListe.Items.Clear();
            for (int i = 0; i < arrayProducts.Length; i++)
            {
                arrayProducts[i] = products[i].ProductName;
                // Ürüne KDV uygulanmadıysa uygulandı ve fiyatı güncellendi. 
                //products i nci elemanı KDVApplied False ise kdv ekliyor
                if (!products[i].KDVApplied) 
                {
                    products[i].UnitPrice = KDV(products[i].UnitPrice);
                    products[i].KDVApplied = true; 
                }
                //bilgiler eklendi
                lstListe.Items.Add($"{products[i].ProductID} - Ürün Adı: {products[i].ProductName} / Ürün Adedi: {products[i].Stock}");
                lstListe.Items.Add($"Kdvli Fiyat: {products[i].UnitPrice}₺");
            }
        }

        private void btnElemanSayisi_Click(object sender, EventArgs e)
        {
            //arrayProducts sayısı eğer nullsa mesaj ile yönlendirme 
            if (arrayProducts == null)
            {
                MessageBox.Show("Lütfen önce Diziye aktarın");
            }
            else
            {
                //arrayProducts arrayinin boyutunu aldık ve ekrana bastık
                int arrayProductsCount = arrayProducts.Length;
                MessageBox.Show($"Eleman sayısı: {arrayProductsCount}");
            }
        }

        private void Listele()
        {
            //listelemeden önce alanı temizler
            lstListe.Items.Clear();
            //döngü ile product ın elemanlarnı listelettik
            foreach (var product in products)
            {
                lstListe.Items.Add($"{product.ProductID} - Ürün Adı: {product.ProductName} / Ürün Adedi: {product.Stock}");
                // kdv uygulanmışsa fiyatı gösterildi
                if (product.KDVApplied) 
                {
                    lstListe.Items.Add($"Kdvli Fiyat: {product.UnitPrice}₺");
                }
                //kdv uygulanmamışsa fiyatı gösterildi.
                else
                {
                    lstListe.Items.Add($"Fiyat: {product.UnitPrice}₺");
                }
            }
        }
        //kdv fonksiyonu
        private double KDV(double kdvsizFiyat)
        {
            double kdvli = kdvsizFiyat * 1.20;
            return kdvli;
        }
    }
}
