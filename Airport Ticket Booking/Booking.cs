namespace Airport_Ticket_Booking;

public class Booking
{
    public Flights flight { get; }
    public string name;
    public int id;
    public int? passenger;

    public Booking(string name, int id, Flights flight,int? passenger)
    {
        this.name = name;
        this.id = id;
        this.flight = flight;
        this.passenger = passenger;
    }
    
    public override string ToString()
    {
        return $"{name},{id},{flight.ID},{flight.Price},{flight.Departure_Country}," +
               $"{flight.Destination_Country},{flight.Departure_Date},{flight.Departure_Airport},{flight.Arrival_Airport},{flight.Class}";
    }
    
}