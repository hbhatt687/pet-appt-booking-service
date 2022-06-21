# pet-appt-booking-service
A sample pet appointment booking system written in .NET


In order to run this application, make sure you have .NET installed on your local machine. Then, navigate to the project directory and run `dotnet run`.

You can find documentation for each of the APIs in the project by visiting `https://localhost:5001/swagger/index.html` once the project is running locally. The Swagger documentation gives the requirements for the inputs required for each of the various APIs.

## Note
* The Dates provided to the API must be in a valid UTC date format. Details such as the seconds/minute level can be exluded if desired.
* The types of pets and appointments must match the enum types listed in the API documentation, or else the API will throw a bad request error.
* There are a few inital appointments seeded into the database by default.
