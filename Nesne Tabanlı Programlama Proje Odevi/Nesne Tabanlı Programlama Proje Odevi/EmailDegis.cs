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
    public partial class EmailDegis : Form
    {
        public EmailDegis()
        {
            InitializeComponent();
        }
        KisiVeritabanı kisi = new KisiVeritabanı();
        kontrol kontrol = new kontrol();
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (Degisken.email.Equals(txtYeniMail.Text))
            {
                MessageBox.Show("Eski mail adresinizi girdiniz","eski mail ile aynı mail yazıldı",MessageBoxButtons.OK,MessageBoxIcon.None);
                txtYeniMail.Clear();
                return;
            }
            if (kontrol.epostaKontrol(txtYeniMail.Text))
            {
                if (!kisi.kisiler_Ara(0,txtYeniMail.Text))
                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(10000,1000000);
                    Degisken.dogrulamaKodu = sayı.ToString();
                    MailDogrulama dogrulama = new MailDogrulama();
                    MailDogrulama.işlem = "değiştir";
                    MailDogrulama.yeniMail = txtYeniMail.Text;
                    dogrulama.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz mail adresi başka kullanıcı tarafından kullanılıyor.");
                    txtYeniMail.Clear();
                    return;
                }
            }
            else {
                txtYeniMail.Clear();
                return;
            }
        }

        private void txtYeniMail_TextChanged(object sender, EventArgs e)
        {
            if (txtYeniMail.Text.Length > 50)
            {
                txtYeniMail.Text = txtYeniMail.Text.Substring(0, 50);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void EmailDegis_FormClosing(object sender, FormClosingEventArgs e)
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
