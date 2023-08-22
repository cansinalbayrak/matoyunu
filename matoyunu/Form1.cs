using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int sayi1, sayi2, op, soruSayisi, dogruCevapSayisi;

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int girilenDeger = Convert.ToInt32(tbSonuc.Text);
                int sonuc = 0;
                if (op == 1)
                    sonuc = sayi1 + sayi2;
                else
                    sonuc = sayi1 - sayi2;
                if (sonuc == girilenDeger)
                {
                    dogruCevapSayisi++;
                    lblDogruGiris.Text = dogruCevapSayisi.ToString();
                }
                sayi1 = rnd.Next(1, 11);
                sayi2 = rnd.Next(1, 11);
                lblSayi1Giris.Text = sayi1.ToString();
                lblSayi2Giris.Text = sayi2.ToString();
                op = rnd.Next(1, 3);
                if (op == 1)
                    lblOpGiris.Text = "+";
                else
                    lblOpGiris.Text = "-";
                soruSayisi++;
                lblSoruSayisiGiris.Text = soruSayisi.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen sayısal değer giriniz.");
            }
            finally
            {
                tbSonuc.Clear();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayi1 = rnd.Next(1,11);
            sayi2 = rnd.Next(1,11);
            lblSayi1Giris.Text = sayi1.ToString();
            lblSayi2Giris.Text = sayi2.ToString();
            op = rnd.Next(1, 3);
            if (op == 1)
                lblOpGiris.Text = "+";
            else
                lblOpGiris.Text = "-";
            soruSayisi++;
            lblSoruSayisiGiris.Text =soruSayisi.ToString();
        }
    }
}
