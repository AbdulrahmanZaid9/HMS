using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsNationalityData
    {
        // Looks up a nationality's country name by its country ID.
        public static bool FindNationalityById(byte countryId, ref string countryName)
        {
            string query = "select country_name from nationalities where country_id =@country_id";
            SqlParameter[] parameters =
                {
                    new SqlParameter("@country_id", countryId)
                };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);
            if (result == null || result == DBNull.Value)
                return false;

            countryName = result.ToString();

            return true;
        }

        // Retrieves all nationality records.
        public static DataTable GetAllNationalities()
        {
            string query = "select * from nationalities";
            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }
    }
}