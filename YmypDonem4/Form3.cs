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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*
             DÖNGÜLER
             */

            //listeye ekleme yapmak için:

            //1, 2, 3 
            for (int i = 1; i <= 3; i++)
            {
                //lstListe.Items.Add(i+"-Caner");
                lstListe.Items.Add($"{i}-Caner");
            }

        }

        string[] ogrenciListesi = new string[] { "Ali", "Ayşe", "Hasan", "Berkay", "Gül" };
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayac = 1;
            foreach (var item in ogrenciListesi)
            {
                lstListe.Items.Add(sayac+"-"+item);
                sayac++;
            }
        }
    }
}
