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
    }
}