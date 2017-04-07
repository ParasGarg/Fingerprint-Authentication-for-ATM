using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Fingerprint_Authentication
{
    class DB_ATM_Fingerprint_Connection
    {

        SqlConnection conn_finger;

        public SqlConnection Connect_Fingerprint()
        {
            conn_finger = new SqlConnection("uid=; pwd=; server=PARASGARG-HP; database=ATM_Fingerprint; Trusted_connection=yes;");
            conn_finger.Open();
            return conn_finger;

        }
    
    }
}
