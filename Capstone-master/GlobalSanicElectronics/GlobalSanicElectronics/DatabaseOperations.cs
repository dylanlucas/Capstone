using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalSanicElectronics
{
    static public class DatabaseOperations
    {
        static public SqlConnection 
                sqlConnectionLink = new SqlConnection(ConfigurationManager.ConnectionStrings["GlobalSanicElectronics"].ConnectionString);
    }
}
