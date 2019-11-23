using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace latemERPAmateurProgrammilityOpenSource.Layers.Bussines
{
    public class BussinesStok
    {
        OtherClass.AllMessages AllMessages = new OtherClass.AllMessages();
        Data.dataConnector dataConnector = new Data.dataConnector();

        public string stokKodu { get; set; }
        public string stokAdi { get; set; }
        public int stokUrunID { get; set; }
        public int stokMiktar { get; set; }

        public void StokEkle()
        {
            dataConnector.baglantiAc();
            SqlCommand sqlStok = dataConnector.setSQLCommand();
            sqlStok.CommandText = "INSERT INTO stoklar(stok_kodu, stok_adi, urun_id, stok_miktar) values(@stok_kodu, @stok_adi, @urun_id, @stok_miktar)";
            sqlStok.Parameters.Clear();
            sqlStok.Parameters.AddWithValue("stok_kodu", stokKodu);
            sqlStok.Parameters.AddWithValue("stok_adi", stokAdi);
            sqlStok.Parameters.AddWithValue("urun_id", stokUrunID);
            sqlStok.Parameters.AddWithValue("stok_miktar", stokMiktar);
            sqlStok.ExecuteNonQuery();
            dataConnector.baglantiKapat();
        }

        public void StokGuncelle(int paramStokID)
        {
            dataConnector.baglantiAc();
            SqlCommand sqlStok = dataConnector.setSQLCommand();
            sqlStok.CommandText = "UPDATE stoklar SET stok_kodu=@stok_kodu, stok_adi=@stok_adi, urun_id=@urun_id, stok_miktar=@stok_miktar WHERE id=@id";
            sqlStok.Parameters.Clear();
            sqlStok.Parameters.AddWithValue("id", paramStokID);
            sqlStok.Parameters.AddWithValue("stok_kodu", stokKodu);
            sqlStok.Parameters.AddWithValue("stok_adi", stokAdi);
            sqlStok.Parameters.AddWithValue("urun_id", stokUrunID);
            sqlStok.Parameters.AddWithValue("stok_miktar", stokMiktar);
            sqlStok.ExecuteNonQuery();
            dataConnector.baglantiKapat();
        }

        public void StokSil(int paramStokID)
        {
            dataConnector.baglantiAc();
            SqlCommand sqlStok = dataConnector.setSQLCommand();
            sqlStok.CommandText = "DELETE FROM stoklar WHERE id=@id";
            sqlStok.Parameters.Clear();
            sqlStok.Parameters.AddWithValue("id", paramStokID);
            sqlStok.ExecuteNonQuery();
            dataConnector.baglantiKapat();
        }

        public bool stokNoKontrol(string paramStokKodu)
        {
            dataConnector.baglantiAc();
            SqlCommand sqlSorgu = dataConnector.setSQLCommand();
            sqlSorgu.CommandText = "SELECT count(*) as kayitsayisi FROM stoklar where stok_kodu=@stok_kodu";
            sqlSorgu.Parameters.Clear();
            sqlSorgu.Parameters.AddWithValue("stok_kodu", paramStokKodu);
            int KayitSayisi = (int)sqlSorgu.ExecuteScalar();
            dataConnector.baglantiKapat();
            if (KayitSayisi == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool stokCikisKontrol(string paramStokID)
        {
            dataConnector.baglantiAc();
            SqlCommand sqlSorgu = dataConnector.setSQLCommand();
            sqlSorgu.CommandText = "SELECT stok_miktar FROM stoklar where id=@id";
            sqlSorgu.Parameters.Clear();
            sqlSorgu.Parameters.AddWithValue("id", paramStokID);
            int KayitSayisi = (int)sqlSorgu.ExecuteScalar();
            dataConnector.baglantiKapat();
            if (KayitSayisi == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public string stokHareketTuru { get; set; }
        public DateTime stokHareketZamani { get; set; }
        public int stokHareketStokID { get; set; }
        public double stokHareketMiktar { get; set; }

        public void StokHareketEkle()
        {
            dataConnector.baglantiAc();
            SqlCommand sqlStok = dataConnector.setSQLCommand();
            sqlStok.CommandText = "INSERT INTO stok_hareketleri(hareket_turu, hareket_zamani, hareket_stok_id," +
                " hareket_miktari) values(@hareket_turu, @hareket_zamani, @hareket_stok_id, @hareket_miktari)";
            sqlStok.Parameters.Clear();
            sqlStok.Parameters.AddWithValue("hareket_turu", stokHareketTuru);
            sqlStok.Parameters.AddWithValue("hareket_zamani", stokHareketZamani);
            sqlStok.Parameters.AddWithValue("hareket_stok_id", stokHareketStokID);
            sqlStok.Parameters.AddWithValue("hareket_stok_id", stokHareketMiktar);
            sqlStok.ExecuteNonQuery();
            dataConnector.baglantiKapat();
        }

        public void stokHareketSil(int stokHareketID)
        {
            dataConnector.baglantiAc();
            SqlCommand sqlStok = dataConnector.setSQLCommand();
            sqlStok.CommandText = "DELETE FROM stok_hareketleri WHERE id=@id";
            sqlStok.Parameters.Clear();
            sqlStok.Parameters.AddWithValue("id", stokHareketID);
            sqlStok.ExecuteNonQuery();
            dataConnector.baglantiKapat();
        }

    }

}
