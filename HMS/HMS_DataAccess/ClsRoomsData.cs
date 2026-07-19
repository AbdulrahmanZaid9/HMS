using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsRoomsData
    {
        // Retrieves all room records.
        public static DataTable GetAllRooms()
        {
            string query = @"
        SELECT *
        FROM rooms;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }

        // Bulk-updates rooms from an old status to a new status, but only once at least 2 hours have passed since the last status change.
        public static bool UpdateRoomsStatus(byte oldStatus, byte newStatus)
        {
            string query = @"
        UPDATE Rooms
        SET room_status = @NewStatus
        WHERE room_status = @OldStatus
          AND DATEADD(HOUR, 2, StatusChangedAt) <= GETDATE();";

            SqlParameter[] parameters =
            {
        new SqlParameter("@OldStatus", oldStatus),
        new SqlParameter("@NewStatus", newStatus)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Updates the status of a single room by its room ID.
        public static bool ChangeRoomStatus(short roomId, byte newStatus)
        {
            string query = @"
        UPDATE rooms
        SET room_status = @new_status
        WHERE room_id = @room_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@new_status", newStatus),
        new SqlParameter("@room_id", roomId)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Retrieves all rooms matching a given room status.
        public static DataTable GetRoomsByStatus(byte roomStatus)
        {
            string query = @"
        SELECT *
        FROM rooms
        WHERE room_status = @room_status;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@room_status", roomStatus)
    };

            return clsDataAccessHelper.ExecuteDataTable(query, parameters);
        }

        // Updates a room's amenities, description, image, price, and status.
        public static bool UpdateRoom(int roomId, string amenities, byte roomStatus, string description, string imagePath, decimal pricePerNight)
        {
            string query = @"
        UPDATE rooms
        SET 
            amenities = @amenities,
            description = @description,
            image_path = @image_path,
            price_per_night = @price_per_night,
            room_status = @room_status
        WHERE room_id = @room_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@amenities", amenities),
        new SqlParameter("@description", description),
        new SqlParameter("@image_path", imagePath),
        new SqlParameter("@price_per_night", pricePerNight),
        new SqlParameter("@room_id", roomId),
        new SqlParameter("@room_status", roomStatus)
    };

            return clsDataAccessHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Inserts a new room record and returns the newly generated room ID.
        public static short AddNewRoom(short roomNumber, byte floorNumber, byte roomTypeId, decimal pricePerNight, byte capacity, string amenities, string description, string imagePath, byte roomStatus)
        {
            string query = @"
        INSERT INTO rooms
        (
            room_number,
            floor_number,
            room_type,
            room_status,
            price_per_night,
            capacity,
            amenities,
            description,
            image_path
        )
        VALUES
        (
            @room_number,
            @floor_number,
            @room_Type_id,
            @room_Status,
            @price_per_night,
            @capacity,
            @amenities,
            @description,
            @image_path
        );

        SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters =
            {
        new SqlParameter("@room_number", roomNumber),
        new SqlParameter("@floor_number", floorNumber),
        new SqlParameter("@room_Type_id", roomTypeId),
        new SqlParameter("@room_Status", roomStatus),
        new SqlParameter("@price_per_night", pricePerNight),
        new SqlParameter("@capacity", capacity),
        new SqlParameter("@amenities", amenities),
        new SqlParameter("@description", description),
        new SqlParameter("@image_path", imagePath)
    };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result != null && short.TryParse(result.ToString(), out short roomId))
                return roomId;

            return 0;
        }

        // Looks up a room by ID and populates its full details via ref parameters.
        public static bool FindRoomById(short roomId, ref short roomNumber, ref byte floorNumber, ref byte roomTypeId, ref decimal pricePerNight, ref byte capacity, ref string amenities, ref string description, ref string imagePath, ref byte roomStatus)
        {
            string query = @"
        SELECT *
        FROM Rooms
        WHERE room_id = @room_id;";

            SqlParameter[] parameters =
            {
        new SqlParameter("@room_id", roomId)
    };

            DataTable table = clsDataAccessHelper.ExecuteDataTable(query, parameters);

            if (table.Rows.Count == 0)
                return false;

            DataRow row = table.Rows[0];

            roomNumber = Convert.ToInt16(row["room_number"]);
            floorNumber = Convert.ToByte(row["floor_number"]);
            roomTypeId = Convert.ToByte(row["room_type_id"]);
            pricePerNight = Convert.ToDecimal(row["price_per_night"]);
            capacity = Convert.ToByte(row["capacity"]);
            amenities = row["amenities"].ToString();
            description = row["description"].ToString();

            imagePath = row["image_path"].ToString();

            if (string.IsNullOrWhiteSpace(imagePath))
                imagePath = null;

            roomStatus = Convert.ToByte(row["room_status"]);

            return true;
        }
    }
}