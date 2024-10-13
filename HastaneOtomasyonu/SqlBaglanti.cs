using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    internal class SqlBaglanti
    {

        public SqlConnection Connection()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BVFFPPL\\SQLEXPRESS;Initial Catalog=Hastane;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            return conn;
        }

    }
}
