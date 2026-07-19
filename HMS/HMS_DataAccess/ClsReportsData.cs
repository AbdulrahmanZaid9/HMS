using System;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class ClsReportsData
    {
        // 1. Daily Revenue Report
        public static DataTable GetDailyRevenueReport()
        {
            string query = @"
        SELECT
            PaymentDate,
            NumberOfPayments,
            RoomRevenue,
            ServiceRevenue,
            RoomRevenue + ServiceRevenue AS TotalRevenue
        FROM
        (
            SELECT
                CAST(payment_date AS DATE) AS PaymentDate,
                COUNT(CASE WHEN PaymentTypeID IN (2,4) THEN 1 END) AS NumberOfPayments,
                SUM(CASE WHEN PaymentTypeID = 2 THEN amount ELSE 0 END) AS RoomRevenue,
                SUM(CASE WHEN PaymentTypeID = 4 THEN amount ELSE 0 END) AS ServiceRevenue
            FROM Payments
            GROUP BY CAST(payment_date AS DATE)
        ) AS T
        ORDER BY PaymentDate;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }
        // 2. Monthly Revenue Report
        public static DataTable GetMonthlyRevenueReport()
        {
            string query = @"
        SELECT
            PaymentYear,
            PaymentMonth,
            NumberOfPayments,
            RoomRevenue,
            ServiceRevenue,
            RoomRevenue + ServiceRevenue AS TotalRevenue,
            AveragePayment
        FROM
        (
            SELECT
                YEAR(payment_date) AS PaymentYear,
                MONTH(payment_date) AS PaymentMonth,
                COUNT(CASE WHEN PaymentTypeID IN (2,4) THEN 1 END) AS NumberOfPayments,
                SUM(CASE WHEN PaymentTypeID = 2 THEN amount ELSE 0 END) AS RoomRevenue,
                SUM(CASE WHEN PaymentTypeID = 4 THEN amount ELSE 0 END) AS ServiceRevenue,
                AVG(CASE WHEN PaymentTypeID IN (2,4) THEN amount END) AS AveragePayment
            FROM Payments
            GROUP BY
                YEAR(payment_date),
                MONTH(payment_date)
        ) AS T
        ORDER BY
            PaymentYear,
            PaymentMonth;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }
        // 3. Yearly Revenue Report
        public static DataTable GetYearlyRevenueReport()
        {
            string query = @"
        SELECT
            PaymentYear,
            NumberOfPayments,
            RoomRevenue,
            ServiceRevenue,
            RoomRevenue + ServiceRevenue AS TotalRevenue,
            AveragePayment
        FROM
        (
            SELECT
                YEAR(payment_date) AS PaymentYear,
                COUNT(CASE WHEN PaymentTypeID IN (2,4) THEN 1 END) AS NumberOfPayments,
                SUM(CASE WHEN PaymentTypeID = 2 THEN amount ELSE 0 END) AS RoomRevenue,
                SUM(CASE WHEN PaymentTypeID = 4 THEN amount ELSE 0 END) AS ServiceRevenue,
                AVG(CASE WHEN PaymentTypeID IN (2,4) THEN amount END) AS AveragePayment
            FROM Payments
            GROUP BY YEAR(payment_date)
        ) AS T
        ORDER BY PaymentYear;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }
        // 4. Revenue By Room Type
        public static DataTable GetRevenueByRoomType()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"
                SELECT
                    RoomName,
                    NumberOfPayments,
                    RoomRevenue,
                    ServiceRevenue,
                    RoomRevenue + ServiceRevenue AS TotalRevenue,
                    AveragePayment

                FROM
                (
                    SELECT

                        rt.room_name AS RoomName,

                        COUNT(CASE WHEN p.PaymentTypeID IN (2,4) THEN 1 END) AS NumberOfPayments,

                        SUM(CASE WHEN p.PaymentTypeID = 2 THEN p.amount ELSE 0 END) AS RoomRevenue,

                        SUM(CASE WHEN p.PaymentTypeID = 4 THEN p.amount ELSE 0 END) AS ServiceRevenue,

                        AVG(CASE WHEN p.PaymentTypeID IN (2,4) THEN p.amount END) AS AveragePayment

                    FROM Payments p

                    INNER JOIN Bills b
                        ON p.bill_id = b.bill_id

                    INNER JOIN Reservations r
                        ON b.reservation_id = r.reservation_id

                    INNER JOIN Rooms ro
                        ON r.room_id = ro.room_id

                    INNER JOIN Rooms_Types rt
                        ON ro.room_type_id = rt.room_id

                    GROUP BY
                        rt.room_name

                ) AS T;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    dt.Load(reader);
                }
            }

            return dt;
        }
        // 5. Customer Revenue Report
        public static DataTable GetCustomerRevenueReport()
        {
            string query = @"
        SELECT
            Name,
            passport_number,
            NumberOfReservations,
            TotalNights,
            RoomRevenue,
            ServiceRevenue,
            RoomRevenue + ServiceRevenue AS TotalRevenue
        FROM
        (
            SELECT
                ps.full_name AS Name,
                ps.passport_number,
                COUNT(DISTINCT r.reservation_id) AS NumberOfReservations,
                SUM(
                    DATEDIFF(
                        DAY,
                        r.actual_check_in,
                        ISNULL(r.actual_check_out, GETDATE())
                    )
                ) AS TotalNights,
                SUM(
                    CASE
                        WHEN p.PaymentTypeID = 2
                        THEN p.amount
                        ELSE 0
                    END
                ) AS RoomRevenue,
                SUM(
                    CASE
                        WHEN p.PaymentTypeID = 4
                        THEN p.amount
                        ELSE 0
                    END
                ) AS ServiceRevenue
            FROM Payments p
            INNER JOIN Bills b
                ON p.bill_id = b.bill_id
            INNER JOIN Reservations r
                ON b.reservation_id = r.reservation_id
            INNER JOIN Customers c
                ON r.customer_id = c.customer_id
            INNER JOIN Persons ps
                ON c.person_id = ps.person_id
            GROUP BY
                ps.full_name,
                ps.passport_number
        ) AS T;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }
        // 6. Customer Stay Analysis Report
        public static DataTable GetCustomerStayReport()
        {
            string query = @"
        SELECT
            DATENAME(MONTH, r.actual_check_in) AS Month,
            COUNT(DISTINCT r.customer_id) AS NumberOfCustomers,
            SUM(
                DATEDIFF(
                    DAY,
                    r.actual_check_in,
                    r.actual_check_out
                )
            ) AS TotalNights,
            AVG(
                DATEDIFF(
                    DAY,
                    r.actual_check_in,
                    r.actual_check_out
                )
            ) AS AverageNights
        FROM Reservations r
        WHERE
            r.actual_check_in IS NOT NULL
            AND r.actual_check_out IS NOT NULL
        GROUP BY
            DATENAME(MONTH, r.actual_check_in)
        ORDER BY
            MIN(r.actual_check_in);";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }
        // 7. Outstanding Bills Report
        public static DataTable GetOutstandingBillsReport()
        {
            string query = @"
        ;WITH BillBalance AS
        (
            SELECT
                r.reservation_id,
                pr.full_name AS CustomerName,
                r.check_out_date,

                ISNULL
                (
                    (
                        SELECT SUM(p.amount)
                        FROM payments p
                        WHERE p.bill_id = b.bill_id
                        AND p.PaymentTypeID IN (2,4,5,6)
                    ),0
                )
                -
                ISNULL
                (
                    (
                        SELECT SUM(p.amount)
                        FROM payments p
                        WHERE p.bill_id = b.bill_id
                        AND p.PaymentTypeID = 3
                    ),0
                ) AS ChargesNet,

                ISNULL
                (
                    (
                        SELECT SUM(p.amount)
                        FROM payments p
                        WHERE p.bill_id = b.bill_id
                        AND p.PaymentTypeID = 1
                    ),0
                ) AS DepositPaid

            FROM reservations r
            INNER JOIN customers c
                ON c.customer_id = r.customer_id
            INNER JOIN persons pr
                ON pr.person_id = c.person_id
            INNER JOIN bills b
                ON b.reservation_id = r.reservation_id
            WHERE
                b.PaidAt IS NULL
                AND r.status <> 4
        )

        SELECT
            reservation_id AS [Reservation #],
            CustomerName AS [Customer],
            (ChargesNet - DepositPaid) AS [Balance Due],
            CONVERT(VARCHAR(10), check_out_date, 103) AS [Due Date],
            CASE
                WHEN check_out_date < GETDATE()
                THEN DATEDIFF(DAY, check_out_date, GETDATE())
                ELSE 0
            END AS [Days Overdue]
        FROM BillBalance
        WHERE
            (ChargesNet - DepositPaid) > 0
        ORDER BY
            [Balance Due] DESC;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }
        // 8. Revenue By Room Report
        public static DataTable GetRevenueByRoom()
        {
            string query = @"
        SELECT
            rm.room_number AS [Room #],
            rt.room_name AS [Room Type],
            COUNT(DISTINCT r.reservation_id) AS [Reservations],
            SUM(p.amount) AS [Revenue]
        FROM Payments p
        INNER JOIN Bills b
            ON p.bill_id = b.bill_id
        INNER JOIN Reservations r
            ON b.reservation_id = r.reservation_id
        INNER JOIN Rooms rm
            ON r.room_id = rm.room_id
        INNER JOIN Rooms_Types rt
            ON rm.room_type_id = rt.room_id
        WHERE
            p.PaymentTypeID = 2
        GROUP BY
            rm.room_number,
            rt.room_name
        ORDER BY
            Revenue DESC;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }
        // 9. Revenue By Active Room Type Report
        public static DataTable GetRevenueByActiveRoomType()
        {
            string query = @"
        SELECT
            rt.room_name AS [Room Type],
            COUNT(DISTINCT r.reservation_id) AS [Reservations],
            SUM(p.amount) AS [Revenue]
        FROM Payments p
        INNER JOIN Bills b
            ON p.bill_id = b.bill_id
        INNER JOIN Reservations r
            ON b.reservation_id = r.reservation_id
        INNER JOIN Rooms rm
            ON r.room_id = rm.room_id
        INNER JOIN Rooms_Types rt
            ON rm.room_type_id = rt.room_id
        WHERE
            p.PaymentTypeID = 2
            AND r.status <> 4
        GROUP BY
            rt.room_name
        ORDER BY
            Revenue DESC;";

            return clsDataAccessHelper.ExecuteDataTable(query, null);
        }
    }
}