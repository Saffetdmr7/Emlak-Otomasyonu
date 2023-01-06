using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    public partial class evAdresEkle : Form
    {
        public evAdresEkle()
        {
            InitializeComponent();
        }
        public static ArrayList List = new ArrayList();
        private void btnGeri_Click(object sender, EventArgs e)
        {
            evEkle evEkle = new evEkle();
            evEkle.Show();
            this.Hide();
        }
        private void btnEvIlaniEkle_Click(object sender, EventArgs e)
        {
            byte index = 7;
            String[] dizi = {txtSehir.Text,txtIlce.Text,txtMahalle.Text,
            txtSokak.Text,txtEvNo.Text,txtKat.Text,txtDaireNo.Text};
            foreach (String item in dizi)
            {
                if (item.Equals(""))
                {
                    index = (byte)Array.IndexOf(dizi, item);
                    break;
                }
            }
            if (List.Count == 0)
            {
                MessageBox.Show("Lütfen görsel ekleyiniz");
                return;
            }
            if (index == 7)
            {  
                evVeriTabanı ev = new evVeriTabanı();
                evAdresVeritabanı evadres = new evAdresVeritabanı();
                evFotoVeriTabanı evfoto = new evFotoVeriTabanı();
                evlisteleVeritabanı evliste = new evlisteleVeritabanı();
                string id = ev.id_Cek().ToString();
                evAdresDegisken.degiskenAta(txtSehir.Text, txtIlce.Text
                    , txtMahalle.Text, txtSokak.Text
                    , txtEvNo.Text, txtKat.Text
                    , txtDaireNo.Text);
                ev.evEkle(id, evDegisken.odaSayisi,
                    evDegisken.mKare, evDegisken.kiraFiyat,
                    evDegisken.satisFiyat, evDegisken.isitmaTuru,
                    evDegisken.esyali, evDegisken.binaTuru);
                evadres.evAdresEkle(id
                    , evAdresDegisken.sehir, evAdresDegisken.ilce
                    , evAdresDegisken.mahalle, evAdresDegisken.sokak,
                    evAdresDegisken.evNo
                    , evAdresDegisken.kat, evAdresDegisken.daireNo);
                evliste.evListeEkle(id, evAdresDegisken.sehir
                    , evAdresDegisken.ilce , evAdresDegisken.mahalle
                    , evDegisken.odaSayisi, evDegisken.mKare
                    , evDegisken.kiraFiyat, evDegisken.satisFiyat);
                evfoto.fotoEkle(id,List);
                AnaSayfa ana = new AnaSayfa();
                ana.Show();
                this.Hide();
            }
            switch (index)
            {
                case 0:
                    MessageBox.Show("Şehir giriniz");
                    break;
                case 1:
                    MessageBox.Show("İlçe giriniz");
                    break;
                case 2:
                    MessageBox.Show("Mahalle giriniz");
                    break;
                case 3:
                    MessageBox.Show("Sokak  giriniz");
                    break;
                case 4:
                    MessageBox.Show("Ev No giriniz");
                    break;
                case 5:
                    MessageBox.Show("Kat belirtiniz");
                    break;
                case 6:
                    MessageBox.Show("Daire No giriniz");
                    break;
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void btnGorselEkle_Click(object sender, EventArgs e)
        {
            if (List.Count == 10)
            {
                MessageBox.Show("Daha fazla görsel ekleyemezsiniz");
                return;
            }
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == null || List.Contains(pictureBoxEV.ImageLocation))
            {
                return;
            }
            List.Add(openFileDialog1.FileName);
            pictureBoxEV.ImageLocation = openFileDialog1.FileName;
        }
        static int i = 0;
        private void btnSonrakiEv_Click(object sender, EventArgs e)
        {
            if (i >= 9) { i = -1; }
            i++;
            if (i>= List.Count)
            {
                pictureBoxEV.ImageLocation = null;
            }
            else
            { 
                pictureBoxEV.ImageLocation = List[i].ToString();
            }
        }
        private void btnOncekiEv_Click(object sender, EventArgs e)
        {
            if (i == 0) { i = 10; }
            i--;
            if (i < List.Count)
            {
                pictureBoxEV.ImageLocation = List[i].ToString();
            }
            else
            {
                pictureBoxEV.ImageLocation = null;
            }
        }
        #region ayarlama
        private void txtSehir_TextChanged(object sender, EventArgs e)
        {
            txtSehir.Text = Ayarla.metinGirSadece(txtSehir.Text,50);
        }
        
        private void txtIlce_TextChanged(object sender, EventArgs e)
        {
            txtIlce.Text = Ayarla.metinGirSadece(txtIlce.Text, 50);
        }

        private void txtMahalle_TextChanged(object sender, EventArgs e)
        {
            txtMahalle.Text = Ayarla.metinGirSadece(txtMahalle.Text, 50);
        }

        private void txtEvNo_TextChanged(object sender, EventArgs e)
        {
            txtEvNo.Text = Ayarla.sınırlıSayıGir(txtEvNo.Text, 5);
        }

        private void txtKat_TextChanged(object sender, EventArgs e)
        {
            txtKat.Text = Ayarla.sınırlıSayıGir(txtKat.Text, 3);
        }

        private void txtDaireNo_TextChanged(object sender, EventArgs e)
        {
            txtDaireNo.Text = Ayarla.sınırlıSayıGir(txtDaireNo.Text, 4);
        }
        #endregion

        private void btnDeğiştir_Click(object sender, EventArgs e)
        {
            if (pictureBoxEV.ImageLocation == null)
            {
                return;
            }
            List.Remove(pictureBoxEV.ImageLocation);
            openFileDialog1.ShowDialog();
            if (List.Contains(openFileDialog1.FileName) || openFileDialog1.FileName == null)
            {
                return;
            }
            pictureBoxEV.ImageLocation = openFileDialog1.FileName;
            List.Add(pictureBoxEV.ImageLocation);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            List.Remove(pictureBoxEV.ImageLocation);
            pictureBoxEV.ImageLocation = null;
        }

        private void evAdresEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }
    }
}
