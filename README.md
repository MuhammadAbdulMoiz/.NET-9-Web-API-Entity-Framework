# .NET-Web-API-Entity-Framework

Learn to build a complete Web API with CRUD operations, code-first migrations, and SQL Server using ASP.NET Core and Entity Framework Core. This sample project implements a simple VideoGame API with GET, POST, PUT, and DELETE endpoints and demonstrates code-first migrations and data seeding.

---

## Project Layout (Key Files)

- `vijeoGAPI/Controllers/VideoGameController.cs` — API controller exposing CRUD endpoints.
- `vijeoGAPI/Data/VideoGameDBContext.cs` — EF Core `DbContext` and `DbSet<VideoGame>`.
- `vijeoGAPI/Migrations/` — EF Core migrations (includes seed data).
- `vijeoGAPI/appsettings.json` — connection string and configuration.

---

## Prerequisites

- .NET SDK 10.0+ installed (dotnet CLI)
- SQL Server, SQL Server Express, or LocalDB instance
- (Optional) Visual Studio 2026 or VS Code

> If using Visual Studio: open the solution and run with **Debug > Start Debugging** or press **F5**.

---

## Configuration

1. Open `appsettings.json`.
2. Set the connection string under `ConnectionStrings:DefaultConnection`:

- LocalDB example:  
  ```json
  "ConnectionStrings": {
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=VideoGameDb;Trusted_Connection=True;"
  }
