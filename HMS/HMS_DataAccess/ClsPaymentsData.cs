using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsPaymentsData
    {
        // Inserts a new payment record for a bill and returns the newly generated payment ID.
        public static int AddNewPayment(int billId, DateTime paymentDate, decimal amount, string transactionReference, byte paymentTypeId, int relatedPaymentId, byte paymentMethodId)
        {
            string query = "insert into Payments (bill_id,payment_date,amount,transaction_reference,PaymentTypeID,RelatedPaymentID,PaymentMethodID)" +
                " values (@bill_id,@payment_date,@amount,@transaction_reference,@PaymentTypeID,@RelatedPaymentID,@PaymentMethodID); SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters =
            {
                new SqlParameter("@bill_id", billId),
                new SqlParameter("@payment_date", paymentDate),
                new SqlParameter("@amount", amount),
                new SqlParameter("@transaction_reference", transactionReference),
                new SqlParameter("@PaymentTypeID", paymentTypeId),
                new SqlParameter("@RelatedPaymentID",relatedPaymentId <= 0 ? (object)DBNull.Value : relatedPaymentId),
                new SqlParameter("@PaymentMethodID", paymentMethodId)
            };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);

        }

        // Retrieves the ID of the original (deposit-type) payment linked to a given bill.
        public static int GetRelatedPaymentId(int billId)
        {
            string query = "select payment_id from payments where PaymentTypeID = 1 and bill_id =@bill_id ";
            SqlParameter[] parameters =
            {
                new SqlParameter("@bill_id", billId),
            };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);

        }

        // Looks up a payment by its ID and populates its details via ref parameters.
        public static bool FindPaymentRecordById(int paymentId, ref int billId, ref DateTime paymentDate, ref decimal amount, ref string transactionReference, ref byte paymentTypeId, ref int relatedPaymentId, ref byte paymentMethodId)
        {
            string query = "select * from Payments where payment_id = @payment_id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@payment_id", paymentId)
            };

            DataTable table =
                clsDataAccessHelper.ExecuteDataTable(query, parameters);

            if (table.Rows.Count == 0)
                return false;

            DataRow row = table.Rows[0];

            billId = Convert.ToInt32(row["bill_id"]);
            paymentDate = Convert.ToDateTime(row["payment_date"]);
            amount = Convert.ToDecimal(row["amount"]);
            transactionReference = row["transaction_reference"].ToString();
            paymentTypeId = Convert.ToByte(row["payment_type_id"]);

            relatedPaymentId = row["related_payment_id"] == DBNull.Value
                ? 0
                : Convert.ToInt32(row["related_payment_id"]);

            paymentMethodId = Convert.ToByte(row["payment_method_id"]);

            return true;

        }
    }
}