using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latemERPAmateurProgrammilityOpenSource
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void işlemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cariRaporlamalarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void yeniCariKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moduleCari.frmCariHesapAddUpdate frmCariHesapEkle = new moduleCari.frmCariHesapAddUpdate();
            frmCariHesapEkle.Show();
        }

        private void cariKayıtlarınıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moduleCari.frmCariListele frmCariListele = new moduleCari.frmCariListele();
            frmCariListele.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void stokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moduleStok.frmStokBilgisiEkle frmStokBilgiEkle = new moduleStok.frmStokBilgisiEkle();
            frmStokBilgiEkle.Show();
        }

        private void stokGirişÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moduleStok.frmStokListesi frmStokListe = new moduleStok.frmStokListesi();
            frmStokListe.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
