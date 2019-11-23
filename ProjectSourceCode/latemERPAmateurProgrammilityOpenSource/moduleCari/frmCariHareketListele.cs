using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latemERPAmateurProgrammilityOpenSource.moduleCari
{
    public partial class frmCariHareketListele : Form
    {
        Layers.Bussines.BussinesCari BussinesCari = new Layers.Bussines.BussinesCari();
        Layers.Data.dataConnector dataConnector = new Layers.Data.dataConnector();
        Layers.OtherClass.AllMessages AllMessages = new Layers.OtherClass.AllMessages();
        Layers.OtherClass.Logs Logs = new Layers.OtherClass.Logs();

        public frmCariHareketListele()
        {
            InitializeComponent();
        }

        public int cariID { get; set; }
        public string cariAdi { get; set; }

        public DateTime setBugun()
        {
            return DateTime.Now;
        }

        public string setFormCaption()
        {
            return "Cari Hareket Listesi - " + cariAdi;
        }

        private void frmCariHareketListele_Load(object sender, EventArgs e)
        {
            dateBirinciTarih.Value = setBugun();
            dateIkinciTarih.Value = setBugun();
            this.Text = setFormCaption();
            double ToplamTutar;
            BussinesCari.cariHareketListele(cariID, gridCariHareketler, out ToplamTutar);
            lblTitle.Text = cariAdi + " adlı cari hesabın toplam hareket tutarı: " + ToplamTutar.ToString() + " ₺'dir";
        }

        private void button1_Click(object sender, EventArgs e)
        {

               BussinesCari.cariHareketFiltrele(cariID, dateBirinciTarih.Value, dateIkinciTarih.Value, gridCariHareketler);
        }
    }
}
