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
    }
}