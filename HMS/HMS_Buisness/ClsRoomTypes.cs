using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Buisness
{
    public class ClsRoomTypes
    {
        public byte RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }

        // Creates an empty room type object with default values.
        ClsRoomTypes()
        {
            this.RoomTypeId = 0;
            this.RoomTypeName = "";
        }

        // Creates a room type object from an existing ID and name.
        ClsRoomTypes(byte roomTypeId, string roomTypeName)
        {
            this.RoomTypeId = roomTypeId;
            this.RoomTypeName = roomTypeName;
        }

        // Retrieves the names of all room types.
        public static List<string> GetAllRoomTypes()
        {
            return ClsRoom_TypesData.GetAllRoomTypes();
        }

        // Retrieves a room type by its ID and returns it as a ClsRoomTypes object, or null if not found.
        public static ClsRoomTypes FindRoomtypeIDByName(byte roomTypeId)
        {
            string typeName = "";

            if (ClsRoom_TypesData.FindRoomTypeById(roomTypeId, ref typeName))
            {
                return new ClsRoomTypes(roomTypeId, typeName);
            }
            else
            {
                return null;
            }
        }

        // Looks up a room type's ID by its name.
        public static byte FindRoomtypeIDByName(string roomTypeName)
        {
            byte type_id = 0;
            if (ClsRoom_TypesData.FindRoomTypeIdByName(roomTypeName, ref type_id))
            {
                return type_id;
            }
            else
            {
                return 0;
            }
        }
    }
}