using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsServiceCategoriesData
    {
        // Looks up a service category by its ID and populates its name via ref parameter.
        public static bool FindCategoryById(ref byte categoryId, ref string categoryName)
        {
            string query = @"
        SELECT *
        FROM service_categories
        WHERE category_id = @category_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@category_id", categoryId)
    };

            DataTable table = clsDataAccessHelper.ExecuteDataTable(query, parameters);

            if (table.Rows.Count == 0)
                return false;

            DataRow row = table.Rows[0];

            categoryId = Convert.ToByte(row["category_id"]);
            categoryName = row["category_name"].ToString();

            return true;
        }

        // Retrieves all service category records.
        public static DataTable GetAllServiceCategories()
        {
            string query = @"
        SELECT *
        FROM service_categories;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }

    }
}