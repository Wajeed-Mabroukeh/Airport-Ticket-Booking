using System.Net;

namespace Airport_Ticket_Booking;

using System.IO;
using System;
public class Passenger : Search
{
    
    public  void Book_a_Flight(string Name, int ID_Num, int ID_flight)
    {
        
        int res_index = Find_Element_Booking(ID_Num);
        int? [] index = Find_Element_Flight(ID_flight);
        if (bookingsList.Count == 0 && index[0] != null && index[1] != null )
        {
            ++flightsList[(int)index[0]].Count_Passengers;
            add_new_booking(flightsList[(int)index[0]], Name, ID_Num);
            File.AppendAllText(filePath_Booking,bookingsList[0].ToString()+"\n");
       
        }
        else
        {
            if (res_index == -1 && index[0] != null && index[1] != null)
            {
                ++flightsList[(int)index[0]].Count_Passengers;
                add_new_booking(flightsList[(int)index[0]], Name, ID_Num);
                File.WriteAllText(filePath_Booking, "");
                foreach (Booking line in bookingsList)
                {
                    File.AppendAllText(filePath_Booking, line.ToString() + "\n");
                }
            }
            else if (index[0] != null && index[1] != null)
            {
                if (bookingsList[res_index].flight.Departure_Date == flightsList[(int)index[0]].Departure_Date)
                {
                    Console.WriteLine("You Arrayed Booking at this Flight that the same Date");
                }
                else
                {
                    ++flightsList[(int)index[0]].Count_Passengers;
                    add_new_booking(flightsList[(int)index[0]], Name, ID_Num);
                    bookingsList.Clear();
                    File.WriteAllText(filePath_Booking, "");
                    foreach (Booking line in bookingsList)
                    {
                        File.AppendAllText(filePath_Booking, line.ToString() + "\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your flight selection is not from the list. Please search again.");
            }
        }

        Update_Flight();
        
    }

    public void add_new_booking(Flights flight , string name , int id)
    {
        Flights flight_Object = new Flights(flight.ID,flight.Price,flight.Departure_Country,flight.Destination_Country,
            flight.Departure_Date,flight.Departure_Airport,flight.Arrival_Airport,flight.Class,flight.Count_Passengers);
        Booking booking_Object = new Booking(name,id,flight_Object,flight_Object.Count_Passengers);
        bookingsList.Add(booking_Object);
    }
    
    
    public int Find_Element_Booking(int id)
    {
        for (int i = 0; i < bookingsList.Count; i++)
        {
            if (bookingsList[i].id == id)
            {
                return i;
            }
        }
        return -1;
    }
    public int? [] Find_Element_Flight(int id)
    {
        int? [] array_check = new int? [2] ;
        for (int i = 0; i < flightsList.Count; i++)
        {
            if (flightsList[i].ID == id)
            {
                array_check[0]=i;
            }
            else
            {
                array_check[0]=null;
            }
        }
        for (int i = 0; i < result_search.Count; i++)
        {
            if (result_search[i].ID == id)
            {
                array_check[1]=i;
            }
            else
            {
                array_check[1]=null;
            }
       
        }
        return array_check;
    }
    
    
    public void Cancel_a_booking(int id_book , int id_flight)
    {
        Booking _book = null; 
        foreach (var book in bookingsList)
        {
            if (book.id == id_book && book.flight.ID == id_flight)
            {
                _book = book;
            }
        }
        if (_book == null)
        {
            Console.WriteLine("There is no flight reservation in your ID");
        }
        else
        {
            bookingsList.Remove(_book);
            Update_Booking();
        }
    }
    public void View_personal_bookings(int id_book)
    {
        List<Booking> Cancel = new List<Booking>();
        foreach (var book in bookingsList)
        {
            if (book.id == id_book)
            {
                Cancel.Add(book);
            }
        }
        if (Cancel.Count() == 0)
        {
            Console.WriteLine("There is no flight reservation in your ID");
        }
        else
        {
            foreach (var cancel in Cancel)
            {
                Console.WriteLine(cancel.ToString());
            }
        }
    }
    
    
    public void Update_Flight()
    {
        File.WriteAllText(filePath_Flights,"");
        foreach (Flights line in flightsList)
        {
            File.AppendAllText(filePath_Flights,$"{line.ToString()},{line.Count_Passengers}\n"); 
        }
        
    }
    public void Update_Booking()
    {
        File.WriteAllText(filePath_Booking,"");
        foreach (Booking booking in bookingsList)
        {
            File.AppendAllText(filePath_Booking,$"{booking.ToString()}\n"); 
        }
        
    }
    public void initial_Flights()
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath_Flights);
            foreach (string line in lines)
            {
                string[] flight = line.Split(",");
                Flights flight_Object = new Flights(int.Parse(flight[0]),double.Parse(flight[1]),flight[2],flight[3],
                    flight[4],flight[5],flight[6],int.Parse(flight[7]),int.Parse(flight[8]));
                flightsList.Add(flight_Object);
               // Console.WriteLine(flight_Object.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    public void initial_Booking()
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath_Booking);
            foreach (string line in lines)
            {
                string[] booking = line.Split(",");
                Flights flight_Object = new Flights(int.Parse(booking[2]),double.Parse(booking[3]),booking[4],booking[5],
                    booking[6],booking[7],booking[8],int.Parse(booking[9]),null);
                Booking booking_Object = new Booking(booking[0],int.Parse(booking[1]),flight_Object,flight_Object.Count_Passengers);
                bookingsList.Add(booking_Object);
               // Console.WriteLine("k");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
