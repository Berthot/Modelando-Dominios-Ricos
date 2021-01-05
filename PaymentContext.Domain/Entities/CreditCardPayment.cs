using System;
using PaymentContext.Domain.ValueObjects;
using Document = System.Reflection.Metadata.Document;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(DateTime paidDate, DateTime expiredDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email, string cardHolderName, string cardNumber, string lastTransactionNumber) : base(paidDate, expiredDate, total, totalPaid, payer, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; } // ultimo 4 numeros
        public string LastTransactionNumber { get;private set; }
    }
}