using Airport_Ticket_Booking;
using Xunit;

namespace project_test.Tests;

public class Passenger_Test
{
    
    [Fact]
    public void Find_Element_Booking()
    {
        //Arrange
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        
        //Act
        var x = p.Find_Element_Booking(2);
        
        //Assert
        Assert.Equal(-1,x);

    }
    
    [Fact]
    public void Find_Element_Flight()
    {
        //Arrange
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        
        //Act
        var x = p.Find_Element_Flight(5);
        
        //Assert
        Assert.Equal(1,x[0]);
    }
    
    [Fact]
    public void Book_a_Flight()
    {
        //Arrange
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        var indix = p.Find_Element_Flight(3);
        
        var count_before = Search.flightsList[(int)indix[0]].Count_Passengers;
        Passenger.result_search = Passenger.flightsList;
        //Act
        p.Book_a_Flight("Wajeed",20,3);
        
        //Assert
        Assert.Equal(Search.flightsList[(int)indix[0]].Count_Passengers, count_before + 1);
    }
    
    [Fact]
     public void Cancel_a_booking()
     {
         //Arrange
         var p = new Passenger();
         p.initial_Booking();
         p.initial_Flights();
         var indix = p.Find_Element_Flight(3);
    
         var count_before = Search.flightsList[(int)indix[0]].Count_Passengers;
         
         
         //Act
         p.Cancel_a_booking(20,3);
         
         //Assert
         Assert.Equal(Search.flightsList[(int)indix[0]].Count_Passengers, count_before - 1);
     }
    
    [Fact]
    public void Search_for_price()
    {
        //Arrange
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        
        //Act
        var price = p.Search_for_price(110);
        
        //Assert
        Assert.NotEmpty(price);
    }
    
    [Fact]
    public void Search_for_DepartureCountry()
    {
        //Arrange
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        
        //Act
        var DepartureCountry = p.Search_for_DepartureCountry("Palestine");
        
        //Assert
        Assert.NotEmpty(DepartureCountry);
    }
    
    [Fact]
    public void Search_for_Departure_Date()
    {
        //Arrange
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        
        //Act
        var Departure_Date = p.Search_for_Departure_Date(DateTime.Parse("9/23/2024 11:10:00 AM"));
        
        //Assert
        Assert.NotEmpty(Departure_Date);
    }
    
    [Fact]
    public void Search_for_Arrival_Airport()
    {
        //Arrange
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        
        //Act
        var Arrival_Airport = p.Search_for_Arrival_Airport("Istanbul");
        
        //Assert
        Assert.NotEmpty(Arrival_Airport);
    }
    
    [Fact]
    public void Search_for_Class()
    {
        //Arrange
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        
        //Act
        var Class = p.Search_for_Class(3);
        
        //Assert
        Assert.NotEmpty(Class);
    } 
    
    [Fact]
    public void Search_for_Flight()
    {
        //Arrange
        var p = new Passenger();
        //p.initial_Booking();
        //p.initial_Flights();
        
        //Act
        var Flight = p.Search_for_Flight(3);
        
        //Assert
        Assert.NotEmpty(Flight);
    }
    
    [Fact]
    public void Search_for_Passengers()
    {
        //Arrange
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        
        //Act
        var passenger = p.Search_for_Passengers(1);
        
        //Assert
        Assert.NotEmpty(passenger);
    }
    
    [Fact]
    public void Search_for_DestinationCountry()
    {
        //Arrange
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        
        //Act
        var DestinationCountry = p.Search_for_DestinationCountry("Turkey".Trim());
        
        //Assert
        Assert.NotEmpty(DestinationCountry);
    }
    
    [Fact]
    public void Search_for_Departure_Airport()
    {
        //Arrange
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        
        //Act
        var Departure_Airport = p.Search_for_Departure_Airport("Aleaa".Trim());
        
        //Assert
        Assert.NotEmpty(Departure_Airport);
    }
    
}