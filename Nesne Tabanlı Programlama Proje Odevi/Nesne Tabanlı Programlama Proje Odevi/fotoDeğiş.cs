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
    public partial class fotoDeğiş : Form
    {
        public fotoDeğiş()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Profil pro = new Profil();
            pro.Show();
            this.Hide();
        }

        private void fotoDeğiş_Load(object sender, EventArgs e)
        {
            pictureBoxOncekiEv.ImageLocation = Degisken.foto;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBoxSonrakiEv.ImageLocation = openFileDialog1.FileName;
        }

        private void btnFotoSeç_Click(object sender, EventArgs e)
        {
            KisiVeritabanı kisi = new KisiVeritabanı();
            openFileDialog1.ShowDialog();
            pictureBoxSonrakiEv.ImageLocation = openFileDialog1.FileName;
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Emin Misin?","",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                kisi.foto_Guncelle(Degisken.email, Degisken.foto);
                Degisken.foto = openFileDialog1.FileName;
                Profil pro = new Profil();
                pro.Show();
                this.Hide();
            }

            
            
           
        }

        private void fotoDeğiş_FormClosing(object sender, FormClosingEventArgs e)
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
