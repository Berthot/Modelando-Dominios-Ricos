using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private readonly IList<Subscription> _subscriptions = new List<Subscription>();
        
        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address {get; set;}

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