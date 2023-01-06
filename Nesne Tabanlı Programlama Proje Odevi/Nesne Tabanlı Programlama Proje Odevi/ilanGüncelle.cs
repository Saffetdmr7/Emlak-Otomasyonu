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
    public partial class ilanGüncelle : Form
    {
        public ilanGüncelle()
        {
            InitializeComponent();
        }
        evVeriTabanı ev = new evVeriTabanı();
        evAdresVeritabanı adres = new evAdresVeritabanı();
        evlisteleVeritabanı evListe = new evlisteleVeritabanı();
        private static int a = 0;
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int seçilen = dataGridViewListele.SelectedCells[0].RowIndex;
            if (a == 1)
            {
                ev.evDegerGüncelle(dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString(), cmbxOdaSayısı.Text
                    , txtMetreKare.Text, txtKiralikFiyat.Text, txtSatilikFiyat.Text, cmbxIsinmaTuru.Text
                    , cmbxEsyaliMi.Text, cmbxBinaTipi.Text);
                evListe.evListeDegerGüncelle(dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString(),
                    cmbxOdaSayısı.Text, txtMetreKare.Text, txtKiralikFiyat.Text, txtSatilikFiyat.Text);
                listele();
                dataGridEvDeger();
            }
            else if (a == 2)
            {
                adres.evAdresGüncelle(dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString(), txtSehir.Text
                    , txtIlce.Text, txtMahalle.Text, txtSokak.Text, txtEvNo.Text
                    , txtKat.Text, txtDaireNo.Text);
                evListe.evListeAdresGüncelle(dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString(), txtSehir.Text
                    , txtIlce.Text, txtMahalle.Text);
                listele();
                dataGridAdres();
            }
            else
            {
                return;
            }
        }
        private void btnEvGüncelle_Click(object sender, EventArgs e)
        {
            panelAdresDegis.Visible = false;
            panelEvDeğiş.Visible = true;
            dataGridEvDeger();
            a = 1;
        }
        private void btnAdresAyarla_Click(object sender, EventArgs e)
        {
            panelAdresDegis.Visible = true;
            panelEvDeğiş.Visible = false;
            dataGridAdres();
            a = 2;
        }
        #region Giriş Formatlama
        private void txtSehir_TextChanged(object sender, EventArgs e)
        {
            txtSehir.Text = Ayarla.metinGirSadece(txtSehir.Text,50);
        }

        private void txtIlce_TextChanged(object sender, EventArgs e)
        {
            txtIlce.Text = Ayarla.metinGirSadece(txtIlce.Text,50);
        }

        private void txtMahalle_TextChanged(object sender, EventArgs e)
        {
            txtMahalle.Text = Ayarla.metinGirSadece(txtMahalle.Text, 50);
        }

        private void txtEvNo_TextChanged(object sender, EventArgs e)
        {
            txtEvNo.Text = Ayarla.sınırlıSayıGir(txtEvNo.Text,5);
        }

        private void txtKat_TextChanged(object sender, EventArgs e)
        {
            txtKat.Text = Ayarla.sınırlıSayıGir(txtKat.Text, 3);
        }

        private void txtDaireNo_TextChanged(object sender, EventArgs e)
        {
            txtDaireNo.Text = Ayarla.sınırlıSayıGir(txtDaireNo.Text, 4);
        }

        private void txtMetreKare_TextChanged(object sender, EventArgs e)
        {
            txtMetreKare.Text = Ayarla.sınırlıSayıGir(txtMetreKare.Text, 10);
        }

        private void txtKiralikFiyat_TextChanged(object sender, EventArgs e)
        {
            txtKiralikFiyat.Text = Ayarla.sınırlıSayıGir(txtKiralikFiyat.Text, 10);
        }

        private void txtSatilikFiyat_TextChanged(object sender, EventArgs e)
        {
            txtSatilikFiyat.Text = Ayarla.sınırlıSayıGir(txtSatilikFiyat.Text, 50);
        }
        #endregion
        public void listele() 
        {
            veriListeleme listeleme = new veriListeleme();
            DataSet ds = new DataSet();
            ds = listeleme.listeleMaileGore(Degisken.email);
            dataGridViewListele.DataSource = ds.Tables[0];
        }
        public void dataGridAdres() {
            if (dataGridViewListele.Rows.Count == 0)
            {
                return;
            }
            evVeriCek ev = new evVeriCek();
            int seçilen = dataGridViewListele.SelectedCells[0].RowIndex;
            ev.evAdresCek(dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString());
            txtSehir.Text = evVeriCek.evAdresVeriler[0].ToString();
            txtIlce.Text = evVeriCek.evAdresVeriler[1].ToString();
            txtMahalle.Text = evVeriCek.evAdresVeriler[2].ToString();
            txtSokak.Text = evVeriCek.evAdresVeriler[3].ToString();
            txtEvNo.Text = evVeriCek.evAdresVeriler[4].ToString();
            txtKat.Text = evVeriCek.evAdresVeriler[5].ToString();
            txtDaireNo.Text = evVeriCek.evAdresVeriler[6].ToString();
            evVeriCek.evAdresVeriler.Clear();
        }
        public void dataGridEvDeger()
        {
            if (dataGridViewListele.Rows.Count == 0)
            {
                return;
            }
            evVeriCek ev = new evVeriCek();
            int seçilen = dataGridViewListele.SelectedCells[0].RowIndex;
            ev.evDegercek(dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString());
            cmbxOdaSayısı.Text = evVeriCek.evVeriler[0].ToString();
            txtMetreKare.Text = evVeriCek.evVeriler[1].ToString();
            txtKiralikFiyat.Text = evVeriCek.evVeriler[2].ToString();
            txtSatilikFiyat.Text = evVeriCek.evVeriler[3].ToString();
            cmbxIsinmaTuru.Text = evVeriCek.evVeriler[4].ToString();
            cmbxEsyaliMi.Text = evVeriCek.evVeriler[5].ToString();
            cmbxBinaTipi.Text = evVeriCek.evVeriler[6].ToString();
            evVeriCek.evVeriler.Clear();
        }
        private void dataGridViewListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (a == 1)
            {
                dataGridEvDeger();
            }
            else if(a == 2)
            {
                dataGridAdres();
            }
            else
            {
                return;
            }
        }
        private void ilanGüncelle_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            AnaSayfa.a = 2;
            AnaSayfa.mail = Degisken.email;
            anasayfa.Show();
            this.Hide();
        }
        private void ilanGüncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void btnFotoGüncelle_Click(object sender, EventArgs e)
        {
            int seçilen = dataGridViewListele.SelectedCells[0].RowIndex;
            evDegisken.dataGridWiewSeçilen = dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString();
            evFoto foto = new evFoto();
            foto.Show();
            this.Hide();
        }
    }
}
