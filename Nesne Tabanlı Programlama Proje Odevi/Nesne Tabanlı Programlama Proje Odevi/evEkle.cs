using System;
using System.Collections;
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
    public partial class evEkle : Form
    {
        public evEkle()
        {
            InitializeComponent();
        }
        private static String ev_Tasıyıcı = "";
        private void btnEvAdresiEkle_Click(object sender, EventArgs e)
        {
            byte index = 7;
            String[] dizi = {cmbxOdaSayısı.Text,txtMetreKare.Text,txtKiralikFiyat.Text,
            txtSatilikFiyat.Text,cmbxIsinmaTuru.Text,cmbxEsyaliMi.Text,cmbxBinaTipi.Text};
            foreach (String item in dizi)
            {
                if (item.Equals(""))
                {
                    index = (byte)Array.IndexOf(dizi,item);
                    break;
                }
            }
            if (index == 7)
            {
                ev_Tasıyıcı = cmbxOdaSayısı.Text;
                evDegisken.ev_Degisken_Ata(cmbxOdaSayısı.Text,txtMetreKare.Text
                    ,txtKiralikFiyat.Text,txtSatilikFiyat.Text
                    ,cmbxIsinmaTuru.Text,cmbxEsyaliMi.Text
                    ,cmbxBinaTipi.Text);
                evAdresEkle evAdres = new evAdresEkle();
                evAdres.Show();
                this.Hide();
            }
            switch (index)
            {
                case 0:
                    MessageBox.Show("Oda sayısını giriniz");
                    break;
                case 1:
                    MessageBox.Show("Metrekareyi giriniz");
                    break;
                case 2:
                    MessageBox.Show("Kiralik fiyatını giriniz");
                    break;
                case 3:
                    MessageBox.Show("Satılık fiyatını  giriniz");
                    break;
                case 4:
                    MessageBox.Show("Isınma türünü giriniz");
                    break;
                case 5:
                    MessageBox.Show("Eşyalı / Eşyasız belirtiniz");
                    break;
                case 6:
                    MessageBox.Show("Bina türü giriniz");
                    break;
            }
        }
        private void evEkle_Load(object sender, EventArgs e)
        {
            if (!(ev_Tasıyıcı.Equals("")))
            {
                cmbxOdaSayısı.Text = evDegisken.odaSayisi;
                cmbxIsinmaTuru.Text = evDegisken.isitmaTuru;
                cmbxEsyaliMi.Text = evDegisken.esyali;
                cmbxBinaTipi.Text = evDegisken.binaTuru;
                txtKiralikFiyat.Text = evDegisken.kiraFiyat;
                txtSatilikFiyat.Text = evDegisken.satisFiyat;
                txtMetreKare.Text = evDegisken.mKare;
            }
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void evEkle_FormClosing(object sender, FormClosingEventArgs e)
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
