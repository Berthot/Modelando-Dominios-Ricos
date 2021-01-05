using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{

    [TestClass]
    public class StudentTest
    {
        [TestMethod]        
        public void TestMethod2()
        {
            var subscription = new Subscription(null);
            var student = new Student(
                new Name("matheus", "bertho"),
                new Document("12345678964", EDocumentsType.CPF), 
                "matheus@bertho.dev"
                );
            
            student.AddSubscription(subscription);
        }
    }

}