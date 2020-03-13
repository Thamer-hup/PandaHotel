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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //in this case the data need to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //var to store primary key
            Int32 Primarykey = 0; 
            //add item to the list 
            clsStaff TestItem = new clsStaff();
            //add an item to the list
            TestItem.StaffName = "Thamer";
            TestItem.Email = "th@thamer.com";
            TestItem.StaffPhone = "07777789687";
            TestItem.StaffRole = "admin";
            //set this staff to the test item
            AllStaff.ThisStaff = TestItem;
            //add the record
            Primarykey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffId = Primarykey;
            // find the record
            AllStaff.ThisStaff.Find(Primarykey); 
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //var to store primary key
            Int32 Primarykey = 0;
            //add item to the list 
            clsStaff TestItem = new clsStaff();
            //add an item to the list
            TestItem.StaffName = "Thamer";
            TestItem.Email = "th@thamer.com";
            TestItem.StaffPhone = "07777789687";
            TestItem.StaffRole = "admin";
            TestItem.Active = true; 
            //set this staff to the test item
            AllStaff.ThisStaff = TestItem;
            //add the record
            Primarykey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffId = Primarykey;
            // find the record
            AllStaff.ThisStaff.Find(Primarykey);
            //
            AllStaff.Delete(); 
            // now find the record 
            Boolean Found = AllStaff.ThisStaff.Find(Primarykey);
            //test to see that the two values are the same
            Assert.IsFalse(Found); 

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //add item to the list 
            clsStaff TestItem = new clsStaff();
            //var to store primary key
            Int32 Primarykey = 0;
            //add an item to the list
            TestItem.StaffName = "Thamer";
            TestItem.Email = "th@thamer.com";
            TestItem.Active = true;
            TestItem.StaffPhone = "07777789687";
            TestItem.StaffRole = "admin";
            //set this staff to the test item
            AllStaff.ThisStaff = TestItem;
            //add the record
            Primarykey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffId = Primarykey;
            //modify the test data 
            TestItem.StaffName = "ThamerU";
            TestItem.Email = "Uth@thamer.com";
            TestItem.Active = false;
            TestItem.StaffPhone = "07777789687";
            TestItem.StaffRole = "staff";
            AllStaff.ThisStaff = TestItem;
            // update the record
            AllStaff.Update(); 
            // find the record
            AllStaff.ThisStaff.Find(Primarykey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }
    }
}
