using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    public partial class adsoyadDegis : Form
    {
        public adsoyadDegis()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            txtYeniAdSoyad.Text.ToUpper().Trim();
            if (!(txtYeniAdSoyad.Text.Equals(Degisken.adsoyad)))
            {
                KisiVeritabanı kisiVeritabanı = new KisiVeritabanı();
                kisiVeritabanı.adsoyad_Guncelle(Degisken.email, txtYeniAdSoyad.Text);
                MessageBox.Show("İsim ve Soyisminiz değiştirildi");
                Profil profil = new Profil();
                Degisken.adsoyad = txtYeniAdSoyad.Text;
                profil.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Eski Ad ve Soyadınızı girdiniz\nLütfen değiştirip tekrar deneyiniz.");
                txtYeniAdSoyad.Clear();
            }
            
        }

        private void txtYeniAdSoyad_TextChanged(object sender, EventArgs e)
        {
            txtYeniAdSoyad.Text = Ayarla.metinGirSadece(txtYeniAdSoyad.Text,50);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void adsoyadDegis_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
