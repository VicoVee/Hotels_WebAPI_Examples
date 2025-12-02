using System;

namespace Project3V2.Models
{
    [Serializable]
    public class HotelAmenity
    {
        private int amenityID;
        private string amenityName;
        private string amenityDescription;
        private string amenityImage;
        private double amenityCost;

        public int AmenityID { get { return amenityID; } set { amenityID = value; } }
        public string AmenityName { get { return amenityName; } set { amenityName = value; } }
        public string AmenityDescription { get { return amenityDescription; } set { amenityDescription = value; } }
        public string AmenityImage { get { return amenityImage; } set { amenityImage = value; } }
        public double AmenityCost { get { return amenityCost; } set { amenityCost = value; } }

        public HotelAmenity()
        {
            amenityID = -9999;
            amenityName = "";
            amenityDescription = "";
            amenityImage = "";
            amenityCost = 0.0;
        }

        public HotelAmenity(int amenityID, string amenityName, string amenityDescription, string amenityImage, double amenityCost)
        {
            this.amenityID = amenityID;
            this.amenityName = amenityName;
            this.amenityDescription = amenityDescription;
            this.amenityImage = amenityImage;
            this.amenityCost = amenityCost;
        }


        public string DisplayAmenity()
        {
            string strHTML = $"<div class='amenitiyChip'> " +
                $"{amenityName}" +
                $"</div>";
            return strHTML;
        }
    }
}
