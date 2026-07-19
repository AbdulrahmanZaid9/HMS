using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    // Holds the shared database connection string used by all data access classes.
    static class clsDataAccessSettings
    {
        public static string connectionString = "Server=.;Database=HotelManagementDB;User Id=sa;Password=sa123456;";
    }
}