using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public static string mail;
        evVeriCek ev = new evVeriCek();
        public static int a = 0;
        public static int i = 0;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            if (a == 0)
            {
                veri_Listele();
            }
            if (a == 2)
            {
                verilerimi_Listele(mail);
                btnIlanListele.Text = "Tüm İlanları Gör";
                a = 1;
            }
            pictureProfil.ImageLocation = Degisken.foto;
            lblProfilAdSoyad.Text = Degisken.adsoyad;
            lblProfilEmail.Text = Degisken.email;
            lblProfilTelNo.Text = Degisken.telno;
        }
        private void dataGridViewListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridListele();
            evfotoListele();
            btnOncekiEv.Enabled = true;
            btnSonrakiEv.Enabled = true;
        }
        private void btnIlanListele_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                verilerimi_Listele(Degisken.email);
                btnIlanListele.Text = "Tüm İlanları Gör";
                a = 1;
            }
            else if (a == 1)
            {
                veri_Listele();
                btnIlanListele.Text = "İlanlarımı Listele";
                a = 0;
            }
            datagridListele();
        }
        private void btnSonrakiEv_Click(object sender, EventArgs e)
        {

            if (i == evVeriCek.evFotoVeriler.Count) { i = -1; }
            i++;
            if (i >= evVeriCek.evFotoVeriler.Count)
            {
                i = 0;
            }
            pictureBoxEv.ImageLocation = evVeriCek.evFotoVeriler[i].ToString();
        }
        private void btnOncekiEv_Click(object sender, EventArgs e)
        {
            if (i <= 0) { i = evVeriCek.evFotoVeriler.Count; }
            i--;
            if (i >= evVeriCek.evFotoVeriler.Count)
            {
                i = evVeriCek.evFotoVeriler.Count - 1;
            }
            pictureBoxEv.ImageLocation = evVeriCek.evFotoVeriler[i].ToString();
        }
        #region kullanılan metotlar
        public void veri_Listele()
        {
            veriListeleme listeleme = new veriListeleme();
            DataSet ds;
            ds = listeleme.diğerlerini_Listele(Degisken.email);
            dataGridViewListele.DataSource = ds.Tables[0];
        }
        public void verilerimi_Listele(string email)
        {
            veriListeleme listeleme = new veriListeleme();
            DataSet ds = new DataSet();
            ds = listeleme.listeleMaileGore(email);
            dataGridViewListele.DataSource = ds.Tables[0];
        }
        public void datagridListele()
        {
            if (dataGridViewListele.Rows.Count == 0)
            {
                return;
            }
            evVeriCek ev = new evVeriCek();
            int seçilen = dataGridViewListele.SelectedCells[0].RowIndex;
            ev.veriCek(dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString());
            lblisitmaTuru.Text = evVeriCek.evVeriler[0].ToString();
            lblEsyali.Text = evVeriCek.evVeriler[1].ToString();
            lblBinaTipi.Text = evVeriCek.evVeriler[2].ToString();
            lblMahalle.Text = evVeriCek.evAdresVeriler[0].ToString() + " Mahallesi";
            lblSokak.Text = evVeriCek.evAdresVeriler[1].ToString() + " Sokak";
            lblNo.Text = "No : " + evVeriCek.evAdresVeriler[2].ToString();
            lblkatDaire.Text = "Kat : " + evVeriCek.evAdresVeriler[3].ToString()
                + "   Daire : " + evVeriCek.evAdresVeriler[4].ToString();
            evVeriCek.evVeriler.Clear();
            evVeriCek.evAdresVeriler.Clear();
        }
        public void evfotoListele()
        {
            evVeriCek.evFotoVeriler.Clear();
            if (dataGridViewListele.Rows.Count == 0)
            {
                return;
            }
            int seçilen = dataGridViewListele.SelectedCells[0].RowIndex;
            ev.evFotoCek(dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString());
            pictureBoxEv.ImageLocation = evVeriCek.evFotoVeriler[0].ToString();
        }
        #endregion
        private void btnIlanSahibiGoster_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (dataGridViewListele.Rows.Count == 0)
                {
                    MessageBox.Show("Liste Boş");
                    return;
                }
                int seçilen = dataGridViewListele.SelectedCells[0].RowIndex;
                IlanlarıGöster ilan = new IlanlarıGöster();
                IlanlarıGöster.id = dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString();
                ilan.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bu ilan zaten size ait");
            }
            
        }
        private void dataGridViewListele_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (a == 0)
            {
                if (dataGridViewListele.Rows.Count == 0)
                {
                    MessageBox.Show("Liste Boş");
                    return;
                }
                int seçilen = dataGridViewListele.SelectedCells[0].RowIndex;
                IlanlarıGöster ilan = new IlanlarıGöster();
                IlanlarıGöster.id = dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString();
                ilan.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bu ilan zaten size ait");
            }
        }
        #region yönlendirme butonları
        private void btnprofil_Click_1(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }
        private void btnIlanEkle_Click(object sender, EventArgs e)
        {
            evEkle ev_Ekle = new evEkle();
            ev_Ekle.Show();
            this.Hide();
        }
        private void btnIlanSil_Click(object sender, EventArgs e)
        {
            IlanSil ılanSil = new IlanSil();
            ılanSil.Show();
            this.Hide();
        }
        private void btnIlanGuncelle_Click(object sender, EventArgs e)
        {
            ilanGüncelle güncelle = new ilanGüncelle();
            güncelle.Show();
            this.Hide();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisSayfası giris = new GirisSayfası();
            giris.Show();
            this.Hide();
        }
        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        #endregion

    }
}
