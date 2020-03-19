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
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();

            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 100;
            //assign the data to the property
            AStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffId, TestData);
        }
        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Thamer";
            //assign the data to the property
            AStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }
        [TestMethod]
        public void StaffPhonePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "07899999999";
            //assign the data to the property
            AStaff.StaffPhone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffPhone, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "th@thamer.com";
            //assign the data to the property
            AStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1; // id for staff 2 for admin
            //assign the data to the property
            AStaff.StaffRoleId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffRoleId, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //bool variable for resutl validation
            Boolean Found = false;
            //create soem test data 
            Int32 StaffId = 1;
            Found = AStaff.Find(StaffId); 
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //bool variable for resutl validation
            Boolean Found = false;
            Boolean OK = true; 
            
            //create soem test data 
            Int32 StaffId = 1;
            Found = AStaff.Find(StaffId);
            if(AStaff.StaffId != 1)
            {
                OK = false; 
            }

            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        string tStaffName = "Thamer Alhazmi";
        string tStaffPhone = "07778889999";
        string tStaffEmail = "thamer@sky.com";
        bool tActive = true;
        int tStaffRoleId = 1; // for staff 

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(tStaffName, tStaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreEqual(Error, ""); 
           
        }
        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffName = ""; 
            Error = AStaff.Valid(StaffName, tStaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffName = "a";
            Error = AStaff.Valid(StaffName, tStaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffName = "aa";
            Error = AStaff.Valid(StaffName, tStaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffName = "aaaaaaaaaaaaaaaaaaa"; // 19 characters
            Error = AStaff.Valid(StaffName, tStaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffName = "aaaaaaaaaaaaaaaaaaaa"; // 20 characters
            Error = AStaff.Valid(StaffName, tStaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffName = "aaaaaaaaaa"; // 10 characters
            Error = AStaff.Valid(StaffName, tStaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffName = "aaaaaaaaaaaaaaaaaaaaa"; // 21 characters
            Error = AStaff.Valid(StaffName, tStaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');  // 21 characters
            Error = AStaff.Valid(StaffName, tStaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "a@a.co";
            Error = AStaff.Valid(tStaffName, tStaffPhone, StaffEmail, tActive, tStaffRoleId);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "a@a.com";
            Error = AStaff.Valid(tStaffName, tStaffPhone, StaffEmail, tActive, tStaffRoleId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffEmailNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "a0@a.com"; // 8 characters
            Error = AStaff.Valid(tStaffName, tStaffPhone, StaffEmail, tActive, tStaffRoleId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@a.com"; // 49 characters 
            Error = AStaff.Valid(tStaffName, tStaffPhone, StaffEmail, tActive, tStaffRoleId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@a.com"; // 50 characters 
            Error = AStaff.Valid(tStaffName, tStaffPhone, StaffEmail, tActive, tStaffRoleId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@a.com"; // 51 characters 
            Error = AStaff.Valid(tStaffName, tStaffPhone, StaffEmail, tActive, tStaffRoleId);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailAtSignTest()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "thamersky.com"; // contains no  @ sign 
            Error = AStaff.Valid(tStaffName, tStaffPhone, StaffEmail, tActive, tStaffRoleId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffPhone = "0888888888"; // 10 nos 
            Error = AStaff.Valid(tStaffName, StaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffPhone = "+888888888888888"; // 16 nos 
            Error = AStaff.Valid(tStaffName, StaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffPhoneMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffPhone = "+8888888888888887"; // 17 nos 
            Error = AStaff.Valid(tStaffName, StaffPhone, tStaffEmail, tActive, tStaffRoleId);
            Assert.AreNotEqual(Error, "");

        }


    }
}
