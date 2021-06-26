using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCuoiKi
{
    class Connect_KDNuocSach
    {
        string connStr = "Data Source=DESKTOP-PIUIOUQ;Initial Catalog = KDNuocSach; Integrated Security = True";
        protected SqlConnection conn;
        public void openConnect()
        {
            conn = new SqlConnection(connStr);
            conn.Open();
        }
        public void closeConnect()
        {
            conn.Close();
        }
    }
}
