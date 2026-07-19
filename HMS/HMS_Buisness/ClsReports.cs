using System.Data;
using HMS_DataAccess;

namespace HMS_Buisness
{
    public class ClsReports
    {

        // Retrieves the daily revenue report.
        public static DataTable GetDailyRevenueReport()
        {
            return ClsReportsData.GetDailyRevenueReport();
        }


        // Retrieves the monthly revenue report.
        public static DataTable GetMonthlyRevenueReport()
        {
            return ClsReportsData.GetMonthlyRevenueReport();
        }


        // Retrieves the yearly revenue report.
        public static DataTable GetYearlyRevenueReport()
        {
            return ClsReportsData.GetYearlyRevenueReport();
        }


        // Retrieves the revenue breakdown grouped by room type.
        public static DataTable GetRevenueByRoomType()
        {
            return ClsReportsData.GetRevenueByRoomType();
        }


        // Retrieves the revenue breakdown grouped by customer.
        public static DataTable GetCustomerRevenueReport()
        {
            return ClsReportsData.GetCustomerRevenueReport();
        }


        // Retrieves the customer stay/occupancy report.
        public static DataTable GetCustomerStayReport()
        {
            return ClsReportsData.GetCustomerStayReport();
        }


        // Retrieves the report of bills that remain unpaid/outstanding.
        public static DataTable GetOutstandingBillsReport()
        {
            return ClsReportsData.GetOutstandingBillsReport();
        }


        // Retrieves the revenue breakdown grouped by individual room.
        public static DataTable GetRevenueByRoom()
        {
            return ClsReportsData.GetRevenueByRoom();
        }


        // Retrieves the revenue breakdown grouped by currently active room types.
        public static DataTable GetRevenueByActiveRoomType()
        {
            return ClsReportsData.GetRevenueByActiveRoomType();
        }

    }
}