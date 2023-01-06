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
    public partial class IlanlarıGöster : Form
    {
        public IlanlarıGöster()
        {
            InitializeComponent();
        }
        public static string id { get; set; }
        private void btnIlanSahibiGoster_Click(object sender, EventArgs e)
        {
            AnaSayfa sayfa = new AnaSayfa();
            AnaSayfa.mail = lblProfilEmail.Text;
            AnaSayfa.a = 2;
            sayfa.Show();
            this.Hide();
        }
        private void IlanlarıGöster_Load(object sender, EventArgs e)
        {
            kisiVeriCek veri = new kisiVeriCek();
            veri.mailCek(id);
            veri.kisiVeriCekMaileGore();
            lblProfilAdSoyad.Text = kisiVeriCek.list[0].ToString();
            lblProfilEmail.Text = kisiVeriCek.list[1].ToString();
            lblProfilTelNo.Text = kisiVeriCek.list[2].ToString();
            lblyas.Text = kisiVeriCek.list[3].ToString();
            pictureBox1.ImageLocation = kisiVeriCek.list[4].ToString();

        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
    }
}
