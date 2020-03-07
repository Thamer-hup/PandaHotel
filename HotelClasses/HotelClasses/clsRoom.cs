namespace HotelClasses
{
    public class clsRoom
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public int FloorNo { get; set; }
        public string RoomType { get; set; }
        public double DailyCharge { get; set; }
        public bool AvailableForBooking { get; set; }
    }
}