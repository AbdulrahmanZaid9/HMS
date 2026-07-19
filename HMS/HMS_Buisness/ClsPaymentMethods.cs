using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Buisness
{
    public class ClsPaymentMethods
    {
        public byte PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; }

        public enum EnPaymentMethods
        {
            Cash = 1,
            CreditCard = 2,
            DebitCard = 3,
            BankTransfer = 4,
            OnlinePayment = 5,
            EWallet = 6
        }


        // Creates an empty payment method object with default values.
        public ClsPaymentMethods()
        {
            this.PaymentMethodId = 0;
            this.PaymentMethodName = string.Empty;
        }

        // Creates a payment method object from an existing ID and name.
        public ClsPaymentMethods(byte paymentMethodId, string paymentMethodName)
        {
            this.PaymentMethodId = paymentMethodId;
            this.PaymentMethodName = paymentMethodName;
        }



        // Retrieves a payment method by its ID and returns it as a ClsPaymentMethods object, or null if not found.
        public static ClsPaymentMethods FindPaymentMethodById(byte paymentMethodId)
        {
            string paymentMethodName = string.Empty;

            if (ClsPaymentMethodsData.FindPaymentMethodById(paymentMethodId, ref paymentMethodName))
            {
                return new ClsPaymentMethods(paymentMethodId, paymentMethodName);
            }
            else
                return null;
        }
    }
}