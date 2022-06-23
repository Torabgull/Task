using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETEATestTask
{
    class ConMgr
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=ETEATestTask; user=sa; password=ims; Integrated Security=False;";
            return con;
        }
    }
}
