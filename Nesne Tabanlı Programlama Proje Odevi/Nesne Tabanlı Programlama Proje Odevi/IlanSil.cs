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
    public partial class IlanSil : Form
    {
        public IlanSil()
        {
            InitializeComponent();
        }
        public void veri_Listele()
        {
            veriListeleme listeleme = new veriListeleme();
            DataSet ds = new DataSet();
            ds = listeleme.listeleMaileGore(Degisken.email);
            dataGridViewListele.DataSource = ds.Tables[0];
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("İlanı Silmek İstediğine Emin Misin?\n(Bu İşlem Geri Alınamaz)","İlan Silmeyi Onayla",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                evVeriTabanı ev = new evVeriTabanı();
                int seçilen = dataGridViewListele.SelectedCells[0].RowIndex;
                ev.evSil(dataGridViewListele.Rows[seçilen].Cells[0].Value.ToString());
                veri_Listele();
                MessageBox.Show("İlan Kaldırıldı...");
            }
            
        }
        private void IlanSil_Load(object sender, EventArgs e)
        {
            veri_Listele();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
        private void IlanSil_FormClosing(object sender, FormClosingEventArgs e)
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
