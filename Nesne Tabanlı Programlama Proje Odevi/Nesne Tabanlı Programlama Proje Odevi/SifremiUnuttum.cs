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
    public partial class SifremiUnuttum : Form
    {
        KisiVeritabanı kisi = new KisiVeritabanı();
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            kontrol kontrol = new kontrol();
            if (kontrol.epostaKontrol(txtEskiPosta.Text))
            {
                return;
            }
            if (kisi.kisiler_Ara(0, txtEskiPosta.Text))
            {

                Random rnd = new Random();
                int sayı = (int)rnd.Next(100000, 1000000);
                if (mail_Gonder.gonder("Hesabınızı kurtarın", "Hesabınızı kurtarmak için gönderilen kodu giriniz.\n(" + sayı.ToString() + ")", txtEskiPosta.Text))
                {
                    Degisken.dogrulamaKodu = sayı.ToString();
                    MailDogrulama mail = new MailDogrulama();
                    Degisken.email = txtEskiPosta.Text;
                    MailDogrulama.işlem = "kurtar";
                    mail.Show();
                    this.Hide();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mail adresi kayıtlı değil","yanlış mail adresi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtEskiPosta.Clear();
            }
                    
        }
       private void txtEskiPosta_TextChanged(object sender, EventArgs e)
        {
            if (txtEskiPosta.Text.Length > 50)
            {
                txtEskiPosta.Text = txtEskiPosta.Text.Substring(0, 50);
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisSayfası giris = new GirisSayfası();
            giris.Show();
            this.Hide();
        }

        private void SifremiUnuttum_FormClosing(object sender, FormClosingEventArgs e)
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