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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
             DİZİLER (ARRAYS)
            Dizi içerisinde aynı türden değerleri tutabilen ve index (indis) numaraları üzerinden bu değerlere ulaşabildiğimiz bir veri yapısıdır. Dizinin içerisinde bulunan değerler o dizinin elemanlarıdır.
             */

            //Dizi Oluşturma

            string[] liste = new string[3];
            string[] ilListesi = new string[] { "Ankara", "İstanbul", "Tekirdağ" };

            //Diziye Değer Atama

            liste[0] = "Ahmet Aksakal";
            liste[1] = "Caner Mollaoğlu";
            liste[2] = "Kuzey Mollaoğlu";

            //Diziden Değer Okuma

            string deger = liste[2];
            //string gelenDeger = liste[3];



        }

        //global degisken
        string[] urunListesi = new string[1];
        int sayac = 0;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunAdi.Text;

            urunListesi[sayac] = urunAdi;
            sayac = sayac + 1;

            Array.Resize(ref urunListesi, urunListesi.Length + 1);
        }
    }
}
