using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Buisness
{
    public class ClsPayments
    {
        public int PaymentId { get; set; }
        public int BillId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string TransactionReference { get; set; }
        public byte PaymentTypeId { get; set; }
        public int RelatedPaymentId { get; set; }
        public byte PaymentMethodId { get; set; }

        public ClsBills Bill { get; set; }
        public ClsPaymentTypes PaymentType { get; set; }
        public ClsPaymentMethods PaymentMethod { get; set; }
        enum EnMode
        {
            AddNew = 1,
            Update = 2,
        }
        EnMode _mode = EnMode.AddNew;

        // Creates a new, unsaved payment in "add" mode with default values and empty linked records.
        public ClsPayments()
        {
            this.PaymentId = 0;
            this.BillId = 0;
            this.PaymentDate = DateTime.Now;
            this.Amount = 0;
            this.TransactionReference = string.Empty;
            this.PaymentTypeId = 0;
            this.RelatedPaymentId = 0;
            this.PaymentMethodId = 0;
            this.Bill = ClsBills.FindBillById(this.BillId);
            this.PaymentType = ClsPaymentTypes.FindPaymentTypeById(this.PaymentTypeId);
            this.PaymentMethod = ClsPaymentMethods.FindPaymentMethodById(this.PaymentMethodId);

            _mode = EnMode.AddNew;
        }

        // Creates a payment object from existing data, loading its linked bill, type, and method, and puts it in "update" mode.
        public ClsPayments(int paymentId, int billId, DateTime paymentDate, decimal amount, string transactionReference,
            byte paymentTypeId, int relatedPaymentId, byte paymentMethodId)
        {
            this.PaymentId = paymentId;
            this.BillId = billId;
            this.PaymentDate = paymentDate;
            this.Amount = amount;
            this.TransactionReference = transactionReference;
            this.PaymentTypeId = paymentTypeId;
            this.RelatedPaymentId = relatedPaymentId;
            this.PaymentMethodId = paymentMethodId;
            this.Bill = ClsBills.FindBillById(this.BillId);
            this.PaymentType = ClsPaymentTypes.FindPaymentTypeById(this.PaymentTypeId);
            this.PaymentMethod = ClsPaymentMethods.FindPaymentMethodById(this.PaymentMethodId);

            _mode = EnMode.Update;
        }

        // Placeholder for updating an existing payment record; currently always returns false (not implemented).
        private bool _UpdatePaymentRecord()
        {
            return false;
        }

        // Inserts this payment as a new record and stores the generated payment ID.
        private bool _AddNewPaymentRecord()
        {
            this.PaymentId = ClsPaymentsData.AddNewPayment(this.BillId, this.PaymentDate, this.Amount, this.TransactionReference, this.PaymentTypeId, this.RelatedPaymentId, this.PaymentMethodId);
            return this.BillId > 0;
        }

        // Saves the payment, inserting it if new or attempting to update it if it already exists.
        public bool Save()
        {

            switch (_mode)
            {
                case EnMode.AddNew:
                    if (_AddNewPaymentRecord())
                    {
                        _mode = EnMode.Update;
                        return true;
                    }
                    return false;

                case EnMode.Update:
                    return _UpdatePaymentRecord();
            }
            return false;
        }

        // Retrieves a payment by its ID and returns it as a ClsPayments object, or null if not found.
        public static ClsPayments FindPaymentRecordById(int paymentId)
        {
            int billId = 0;
            int relatedPaymentId = 0;
            DateTime paymentDate = DateTime.MinValue;
            decimal amount = 0;
            string transactionReference = string.Empty;
            byte paymentTypeId = 0;
            byte paymentMethodId = 0;
            if (ClsPaymentsData.FindPaymentRecordById(paymentId, ref billId, ref paymentDate, ref amount, ref transactionReference, ref paymentTypeId, ref relatedPaymentId, ref paymentMethodId))
            {
                return new ClsPayments(paymentId, billId, paymentDate, amount, transactionReference, paymentTypeId, relatedPaymentId, paymentMethodId);
            }
            else
                return null;
        }

        // Retrieves the ID of the original (deposit-type) payment linked to a given bill.
        public static int GetRelatedPaymentId(int billId)
        {
            return ClsPaymentsData.GetRelatedPaymentId(billId);
        }

    }
}