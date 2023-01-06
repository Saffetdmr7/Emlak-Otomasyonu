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

namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    public partial class evFoto : Form
    {
        public evFoto()
        {
            InitializeComponent();
        }
        evVeriCek evVeriCek = new evVeriCek();
        evFotoVeriTabanı evfotoEkle = new evFotoVeriTabanı();
        private static int i = 0;
        private void evFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkmak istediğine emin misin?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void evFoto_Load(object sender, EventArgs e)
        {
            fotoCek("");
        }
        public void fotoCek(string a)
        {
            if (a.Equals(""))
            {
                evVeriCek.evFotoVeriler.Clear();
                evVeriCek.evFotoCek(evDegisken.dataGridWiewSeçilen);
            }
            pctrbxSeçili.ImageLocation = evVeriCek.evFotoVeriler[0].ToString();
            if (evVeriCek.evFotoVeriler.Count == 2)
            {
                pctrbxSonraki.ImageLocation = evVeriCek.evFotoVeriler[1].ToString();
            }
            else if (evVeriCek.evFotoVeriler.Count > 2)
            {
                pctrbxSonraki.ImageLocation = evVeriCek.evFotoVeriler[1].ToString();
                pctrbxÖnceki.ImageLocation = evVeriCek.evFotoVeriler[evVeriCek.evFotoVeriler.Count-1].ToString();
            }
        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            evfotoEkle.fotoSil(evDegisken.dataGridWiewSeçilen);
            evfotoEkle.fotoEkle(evDegisken.dataGridWiewSeçilen,evVeriCek.evFotoVeriler);
            AnaSayfa ana = new AnaSayfa();
            AnaSayfa.a = 0;
            ana.Show();
            this.Hide();
        }
        #region katalog
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (evVeriCek.evFotoVeriler.Count == 1)
            {
                pctrbxSeçili.ImageLocation = evVeriCek.evFotoVeriler[0].ToString();
                pctrbxSonraki.ImageLocation = null;
                pctrbxÖnceki.ImageLocation = null;
                return;
            }
            if (i == evVeriCek.evFotoVeriler.Count) { i = -1; }
            i++;
            if (i >= evVeriCek.evFotoVeriler.Count)
            {
                i = 0;
            }
            if (i == 0)
            {
                pctrbxÖnceki.ImageLocation = evVeriCek.evFotoVeriler[evVeriCek.evFotoVeriler.Count - 1].ToString();
            }
            else
            {
                pctrbxÖnceki.ImageLocation = pctrbxSeçili.ImageLocation;
            }
            if (i == evVeriCek.evFotoVeriler.Count - 1)
            {
                pctrbxSonraki.ImageLocation = evVeriCek.evFotoVeriler[0].ToString();
            }
            else
            {
                pctrbxSonraki.ImageLocation = evVeriCek.evFotoVeriler[i + 1].ToString();
            }
            pctrbxSeçili.ImageLocation = evVeriCek.evFotoVeriler[i].ToString();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (evVeriCek.evFotoVeriler.Count == 1)
            {
                pctrbxSeçili.ImageLocation = evVeriCek.evFotoVeriler[0].ToString();
                pctrbxSonraki.ImageLocation = null;
                pctrbxÖnceki.ImageLocation = null;
                return;
            }
            if (i <= 0) { i = evVeriCek.evFotoVeriler.Count; }
            i--;
            if (i >= evVeriCek.evFotoVeriler.Count)
            {
                i = evVeriCek.evFotoVeriler.Count - 1;
            }
            if (i == 0)
            {
                pctrbxÖnceki.ImageLocation = evVeriCek.evFotoVeriler[evVeriCek.evFotoVeriler.Count - 1].ToString();
            }
            else
            {
                pctrbxÖnceki.ImageLocation = pctrbxSeçili.ImageLocation = evVeriCek.evFotoVeriler[i - 1].ToString();
            }
            if (i == evVeriCek.evFotoVeriler.Count - 1)
            {
                pctrbxSonraki.ImageLocation = evVeriCek.evFotoVeriler[0].ToString();
            }
            else
            {
                pctrbxSonraki.ImageLocation = pctrbxSeçili.ImageLocation;
            }
            pctrbxSeçili.ImageLocation = evVeriCek.evFotoVeriler[i].ToString();
        }
        #endregion
        DialogResult result;
        private void btnFotoGüncelle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == null)
            {
                MessageBox.Show("Önce Görsel Seçiniz.");
                return;
            }
            foreach (string item in evVeriCek.evFotoVeriler)
            {
                if (item == openFileDialog1.FileName)
                {
                    MessageBox.Show("Bu Görsel Zaten Mevcut");
                    return;
                }
            }
            
            result = MessageBox.Show("İşlemi Onaylıor Musunuz?","",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                evVeriCek.evFotoVeriler.RemoveAt(i);
                evVeriCek.evFotoVeriler.Insert(i, openFileDialog1.FileName);
                pctrbxSeçili.ImageLocation = evVeriCek.evFotoVeriler[i].ToString();
            }
        }
        private void btnFotoSil_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("İşlemi Onaylıor Musunuz?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (evVeriCek.evFotoVeriler.Count == 1)
                {
                    MessageBox.Show("İlanınızda en az 1 tane görsel olması gerekiyor.");
                }
                else
                {
                    evVeriCek.evFotoVeriler.RemoveAt(i);
                    fotoCek("a");
                }
                if (evVeriCek.evFotoVeriler.Count == 1)
                {
                    pctrbxSeçili.ImageLocation = evVeriCek.evFotoVeriler[0].ToString();
                    pctrbxSonraki.ImageLocation = null;
                    pctrbxÖnceki.ImageLocation = null;
                    return;
                }

            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (evVeriCek.evFotoVeriler.Count == 10)
            {
                MessageBox.Show("Daha fazla görsel ekleyemezsin\nSilmeyi dene");
                return;
            }
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == null)
            {
                MessageBox.Show("Bir görsel seçiniz");
                return;
            }
            foreach (string item in evVeriCek.evFotoVeriler)
            {
                if (item == openFileDialog1.FileName)
                {
                    MessageBox.Show("Bu görseli daha önce eklediniz");
                    return;
                }
            }
            evVeriCek.evFotoVeriler.Add(openFileDialog1.FileName);
            fotoCek("a");
            if (evVeriCek.evFotoVeriler.Count == 10)
            {
                pctrbxSonraki.ImageLocation = openFileDialog1.FileName;
                pctrbxSeçili.ImageLocation = evVeriCek.evFotoVeriler[9].ToString();
                pctrbxÖnceki.ImageLocation = evVeriCek.evFotoVeriler[8].ToString();
                return;
            }
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            ilanGüncelle güncelle = new ilanGüncelle();
            güncelle.Show();
            this.Hide();
        }
    }
}
