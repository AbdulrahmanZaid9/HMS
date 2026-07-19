using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsPaymentMethodsData
    {
        // Looks up a payment method's name by its payment method ID.
        public static bool FindPaymentMethodById(byte paymentMethodId, ref string paymentMethodName)
        {
            string query = "select PaymentMethodName from paymentMethods where PaymentMethodID =@paymentMethodID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@paymentMethodID", paymentMethodId)
            };

            object result = clsDataAccessHelper.ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return false;

            paymentMethodName = result.ToString();

            return true;
        }

    }
}