using System;
using PaymentContext.Domain.ValueObjects;
using Document = System.Reflection.Metadata.Document;

namespace PaymentContext.Domain.Entities
{

    public abstract class Payment
    {
        protected Payment(DateTime paidDate, DateTime expiredDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpiredDate = expiredDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
        }

        public string Number { get; private set; } // 9 digitos
        public DateTime PaidDate { get; private set; }
        public DateTime ExpiredDate { get; private set; }
        public decimal Total { get; private set; } // valor total
        public decimal TotalPaid { get; private set; } // valor com desconto
        public string Payer { get; private set; } // proprieatrio do pagamento
        public Document Document { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }

    }
    







}