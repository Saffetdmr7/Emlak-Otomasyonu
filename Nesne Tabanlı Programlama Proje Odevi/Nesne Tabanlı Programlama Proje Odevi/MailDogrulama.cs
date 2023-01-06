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
    public partial class MailDogrulama : Form
    {
        public MailDogrulama()
        {
            InitializeComponent();
        }
        public static string işlem { get; set; }
        public static string yeniMail{ get; set; }
        byte sny = 59, dk = 2, hak = 3;
        private void btnDogrula_Click(object sender, EventArgs e)
        {
            hak--;
            KisiVeritabanı kisi = new KisiVeritabanı();
            işlem.ToLower();
            işlem.Trim();
            
            if (Degisken.dogrulamaKodu.Equals(txtDogrulamaKodu.Text))
            {
                if (işlem.Equals("doğrula"))
                {
                    kisi.kisi_Ekle(Degisken.email, Degisken.password, Degisken.telno, Degisken.yas, Degisken.adsoyad, Degisken.foto); ;
                    MessageBox.Show("Hesabınız oluşturuldu ve doğrulandı", "Doğrulama başarılı");
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                }
                else if (işlem.Equals("değiştir"))
                {
                    kisi.mail_Guncelle(yeniMail, Degisken.email);
                    Degisken.email = yeniMail;
                    MessageBox.Show("E-Posta adresi başarı ile değiştirildi", "İşlem başarılı");
                    Profil profil = new Profil();
                    profil.Show();
                }
                else if (işlem.Equals("kurtar"))
                {
                    MessageBox.Show("Hesabınız başarı ile kurtarıldı");
                    sifreDegis sifre = new sifreDegis();
                    sifreDegis.yön = işlem;
                    sifre.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Doğrulama kodu yanlış veya eksik girdiniz\nKalan hakkınız("+hak+")", "Yanlış kod", MessageBoxButtons.OK);
                txtDogrulamaKodu.Clear();
            }
            if (hak <= 0)
            {
                MessageBox.Show("3 deneme hakkınızı bitirdiniz lütfen yeni kod alıp tekrar deneyiniz", "Fazla deneme");
                geri_Git(işlem);
            }
        }
        private void geri_Git(String islem) {
            islem.ToLower();
            islem.Trim();
            if (islem.Equals("doğrula"))
            {
                HesapOlustur hesapOlustur = new HesapOlustur();
                hesapOlustur.Show();
            }
            else if (islem.Equals("değiştir"))
            {
                Profil pro = new Profil();
                pro.Show();
            }
            else if (islem.Equals("kurtar"))
            {
                SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
                sifremiUnuttum.Show();
            }
            this.Hide();
        }
        private void MailDogrulama_Load(object sender, EventArgs e)
        {
            
            dakika.Interval = 60000;
            saniye.Interval = 1000;
            saniye.Start();
            dakika.Start();
        }
        private void txtDogrulamaKodu_TextChanged(object sender, EventArgs e)
        {
            txtDogrulamaKodu.Text = Ayarla.dogrulamaKodu(txtDogrulamaKodu.Text);
        }
        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            geri_Git(işlem);
        }
        private void MailDogrulama_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void dakika_Tick(object sender, EventArgs e)
        {
            if (dk < 0)
            {
                dakika.Stop();
                saniye.Stop();
                MessageBox.Show("Verilen süre içinde doğru kodu giremediniz\n tekrar kod alınız veya spam kutunuzu kontrol ediniz", "Süre Bitti");
                geri_Git(işlem);
            }
            dk--;
        }
        private void saniye_Tick(object sender, EventArgs e)
        {
            progressBarSure.Increment(1);
            lblSüre.Text = "0" + dk.ToString() + " : " + sny.ToString();
            if (sny == 0)
            {
                sny = 59;
            }
            sny--;
        }
    }
}
