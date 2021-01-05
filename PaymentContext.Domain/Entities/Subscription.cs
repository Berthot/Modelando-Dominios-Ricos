using System;
using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        private readonly IList<Payment> _payments;
        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> Payments => _payments.ToArray();


        public void AddPayments(Payment payment)
        {
            _payments.Add(payment);
        }


        public void Activated()
        {
            Active = true;
            LastUpdateDate = DateTime.Now;
        }
        public void Inactivated()
        {
            Active = false;
            LastUpdateDate = DateTime.Now;
        }
    }
}