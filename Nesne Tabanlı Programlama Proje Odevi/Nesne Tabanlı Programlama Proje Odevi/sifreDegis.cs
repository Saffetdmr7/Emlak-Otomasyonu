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
    public partial class sifreDegis : Form
    {
        public sifreDegis()
        {
            InitializeComponent();
        }
        public static string yön;
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            kontrol kontrol = new kontrol();
            KisiVeritabanı kisi = new KisiVeritabanı();
            if (!(txtPassword.Text.Equals(Degisken.password)))
            {
                if (txtPassword.Text.Equals(txtCheckPassword.Text))
                {
                    if (kontrol.sifreKontrol(txtPassword.Text))
                    {
                        
                        kisi.sifre_Guncelle(Degisken.email, txtPassword.Text);
                        MessageBox.Show("Şifreniz değiştirildi");                        
                        if (yön.Equals("degis"))
                        {
                            Degisken.password = txtPassword.Text;
                            Profil pro = new Profil();
                            pro.Show();
                            this.Hide();
                        }
                        if (yön.Equals("kurtar"))
                        {
                            GirisSayfası giris = new GirisSayfası();
                            giris.Show();
                            this.Hide();
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler eşleşmiyor \nLütfen kontrol ederek yeniden deneyiniz.");
                    txtPassword.Clear();
                    txtCheckPassword.Clear();

                }
            }
            else
            {
                MessageBox.Show("Eski şifrenizi girdiniz \nLütfen kontrol ederek yeniden deneyiniz.");
                txtPassword.Clear();
                txtCheckPassword.Clear();
            }
        }
        private void chckSifreGoster_CheckedChanged(object sender, EventArgs e)
        {

            if (chckSifreGoster.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtCheckPassword.UseSystemPasswordChar = false;
            }
            else if (!(chckSifreGoster.Checked))
            {
                txtPassword.UseSystemPasswordChar = true;
                txtCheckPassword.UseSystemPasswordChar = true;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 50)
            {
                txtPassword.Text = txtPassword.Text.Substring(0, 50);
            }
        }
        private void txtCheckPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtCheckPassword.Text.Length > 50)
            {
                txtCheckPassword.Text = txtCheckPassword.Text.Substring(0, 50);
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (yön.Equals("kurtar"))
            {
                SifremiUnuttum sifre = new SifremiUnuttum();
                sifre.Show();
                this.Hide();
            }
            else if (yön.Equals("degis"))
            {
                Profil pro = new Profil();
                pro.Show();
                this.Hide();
            }
            
        }

        private void sifreDegis_FormClosing(object sender, FormClosingEventArgs e)
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