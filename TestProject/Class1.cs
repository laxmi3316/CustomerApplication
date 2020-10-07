using CustomerApplication;
using NUnit.Framework;
using System;
using System.Security.Cryptography.X509Certificates;

namespace TestProject
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void test()
        {
            var test = new customer();
            Assert.Throws<NotImplementedException>(()=>test.AddCustomer());
        }


    }
}
