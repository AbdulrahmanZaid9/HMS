using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static HMS_Buisness.ClsReservations;
using static HMS_Buisness.ClsUsers;

namespace HMS_Buisness
{
    public class ClsRooms
    {
        public enum EnRoomStatus
        {
            Available = 1,
            Occupied = 2,
            Maintenance = 3,
            Cleaning = 4
        }
        enum EnMode
        {
            AddNew = 1,
            Update = 2,
        }
        EnMode Mode = EnMode.AddNew;
        public EnRoomStatus RoomStatus { get; set; }
        public short RoomId { get; set; }
        public byte RoomTypeId { get; set; }
        public ClsRoomTypes RoomType { get; set; }
        public short RoomNumber { get; set; }
        public byte FloorNumber { get; set; }
        public decimal PricePerNight { get; set; }
        public byte Capacity { get; set; }
        public string Amenities { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        // Returns the display-friendly string form of the current room status.
        public string StatusString
        {
            get
            {
                switch (RoomStatus)
                {
                    case EnRoomStatus.Available:
                        return "Available";
                    case EnRoomStatus.Occupied:
                        return "Occupied";
                    case EnRoomStatus.Maintenance:
                        return "Maintenance";
                    case EnRoomStatus.Cleaning:
                        return "Cleaning";
                    default:
                        return "Unknown";
                }
            }
        }

        // Creates a room object from existing data, loading its linked room type, and puts it in "update" mode.
        public ClsRooms(short roomId, short roomNumber, byte floorNumber, byte roomTypeId, decimal pricePerNight, byte capacity, string amenities, string description, string imagePath, EnRoomStatus roomStatus)
        {
            this.RoomId = roomId;
            this.RoomNumber = roomNumber;
            this.FloorNumber = floorNumber;
            this.RoomTypeId = roomTypeId;
            this.PricePerNight = pricePerNight;
            this.Capacity = capacity;
            this.Amenities = amenities;
            this.Description = description;
            this.ImagePath = imagePath;
            this.RoomStatus = roomStatus;
            this.RoomType = ClsRoomTypes.FindRoomtypeIDByName(roomTypeId);

            Mode = EnMode.Update;
        }

        // Creates a new, unsaved room in "add" mode with default values.
        public ClsRooms()
        {
            this.RoomId = 0;
            this.RoomNumber = 0;
            this.FloorNumber = 0;
            this.RoomTypeId = 0;
            this.PricePerNight = 0;
            this.Capacity = 0;
            this.Amenities = string.Empty;
            this.Description = string.Empty;
            this.ImagePath = string.Empty;
            this.RoomStatus = EnRoomStatus.Available;
            this.RoomType = ClsRoomTypes.FindRoomtypeIDByName(RoomTypeId);

            Mode = EnMode.AddNew;
        }

        // Persists changes to an existing room in the database.
        private bool _UpdateRoom()
        {
            return ClsRoomsData.UpdateRoom(this.RoomId, this.Amenities, (byte)this.RoomStatus, this.Description, this.ImagePath, this.PricePerNight);
        }

        // Inserts this room as a new record.
        private bool _AddNewRoom()
        {
            return ClsRoomsData.AddNewRoom(this.RoomNumber, this.FloorNumber, this.RoomTypeId, this.PricePerNight, this.Capacity, this.Amenities, this.Description, this.ImagePath, (byte)this.RoomStatus) > 0;
        }

        // Bulk-updates rooms from an old status to a new status after the elapsed-time condition is met.
        public static bool UpdateRoomsStatus(byte oldStatus, byte newStatus)
        {
            return ClsRoomsData.UpdateRoomsStatus(oldStatus, newStatus);
        }

        // Retrieves all room records.
        public static DataTable GetAllRooms()
        {
            return ClsRoomsData.GetAllRooms();
        }

        // Retrieves all rooms matching a given room status.
        public static DataTable GetRoomsByStatus(EnRoomStatus roomStatus)
        {
            return ClsRoomsData.GetRoomsByStatus(Convert.ToByte(roomStatus));
        }

        // Returns the fixed list of all possible room status names, including an "All" filter option.
        public static List<string> GetAllRoomStatuses()
        {
            return new List<string> { "All", "Available", "Occupied", "Maintenance", "Cleaning" };
        }

        // Saves the room, inserting it if new or updating it if it already exists.
        public bool Save()
        {

            switch (Mode)
            {
                case EnMode.AddNew:
                    if (_AddNewRoom())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return _UpdateRoom();
            }
            return false;
        }

        // Converts a room status name string into its corresponding numeric status code.
        public static byte GetStatusNumberByName(string statusName)
        {
            switch (statusName)
            {
                case "Available":
                    return (byte)EnRoomStatus.Available;
                case "Occupied":
                    return (byte)EnRoomStatus.Occupied;
                case "Maintenance":
                    return (byte)EnRoomStatus.Maintenance;
                case "Cleaning":
                    return (byte)EnRoomStatus.Cleaning;
                default:
                    return 0;
            }
        }

        // Updates the status of a single room by its room ID.
        public static bool ChangeRoomStatus(EnRoomStatus newStatus, short roomId)
        {
            return ClsRoomsData.ChangeRoomStatus(roomId, (byte)newStatus);
        }

        // Retrieves a room by ID and returns it as a ClsRooms object, or null if not found.
        public static ClsRooms FindRoomById(short roomId)
        {
            short roomNumber = 0;
            byte floorNumber = 0;
            byte roomTypeId = 0;
            decimal pricePerNight = 0;
            byte capacity = 0;
            string amenities = "";
            string description = "";
            string imagePath = "";
            byte roomStatus = 0;

            if (ClsRoomsData.FindRoomById(
                roomId,
                ref roomNumber,
                ref floorNumber,
                ref roomTypeId,
                ref pricePerNight,
                ref capacity,
                ref amenities,
                ref description,
                ref imagePath,
                ref roomStatus))
            {
                return new ClsRooms(
                    roomId,
                    roomNumber,
                    floorNumber,
                    roomTypeId,
                    pricePerNight,
                    capacity,
                    amenities,
                    description,
                    imagePath,
                    (EnRoomStatus)roomStatus
                );
            }
            else
            {
                return null;
            }
        }
    }
}