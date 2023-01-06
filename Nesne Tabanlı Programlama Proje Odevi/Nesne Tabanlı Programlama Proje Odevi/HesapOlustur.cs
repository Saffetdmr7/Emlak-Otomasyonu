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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    public partial class HesapOlustur : Form
    {
        public HesapOlustur()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Database db = new Database();
        private void HesapOlustur_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            kontrol kontrol = new kontrol();
            bool b1 = txtFullName.Text != "" && cmbxAge.Text != ""
                && txtPhoneNumber.Text != "" && txtPassword.Text != ""
                && txtCheckPassword.Text != "" && txtEmail.Text != "";
            if (b1)
            {
                if (txtCheckPassword.Text.Equals(txtPassword.Text))
                {
                    KisiVeritabanı kisi = new KisiVeritabanı();
                    txtFullName.Text.ToUpper();
                    txtEmail.Text.ToLower();
                    #region Telefon numarası kontrol
                    if (kisi.kisiler_Ara(2,txtPhoneNumber.Text))
                    {
                        if (kontrol.telnoKontrol(txtPhoneNumber.Text))
                        {
                        }
                        else
                        {
                            MessageBox.Show("Bu telefon numarası zaten daha önce eklenmiş");
                            txtPhoneNumber.Clear();
                            return;
                        }
                        
                    }
                    #endregion
                    if (kisi.kisiler_Ara(0, txtEmail.Text))
                    {
                        MessageBox.Show("Yazdığınız E-Posta adresi başka kullanıcı tarafından kullanılıyor.", "Yeni bir e-posta adresi giriniz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Clear();
                        return;
                    }
                    if (kontrol.epostaKontrol(txtEmail.Text))
                    {
                        if (kontrol.sifreKontrol(txtPassword.Text))
                        {
                            if (fotosecimidialog.FileName.Equals(""))
                            {
                                MessageBox.Show("bir dosya seçin");
                                return;
                            }
                            Random rnd = new Random();
                            int sayı = (int)rnd.Next(100000, 1000000);
                            if (mail_Gonder.gonder("Hesabınızı doğrulayın", "hesabınızı doğrulamak için gönderilen kodu giriniz.\n(" + sayı.ToString() + ")", txtEmail.Text))
                            {
                                Degisken.dogrulamaKodu = sayı.ToString();
                                Degisken.email = txtEmail.Text;
                                Degisken.adsoyad = txtFullName.Text;
                                Degisken.telno = txtPhoneNumber.Text;
                                Degisken.password = txtCheckPassword.Text;
                                Degisken.yas = cmbxAge.Text;
                                Degisken.rol = "Müşteri";
                                MailDogrulama mailDogrulama = new MailDogrulama();
                                MailDogrulama.işlem = "doğrula";
                                mailDogrulama.Show();
                                this.Hide();
                            }
                            else
                            {
                                return;
                            }
                            
                        }
                        else
                        {
                            txtCheckPassword.Clear();
                            txtPassword.Clear();
                            return;
                        }
                    }
                    else
                    {
                        txtEmail.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Girilen şifreler farklı", "Şifreler uyuşmuyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtCheckPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurduğunuzdan emin olun");
            }
        }
        private void chckPassword_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chckPassword.Checked)
            {
                 txtPassword.UseSystemPasswordChar = false;
                 txtCheckPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtCheckPassword.UseSystemPasswordChar = true;
            }
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            fotosecimidialog.ShowDialog();
            pictureBox1.ImageLocation = fotosecimidialog.FileName;   
            Degisken.foto = fotosecimidialog.FileName;
        }
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fotosecimidialog_FileOk(object sender, CancelEventArgs e)
        {
            Degisken.foto = fotosecimidialog.FileName;
        }
        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            txtFullName.Text = Ayarla.metinGirSadece(txtFullName.Text, 50);
        }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = Ayarla.sınırlıSayıGir(txtPhoneNumber.Text, 11);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 50)
            {
                txtEmail.Text = txtEmail.Text.Substring(0, 50);
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisSayfası girisSayfası = new GirisSayfası();
            girisSayfası.Show();
            this.Hide();   
        }

        private void HesapOlustur_Load(object sender, EventArgs e)
        {
        }

        private void txtCheckPassword_Enter(object sender, EventArgs e)
        {
            txtCheckPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
