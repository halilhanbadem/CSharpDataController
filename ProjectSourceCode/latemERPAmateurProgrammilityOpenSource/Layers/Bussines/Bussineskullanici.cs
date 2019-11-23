using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace latemERPAmateurProgrammilityOpenSource.Layers.Bussines
{
    public class BussinesKullanici
    {
        static Data.dataConnector dataConnector = new Data.dataConnector();
        static SqlCommand sqlQuery = dataConnector.setSQLCommand();
        static OtherClass.AllMessages ShowMesaj = new OtherClass.AllMessages();

        public string userName { get; set; }
        public string userPassword { get; set; }
        public int userID { get; set; }
        public string userAdiSoyadi { get; set; }
        public string userMail { get; set; }
        public int userYetkiID { get; set; }

        //güncelleme, kayıt işlemlerinde varsayılan tanımlamaların set değeri değişmemesi için oluşturuldu.
        public string OUserName { get; set; }
        public string OUserPassword { get; set; }
        public string OUserAdiSoyadi { get; set; }
        public string OUserMail { get; set; }
        public int OUserYetkiID { get; set; }

        public void updateUserInfo(int userIDparam)
        {
            dataConnector.baglantiAc();
            sqlQuery.CommandText = "SELECT * FROM kullanicilar WHERE id=@ID";
            sqlQuery.Parameters.Clear();
            sqlQuery.Parameters.AddWithValue("ID", userIDparam);
            SqlDataReader sqlReader = sqlQuery.ExecuteReader();
             if (sqlReader.Read())
            {
                userName = sqlReader["kullaniciadi"].ToString();
                userPassword = sqlReader["sifre"].ToString();
                userAdiSoyadi = sqlReader["adisoyadi"].ToString();
                userMail = sqlReader["mail"].ToString();
                userYetkiID = Convert.ToInt32(sqlReader["yetki_id"].ToString());
                userID = Convert.ToInt32(sqlReader["id"].ToString());
            };
            dataConnector.baglantiKapat();
        }

        public bool userCheck(string userNameparam, string userPasswordparam)
        {
            dataConnector.baglantiAc();
            sqlQuery.CommandText = "SELECT * FROM kullanicilar WHERE kullaniciadi=@kullaniciadi AND sifre=@sifre";
            sqlQuery.Parameters.Clear();
            sqlQuery.Parameters.AddWithValue("kullaniciadi", userNameparam);
            sqlQuery.Parameters.AddWithValue("sifre", userPasswordparam);
            SqlDataReader sqlReader = sqlQuery.ExecuteReader();
            if (sqlReader.Read())
            {
                updateUserInfo(Convert.ToInt32(sqlReader["id"].ToString()));
                dataConnector.baglantiKapat();
                return true;
            }
            else
            {
                dataConnector.baglantiKapat();
                return false;
            }
        }


        public bool userDelete(string userIDParam)
        {
           try {  
            dataConnector.baglantiAc();
            sqlQuery.CommandText = "DELETE FROM kullanicilar where id=@ID";
            sqlQuery.Parameters.Clear();
            sqlQuery.Parameters.AddWithValue("ID", userIDParam);
            sqlQuery.ExecuteNonQuery();
            dataConnector.baglantiKapat();
                return true;
            } catch (Exception hataMesaj)
            {
                dataConnector.baglantiKapat();
                ShowMesaj.HataMesaji(hataMesaj.Message);
                return false;
            }
        }

        public bool userUpdate(string userIDParam)
        {
            try
            {
                dataConnector.baglantiAc();
                sqlQuery.CommandText = "UPDATE kullanicilar SET kullaniciadi=@kullaniciadi, adisoyadi=@adisoyadi, sifre=@sifre, mail=@mail, yetki_id=@yetki_id  where id=@ID";
                sqlQuery.Parameters.Clear();
                sqlQuery.Parameters.AddWithValue("ID", userIDParam);
                sqlQuery.Parameters.AddWithValue("kullaniciadi", OUserName);
                sqlQuery.Parameters.AddWithValue("adisoyadi", OUserAdiSoyadi);
                sqlQuery.Parameters.AddWithValue("sifre", OUserPassword);
                sqlQuery.Parameters.AddWithValue("mail", OUserMail);
                sqlQuery.Parameters.AddWithValue("yetki_id", OUserYetkiID);
                sqlQuery.ExecuteNonQuery();
                dataConnector.baglantiKapat();
                return true;
            }
            catch (Exception hataMesaj)
            {
                dataConnector.baglantiKapat();
                ShowMesaj.HataMesaji(hataMesaj.Message);
                return false;
            }
        }


        public bool userInsert()
        {
            try
            {
                dataConnector.baglantiAc();
                sqlQuery.CommandText = "INSERT INTO kullanicilar(kullaniciadi, adisoyadi, sifre, mail, yetki_id) VALUES(@kullaniciadi, @adisoyadi, @sifre, @mail, @yetki_id)";
                sqlQuery.Parameters.Clear();
                sqlQuery.Parameters.AddWithValue("kullaniciadi", OUserName);
                sqlQuery.Parameters.AddWithValue("adisoyadi", OUserAdiSoyadi);
                sqlQuery.Parameters.AddWithValue("sifre", OUserPassword);
                sqlQuery.Parameters.AddWithValue("mail", OUserMail);
                sqlQuery.Parameters.AddWithValue("yetki_id", OUserYetkiID);
                sqlQuery.ExecuteNonQuery();
                dataConnector.baglantiKapat();
                return true;
            }
            catch (Exception hataMesaj)
            {
                dataConnector.baglantiKapat();
                ShowMesaj.HataMesaji(hataMesaj.Message);
                return false;
            }

        }


    }
}
