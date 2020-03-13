using System;

namespace HotelClasses
{
    public class clsStaff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffPhone { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public string StaffRole { get; set; }

        public bool Find(int StaffName)
        {
            return true; 
        }

        public string Valid(string text1, string text2, string text3, bool @checked, string selectedValue)
        {
            return "";
        }
    }
}