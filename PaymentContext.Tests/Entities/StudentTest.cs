using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{

    [TestClass]
    public class StudentTest
    {
        [TestMethod]        
        public void TestMethod2()
        {
            var student = new Student("Matheus", "Bertho", "12345678964", "matheus@bertho.dev");
            var x = new Student();
        }
    }

}