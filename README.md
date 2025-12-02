# Hotels_WebAPI_Examples
An example of how to use the hotels api!

For the general APIs to get the hotels, hotel rooms, etc. these DO NOT require the API keys

For the Reservation, it does need a key. To start, call the GenerateAPIKey() and pass in:
- A fake username
- A fake password
- A fake site name
These WILL NOT be used for verification or anything. If you do forget your API key, just generate a new one

This API will return two valuable things:
- API Token (KEEP THIS)
- Travelsite ID (KEEP THIS)
You will need both of these values to Reserve a room

For the POST ReserveRoom(), it is a little more complex.
It requires a Customer model, which I have placed here and also in the documentation in the JSON.


