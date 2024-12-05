ReceptionSystemApp_16246

This application was developed for Web Application module, as coursework portfolio project @ WIUT by student ID: 00016246
## Topic Calculation:

00016246 % 20 = 6 The topic number 6 was "Reception System App".

## Description: A Reception Management System API for managing operations like room bookings, guest information, user management, and reservations. This API provides CRUD functionality for various entities and adheres to clean architecture principles, incorporating design patterns like the Repository Pattern.

### Features
CRUD operations for:
Rooms
Guests
Users
Reservations
Database integration with Entity Framework Core.
API documentation using Swagger.

### Technologies Used
- .NET 6 (ASP.NET Core Web API)
- Entity Framework Core (Code-First Migrations)
- SQL Server (Database)
- Swagger (API documentation)
- C#

### Prerequisites
Before running the application, ensure the following are installed:

.NET SDK 6 or higher
SQL Server
IDE (e.g., Visual Studio or Visual Studio Code)
Postman or any API testing tool (optional)


### Setup Instructions
#### Clone the Repository:

git clone https://github.com/16246WIUTStudent/Reception_16246.git
cd reception-management-system

#### Configure the Database
- Open appsettings.json and replace the connection string with your SQL Server details:
json
- Copy code
"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=ReceptionDB;Trusted_Connection=True;"
}
- Apply Migrations Run the following commands to update the database:

dotnet ef migrations add InitialCreate
dotnet ef database update
Run the Application Start the API by running:

dotnet run
Access API Documentation Open http://localhost:5267/swagger in your browser to view and test the API documentation.


### API Endpoints
Rooms
GET /api/Rooms - Get all rooms.
GET /api/Rooms/{id} - Get a specific room by ID.
POST /api/Rooms - Create a new room.
PUT /api/Rooms/{id} - Update a room.
DELETE /api/Rooms/{id} - Delete a room.
Guests
Similar endpoints as above but with /api/Guests.
Users
Similar endpoints as above but with /api/Users.
Reservations
Similar endpoints as above but with /api/Reservations.
Design Patterns


### Repository Pattern
The API uses the Repository Pattern for data access. Each entity has its own repository for separation of concerns and scalability.

Example: IRoomRepository, IGuestRepository, etc.

Planned Patterns
Singleton: Will manage shared configurations or services.
Observer: Will notify users about events like reservations.

### Future Enhancements
Add CORS configuration for frontend integration.
Implement additional design patterns (e.g., Singleton, Observer).
Add authentication and authorization.

### Contributing
Contributions are welcome! Feel free to fork the repository and submit a pull request.

### License
This project is licensed under the MIT License. See LICENSE for details.
