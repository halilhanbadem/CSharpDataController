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
    public partial class frmCariBorclandir : Form
    {
        public frmCariBorclandir()
        {
            InitializeComponent();
        }

        public string cariAdi { get; set; }
        public int cariID { get; set; }

        Layers.OtherClass.AllMessages AllMessages = new Layers.OtherClass.AllMessages();
        Layers.OtherClass.Logs Logs = new Layers.OtherClass.Logs();
        Layers.Data.dataConnector dataConnector = new Layers.Data.dataConnector();
        Layers.Bussines.BussinesCari cariIslemleri = new Layers.Bussines.BussinesCari();
        
        public DateTime setBugun()
        {
            return DateTime.Now;
        }

        public string setFormCaption()
        {
            return "Cari Borçlandır/Alacaklandır -> " + cariAdi;
        }

        
        
        private void frmCariBorclandir_Load(object sender, EventArgs e)
        {
            dateIslemTarihi.Value = setBugun();
            this.Text = setFormCaption();
            ekraniTemizle();
        }

        public void ekraniTemizle()
        {
            edtMiktar.Value = 0;
            memAdres.Clear();
            dateIslemTarihi.Value = setBugun();
            cmbIslemTipi.SelectedIndex = 0;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ekraniTemizle();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (cmbIslemTipi.SelectedIndex == -1)
            {
                AllMessages.UyariMesaji("İşlem tipi seçmediniz. Lütfen işlem tipi seçiniz!");
            }
            else
            {
                if (edtMiktar.Value <= 0)
                {
                    AllMessages.UyariMesaji("Lütfen 0'dan büyük bir miktar giriniz!");
                }
                else
                {
                    try
                    {
                        cariIslemleri.borclandirAciklamasi = memAdres.Text;
                        cariIslemleri.borclandirTarihi = dateIslemTarihi.Value;
                        cariIslemleri.borclandirTipi = cmbIslemTipi.Text;
                        cariIslemleri.borclandirTutari = Convert.ToDouble(edtMiktar.Value);
                        cariIslemleri.borclandirCariID = cariID;
                        cariIslemleri.CariBorclandir();
                        ekraniTemizle();
                        frmCariListele frmCariListele = (frmCariListele)Application.OpenForms["frmCariListele"];
                        frmCariListele.gridRefresh();
                        this.Close();

                    }
                    catch (Exception hata)
                    {
                        dataConnector.baglantiKapat();
                        Logs.logla(hata.Message, this.Name);
                        AllMessages.HataMesaji("Cari " + cmbIslemTipi.Text + " işleminiz gerçekleşirken hata oluştu! Log kayıtlarına bakınız.");
                    }
                }
            }
        }
    }
}
