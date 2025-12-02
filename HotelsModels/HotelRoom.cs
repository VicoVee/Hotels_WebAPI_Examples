
    public class HotelRoom
    {
        private int hotelRoomID;
        private int hotelID;
        private int roomOccupancy;
        private string bedType;
        private double costPerNight;
        private double baseCost;
        private string luxuryType;
        private string hotelRoomImage;
        private string hotelRoomDescription;
        private List<HotelAmenity> listHotelAmenities;

        public int HotelRoomID { get { return hotelRoomID; } set { hotelRoomID = value; } }
        public int HotelID { get { return hotelID; } set { hotelID = value; } }
        public int RoomOccupancy { get { return roomOccupancy; } set { roomOccupancy = value; } }
        public string BedType { get { return bedType; } set { bedType = value; } }
        public double CostPerNight { get { return CalculateDailyCost(); } }
        public double BaseCost { get { return baseCost; } set { baseCost = value; } }
        public string LuxuryType { get { return luxuryType; } set { luxuryType = value; } }
        public string HotelRoomImage { get { return hotelRoomImage; } set { hotelRoomImage = value; } }
        public string HotelRoomDescription { get { return hotelRoomDescription; } set { hotelRoomDescription = value; } }
        public List<HotelAmenity> ListHotelAmenities { get { return listHotelAmenities; } set { listHotelAmenities = value; } }
        public HotelRoom()
        {
            hotelRoomID = -9999;
            hotelID = -9999;
            roomOccupancy = 0;
            bedType = "Single";
            baseCost = 0.0;
            luxuryType = "Standard";
            hotelRoomImage = "";
            hotelRoomDescription = "The average room";
            listHotelAmenities = new List<HotelAmenity>();
            costPerNight = CalculateDailyCost();
        }

        public HotelRoom(int hotelRoomID, int hotelID, int roomOccupancy,
            string bedType, double baseCost, string luxuryType,
            string hotelRoomImage, string hotelRoomDescription, List<HotelAmenity> list)
        {
            this.hotelRoomID = hotelRoomID;
            this.hotelID = hotelID;
            this.roomOccupancy = roomOccupancy;
            this.bedType = bedType;
            this.baseCost = baseCost;
            this.luxuryType = luxuryType;
            this.hotelRoomImage = hotelRoomImage;
            this.hotelRoomDescription = hotelRoomDescription;
            this.listHotelAmenities = list;

            this.costPerNight = CalculateDailyCost();
        }

        public double CalculateDailyCost()
        {
            double totalCost = 0;
            List<HotelAmenity> listHotelAmentities = new List<HotelAmenity>();

            foreach (HotelAmenity amentity in listHotelAmenities)
            {
                totalCost += amentity.AmenityCost;
            }

            totalCost += baseCost;

            return totalCost;
        }

        public string DisplayAllAmenities()
        {
            string strHTML = "<h4>Amenities</h4>";
            foreach (HotelAmenity amentity in listHotelAmenities)
            {
                strHTML += $"{amentity.DisplayAmenity()}<br/>";
            }
            return strHTML + "";
        }
    }
