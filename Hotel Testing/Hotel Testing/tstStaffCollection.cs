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
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //in this case the data need to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add item to the list 
            clsStaff TestItem = new clsStaff();
            //add an item to the list
            TestItem.StaffName = "Thamer";
            TestItem.Email = "th@thamer.com";
            TestItem.StaffPhone = "07777789687";
            TestItem.StaffRole = "admin";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList; 
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create soem test data to assign to the property
            Int32 SomeCount = 2;
            //add item to the list 
            AllStaff.Count = SomeCount; 
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //in this case the data need to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add item to the list 
            clsStaff TestItem = new clsStaff();
            //add an item to the list
            TestItem.StaffName = "Thamer";
            TestItem.Email = "th@thamer.com";
            TestItem.StaffPhone = "07777789687";
            TestItem.StaffRole = "admin";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, 2);
        }
    }
}
