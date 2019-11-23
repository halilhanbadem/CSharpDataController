using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace latemERPAmateurProgrammilityOpenSource.moduleCari
{
    public partial class frmCariListele : Form
    {
        Layers.Bussines.BussinesCari cariIslemler = new Layers.Bussines.BussinesCari();
        Layers.Data.dataConnector dataConnector = new Layers.Data.dataConnector();
        Layers.OtherClass.AllMessages allMessages = new Layers.OtherClass.AllMessages();


        public frmCariListele()
        {
            InitializeComponent();
        }

        private void frmCariListele_Load(object sender, EventArgs e)
        {
            cariIslemler.cariListele(gridCariler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCariHesapAddUpdate frmCariHesapEkle = new frmCariHesapAddUpdate();
            frmCariHesapEkle.islemTuru = 0;
            frmCariHesapEkle.ShowDialog();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            dataConnector.baglantiAc();
            SqlDataAdapter sqlFiltre = new SqlDataAdapter("SELECT * FROM cariler WHERE " +
                "cari_adi_soyadi like '%" + txtFiltrele.Text + "%' or cari_unvan like '%" +
                txtFiltrele.Text + "%' or cari_il like '%" + txtFiltrele.Text + "%'", 
                dataConnector.getSQLconnect());
            DataTable filtreTablo = new DataTable();
            sqlFiltre.Fill(filtreTablo);
            gridCariler.DataSource = filtreTablo;
            filtreTablo.Dispose();
            dataConnector.baglantiKapat();
        }

        public void gridRefresh()
        {
            cariIslemler.cariListele(gridCariler);
        }

        private void btnCariGuncelle_Click(object sender, EventArgs e)
        {
            frmCariHesapAddUpdate frmCariHesapAddUpdate = new frmCariHesapAddUpdate();
            frmCariHesapAddUpdate.islemTuru = 1;
            frmCariHesapAddUpdate.islemID = Convert.ToInt32(gridCariler.Rows[gridCariler.CurrentRow.Index].Cells["id"].Value.ToString());
            frmCariHesapAddUpdate.ShowDialog();
        }

        private void btnCariSil_Click(object sender, EventArgs e)
        {
            if (allMessages.SoruMesaji("Bu cari kaydını silmek istediğinize emin misiniz? Cari kaydı silindiğinde tüm kayıtlı hareketleri, satışları ve faturaları silinecektir. Bu riski göze alarak lütfen karar veriniz!"))
            {
                cariIslemler.cariSil(Convert.ToInt32(gridCariler.Rows[gridCariler.CurrentRow.Index].Cells["id"].Value.ToString()));
                gridRefresh();
            }
        }

        private void btnBorclandir_Click(object sender, EventArgs e)
        {
            frmCariBorclandir frmCariBorclandir = new frmCariBorclandir();
            frmCariBorclandir.cariID = Convert.ToInt32(gridCariler.Rows[gridCariler.CurrentRow.Index].Cells["id"].Value.ToString());
            frmCariBorclandir.cariAdi = gridCariler.Rows[gridCariler.CurrentRow.Index].Cells["cari_unvan"].Value.ToString();
            frmCariBorclandir.ShowDialog();    
        }

        private void btnCariHareket_Click(object sender, EventArgs e)
        {
            frmCariHareketListele frmCariHareketListele = new frmCariHareketListele();
            frmCariHareketListele.cariID = Convert.ToInt32(gridCariler.Rows[gridCariler.CurrentRow.Index].Cells["id"].Value.ToString());
            frmCariHareketListele.cariAdi = gridCariler.Rows[gridCariler.CurrentRow.Index].Cells["cari_unvan"].Value.ToString();
            frmCariHareketListele.ShowDialog();
        }
    }
}
