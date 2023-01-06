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
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }
        private void btnEmailDegis_Click(object sender, EventArgs e)
        {
            EmailDegis email = new EmailDegis();
            email.Show();
            this.Hide();
        }
        private void btnTelnoDegis_Click(object sender, EventArgs e)
        {
            telnoDegis degis = new telnoDegis();
            degis.Show();
            this.Hide();
        }
        private void btnYasDegis_Click(object sender, EventArgs e)
        {
            yasDegistir yasDegistir = new yasDegistir();
            yasDegistir.Show();
            this.Hide();
        }
        private void btnSifreDegis_Click(object sender, EventArgs e)
        {
            sifreDegis sifreDegis = new sifreDegis();
            sifreDegis.yön = "degis";
            sifreDegis.Show();
            this.Hide();
        }
        private void btnAdSoyadDegis_Click(object sender, EventArgs e)
        {
            adsoyadDegis adsoyadDegis = new adsoyadDegis();
            adsoyadDegis.Show();
            this.Hide();
        }
        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            KisiVeritabanı kisi = new KisiVeritabanı();
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Hesabı silmek istediğinize emin misiniz?\n (Bu işlem geri alınamaz","Hesap sil",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                kisi.kisi_Sil(Degisken.email);
                GirisSayfası girisSayfası = new GirisSayfası();
                girisSayfası.Show();
                this.Hide();
            }
        }
        private void btnProfilFoto_Click(object sender, EventArgs e)
        {
            fotoDeğiş foto = new fotoDeğiş();
            foto.Show();
            this.Hide();
        }
        private void Profil_Load(object sender, EventArgs e)
        {
            lblProfilAdSoyad.Text = Degisken.adsoyad;
            lblProfilEmail.Text = Degisken.email;
            lblProfilTelNo.Text = Degisken.telno;
            lblyas.Text = Degisken.yas;
            pictureBox1.ImageLocation = Degisken.foto;
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
        private void Profil_FormClosing(object sender, FormClosingEventArgs e)
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
