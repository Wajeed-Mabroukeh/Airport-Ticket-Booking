namespace Airport_Ticket_Booking;

public class Search
{
    public readonly string filePath_Flights = @"C:\Users\wajed\RiderProjects\Airport Ticket Booking\Airport Ticket Booking\Flights.txt";
    public readonly string filePath_Booking = @"C:\Users\wajed\RiderProjects\Airport Ticket Booking\Airport Ticket Booking\Booking.txt";
    public static List<Flights> flightsList = new ();
    public static List<Booking> bookingsList = new ();
    public  static List<Flights> result_search = new ();
    
    public  List<Flights> Search_for_price(double price)
    {
        result_search.Clear();
        foreach (var flight in flightsList)
        {
            if (flight.Price == price)
            {
                result_search.Add(flight);
            }
        }
        return result_search;
    }
    public  List<Flights> Search_for_DepartureCountry(string Departure_Country)
    {
        result_search.Clear();
        foreach (var flight in flightsList)
        {
            if (flight.Departure_Country == Departure_Country)
            {
                result_search.Add(flight);
            }
        }
        return result_search;
    }
    public  List<Flights> Search_for_DestinationCountry(string Destination_Country)
    {
        result_search.Clear();
        foreach (var flight in flightsList)
        {
            if (flight.Destination_Country == Destination_Country)
            {
                result_search.Add(flight);
            }
        }
        return result_search;
    }
    public  List<Flights> Search_for_Departure_Date(string Departure_Date)
    {
        result_search.Clear();
        foreach (var flight in flightsList)
        {
            if (flight.Departure_Date == Departure_Date)
            {
                result_search.Add(flight);
            }
        }
        return result_search;
    }
    public  List<Flights> Search_for_Departure_Airport(string Departure_Airport)
    {
        result_search.Clear();
        foreach (var flight in flightsList)
        {
            if (flight.Departure_Airport == Departure_Airport)
            {
                result_search.Add(flight);
            }
        }
        return result_search;
    }
    public  List<Flights> Search_for_Arrival_Airport(string Arrival_Airport)
    {
        result_search.Clear();
        foreach (var flight in flightsList)
        {
            if (flight.Arrival_Airport == Arrival_Airport)
            {
                result_search.Add(flight);
            }
        }
        return result_search;
    }
    public  List<Flights> Search_for_Class(int clas)
    {
        result_search.Clear();
        foreach (var flight in flightsList)
        {
            if (flight.Class == clas)
            {
                result_search.Add(flight);
            }
        }
        return result_search;
    }

    public List<Flights> Search_for_Flight(int flight_ID)
    {
        result_search.Clear();
        foreach (var flight in flightsList)
        {
            if (flight.ID == flight_ID)
            {
                result_search.Add(flight);
            }
        }
        return result_search;
    }
    public List<Flights> Search_for_Passengers(int passenger)
    {
        result_search.Clear();
        foreach (var flight in flightsList)
        {
            if (flight.Count_Passengers == passenger)
            {
                result_search.Add(flight);
            }
        }
        return result_search;
    }
}