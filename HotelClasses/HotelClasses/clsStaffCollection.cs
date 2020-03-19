using System;
using System.Collections.Generic;

namespace HotelClasses
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList; 
        public  List<clsStaff> StaffList
        {
            get
            {
                return mStaffList; 
            }
            set
            {
                mStaffList = value; 
            }
        }

        public clsStaff mThisStaff = new clsStaff(); 

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff; 
            }
            set
            {
                mThisStaff = value; 
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count; 
            }
            set
            {

            }
        }

        public clsStaffCollection()
        {
            clsDataConnection dB = new clsDataConnection();
            dB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(dB); 

            //mStaffList = new List<clsStaff>();
            //Int32 Index = 0;
            //Int32 RecordCount = 0;
            //clsDataConnection dB = new clsDataConnection();
            //dB.Execute("sproc_tblStaff_SelectAll");
            //RecordCount = dB.Count; 
            //while(Index < RecordCount)
            //{
            //    clsStaff TestItem = new clsStaff();
            //    //add an item to the list
            //    TestItem.StaffId = Convert.ToInt32(dB.DataTable.Rows[Index]["StaffId"]);
            //    TestItem.StaffName = Convert.ToString(dB.DataTable.Rows[Index]["StaffName"]);
            //    TestItem.Email = Convert.ToString(dB.DataTable.Rows[Index]["Email"]);
            //    TestItem.Active = Convert.ToBoolean(dB.DataTable.Rows[Index]["Active"]);
            //    TestItem.StaffPhone = Convert.ToString(dB.DataTable.Rows[Index]["StaffPhone"]); 
            //    TestItem.StaffRoleId = Convert.ToInt32(dB.DataTable.Rows[Index]["StaffRoleId"]);
            //    mStaffList.Add(TestItem);
            //    Index++; 
            //}


           
        }

        public int Add()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("StaffName", mThisStaff.StaffName);
            db.AddParameter("StaffPhone", mThisStaff.StaffPhone);
            db.AddParameter("StaffEmail", mThisStaff.Email);
            db.AddParameter("Active", mThisStaff.Active);
            db.AddParameter("StaffRoleId", mThisStaff.StaffRoleId);
            return db.Execute("sproc_tblStaff_Insert"); 
            //mThisStaff.StaffId = 123;
            //return mThisStaff.StaffId; 
        }

        public void Delete()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("StaffId", mThisStaff.StaffId);
            
            db.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("StaffId", mThisStaff.StaffId);
            db.AddParameter("StaffName", mThisStaff.StaffName);
            db.AddParameter("StaffPhone", mThisStaff.StaffPhone);
            db.AddParameter("StaffEmail", mThisStaff.Email);
            db.AddParameter("Active", mThisStaff.Active);
            db.AddParameter("StaffRoleId", mThisStaff.StaffRoleId);
            db.Execute("sproc_tblStaff_Update");
        }

        public void ReportByStaffName(string sName)
        {
            clsDataConnection dB = new clsDataConnection();
            dB.AddParameter("@StaffName", sName); 
            dB.Execute("sproc_tblStaff_FilterByStaffName");
            PopulateArray(dB); 
        }
        void PopulateArray(clsDataConnection dB)
        {
            mStaffList = new List<clsStaff>();
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = dB.Count;
            while (Index < RecordCount)
            {
                clsStaff TestItem = new clsStaff();
                //add an item to the list
                TestItem.StaffId = Convert.ToInt32(dB.DataTable.Rows[Index]["StaffId"]);
                TestItem.StaffName = Convert.ToString(dB.DataTable.Rows[Index]["StaffName"]);
                TestItem.Email = Convert.ToString(dB.DataTable.Rows[Index]["Email"]);
                TestItem.Active = Convert.ToBoolean(dB.DataTable.Rows[Index]["Active"]);
                TestItem.StaffPhone = Convert.ToString(dB.DataTable.Rows[Index]["StaffPhone"]);
                TestItem.StaffRoleId = Convert.ToInt32(dB.DataTable.Rows[Index]["StaffRoleId"]);
                mStaffList.Add(TestItem);
                Index++;
            }
        }
    }
}