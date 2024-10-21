# Airport Ticket Booking System Project
<b>Project Overview</b><br>
This project is a console-based application developed in C# for FTS company as part of backend developer training.This project is a .NET Console Application simulating an Airport Ticket Booking System. It allows passengers to search and book flights, manage their bookings, and allows managers to handle flight and booking data, including uploading flight lists via CSV. The system uses the file system for data storage and ensures proper model validation.

## Features

### For Passengers:
1. **Book a Flight**:
   - Select a flight based on various search parameters.
   - Choose a class for the flight: Economy, Business, First Class.
   - Prices vary based on the class selected.

2. **Search Available Flights**:
   - Search by the following parameters:
     - Price
     - Departure Country
     - Destination Country
     - Departure Date
     - Departure Airport
     - Arrival Airport
     - Class

3. **Manage Bookings**:
   - **Cancel a booking**.
   - **Modify a booking**.
   - **View personal bookings**.

### For Managers:
1. **Filter Bookings**:
   - Filter by the following parameters:
     - Flight
     - Price
     - Departure Country
     - Destination Country
     - Departure Date
     - Departure Airport
     - Arrival Airport
     - Passenger
     - Class

2. **Batch Flight Upload**:
   - Import a list of flights using a CSV file.
   - Ensure validation is applied during the import process.

3. **Dynamic Model Validation**:
   - Validate imported flight data against the model.
   - Provide detailed error messages if issues are found.
   - Example:
     - **Departure Country**: Required (Free Text)
     - **Departure Date**: Required (Date Time, Future date)

## Data Storage
All data is stored in the file system, providing a lightweight storage solution for this console application.

## Getting Started

### Prerequisites
- .NET SDK 6.0 or higher.
- Basic knowledge of C# and .NET.

### Installation
1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/airport-ticket-booking-system.git
    ```
2. Navigate to the project directory:
    ```bash
    cd airport-ticket-booking-system
    ```
3. Build and run the application:
    ```bash
    dotnet build
    dotnet run
    ```

### Usage
- **Passengers**: Book, search, modify, and view flight bookings.
- **Managers**: Manage bookings, upload flight data, and perform validation on flight uploads.

## Project Structure

```bash
airport-ticket-booking-system/
│
├── Program.cs              # Entry point of the application.
├── Models/                 # Contains the data models for Passenger, Booking, Flight, etc.
├── Services/               # Handles business logic (booking, flight search, etc.).
├── Data/                   # File system-based data storage and retrieval.
├── Utilities/              # Helper classes for validation and CSV parsing.
└── README.md               # Project documentation.
