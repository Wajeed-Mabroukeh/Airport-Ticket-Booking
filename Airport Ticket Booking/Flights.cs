namespace Airport_Ticket_Booking;

using System.Data;
public class Flights
{
    public int ID { set; get; }
    public double Price { set; get; }
    public string Departure_Country { set; get; }
    public string Destination_Country { set; get; }
    public DateTime Departure_Date { set; get; }
    public string Departure_Airport { set; get; }
    public string Arrival_Airport { set; get; }
    public  int Class { set; get; }
    public  int? AvailableSeats { set; get; }
    public  int? Count_Passengers { set; get; }

    public Flights(int ID,double Price,string Departure_Country,string Destination_Country
        ,DateTime Departure_Date,string Departure_Airport ,string Arrival_Airport,int Class,int? Count_Passengers,int? AvailableSeats)
    {
         this.ID =ID ;
         this.Price = Price;
         this.Departure_Date = Departure_Date ;
         this.Departure_Country = Departure_Country;
         this.Destination_Country = Destination_Country ;
         this.Departure_Airport = Departure_Airport;
         this.Arrival_Airport = Arrival_Airport;
         this.Class = Class;
         this.Count_Passengers = Count_Passengers;
         this.AvailableSeats = AvailableSeats;
        
    }
   
    public override string ToString()
    {
        return $"{ID},{Price},{Departure_Country}," +
               $"{Destination_Country},{Departure_Date},{Departure_Airport},{Arrival_Airport},{Class}";
    }
}