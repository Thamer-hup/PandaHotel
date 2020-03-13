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
            mStaffList = new List<clsStaff>();
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection dB = new clsDataConnection();
            dB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = dB.Count; 
            while(Index < RecordCount)
            {
                clsStaff TestItem = new clsStaff();
                //add an item to the list
                TestItem.StaffId = Convert.ToInt32(dB.DataTable.Rows[Index]["StaffId"]);
                TestItem.StaffName = Convert.ToString(dB.DataTable.Rows[Index]["StaffName"]);
                TestItem.Email = Convert.ToString(dB.DataTable.Rows[Index]["Email"]);
                TestItem.StaffPhone = Convert.ToString(dB.DataTable.Rows[Index]["Phone"]); 
                TestItem.StaffRole = Convert.ToString(dB.DataTable.Rows[Index]["StaffRole"]);
                mStaffList.Add(TestItem);
                Index++; 
            }


           
        }

        public int Add()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("StaffName", mThisStaff.StaffName);
            db.AddParameter("StaffPhone", mThisStaff.StaffPhone);
            db.AddParameter("StaffEmail", mThisStaff.Email);
            db.AddParameter("Active", mThisStaff.Active);
            db.AddParameter("StaffRole", mThisStaff.StaffRole);
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
            db.AddParameter("StaffRole", mThisStaff.StaffRole);
            db.Execute("sproc_tblStaff_Update");
        }
    }
}