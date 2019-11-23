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
    public partial class frmCariHesapAddUpdate : Form
    {
        Layers.Bussines.BussinesCari CariIslemler = new Layers.Bussines.BussinesCari();
        Layers.OtherClass.AllMessages Msg = new Layers.OtherClass.AllMessages();
        Layers.OtherClass.Logs Log = new Layers.OtherClass.Logs();

        public int islemTuru { get; set; }
        public int islemID { get; set; }

        public frmCariHesapAddUpdate()
        {
            InitializeComponent();
        }

        public void modGuncelle()
        {
            btnTamamla.Text = "Cari Kaydını Güncelle";
            btnTamamla.ImageIndex = 2;

            CariIslemler.setCariBilgileri(islemID);
            txtAdres.Text = CariIslemler.cariAdres;
            txtBakiye.Text = CariIslemler.cariBakiye.ToString();
            txtCariAdiSoyadi.Text = CariIslemler.cariAdiSoyadi;
            txtCariNo.Text = CariIslemler.cariNo;
            txtCariUnvan.Text = CariIslemler.cariUnvan;
            txtCariYetkliAdi.Text = CariIslemler.cariYetkiliAdi;
            txtFax.Text = CariIslemler.cariFax;
            txtIlce.Text = CariIslemler.cariIlce;
            txtMail.Text = CariIslemler.cariMail;
            txtPostaKodu.Text = CariIslemler.cariPostaKodu.ToString();
            txtSicilNo.Text = CariIslemler.cariSicilNumarasi.ToString();
            txtTCKimlik.Text = CariIslemler.cariTCKimlik.ToString();
            txtTelefon.Text = CariIslemler.cariTelefon;
            txtTelefon2.Text = CariIslemler.cariTelefon2;
            txtVergiDairesi.Text = CariIslemler.cariVergiDairesi;
            txtVergiNo.Text = CariIslemler.cariVergiNumarasi.ToString();
            cmbIl.Text = CariIslemler.cariIl;
            cmbBakiyeTuru.Text = CariIslemler.cariBakiyeTuru;
            cmbTuru.Text = CariIslemler.cariTuru;
        }

        public void modEkle()
        {
            btnTamamla.Text = "Cari Kaydını Tamamla";
            btnTamamla.ImageIndex = 0;
        }

        public List<String> bosAlanTespit()
        {
            List<string> BosAlanlar = new List<string>();

            if (txtAdres.Text.Length == 0)
            {
                BosAlanlar.Add("Cari Adres Alanı");
            }

            if (txtTCKimlik.Text.Length == 0)
            {
                BosAlanlar.Add("Cari T.C. Kimlik Alanı");
            }

            if (txtCariAdiSoyadi.Text.Length == 0)
            {
                BosAlanlar.Add("Cari Adı Soyadı Alanı");
            }

            if (txtCariUnvan.Text.Length == 0)
            {
                BosAlanlar.Add("Cari Unvan Alanı");
            }

            if (txtTelefon.Text.Length == 0)
            {
                BosAlanlar.Add("Cari Telefon Alanı");
            }

            if (txtVergiNo.Text.Length == 0)
            {
                BosAlanlar.Add("Cari Vergi No Alanı");
            }

            if (txtSicilNo.Text.Length == 0)
            {
                BosAlanlar.Add("Cari Sicil No Alanı");
            }

            if (txtPostaKodu.Text.Length == 0)
            {
                BosAlanlar.Add("Cari Posta Kodu Alanı");
            }

            return BosAlanlar;
        }

        public bool bosAlanKontrol()
        {
            if (bosAlanTespit().Count == 0)
            {
                return true;
            } else

                return false;
        }


        public void ekranTemizle()
        {
            txtAdres.Clear();
            txtBakiye.Clear();
            txtCariAdiSoyadi.Clear();
            txtCariNo.Clear();
            txtCariUnvan.Clear();
            txtCariYetkliAdi.Clear();
            txtFax.Clear();
            txtIlce.Clear();
            txtMail.Clear();
            txtPostaKodu.Clear();
            txtSicilNo.Clear();
            txtTCKimlik.Clear();
            txtTelefon.Clear();
            txtTelefon2.Clear();
            txtVergiDairesi.Clear();
            txtVergiNo.Clear();
            cmbBakiyeTuru.SelectedItem = 0;
            cmbIl.SelectedItem = 0;
            cmbTuru.SelectedItem = 0;
        }

   
        public void cariIslemiGerceklestir()
        {
            try
            {
                CariIslemler.cariNo = txtCariNo.Text;
                CariIslemler.cariAdiSoyadi = txtCariAdiSoyadi.Text;
                CariIslemler.cariUnvan = txtCariUnvan.Text;
                CariIslemler.cariTCKimlik = Convert.ToInt64(txtTCKimlik.Text);
                CariIslemler.cariTelefon = txtTelefon.Text;
                CariIslemler.cariTelefon2 = txtTelefon2.Text;
                CariIslemler.cariFax = txtFax.Text;
                CariIslemler.cariIl = cmbIl.Text;
                CariIslemler.cariIlce = txtIlce.Text;
                CariIslemler.cariVergiDairesi = txtVergiDairesi.Text;
                CariIslemler.cariVergiNumarasi = Convert.ToInt64(txtVergiNo.Text);
                CariIslemler.cariSicilNumarasi = Convert.ToInt64(txtSicilNo.Text);
                CariIslemler.cariPostaKodu = Convert.ToInt64(txtPostaKodu.Text);
                CariIslemler.cariMail = txtMail.Text;
                CariIslemler.cariAdres = txtAdres.Text;
                CariIslemler.cariPostaKodu = Convert.ToInt64(txtPostaKodu.Text);
                CariIslemler.cariYetkiliAdi = txtCariYetkliAdi.Text;
                CariIslemler.cariTuru = cmbTuru.Text;
                CariIslemler.cariBakiye = Convert.ToDouble(txtBakiye.Text);
                CariIslemler.cariBakiyeTuru = cmbBakiyeTuru.Text;
                if (islemTuru == 1)
                {
                    CariIslemler.cariGuncelle(islemID);
                }
                else
                {
                    CariIslemler.cariEkle();
                }
                ekranTemizle();
                frmCariListele frmCariListele = (frmCariListele)Application.OpenForms["frmCariListele"];
                frmCariListele.gridRefresh();
                this.Close();
            }
            catch (Exception hata)
            {
                Log.logla(hata.Message, this.Name);
                Msg.HataMesaji("Cari kaydı gerçekleşirken bir hata oluştu! Lütfen log kayıtlarına göz atınız.");
            }
        }


        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (bosAlanKontrol() == false)
            {
                Msg.UyariMesaji("Boş alanlar mevcut! Sırasıyla: \n \n" + string.Join("\n", bosAlanTespit().ToArray()));
            }
            else
            {

                if (islemTuru == 1)
                {
                    bool donenDeger;
                    donenDeger = CariIslemler.TCKontrol(Convert.ToInt64(txtTCKimlik.Text));
                    if (CariIslemler.x_cariKontrolID == islemID || donenDeger == false)
                    {
                        donenDeger = CariIslemler.SicilKontrol(Convert.ToInt64(txtSicilNo.Text));
                        if (CariIslemler.x_cariKontrolID == islemID || donenDeger == false)
                        {
                            donenDeger = CariIslemler.VergiNoKontrol(Convert.ToInt64(txtVergiNo.Text));
                            if (CariIslemler.x_cariKontrolID == islemID || donenDeger == false)
                            {
                                cariIslemiGerceklestir();
                            }
                            else
                            {
                                Msg.UyariMesaji("Aynı vergi numarasına ait bir cari kayıt zaten mevcut!");
                            }
                        }
                        else
                        {
                            Msg.UyariMesaji("Aynı sicil numarasına ait bir cari kayıt zaten mevcut!");
                        }
                    }
                    else
                    {
                        Msg.UyariMesaji("Aynı T.C. Kimlik numarasına ait bir cari kayıt zaten mevcut!");
                    }
                }
                else
                {
                    if (CariIslemler.TCKontrol(Convert.ToInt64(txtTCKimlik.Text)) == false)
                    {
                        if (CariIslemler.SicilKontrol(Convert.ToInt64(txtSicilNo.Text)) == false)
                        {
                            if (CariIslemler.VergiNoKontrol(Convert.ToInt64(txtVergiNo.Text)) == false)
                            {
                                cariIslemiGerceklestir();
                            }
                            else
                            {
                                Msg.UyariMesaji("Aynı vergi numarasına ait bir cari kayıt zaten mevcut!");
                            }
                        }
                        else
                        {
                            Msg.UyariMesaji("Aynı sicil numarasına ait bir cari kayıt zaten mevcut!");
                        }
                    }
                    else
                    {
                        Msg.UyariMesaji("Aynı T.C. Kimlik numarasına ait bir cari kayıt zaten mevcut!");
                    }
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (Msg.SoruMesaji("Ekranı temizlemek istediğinize emin misiniz?"))
            { 
              ekranTemizle();
            }
        }

        private void frmCariHesapEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            ekranTemizle();
        }

        private void frmCariHesapAddUpdate_Load(object sender, EventArgs e)
        {
            if (islemTuru == 1)
            {
                modGuncelle();
            } else
            {
                ekranTemizle();
                modEkle();
            }
        }
    }
}
