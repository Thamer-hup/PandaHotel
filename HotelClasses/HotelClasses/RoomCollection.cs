using System;
using System.Collections.Generic;

namespace HotelClasses
{
    public class clsRoomCollection 
    {
        List<clsRoom> mRoomList;
        public List<clsRoom> RoomList
        {
            get
            {
                return mRoomList;
            }
            set
            {
                mRoomList = value;
            }
        }

        public clsRoom mThisRoom = new clsRoom();

        public clsRoom ThisRoom
        {
            get
            {
                return mThisRoom;
            }
            set
            {
                mThisRoom = value;
            }
        }
        public int Count
        {
            get
            {
                return mRoomList.Count;
            }
            set
            {

            }
        }

        public clsRoomCollection()
        {
            clsDataConnection dB = new clsDataConnection();
            dB.Execute("sproc_tblRoom_SelectAll");
            PopulateArray(dB);


        }

        public int Add()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("RoomNumber", mThisRoom.RoomNumber);
            db.AddParameter("FloorNo", mThisRoom.FloorNo);
            db.AddParameter("RoomTypeId", mThisRoom.RoomTypeId);
            db.AddParameter("DailyCharge", mThisRoom.DailyCharge);
            db.AddParameter("AvailableForBooking", mThisRoom.AvailableForBooking);
            return db.Execute("sproc_tblRoom_Insert");
            //mThisStaff.StaffId = 123;
            //return mThisStaff.StaffId; 
        }



        public void Update()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("RoomId", mThisRoom.RoomId);
            db.AddParameter("RoomNumber", mThisRoom.RoomNumber);
            db.AddParameter("FloorNo", mThisRoom.FloorNo);
            db.AddParameter("RoomTypeId", mThisRoom.RoomTypeId);
            db.AddParameter("DailyCharge", mThisRoom.DailyCharge);
            db.AddParameter("AvailableForBooking", mThisRoom.AvailableForBooking);
            db.Execute("sproc_tblRoom_Update");
        }

        public void ReportByRoomNumber(string sName)
        {
            clsDataConnection dB = new clsDataConnection();
            dB.AddParameter("@RoomNumber", sName);
            dB.Execute("sproc_tblRoom_FilterByRoomNumber");
            PopulateArray(dB);
        }
        void PopulateArray(clsDataConnection dB)
        {
            mRoomList = new List<clsRoom>();
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = dB.Count;
            while (Index < RecordCount)
            {
                clsRoom TestItem = new clsRoom();
                //add an item to the list
                TestItem.RoomId = Convert.ToInt32(dB.DataTable.Rows[Index]["RoomId"]);
                TestItem.RoomNumber = Convert.ToString(dB.DataTable.Rows[Index]["RoomNumber"]);
                TestItem.FloorNo = Convert.ToInt32(dB.DataTable.Rows[Index]["FloorNo"]);
                TestItem.RoomTypeId = Convert.ToInt32(dB.DataTable.Rows[Index]["RoomTypeId"]);
                TestItem.DailyCharge = Convert.ToDouble(dB.DataTable.Rows[Index]["DailyCharge"]);
                TestItem.AvailableForBooking = Convert.ToBoolean(dB.DataTable.Rows[Index]["AvailableForBooking"]);
                mRoomList.Add(TestItem);
                Index++;
            }
        }
    }
}