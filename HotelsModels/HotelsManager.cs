
// ============================================================
//            Hotel and Hotelroom API Examples
// ============================================================


// Retrieving Basic Hotel Classes
public List<Hotel> GetAllHotels(SearchCriteria search)
{
    // Since this is a GET request, no request body is passed
    List<Hotel> hotels = new List<Hotel>();

    // Set up the client to send the request
    HttpClient client = new HttpClient();

    // Ensure that it is a POST type and not a GET type
    HttpResponseMessage response = client.GetAsync($"https://cis-iis2.temple.edu/Fall2025/CIS3342_tuq23078/WebAPI/" +
        $"VictoriaAPIs/Hotels/GetHotels/{search.DestinationCity}/{search.DestinationState}").Result;

    // Wait and receive the response. If the response is successful, 
    // deserialize the response body and get the results 

    if (response.IsSuccessStatusCode)
    {
        string jsonResults = response.Content.ReadAsStringAsync().Result;
        hotels = JsonSerializer.Deserialize<List<Hotel>>(jsonResults);
    }
    listHotels = hotels;
    return hotels;
}

public List<HotelRoom> GetAllRoomsByHotel(Hotel hotel, DateTime start, DateTime end)
{

    List<HotelRoom> rooms = new List<HotelRoom>();
    // Set up the client to send the request
    HttpClient client = new HttpClient();

    // Ensure that it is a POST type and not a GET type
    HttpResponseMessage response = client.GetAsync($"https://cis-iis2.temple.edu/Fall2025/CIS3342_tuq23078/WebAPI/" +
        $"VictoriaAPIs/Hotels/GetRoomsByHotel/{hotel.HotelID}/{start.ToString("MM-dd-yyyy")}/{end.ToString("MM-dd-yyyy")}").Result;

    if (response.IsSuccessStatusCode)
    {
        string jsonResults = response.Content.ReadAsStringAsync().Result;
        rooms = JsonSerializer.Deserialize<List<HotelRoom>>(jsonResults);
    }
    listHotelRooms = rooms;
    return rooms;
}


public List<HotelRoom> GetAllRoomsByAmenities(List<HotelAmenity> amenities)
{
    List<HotelRoom> rooms = new List<HotelRoom>();

    // Create a Http Client
    HttpClient client = new HttpClient();

    // Create a post request
    string amenitiesJSON = JsonSerializer.Serialize(amenities);
    StringContent body = new StringContent(amenitiesJSON);
    body.Headers.ContentType = new MediaTypeHeaderValue("application/json");

    // Create and send the respond
    HttpResponseMessage response = client.PostAsync($"https://cis-iis2.temple.edu/Fall2025/CIS3342_tuq23078/WebAPI/" +
        $"VictoriaAPIs/Hotels/FindRooms/Amenities", body).Result;

    // Check if the response came through and hope for the best
    if (response.IsSuccessStatusCode)
    {

        // Deserialization time
        string jsonResults = response.Content.ReadAsStringAsync().Result;
        rooms = JsonSerializer.Deserialize<List<HotelRoom>>(jsonResults);
    }

    ListHotelRooms = rooms;
    return rooms;
}

// ============================================================
//            Hotel and Hotelroom Filters to Use
// ============================================================

public List<HotelRoom> FilterRoomsByAmenities(List<string> amenities)
{
    // Create empty list to return hotel rooms
    List<HotelRoom> filteredHotelRooms = new List<HotelRoom>();
    
    // Create the content to be passed to the reponse, specifically convert list of strings to a JSON format
    string amenitiesJSON = JsonSerializer.Serialize(amenities);
    StringContent body = new StringContent(amenitiesJSON);
    body.Headers.ContentType = new MediaTypeHeaderValue("application/json");

    // Set up the client to send the request
    HttpClient client = new HttpClient();

    // Ensure that it is a POST type and not a GET type
    HttpResponseMessage response = client.PostAsync($"https://cis-iis2.temple.edu/Fall2025/CIS3342_tuq23078/WebAPI/" +
        $"VictoriaAPIs/Hotels/FindRoomsByHotel/{chosenHotel.HotelID}/{chosenHotel.HotelCity}/{chosenHotel.HotelCountry}", body).Result;

    // Wait and receive the response. If the response is successful, 
    // deserialize the response body and get the results 

    if (response.IsSuccessStatusCode)
    {
        string jsonResults = response.Content.ReadAsStringAsync().Result;
        filteredHotelRooms = JsonSerializer.Deserialize<List<HotelRoom>>(jsonResults);
    }
    listHotelRooms = filteredHotelRooms;
    return filteredHotelRooms;

}


public List<Hotel> FilterHotelsByLocation(string city, string state, string country)
{
    List<Hotel> filteredHotels = new List<Hotel>();

    foreach (Hotel hotel in listHotels)
    {
        if (hotel.HotelCity == city && hotel.HotelState == state && hotel.HotelCountry == country)
        {
            filteredHotels.Add(hotel);
        }
    }
    return filteredHotels;
}

public List<Hotel> FilterHotelsByRating(int rating)
{
    List<Hotel> filteredHotels = new List<Hotel>();

    foreach (Hotel hotel in listHotels)
    {
        if (hotel.HotelRating == rating)
        {
            filteredHotels.Add(hotel);
        }
    }
    listHotels = filteredHotels;
    return filteredHotels;
}

public List<Hotel> FilterHotelsByName(string name)
{
    List<Hotel> filteredHotels = new List<Hotel>();

    foreach (Hotel hotel in listHotels)
    {
        if (hotel.HotelName == name)
        {
            filteredHotels.Add(hotel);
        }
    }
    listHotels = filteredHotels;
    return filteredHotels;
}

// Hotel Room Filters
public List<HotelRoom> FilterRoomsByCost(double maxCost)
{
    List<HotelRoom> filteredHotelRooms = new List<HotelRoom>();
    foreach (HotelRoom room in listHotelRooms)
    {
        if (room.CostPerNight <= maxCost)
        {
            filteredHotelRooms.Add(room);
        }
    }
    listHotelRooms = filteredHotelRooms;
    return filteredHotelRooms;
}

public List<HotelRoom> FilterRoomsByOccupancy(int people)
{
    List<HotelRoom> filteredHotelRooms = new List<HotelRoom>();
    foreach (HotelRoom room in listHotelRooms)
    {
        if (room.RoomOccupancy >= people)
        {
            filteredHotelRooms.Add(room);
        }
    }
    listHotelRooms = filteredHotelRooms;
    return filteredHotelRooms;
}




// Check if a hotelroom exists in the list
public Boolean IsRoomInList(List<BookedHotelRoom> list, BookedHotelRoom chosenRoom)
{

    foreach (BookedHotelRoom room in list)
    {
        if (chosenRoom.HotelRoom.HotelRoomID == room.HotelRoom.HotelRoomID)
        {
            return true;
        }
    }
    return false;
}

// Find Hotel By ID, Get Hotel by HotelRoom
public Hotel FindHotelByID(int hotelID)
{
    foreach (Hotel hotel in listHotels)
    {
        if (hotel.HotelID == hotelID)
        {
            return hotel;
        }
    }
    return null;
}

public HotelRoom FindHotelRoomByID(int hotelID, int hotelRoomID) {
    foreach (HotelRoom room in listHotelRooms) {
        if (room.HotelID == hotelID && room.HotelRoomID == hotelRoomID) {
            return room;
        }
    }
    return null;
}
