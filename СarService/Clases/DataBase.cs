using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СarService.Clases
{
    public static class DataBase
    {
        public static string strConn = "Server=DESKTOP-N6GODSK;" +
                    "Database=CarServiceBase;" +
                "Trusted_Connection=True;" +
              "TrustServerCertificate=True;";
        public static SqlConnection conn = new SqlConnection(strConn);

    }
}
