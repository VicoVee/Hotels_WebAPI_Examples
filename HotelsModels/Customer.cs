
public class Customer
{
    public int UserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    // Store the vacation start and end date here
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    // I made the customer model more lighter and simpler
    // Please refer to swagger for the most recent model
    // But only the name and email + phone is needed. The UserID will be generated automativally from my API
    
    // public string Password { get; set; }
    // public string Address { get; set; }
    // public string City { get; set; }
    // public string State { get; set; }
    // public string ZipCode { get; set; }
    // public string Country { get; set; }


}

