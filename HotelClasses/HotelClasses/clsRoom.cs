using System;

namespace HotelClasses
{
    public class clsRoom
    {
        private int mRoomId; 
        public int RoomId 
        {
            get
            {
                return mRoomId;
            }
            set
            {
                mRoomId = value;
            }
        }
        private string mRoomNumber;
        public string RoomNumber
        {
            get
            {
                return mRoomNumber;
            }
            set
            {
                mRoomNumber = value;
            }
        }
        private int mFloorNo;
        public int FloorNo 
        {
            get
            {
                return mFloorNo;
            }
            set
            {
                mFloorNo = value;
            }
        }
        private int mRoomTypeId;
        public int RoomTypeId 
        {
            get
            {
                return mRoomTypeId;
            }
            set
            {
                mRoomTypeId = value;
            }
        }

        private double mDailyCharge;
        public double DailyCharge
        {
            get
            {
                return mDailyCharge;
            }
            set
            {
                mDailyCharge = value;
            }
        }

        private bool mAvailableForBooking;
        public bool AvailableForBooking
        {
            get
            {
                return mAvailableForBooking;
            }
            set
            {
                mAvailableForBooking = value;
            }
        }

        public string Valid(string text1, string text2, string text3, object @checked, int v)
        {
            return "";
        }

        public bool Find(int RoomId)
        {
            clsDataConnection dB = new clsDataConnection();
            dB.AddParameter("RoomId", RoomId);
            dB.Execute("sproc_tblRoom_FilterByRoomId");
            if (dB.Count == 1)
            {
                clsStaff TestItem = new clsStaff();
                //add an item to the list
                mRoomId = Convert.ToInt32(dB.DataTable.Rows[0]["RoomId"]);
                mRoomNumber = Convert.ToString(dB.DataTable.Rows[0]["RoomNumber"]);
                mFloorNo = Convert.ToInt32(dB.DataTable.Rows[0]["FloorNo"]);
                mRoomTypeId = Convert.ToInt32(dB.DataTable.Rows[0]["RoomTypeId"]);
                mDailyCharge = Convert.ToInt32(dB.DataTable.Rows[0]["DailyCharge"]);
                mAvailableForBooking = Convert.ToBoolean(dB.DataTable.Rows[0]["AvailableForBooking"]);

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}