using Airport_Ticket_Booking;

namespace project_test.Tests;

public class Manager_Test
{
    private Passenger _passenger;
    public Manager_Test()
    {
        _passenger = new Passenger();
        _passenger.initial_Booking();
        _passenger.initial_Flights();
    }
    
    
    [Fact]
    public void ReadFlightsFromCsv()
    {
        //Arrange
        var manager = new Manager();
        
        //Act
        List<Flights> flight = manager.ReadFlightsFromCsv(manager.filePath_FlightsCSV);
        
        //Assert
        Assert.NotEmpty(flight);

    }
    
    [Fact]
    public void ValidateFlight()
    {
        //Arrange
        var manager = new Manager();
        
        //Act
        List<Flights> flight = manager.ReadFlightsFromCsv(manager.filePath_FlightsCSV);
        manager.ValidateFlight(flight[0], _passenger);
        
        //Assert
        Assert.NotEmpty(flight);
        //Assert.NotEmpty(manager.errors);

    }
}