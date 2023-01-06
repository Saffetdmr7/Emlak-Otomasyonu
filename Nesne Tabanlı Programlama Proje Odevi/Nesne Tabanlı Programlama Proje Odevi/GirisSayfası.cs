using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    public partial class GirisSayfası : Form
    {
        public GirisSayfası()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Database db = new Database();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            KisiVeritabanı kisi = new KisiVeritabanı();
            bool a = kisi.kisiler_Ara(0, txtEmail.Text);
            KisiVeritabanı kisi1 = new KisiVeritabanı();
            bool b = kisi1.kisiler_Ara(1, txtPassword.Text);

            if (a && b)
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                Degisken.degiskenAta(kisi.dizi[0].ToString(), kisi.dizi[1].ToString()
                    , kisi.dizi[2].ToString(), kisi.dizi[3].ToString()
                    , kisi.dizi[4].ToString(), kisi.dizi[5].ToString()
                    , kisi.dizi[6].ToString(), kisi.dizi[7].ToString());
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E posta ya da Şifre hatalı", "Hatalı Giriş");
                txtEmail.Clear();
                txtPassword.Clear();
            }
        }
        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void GirisSayfası_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void GirisSayfası_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtEmail.Text == "E-Posta Girin")
            {
                lblPosta.Visible = false;
                txtEmail.Text = "E-Posta Girin";
            }
            if (txtPassword.Text == "" || txtPassword.Text == "Şifrenizi Girin")
            {
                txtPassword.UseSystemPasswordChar = false;
                lblsifre.Visible = false;
                txtPassword.Text = "Şifrenizi Girin";
            }
        }
        private void btnSifreUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            sifremiUnuttum.Show();
            this.Hide();
        }
        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            HesapOlustur hesapOlustur = new HesapOlustur();
            hesapOlustur.Show();
            this.Hide();
        }
        private void GirisSayfası_Load(object sender, EventArgs e)
        {
                lblPosta.Visible = false;
                txtEmail.Text = "E-Posta Girin";
                txtPassword.UseSystemPasswordChar = false;
                lblsifre.Visible = false;
                txtPassword.Text = "Şifrenizi Girin";
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Şifrenizi Girin" || txtPassword.Text == "")
            {
                txtPassword.Clear();
                txtPassword.UseSystemPasswordChar = true;
                checkPassword.Checked = false;
            }
            lblsifre.Visible = true;
            if (txtEmail.Text == "" || txtEmail.Text == "E-Posta Girin")
            {
                lblPosta.Visible = false;
                txtEmail.Text = "E-Posta Girin";
            }
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-Posta Girin" || txtEmail.Text == "")
            {
                txtEmail.Clear();
            }
            lblPosta.Visible = true;
            if (txtPassword.Text == "" || txtPassword.Text == "Şifrenizi Girin")
            {
                txtPassword.UseSystemPasswordChar = false;
                lblsifre.Visible = false;
                txtPassword.Text = "Şifrenizi Girin";
            }
        }
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
