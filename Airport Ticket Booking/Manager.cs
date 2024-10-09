namespace Airport_Ticket_Booking;
using CsvHelper;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

public class Manager : Search
{
    
    public  List<string> errors = new List<string>();
    public List<Flights> ReadFlightsFromCsv(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var flights = csv.GetRecords<Flights>().ToList();
            return flights;
        }
    }
    
    public void  ValidateFlight(Flights flight ,Passenger passenger)
    {
        bool flag_validateflight = false;

        if (string.IsNullOrEmpty(flight.Departure_Country))
        {
            flag_validateflight = true;
            errors.Add($"Flight_ID: {flight.ID} ,Departure Country: Required.");
        }

        if (string.IsNullOrEmpty(flight.Destination_Country))
        {
            flag_validateflight = true;
            errors.Add($"Flight_ID: {flight.ID} ,Destination Country: Required.");
        }

        if (string.IsNullOrEmpty(flight.Departure_Airport))
        {
            flag_validateflight = true;
            errors.Add($"Flight_ID: {flight.ID} ,Departure Airport: Required.");
        }

        if (string.IsNullOrEmpty(flight.Arrival_Airport))
        {
            flag_validateflight = true;
            errors.Add($"Flight_ID: {flight.ID} ,Arrival Airport: Required.");
        }

        if (flight.Departure_Date < DateTime.Now)
        {
            flag_validateflight = true;
            errors.Add($"Flight_ID: {flight.ID} Departure Date: Must be today or in the future.");
        }

        if (flight.AvailableSeats < flight.Count_Passengers)
        {
            flag_validateflight = true;
            errors.Add($"Flight_ID: {flight.ID} ,Available Seats: Must be greater than Count Passengers.");
        }

        if (flight.AvailableSeats <= 0)
        {
            flag_validateflight = true;
            errors.Add($"Flight_ID: {flight.ID} ,AvailableSeats: Must be greater than 0.");
        }

        if (flight.Price < 0)
        {
            flag_validateflight = true;
            errors.Add($"Flight_ID: {flight.ID} ,Price: Must be greater than 0 or equal 0.");
        }

        if (flight.Class <= 0)
        {
            flag_validateflight = true;
            errors.Add($"Flight_ID: {flight.ID} ,Class: Must be greater than 0.");
        }

        if (flight.Count_Passengers < 0)
        {
            flag_validateflight = true;
            errors.Add($"Flight_ID: {flight.ID} ,Passengers: Must be greater than 0 or equal 0.");
        }

        if (!flag_validateflight && passenger.Find_Element_Flight(flight.ID)[0] == null)
        {
            Passenger.flightsList.Add(flight);
            passenger.Update_Flight();
        }

    }
}
