namespace HotelWebAPI.Models
{
    public class BookedHotelRoom
    {
        public Customer Customer { get; set; }
        public HotelRoom HotelRoom { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public double TotalCost { get { return CalculateTotalCost(); } }
        public int HotelBookingID { get; set; }

        public double CalculateTotalCost()
        {
            // So for days that are in the next month (1,2,3, etc.), ensure that 
            // the absolute value is given
            // Add 1 day for same day bookings
            if (HotelRoom != null && CheckInDate != null && CheckOutDate != null)
            {
                int totalDays = Math.Abs(CheckOutDate.Day - CheckInDate.Day) + 1;
                return totalDays * HotelRoom.CostPerNight;
            }
            return -9999;
        }
    }
}
