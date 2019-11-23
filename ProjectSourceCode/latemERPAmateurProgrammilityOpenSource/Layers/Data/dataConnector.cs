using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace latemERPAmateurProgrammilityOpenSource.Layers.Data
{
    public class dataConnector
    {
        OtherClass.getInformationText infoini = new OtherClass.getInformationText();
        static SqlConnection baglanti = new SqlConnection();
        

        public void baglantiAc()
        {
            infoini.iniInfoRefresh();
            
            string ConnectionString;
            if (infoini.loginMethod == "U") ///U username ile giriş; W windows ile giriş
            {
                 ConnectionString = @"Data Source=" + infoini.serverName + "; Initial Catalog=" + infoini.dataName + "; User Id=" + infoini.userName + "; Password=" + infoini.userPass;
            }
            else
            {
                 ConnectionString = @"Data Source=" + infoini.serverName + "; Initial Catalog=" + infoini.dataName + "; Integrated Security= SSPI";
            }

            if (baglanti.State == ConnectionState.Open)
            {
                baglantiKapat();
            }
            baglanti.ConnectionString = ConnectionString;
            baglanti.Open();
        }

        public void baglantiKapat()
        {
            baglanti.Close();
        }


        public SqlCommand setSQLCommand()
        { 
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = baglanti;
            return sqlCommand;
        }

        public SqlConnection getSQLconnect()
        {
            baglantiAc();
            return baglanti;
        }

    }
}
