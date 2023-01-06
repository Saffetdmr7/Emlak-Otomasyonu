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
    public partial class yasDegistir : Form
    {
        public yasDegistir()
        {
            InitializeComponent();
        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (!(cmbxYas.Text.Equals(Degisken.yas)))
            {
                KisiVeritabanı kisiVeritabanı = new KisiVeritabanı();
                kisiVeritabanı.yas_Guncelle(Degisken.email, cmbxYas.Text);
                Degisken.yas = cmbxYas.Text;
                Profil profil = new Profil();
                profil.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Eski yaşınızı girdiniz lütfen değiştiriniz.");
                cmbxYas.Text = "";
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void yasDegistir_FormClosing(object sender, FormClosingEventArgs e)
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
