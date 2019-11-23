using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace latemERPAmateurProgrammilityOpenSource.Layers.Bussines
{
    public class BussinesUrun
    {
        OtherClass.AllMessages AllMessages = new OtherClass.AllMessages();
        Data.dataConnector dataConnector = new Data.dataConnector();

        public string urunAdi { get; set; }
        public string urunBirim { get; set; }
        public double urunBirimFiyat { get; set; }
        public int urunKDVOran { get; set; }
        public int urunOTVOran { get; set; }
        public int urunMTVOran { get; set; }
        public int urunTevfikatOran { get; set; }
        public string urunMensei { get; set; }
        public int urunBarkod { get; set; }
        public string urunAltAdi { get; set; }
        public string urunKategori { get; set; }

        public void urunEkle()
        {
            dataConnector.baglantiAc();
            SqlCommand sqlSorgu = dataConnector.setSQLCommand();
            sqlSorgu.CommandText = "INSERT INTO urunler(urun_adi, urun_birim, urun_birim_fiyat, " +
                "urun_kdv_oran, urun_otv_oran, urun_mtv_oran, urun_tevfikat_oran, urun_mensei, urun_barkod," +
                " urun_alt_adi, urun_kategori) values(@urun_adi, @urun_birim, @urun_birim_fiyat, @urun_kdv_oran," +
                " @urun_otv_oran, @urun_mtv_oran, @urun_tevfikat_oran, @urun_mensei, @urun_barkod, @urun_alt_adi, @urun_kategori)";
            sqlSorgu.Parameters.Clear();
            sqlSorgu.Parameters.AddWithValue("urun_adi", urunAdi);
            sqlSorgu.Parameters.AddWithValue("urun_birim", urunBirim);
            sqlSorgu.Parameters.AddWithValue("urun_birim_fiyat", urunBirimFiyat);
            sqlSorgu.Parameters.AddWithValue("urun_kdv_oran", urunKDVOran);
            sqlSorgu.Parameters.AddWithValue("urun_otv_oran", urunOTVOran);
            sqlSorgu.Parameters.AddWithValue("urun_mtv_oran", urunMTVOran);
            sqlSorgu.Parameters.AddWithValue("urun_tevfikat_oran", urunTevfikatOran);
            sqlSorgu.Parameters.AddWithValue("urun_mensei", urunMensei);
            sqlSorgu.Parameters.AddWithValue("urun_barkod", urunBarkod);
            sqlSorgu.Parameters.AddWithValue("urun_alt_adi", urunAltAdi);
            sqlSorgu.Parameters.AddWithValue("urun_kategori", urunKategori);
            sqlSorgu.ExecuteNonQuery();
            dataConnector.baglantiKapat();
        }

        public void urunGuncelle(int paramUrunID)
        {
            dataConnector.baglantiAc();
            SqlCommand sqlSorgu = dataConnector.setSQLCommand();
            sqlSorgu.CommandText = "UPDATE urunler SET urun_adi=@urun_adi, urun_birim=@urun_birim, urun_birim_fiyat=@urun_birim_fiyat, " +
                "urun_kdv_oran=@urun_kdv_oran, urun_otv_oran=@urun_otv_oran, urun_mtv_oran=@urun_mtv_oran, urun_tevfikat_oran=@urun_tevfikat_oran, urun_mensei=@urun_mensei, urun_barkod=@urun_barkod," +
                " urun_alt_adi=@urun_alt_adi, urun_kategori=@urun_kategori where id=@id";
            sqlSorgu.Parameters.Clear();
            sqlSorgu.Parameters.AddWithValue("id", paramUrunID);
            sqlSorgu.Parameters.AddWithValue("urun_adi", urunAdi);
            sqlSorgu.Parameters.AddWithValue("urun_birim", urunBirim);
            sqlSorgu.Parameters.AddWithValue("urun_birim_fiyat", urunBirimFiyat);
            sqlSorgu.Parameters.AddWithValue("urun_kdv_oran", urunKDVOran);
            sqlSorgu.Parameters.AddWithValue("urun_otv_oran", urunOTVOran);
            sqlSorgu.Parameters.AddWithValue("urun_mtv_oran", urunMTVOran);
            sqlSorgu.Parameters.AddWithValue("urun_tevfikat_oran", urunTevfikatOran);
            sqlSorgu.Parameters.AddWithValue("urun_mensei", urunMensei);
            sqlSorgu.Parameters.AddWithValue("urun_barkod", urunBarkod);
            sqlSorgu.Parameters.AddWithValue("urun_alt_adi", urunAltAdi);
            sqlSorgu.Parameters.AddWithValue("urun_kategori", urunKategori);
            sqlSorgu.ExecuteNonQuery();
        }

        public void urunSil(int paramUrunID)
        {
            dataConnector.baglantiAc();
            SqlCommand sqlSorgu = dataConnector.setSQLCommand();
            sqlSorgu.CommandText = "DELETE FROM urunler where id=@id";
            sqlSorgu.Parameters.Clear();
            sqlSorgu.Parameters.AddWithValue("id", paramUrunID);
            sqlSorgu.ExecuteNonQuery();
        }
    }
}
