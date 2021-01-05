using System;

namespace PaymentContext.Domain.Entities
{

    public abstract class Payment
    {
        public string Number { get; set; } // 9 digitos
        public DateTime PaidDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal Total { get; set; } // valor total
        public decimal TotalPaid { get; set; } // valor com desconto
        public string Payer { get; set; } // proprieatrio do pagamento
        public string Document { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }


    public class BoletoPayment : Payment
    {
        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
    }


    public class CreaditCardPayment : Payment
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; } // ultimo 4 numeros
        public string LastTransactionNumber { get; set; }
    }


    public class PayPalPayment : Payment
    {
        public string TransactionCode { get; set; }
                
    }


}