using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsPaymentTypesData
    {
        // Looks up a payment type's name by its payment type ID.
        public static bool FindPaymentTypeById(byte paymentTypeId, ref string paymentTypeName)
        {
            string query = "select PaymentTypeName from paymentTypes where PaymentTypeID =@paymentTypeID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@paymentTypeID", paymentTypeId)
            };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return false;

            paymentTypeName = result.ToString();

            return true;
        }
    }
}