using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Buisness
{
    public class ClsPaymentTypes
    {
        public byte PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }
        public enum EnPaymentTypes
        {
            Deposite = 1,
            RoomCharge = 2,
            Tax = 5,
            Refund = 3,
            ServiceCharge = 4,
            DepositForfeited = 6
        }

        // Creates an empty payment type object with default values.
        public ClsPaymentTypes()
        {
            this.PaymentTypeId = 0;
            this.PaymentTypeName = string.Empty;
        }

        // Creates a payment type object from an existing ID and name.
        public ClsPaymentTypes(byte paymentTypeId, string paymentTypeName)
        {
            this.PaymentTypeId = paymentTypeId;
            this.PaymentTypeName = paymentTypeName;
        }

        // Retrieves a payment type by its ID and returns it as a ClsPaymentTypes object, or null if not found.
        public static ClsPaymentTypes FindPaymentTypeById(byte paymentTypeId)
        {
            string paymentTypeName = string.Empty;

            if (ClsPaymentTypesData.FindPaymentTypeById(paymentTypeId, ref paymentTypeName))
            {
                return new ClsPaymentTypes(paymentTypeId, paymentTypeName);
            }
            else
                return null;
        }
    }
}