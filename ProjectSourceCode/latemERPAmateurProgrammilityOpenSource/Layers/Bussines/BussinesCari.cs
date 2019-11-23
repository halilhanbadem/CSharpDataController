using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace latemERPAmateurProgrammilityOpenSource.Layers.Bussines
{
    public class BussinesCari
    {
        Data.dataConnector data = new Data.dataConnector();
        OtherClass.AllMessages msg = new OtherClass.AllMessages();
     

        public string cariNo { get; set; }
        public string cariAdiSoyadi { get; set; }
        public string cariUnvan { get; set; }
        public Int64 cariTCKimlik { get; set; }
        public string cariTelefon { get; set; }
        public string cariTelefon2 { get; set; }
        public string cariFax { get; set; }
        public string cariIl { get; set; }
        public string cariIlce { get; set; }
        public string cariVergiDairesi { get; set; }
        public Int64 cariVergiNumarasi { get; set; }
        public Int64 cariSicilNumarasi { get; set; }
        public string cariAdres { get; set; }
        public Int64 cariPostaKodu { get; set; }
        public string cariMail { get; set; }
        public string cariYetkiliAdi { get; set; }
        public string cariTuru { get; set; }
        public double cariBakiye { get; set; }
        public string cariBakiyeTuru { get; set; }


        public int x_cariKontrolID { get; set; }


        public void cariEkle()
        {
            data.baglantiAc();
            SqlCommand qryCari = data.setSQLCommand();
            qryCari.CommandText = "INSERT INTO cariler(cari_no, cari_adi_soyadi, cari_unvan, " +
                "cari_tc_kimlik, cari_telefon, cari_telefon2, cari_fax, cari_il, cari_ilce," +
                " cari_vergi_daire, cari_vergi_numarasi, cari_sicil_numarasi, cari_adres, " +
                "cari_posta_kodu, cari_mail, cari_yetkili_adi, cari_turu, cari_bakiye, cari_bakiye_turu)" +
                " values(@cari_no, @cari_adi_soyadi, @cari_unvan, @cari_tc_kimlik, @cari_telefon, " +
                "@cari_telefon2, @cari_fax, @cari_il, @cari_ilce, @cari_vergi_daire, @cari_vergi_numarasi, " +
                "@cari_sicil_numarasi, @cari_adres, @cari_posta_kodu, @cari_mail, @cari_yetkili_adi, @cari_turu," +
                " @cari_bakiye, @cari_bakiye_turu)";
            qryCari.Parameters.Clear();
            qryCari.Parameters.AddWithValue("cari_no", cariNo);
            qryCari.Parameters.AddWithValue("cari_adi_soyadi", cariAdiSoyadi);
            qryCari.Parameters.AddWithValue("cari_unvan", cariUnvan);
            qryCari.Parameters.AddWithValue("cari_tc_kimlik", cariTCKimlik);
            qryCari.Parameters.AddWithValue("cari_telefon", cariTelefon);
            qryCari.Parameters.AddWithValue("cari_telefon2", cariTelefon2);
            qryCari.Parameters.AddWithValue("cari_fax", cariFax);
            qryCari.Parameters.AddWithValue("cari_il", cariIl);
            qryCari.Parameters.AddWithValue("cari_ilce", cariIlce);
            qryCari.Parameters.AddWithValue("cari_vergi_daire", cariVergiDairesi);
            qryCari.Parameters.AddWithValue("cari_vergi_numarasi", cariVergiNumarasi);
            qryCari.Parameters.AddWithValue("cari_sicil_numarasi", cariSicilNumarasi);
            qryCari.Parameters.AddWithValue("cari_adres", cariAdres);
            qryCari.Parameters.AddWithValue("cari_posta_kodu", cariPostaKodu);
            qryCari.Parameters.AddWithValue("cari_mail", cariMail);
            qryCari.Parameters.AddWithValue("cari_yetkili_adi", cariYetkiliAdi);
            qryCari.Parameters.AddWithValue("cari_turu", cariTuru);
            qryCari.Parameters.AddWithValue("cari_bakiye", cariBakiye);
            qryCari.Parameters.AddWithValue("cari_bakiye_turu", cariBakiyeTuru);
            qryCari.ExecuteNonQuery();
                data.baglantiKapat();
                msg.BilgiMesaji("Cari kaydınız başarılı bir şekilde tamamlanmıştır!");
        }

        public void cariGuncelle(int cariIDParam)
        {
            data.baglantiAc();
            SqlCommand qryCari = data.setSQLCommand();
            qryCari.CommandText = "UPDATE cariler SET cari_no=@cari_no, cari_adi_soyadi=@cari_adi_soyadi, cari_unvan=@cari_unvan, " +
                "cari_tc_kimlik=@cari_tc_kimlik, cari_telefon=@cari_telefon, cari_telefon2=@cari_telefon2, " +
                "cari_fax=@cari_fax, cari_il=@cari_il, cari_ilce=@cari_ilce," +
                " cari_vergi_daire=@cari_vergi_daire, cari_vergi_numarasi=@cari_vergi_numarasi, cari_sicil_numarasi=@cari_sicil_numarasi, cari_adres=@cari_adres, " +
                "cari_posta_kodu=@cari_posta_kodu, cari_mail=@cari_mail, cari_yetkili_adi=@cari_yetkili_adi, cari_turu=@cari_turu, cari_bakiye=@cari_bakiye," +
                " cari_bakiye_turu=@cari_bakiye_turu WHERE id=@ID";
            qryCari.Parameters.Clear();
            qryCari.Parameters.AddWithValue("ID", cariIDParam);
            qryCari.Parameters.AddWithValue("cari_no", cariNo);
            qryCari.Parameters.AddWithValue("cari_adi_soyadi", cariAdiSoyadi);
            qryCari.Parameters.AddWithValue("cari_unvan", cariUnvan);
            qryCari.Parameters.AddWithValue("cari_tc_kimlik", cariTCKimlik);
            qryCari.Parameters.AddWithValue("cari_telefon", cariTelefon);
            qryCari.Parameters.AddWithValue("cari_telefon2", cariTelefon2);
            qryCari.Parameters.AddWithValue("cari_fax", cariFax);
            qryCari.Parameters.AddWithValue("cari_il", cariIl);
            qryCari.Parameters.AddWithValue("cari_ilce", cariIlce);
            qryCari.Parameters.AddWithValue("cari_vergi_daire", cariVergiDairesi);
            qryCari.Parameters.AddWithValue("cari_vergi_numarasi", cariVergiNumarasi);
            qryCari.Parameters.AddWithValue("cari_sicil_numarasi", cariSicilNumarasi);
            qryCari.Parameters.AddWithValue("cari_adres", cariAdres);
            qryCari.Parameters.AddWithValue("cari_posta_kodu", cariPostaKodu);
            qryCari.Parameters.AddWithValue("cari_mail", cariMail);
            qryCari.Parameters.AddWithValue("cari_yetkili_adi", cariYetkiliAdi);
            qryCari.Parameters.AddWithValue("cari_turu", cariTuru);
            qryCari.Parameters.AddWithValue("cari_bakiye", cariBakiye);
            qryCari.Parameters.AddWithValue("cari_bakiye_turu", cariBakiyeTuru);
            qryCari.ExecuteNonQuery();
            data.baglantiKapat();
            msg.BilgiMesaji("Cari kaydınız başarılı bir şekilde tamamlanmıştır!");
        }


        public void setCariBilgileri(int cariIDParam)
        {
            data.baglantiAc();
            SqlCommand sqlCari = data.setSQLCommand();
            sqlCari.CommandText = "SELECT * FROM cariler where id=@id";
            sqlCari.Parameters.Clear();
            sqlCari.Parameters.AddWithValue("id", cariIDParam);
            SqlDataReader sqlOku = sqlCari.ExecuteReader();
            sqlOku.Read();

            cariAdiSoyadi = sqlOku["cari_adi_soyadi"].ToString();
            cariNo = sqlOku["cari_no"].ToString();
            cariUnvan = sqlOku["cari_unvan"].ToString();
            cariTCKimlik = Convert.ToInt64(sqlOku["cari_tc_kimlik"].ToString());
            cariTelefon = sqlOku["cari_telefon"].ToString();
            cariTelefon2 = sqlOku["cari_telefon2"].ToString();
            cariFax = sqlOku["cari_fax"].ToString();
            cariIl = sqlOku["cari_il"].ToString();
            cariIlce = sqlOku["cari_ilce"].ToString(); 
            cariVergiDairesi = sqlOku["cari_vergi_daire"].ToString(); 
            cariVergiNumarasi = Convert.ToInt64(sqlOku["cari_vergi_numarasi"].ToString()); 
            cariSicilNumarasi = Convert.ToInt64(sqlOku["cari_sicil_numarasi"].ToString()); 
            cariAdres = sqlOku["cari_adres"].ToString(); 
            cariPostaKodu = Convert.ToInt64(sqlOku["cari_posta_kodu"].ToString()); 
            cariMail = sqlOku["cari_mail"].ToString();
            cariYetkiliAdi = sqlOku["cari_yetkili_adi"].ToString();
            cariTuru = sqlOku["cari_turu"].ToString();
            cariBakiye = Convert.ToDouble(sqlOku["cari_bakiye"].ToString());
            cariBakiyeTuru = sqlOku["cari_bakiye_turu"].ToString();
            data.baglantiKapat();
        }
       

        public bool TCKontrol(Int64 TCKimlik)
        {
            data.baglantiAc();
            SqlCommand sqlCari = data.setSQLCommand();
            sqlCari.CommandText = "SELECT * FROM cariler where cari_tc_kimlik=@tc_kimlik";
            sqlCari.Parameters.Clear();
            sqlCari.Parameters.AddWithValue("tc_kimlik", TCKimlik);
            SqlDataReader sqlOku = sqlCari.ExecuteReader();
            if (sqlOku.Read())
            { 
                x_cariKontrolID = Convert.ToInt32(sqlOku["id"].ToString());
                data.baglantiKapat();
                return true;
            } else
            {
                data.baglantiKapat();
                return false;
            }
        }

        public bool SicilKontrol(Int64 SicilNo)
        {
            data.baglantiAc();
            SqlCommand sqlCari = data.setSQLCommand();
            sqlCari.CommandText = "SELECT * FROM cariler where cari_sicil_numarasi=@sicil_no";
            sqlCari.Parameters.Clear();
            sqlCari.Parameters.AddWithValue("sicil_no", SicilNo);
            SqlDataReader sqlOku = sqlCari.ExecuteReader();
            if (sqlOku.Read())
            {
                x_cariKontrolID = Convert.ToInt32(sqlOku["id"].ToString());
                data.baglantiKapat();
                return true;
            }
            else
            {
                data.baglantiKapat();
                return false;
            }
        }

        public bool VergiNoKontrol(Int64 vergiNo)
        {
            data.baglantiAc();
            SqlCommand sqlCari = data.setSQLCommand();
            sqlCari.CommandText = "SELECT * FROM cariler where cari_vergi_numarasi=@vergi_no";
            sqlCari.Parameters.Clear();
            sqlCari.Parameters.AddWithValue("vergi_no", vergiNo);
            SqlDataReader sqlOku = sqlCari.ExecuteReader();
            if (sqlOku.Read())
            {
                x_cariKontrolID = Convert.ToInt32(sqlOku["id"].ToString());
                data.baglantiKapat();
                return true;
            }
            else
            {
                data.baglantiKapat();
                return false;
            }
        }

        public void cariSil(int paramCariID)
        {
            data.baglantiAc();
            SqlCommand sqlCari = data.setSQLCommand();
            sqlCari.CommandText = "DELETE FROM cariler where id=@id";
            sqlCari.Parameters.Clear();
            sqlCari.Parameters.AddWithValue("id", paramCariID);
            sqlCari.ExecuteNonQuery();
        }

        public void cariListele(DataGridView gridName)
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM cariler", data.getSQLconnect());
            DataTable cariTablo = new DataTable();
            sqlAdapter.Fill(cariTablo);
            gridName.DataSource = cariTablo;
            sqlAdapter.Dispose();
            data.baglantiKapat();
        }



        public int borclandirCariID { get; set; }
        public string borclandirAciklamasi { get; set; }
        public DateTime borclandirTarihi { get; set; }
        public string borclandirTipi { get; set; }
        public double borclandirTutari { get; set; }

        public void CariBorclandir()
        {
            data.baglantiAc();
            SqlCommand sqlCari = data.setSQLCommand();
            sqlCari.CommandText = "INSERT INTO cari_islemleri(cari_id, islem_aciklama, islem_tarihi, islem_tipi, islem_tutari)" +
                " Values(@cari_id, @islem_aciklama, @islem_tarihi, @islem_tipi, @islem_tutari)";
            sqlCari.Parameters.Clear();
            sqlCari.Parameters.AddWithValue("cari_id", borclandirCariID);
            sqlCari.Parameters.AddWithValue("islem_aciklama", borclandirAciklamasi);
            sqlCari.Parameters.AddWithValue("islem_tarihi", borclandirTarihi);
            sqlCari.Parameters.AddWithValue("islem_tipi", borclandirTipi);
            sqlCari.Parameters.AddWithValue("islem_tutari", borclandirTutari);
            sqlCari.ExecuteNonQuery();

            setCariBilgileri(borclandirCariID);

            data.baglantiAc();
            sqlCari.CommandText = "UPDATE cariler SET cari_bakiye=@bakiye WHERE id=@id";
            sqlCari.Parameters.Clear();

            double newBakiye;

            if (borclandirTipi == "BORÇLANDIR")
            {
                newBakiye = cariBakiye - borclandirTutari;
            } else
            {
                newBakiye = cariBakiye + borclandirTutari;
            }

            sqlCari.Parameters.AddWithValue("bakiye", newBakiye);
            sqlCari.Parameters.AddWithValue("id", borclandirCariID);
            sqlCari.ExecuteNonQuery();

            string durum;
            if (borclandirTipi == "BORÇLANDIR")
            {
                durum = "BORÇLANDIRILDI!";
            }
            else
            {
                durum = "ALACAKLANDIRILDI!";
            }
            data.baglantiKapat();
            msg.BilgiMesaji("Cari başarılı bir şekilde " + durum);
        }


        public void cariHareketListele(int paramCariID, DataGridView gridName, out double toplamTutar)
        {
            data.baglantiAc();
            SqlDataAdapter sqlliste = new SqlDataAdapter("SELECT * FROM cari_hareketler WHERE cari_id=" + paramCariID, data.getSQLconnect());
            DataTable tablo = new DataTable();
            sqlliste.Fill(tablo);
            gridName.DataSource = tablo;
            tablo.Dispose();
            data.baglantiKapat();

            data.baglantiAc();
            SqlCommand sqlToplam = data.setSQLCommand();
            sqlToplam.CommandText = "SELECT SUM(hareket_tutari) as TOPLAMTUTAR FROM cari_hareketler WHERE cari_id=" + paramCariID;
            SqlDataReader sqlReader = sqlToplam.ExecuteReader();

            if (sqlReader.Read())
            {
                string Deger = sqlReader["TOPLAMTUTAR"].ToString();
                if (Deger != "")
                {
                    toplamTutar = Convert.ToDouble(Deger);
                }
                else
                {
                    toplamTutar = 0;
                } 

            }
            else
            {
                toplamTutar = 0;
            }
        }

        public void cariBorclandirmaveAlacaklandirmaListele(int paramCariID, DataGridView gridName)
        {
            data.baglantiAc();
            SqlDataAdapter sqlListe = new SqlDataAdapter("SELECT * FROM cari_islemleri WHERE cari_id=" + paramCariID, data.getSQLconnect());
            DataTable tablo = new DataTable();
            sqlListe.Fill(tablo);
            gridName.DataSource = tablo;
            tablo.Dispose();
            data.baglantiKapat();
        }

        public void cariHareketFiltrele(int paramCariID, DateTime birinciTarih, DateTime ikinciTarih, DataGridView gridName)
        {
            data.baglantiAc();
            SqlDataAdapter sqlListe = new SqlDataAdapter("SELECT * FROM cari_hareketler WHERE " +
                "(hareket_tarihi BETWEEN '" + birinciTarih.Date + "' AND '" + ikinciTarih.Date + "') and cari_id="
                + paramCariID, data.getSQLconnect());
            DataTable tablo = new DataTable();
            sqlListe.Fill(tablo);
            gridName.DataSource = tablo;
            tablo.Dispose();
            data.baglantiKapat();
        }

    }
}
