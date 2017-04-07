using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Fingerprint_Authentication
{
    class DB_ATM_Data_Connection
    {

        SqlConnection conn_data;

        public SqlConnection Connect_Details()
        {
            conn_data = new SqlConnection("uid=; pwd=; server=PARASGARG-HP; database=ATM_Data; Trusted_connection=yes;");
            conn_data.Open();
            return conn_data;

        }
    
    }
}
