using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Buisness
{
    public class ClsNationality
    {
        public byte CountryId { get; set; }
        public string CountryName { get; set; }

        // Creates an empty nationality object with default values.
        public ClsNationality()
        {
            this.CountryId = 0;
            this.CountryName = string.Empty;
        }

        // Creates a nationality object from an existing country ID and name.
        public ClsNationality(byte countryId, string countryName)
        {
            this.CountryId = countryId;
            this.CountryName = countryName;
        }


        // Retrieves a nationality by its country ID and returns it as a ClsNationality object, or null if not found.
        public static ClsNationality FindNationalityById(byte countryId)
        {
            string countryName = string.Empty;

            if (ClsNationalityData.FindNationalityById(countryId, ref countryName))
            {
                return new ClsNationality(countryId, countryName);
            }
            else
                return null;
        }

        // Retrieves all nationality records.
        public static DataTable GetAllNationalities()
        {
            return ClsNationalityData.GetAllNationalities();
        }
    }
}