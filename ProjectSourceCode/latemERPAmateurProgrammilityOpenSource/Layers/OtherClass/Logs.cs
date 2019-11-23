using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace latemERPAmateurProgrammilityOpenSource.Layers.OtherClass
{
    public class Logs
    {
        Data.dataConnector data = new Data.dataConnector();

        public void logla(string content, string form_name)
        {
            data.baglantiAc();
            SqlCommand qryLog = data.setSQLCommand();
            qryLog.CommandText = "INSERT INTO genel_log(log_tarihi, log_aciklamasi, log_form_name) " +
                "values(@log_tarihi, @log_aciklamasi, @log_form_name)";
            qryLog.Parameters.Clear();
            qryLog.Parameters.AddWithValue("log_tarihi", DateTime.Now);
            qryLog.Parameters.AddWithValue("log_aciklamasi", content);
            qryLog.Parameters.AddWithValue("log_form_name", form_name);
            qryLog.ExecuteNonQuery();
            data.baglantiKapat();
        }

    }
}
