using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsRoom_TypesData
    {

        // Looks up a room type's name by its room type ID.
        public static bool FindRoomTypeById(byte roomTypeId, ref string typeName)
        {
            string query = @"
        SELECT room_name
        FROM rooms_types
        WHERE room_id = @room_type_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@room_type_id", roomTypeId)
    };

            DataTable table = clsDataAccessHelper.ExecuteDataTable(query, parameters);

            if (table.Rows.Count == 0)
                return false;

            DataRow row = table.Rows[0];

            typeName = row["room_name"].ToString();

            return true;
        }

        // Retrieves the names of all room types.
        public static List<string> GetAllRoomTypes()
        {
            List<string> roomTypes = new List<string>();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select room_name from rooms_types";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        roomTypes.Add(reader["room_name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                reader?.Close();

                connection.Close();
            }

            return roomTypes;
        }

        // Looks up a room type's ID by its name.
        public static bool FindRoomTypeIdByName(string typeName, ref byte typeId)
        {
            string query = @"
        SELECT room_id
        FROM rooms_types
        WHERE room_name = @room_name;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@room_name", typeName)
    };

            DataTable table = clsDataAccessHelper.ExecuteDataTable(query, parameters);

            if (table.Rows.Count == 0)
                return false;

            DataRow row = table.Rows[0];

            typeId = Convert.ToByte(row["room_id"]);

            return true;
        }
    }
}