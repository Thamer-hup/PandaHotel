using HotelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Testing
{
    [TestClass]
    public class tstRoom
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsRoom ARoom = new clsRoom();

            Assert.IsNotNull(ARoom);
        }
        [TestMethod]
        public void RoomIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsRoom ARoom = new clsRoom();
            //create some test data to assign to the property
            Int32 TestData = 100;
            //assign the data to the property
            ARoom.RoomId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARoom.RoomId, TestData);
        }
        [TestMethod]
        public void RoomNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsRoom ARoom = new clsRoom();
            //create some test data to assign to the property
            String TestData = "RM001";
            //assign the data to the property
            ARoom.RoomNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARoom.RoomNumber, TestData);
        }
        [TestMethod]
        public void FloorNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsRoom ARoom = new clsRoom();
            //create some test data to assign to the property
            Int32 TestData = 4;
            //assign the data to the property
            ARoom.FloorNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARoom.FloorNo, TestData);
        }
        [TestMethod]
        public void RoomTypePropertyOK()
        {
            //create an instance of the class we want to create
            clsRoom ARoom = new clsRoom();
            //create some test data to assign to the property
            String TestData = "Deluxe";
            //assign the data to the property
            ARoom.RoomType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARoom.RoomType, TestData);
        }

        [TestMethod]
        public void DailyChargePropertyOK()
        {
            //create an instance of the class we want to create
            clsRoom ARoom = new clsRoom();
            //create some test data to assign to the property
            Double TestData = 99.99;
            //assign the data to the property
            ARoom.DailyCharge = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARoom.DailyCharge, TestData);
        }

        [TestMethod]
        public void AvailableForBookingPropertyOK()
        {
            //create an instance of the class we want to create
            clsRoom ARoom = new clsRoom();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ARoom.AvailableForBooking = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARoom.AvailableForBooking, TestData);
        }

    }
}
