using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsServicesData
    {
        // Looks up a service by its ID and populates its category, name, price, description, and active status via ref parameters.
        public static bool FindServiceById(byte serviceId, ref byte categoryId, ref string serviceName, ref decimal price, ref string description, ref bool isActive)
        {
            string query = @"
        SELECT *
        FROM services
        WHERE service_id = @service_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@service_id", serviceId)
    };

            DataTable table = clsDataAccessHelper.ExecuteDataTable(query, parameters);

            if (table.Rows.Count == 0)
                return false;

            DataRow row = table.Rows[0];

            categoryId = Convert.ToByte(row["category_id"]);
            serviceName = row["service_name"].ToString();
            price = Convert.ToDecimal(row["price"]);
            description = row["description"].ToString();
            isActive = Convert.ToBoolean(row["is_active"]);

            return true;
        }

        // Updates the price of a service by its service ID.
        public static bool UpdatePriceById(byte serviceId, decimal price)
        {
            string query = @"
        UPDATE services
        SET price = @price
        WHERE service_id = @service_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@service_id", serviceId),
        new SqlParameter("@price", price)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Retrieves all active services along with their category names.
        public static DataTable GetAllServices()
        {
            string query = @"
        SELECT 
            service_id,
            service_name,
            SC.category_name,
            price,
            description
        FROM services S
        INNER JOIN service_categories SC
            ON S.category_id = SC.category_id
        WHERE is_active = 1;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }

        // Retrieves all service names and their corresponding IDs.
        public static DataTable GetAllServiceNamesAndId()
        {
            string query = @"
        SELECT 
            service_name,
            service_id
        FROM services;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }
    }
}