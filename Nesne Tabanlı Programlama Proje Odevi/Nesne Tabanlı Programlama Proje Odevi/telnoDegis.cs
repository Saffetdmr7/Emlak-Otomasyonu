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
    public partial class telnoDegis : Form
    {
        public telnoDegis()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            KisiVeritabanı kisi = new KisiVeritabanı();
            kontrol kontrol = new kontrol();
            if (!(kisi.kisiler_Ara(2,txtYeniTelNo.Text)))
            {
                if (kontrol.telnoKontrol(txtYeniTelNo.Text))
                {
                    kisi.telno_Guncelle(Degisken.email,txtYeniTelNo.Text);
                    Degisken.telno = txtYeniTelNo.Text;
                    MessageBox.Show("Telefon numaranız başarı ile değiştirildi");
                    Profil pro = new Profil();
                    pro.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Bu numara başka kullanıcı tarafından kullanılıyor.");
                txtYeniTelNo.Clear();
            }
        }

        private void txtYeniTelNo_TextChanged(object sender, EventArgs e)
        {
            txtYeniTelNo.Text = Ayarla.sınırlıSayıGir(txtYeniTelNo.Text,11);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Profil pro = new Profil();
            pro.Show();
            this.Hide();
        }
        private void telnoDegis_FormClosing(object sender, FormClosingEventArgs e)
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
