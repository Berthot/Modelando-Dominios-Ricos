using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private readonly IList<Subscription> _subscriptions = new List<Subscription>();

        public Student(Name name, Document document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public Address Address { get; set; }

        public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions.ToArray();

        public void AddSubscription(Subscription subscription)
        {
            // se ja tiver assinatura ativa, cancela

            // cancelaas outras e deixa essa como principal

            foreach (var sub in Subscriptions)
                sub.Inactivated();

            _subscriptions.Add(subscription);
        }
    }
}