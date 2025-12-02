
    public class Hotel
    {
        private int hotelID;
        private string hotelName;
        private string hotelPhone;
        private string hotelEmail;
        private string hotelAddress;
        private string hotelCity;
        private string hotelState;
        private string hotelZip;
        private string hotelCountry;
        private string hotelImage;
        private string hotelDescription;
        private int hotelRating;
        private int hotelRoomCount;
        private List<HotelRoom> listHotelRooms;

        public int HotelID { get { return hotelID; } set { hotelID = value; } }
        public string HotelName { get { return hotelName; } set { hotelName = value; } }
        public string HotelPhone { get { return hotelPhone; } set { hotelPhone = value; } }
        public string HotelEmail { get { return hotelEmail; } set { hotelEmail = value; } }
        public string HotelAddress { get { return hotelAddress; } set { hotelAddress = value; } }
        public string HotelCity { get { return hotelCity; } set { hotelCity = value; } }
        public string HotelState { get { return hotelState; } set { hotelState = value; } }
        public string HotelZip { get { return hotelZip; } set { hotelZip = value; } }
        public string HotelCountry { get { return hotelCountry; } set { hotelCountry = value; } }
        public string HotelImage { get { return hotelImage; } set { hotelImage = value; } }
        public string HotelDescription { get { return hotelDescription; } set { hotelDescription = value; } }
        public int HotelRating { get { return hotelRating; } set { hotelRating = value; } }
        public int HotelRoomCount { get { return hotelRoomCount; } set { hotelRoomCount = value; } }

        public List<HotelRoom> ListHotelRooms { get { return listHotelRooms; } set { listHotelRooms = value; } }

        public Hotel()
        {
            hotelID = -9999;
            hotelName = "";
            hotelPhone = "";
            hotelEmail = "";
            hotelAddress = "";
            hotelCity = "";
            hotelState = "";
            hotelZip = "";
            hotelCountry = "";
            hotelImage = "";
            hotelDescription = "";
            hotelRoomCount = 0;
            hotelRating = 3;
            listHotelRooms = new List<HotelRoom>();
        }

        public Hotel(int hotelID, string hotelName, string hotelPhone,
            string hotelEmail, string hotelAddress, string hotelCity,
            string hotelState, string hotelZip, string hotelCountry,
            string hotelImage, string hotelDescription, int hotelRating, int hotelRoomCount,
            List<HotelRoom> rooms)
        {
            this.hotelID = hotelID;
            this.hotelName = hotelName;
            this.hotelPhone = hotelPhone;
            this.hotelEmail = hotelEmail;
            this.hotelAddress = hotelAddress;
            this.hotelCity = hotelCity;
            this.hotelState = hotelState;
            this.hotelZip = hotelZip;
            this.hotelCountry = hotelCountry;
            this.hotelImage = hotelImage;
            this.hotelDescription = hotelDescription;
            this.hotelRating = hotelRating;
            this.hotelRoomCount = hotelRoomCount;
            listHotelRooms = rooms;
        }


    }

