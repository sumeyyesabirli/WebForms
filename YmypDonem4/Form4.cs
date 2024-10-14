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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            /*
             IF KARAR YAPISI
            Karşılaştırma Operetörleri: 
            <, >, <=, >=, ==, !=
            Mantıksal Operatörler:
            &, && (ve), |, || (veya) 
             */

            int sayi = 400;

            if (sayi >= 500)
            {
                //true bloğu 
            }
            else
            {
                //false bloğu
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ahmet'in sınıfını geçebilmesi için devamsızlık durumunun 15 günün altında ve not ortalamasının 90 puan ve üzerinde olması gerekmektedir.

            short devamsizlikDurumu = 10;
            short notOrtalamasi = 90;

            //Ahmetin sınıfını geçebilmesi bu iki koşulunda aynı anda gercekleşmesine bağlıdır.

            if (devamsizlikDurumu < 15 && notOrtalamasi >= 90)
            {
                MessageBox.Show("Sınıfınızı geçtiniz.");
            }
            else
            {
                MessageBox.Show("KALDINIZ");
            }

            /*
             * && operatoru kullanıldığında;
             true, true > true
            false, true > false
            true, false > false
            false, false > false
             */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ahmet'in sınıfını geçebilmesi için devamsızlık durumunun 15 günün altında veya not ortalamasının 90 puan ve üzerinde olması gerekmektedir.

            short devamsizlikDurumu = 20;
            short notOrtalamasi = 90;

            //Ahmetin sınıfını geçebilmesi bu iki koşulundan herhangi birinin gercekleşmesine bağlıdır.
            if (devamsizlikDurumu < 15 || notOrtalamasi >= 90)
            {
                MessageBox.Show("Sınıfınızı geçtiniz.");
            }
            else
            {
                MessageBox.Show("KALDINIZ");
            }

            /*
             || operatoru kullanıyorsak;

            true, false > true
            false, true > true
            true , true > true
            false, false > false


             */
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            /*
             Müşteri;

            500 tl ile 1000 tl arasında alışveriş yaptıysa %25 idirim,
            1000 tl ile 2500 tl arasında alışveriş yaptıysa %35 idirim,
            2500 tl ile 5000 tl arasında alışveriş yaptıysa %40 idirim,
            5000 tlden fazla alışveriş yaptıysa %45 idirim

            uygulanacaktır. 

             */

            double tutar = Convert.ToDouble(txtTutar.Text);
            bool indirimVarmi = true;
            double indirimOrani = 0;

            if (tutar >= 500 && tutar <= 1000)
            {
                //tutar=tutar - (tutar * 0.25);
                tutar -= tutar * 0.25;
                indirimOrani = 0.25;
            }
            else if (tutar > 1000 && tutar <= 2500)
            {
                tutar -= tutar * 0.35;
                indirimOrani = 0.35;
            }
            else if (tutar > 2500 && tutar <= 5000)
            {
                tutar -= tutar * 0.40;
                indirimOrani = 0.40;
            }
            else if (tutar > 5000)
            {
                tutar -= tutar * 0.45;
                indirimOrani = 0.45;
            }
            else
            {
                indirimVarmi = false;
            }
            //indirimVarmi==true
            if (indirimVarmi)
            {
                lblMesaj.Text = $"İndirimli tutar: {tutar}\nİndirim Oranı: {indirimOrani}";
            }
            else
            {
                lblMesaj.Text = "İndirim hakkı kazanamadınız.";
            }

        }
    }
}
