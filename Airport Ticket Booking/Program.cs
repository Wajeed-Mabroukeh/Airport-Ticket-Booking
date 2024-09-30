
using Airport_Ticket_Booking;

class Program
{
    static void Main()
    {
        var passenger = new Passenger();
        passenger.initial_Booking();
        passenger.initial_Flights();
        while (true)
        {
            try
            {
                Console.WriteLine("What you need Service -_-?" + "\n"
                                                               + "1.Show Flights" + "\n"
                                                               + "2.Manage Booking"
                );
                string read = Console.ReadLine();
                if (read.Trim() == "1")
                {
                    Console.WriteLine("Please Select How you show Flights:" + "\n"
                                                                            + "1.All Flights" + "\n"
                                                                            + "2.Search"
                    );
                    string read_Flight = Console.ReadLine();
                    
                    if (read_Flight.Trim() == "1" && Passenger.flightsList.Count != 0)
                    {
                        foreach (var flight in Passenger.flightsList)
                        {
                            Console.WriteLine(flight.ToString());
                        }
                            Console.WriteLine("Are your Sure Book Flight?(y\\n)");
                            string read_book = Console.ReadLine();
                            if (read_book == "y")
                            {
                                Set_data_from_Console(passenger);
                            }
                    }
                    else if (read_Flight.Trim() == "2")
                    {
                        Console.WriteLine("Please Select how you Search Flights:" + "\n"
                            + "1.Price" + "\n"
                            + "2.Departure Country"+ "\n"
                            + "3.Destination Country"+ "\n"
                            + "4.Departure Date"+ "\n"
                            + "5.Departure Airport"+ "\n"
                            + "6.Arrival Airport"+ "\n"
                            + "7.Class"
                        );
                        string read_search = Console.ReadLine();
                        switch (read_search)
                        {
                            case "1":
                                Console.WriteLine("Please enter price:");
                                string read_price = Console.ReadLine();
                                List<Flights>? flight_price = passenger.Search_for_price(double.Parse(read_price));
                                foreach (var res_price in flight_price)
                                {
                                    Console.WriteLine(res_price.ToString());
                                }

                                if (flight_price.Count != 0)
                                {
                                    Console.WriteLine("Are your Sure Book Flight?(y\\n)");
                                    string read_book = Console.ReadLine();
                                    if (read_book == "y")
                                    {
                                        Set_data_from_Console(passenger);
                                    }
                                }

                                break;
                            case "2":
                                Console.WriteLine("Please enter Departure Country:");
                                string read_DepartureCountry = Console.ReadLine();
                                List<Flights>? flight_DepartureCountry = passenger.Search_for_DepartureCountry(read_DepartureCountry);
                                foreach (var res_price in flight_DepartureCountry)
                                {
                                    Console.WriteLine(res_price.ToString());
                                }
                                if (flight_DepartureCountry.Count != 0)
                                {
                                    Console.WriteLine("Are your Sure Book Flight?(y\\n)");
                                    string read_book = Console.ReadLine();
                                    if (read_book == "y")
                                    {
                                        Set_data_from_Console(passenger);
                                    }
                                }
                                break;
                            case "3":
                                Console.WriteLine("Please enter Destination Country:");
                                string read_DestinationCountry = Console.ReadLine();
                                List<Flights>? flight_DestinationCountry = passenger.Search_for_DestinationCountry(read_DestinationCountry);
                                foreach (var res_price in flight_DestinationCountry)
                                {
                                    Console.WriteLine(res_price.ToString());
                                }
                                if (flight_DestinationCountry.Count != 0)
                                {
                                    Console.WriteLine("Are your Sure Book Flight?(y\\n)");
                                    string read_book = Console.ReadLine();
                                    if (read_book == "y")
                                    {
                                        Set_data_from_Console(passenger);
                                    }
                                }
                                break;
                            case "4":
                                Console.WriteLine("Please enter Departure Date:");
                                string read_Departure_Date = Console.ReadLine();
                                List<Flights>? flight_DepartureDate = passenger.Search_for_Departure_Date(read_Departure_Date);
                                foreach (var res_price in flight_DepartureDate)
                                {
                                    Console.WriteLine(res_price.ToString());
                                }
                                if (flight_DepartureDate.Count != 0)
                                {
                                    Console.WriteLine("Are your Sure Book Flight?(y\\n)");
                                    string read_book = Console.ReadLine();
                                    if (read_book == "y")
                                    {
                                        Set_data_from_Console(passenger);
                                    }
                                }
                                break;
                            case "5":
                                Console.WriteLine("Please enter Departure Airport:");
                                string read_Departure_Airport = Console.ReadLine();
                                List<Flights>? flight_DepartureAirport = passenger.Search_for_Departure_Airport(read_Departure_Airport);
                                foreach (var res_price in flight_DepartureAirport)
                                {
                                    Console.WriteLine(res_price.ToString());
                                }
                                if (flight_DepartureAirport.Count != 0)
                                {
                                    Console.WriteLine("Are your Sure Book Flight?(y\\n)");
                                    string read_book = Console.ReadLine();
                                    if (read_book == "y")
                                    {
                                        Set_data_from_Console(passenger);
                                    }
                                }
                                break;
                            case "6":
                                Console.WriteLine("Please enter Arrival Airport:");
                                string read_Arrival_Airport = Console.ReadLine();
                                List<Flights>? flight_Arrival_Airport = passenger.Search_for_Arrival_Airport(read_Arrival_Airport);
                                foreach (var res_price in flight_Arrival_Airport)
                                {
                                    Console.WriteLine(res_price.ToString());
                                }
                                if (flight_Arrival_Airport.Count != 0)
                                {
                                    Console.WriteLine("Are your Sure Book Flight?(y\\n)");
                                    string read_book = Console.ReadLine();
                                    if (read_book == "y")
                                    {
                                        Set_data_from_Console(passenger);
                                    }
                                }
                                break;
                            case "7":
                                Console.WriteLine("Please enter Class:"
                                    +"1.Economy"
                                    +"2.Business"
                                    +"3.First Class"
                                    );
                                string read_Class = Console.ReadLine();
                                List<Flights>? flight_Class = passenger.Search_for_Class(int.Parse(read_Class));
                                foreach (var res_price in flight_Class)
                                {
                                    Console.WriteLine(res_price.ToString());
                                }
                                if (flight_Class.Count != 0)
                                {
                                    Console.WriteLine("Are your Sure Book Flight?(y\\n)");
                                    string read_book = Console.ReadLine();
                                    if (read_book == "y")
                                    {
                                        Set_data_from_Console(passenger);
                                    }
                                }
                                break;
                        }
                        

                    }
                }
                else if (read.Trim() == "2")
                {
                    Console.WriteLine("Please Choose Manage Bookings:\n"
                                      +"1.Cancel a booking\n"
                                      +"2.View personal bookings"
                    );
                    try
                    {
                        string read_manage = Console.ReadLine();
                        if (read_manage.Trim() == "1")
                        {
                            Console.WriteLine("Please enter Your ID:");
                            string read_ID_Book = Console.ReadLine();
                            Console.WriteLine("Please enter Your ID_Flight:");
                            string read_ID_Book_flight = Console.ReadLine();
                            passenger.Cancel_a_booking(int.Parse(read_ID_Book),int.Parse(read_ID_Book_flight));
                            
                        }
                        else if (read_manage.Trim() == "2")
                        {
                            Console.WriteLine("Please enter Your ID:");
                            string read_ID_Book = Console.ReadLine();
                            passenger.View_personal_bookings(int.Parse(read_ID_Book));

                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                   

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please try Again _-_");
            }
        }
    }

    public static void Set_data_from_Console(Passenger passenger)
    { 
        Console.WriteLine("Please Enter Your Name");
        string read_name = Console.ReadLine();
        Console.WriteLine("Please Enter Your ID Number");
        string read_ID_Number = Console.ReadLine();
        Console.WriteLine("Please Enter ID Flight");
        string read_ID_Flight = Console.ReadLine();

        passenger.Book_a_Flight(read_name,int.Parse(read_ID_Number),int.Parse(read_ID_Flight));

    }
}