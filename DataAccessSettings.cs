using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class DataAccessSettings
    {
        static public string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=POS_Database;Trusted_Connection=True;";
 
        //static public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
        //                                          AttachDbFilename=|DataDirectory|\POS_DB.mdf;
        //                                          Integrated Security=True;";
    }
}
