using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Global_Classes
{
    // Holds application-wide global state and constants (current logged-in user, default image path, images folder name, deposit amount).
    internal static class ClsGlobal
    {
        public static ClsUsers CurrentUser;
        public static string DefulatImagePath = "Not found.png";
        public static string ImagesFolderName = "RoomImages";
        public static decimal DepoisteAmount = 100;

    }
}