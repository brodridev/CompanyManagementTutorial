# CompanyManagement.API

This is a .NET 9 Web API for managing companies using Clean Architecture.  
**No database connection is required** for development or testing; the API uses an in-memory database.

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022 (optional, for IDE support)

## Running the API

### Using the Terminal

1. **Restore dependencies:** dotnet restore
2. **Run the API:** dotnet run --project CompanyManagement.API
3. **Access the API:**
- Open your browser and navigate to [https://localhost:7125/swagger](https://localhost:7125/swagger) or the URL shown in the terminal.

### Using Visual Studio 2022

1. Open the solution in Visual Studio 2022.
2. Set `CompanyManagement.API` as the startup project.
3. Press `F5` (Debug) or `Ctrl+F5` (Run without debugging).
4. The browser should open automatically to the Swagger UI. If not, navigate to `/swagger` on the displayed URL.

## Notes

- **No SQL Server or external database is required.** All data is stored in-memory and will be lost when the application stops.
- The API endpoints and documentation are available via Swagger UI at `/swagger`.

## Project Structure

- `CompanyManagement.API` - Web API project
- `CompanyManagement.Application` - Application layer
- `CompanyManagement.Domain` - Domain entities and interfaces
- `CompanyManagement.Infrastructure` - Infrastructure and data access (uses in-memory database for development)

---

Feel free to contribute or open issues!

