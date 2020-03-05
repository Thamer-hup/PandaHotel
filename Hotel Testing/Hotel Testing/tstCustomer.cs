using System;
using HotelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomer ACustomer = new clsCustomer();

            Assert.IsNotNull(ACustomer);
        }
    }
}
