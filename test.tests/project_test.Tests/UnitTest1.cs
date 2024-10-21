using System.Diagnostics;
using Airport_Ticket_Booking;
using Xunit;

namespace project_test.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        var x = p.Find_Element_Booking(2);
        
        Assert.Equal(-1,x);

    }

    [Fact]
    public void Test2()
    {
        var p = new Passenger();
        p.initial_Booking();
        p.initial_Flights();
        var x = p.Find_Element_Booking(5);
        
        Assert.Equal(0,x);
    }
}