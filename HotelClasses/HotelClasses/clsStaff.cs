using System;

namespace HotelClasses
{
    public class clsStaff
    {
        private int mStaffId; 
        public int StaffId
        {
            get {
                return mStaffId; 
            }
            set
            {
                mStaffId = value; 
            }
        }
        private string mStaffName; 
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }
        private string mStaffPhone;
        public string StaffPhone
        {
            get
            {
                return mStaffPhone;
            }
            set
            {
                mStaffPhone = value;
            }
        }
        private string mEmail; 
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        private bool mActive; 

            //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }
        private int mStaffRoleId;
        public int StaffRoleId
        {
            get
            {
                //return the private data
                return mStaffRoleId;
            }
            set
            {
                //set the private data
                mStaffRoleId = value;
            }
        }

        public bool Find(int StaffId)
        {
            clsDataConnection dB = new clsDataConnection();
            dB.AddParameter("StaffId", StaffId);
            dB.Execute("sproc_tblStaff_FilterByStaffId");
            if (dB.Count == 1)
            {
                clsStaff TestItem = new clsStaff();
                //add an item to the list
                mStaffId = Convert.ToInt32(dB.DataTable.Rows[0]["StaffId"]);
                mStaffName = Convert.ToString(dB.DataTable.Rows[0]["StaffName"]);
                mEmail = Convert.ToString(dB.DataTable.Rows[0]["Email"]);
                mActive = Convert.ToBoolean(dB.DataTable.Rows[0]["Active"]);
                mStaffPhone = Convert.ToString(dB.DataTable.Rows[0]["StaffPhone"]);
                mStaffRoleId = Convert.ToInt32(dB.DataTable.Rows[0]["StaffRoleId"]);
                return true; 
            }
            else
            {
                return false; 
            }

        }

        public string Valid(string pStaffName, string pStaffPhone, string pStaffEmail, bool pActive, int pStaffRoleId)
        {
            string Error = ""; 
            if(pStaffName.Length == 0)
            {
                Error = Error + "The staff name may not be blank.";
            }
            if (pStaffName.Length > 20)
            {
                Error = Error + "The staff name must be less than 20 characters.";
            }
            if (pStaffEmail.Length <= 6)
            {
                Error = Error + "The staff email can not be less then 7 characters.";
            }
            if (pStaffEmail.Length > 50)
            {
                Error = Error + "The staff email can not be more then 50 characters.";
            }
            if (!pStaffEmail.Contains("@"))
            {
                Error = Error + "The staff email is not in the right format.";
            }
            if (pStaffPhone.Length <= 11)
            {
                Error = Error + "The staff phone can not be less then 11 characters.";
            }
            if (pStaffPhone.Length > 16)
            {
                Error = Error + "The staff email can not be more then 16 characters.";
            }
            return Error; 
        }
    }
}