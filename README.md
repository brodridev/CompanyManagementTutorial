# **CompanyManagement.API**

A **.NET 9 Web API** for managing companies, built with **Clean Architecture** principles.  
🚀 **No external database required** — runs on an in-memory database for easy development and testing.

---

## **📦 Prerequisites**

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)  
- Visual Studio 2022 *(optional, recommended for full IDE support)*

---

## **▶️ Running the API**

### **From the Terminal**
```bash
# 1) Restore dependencies
dotnet restore

# 2) Run the API
dotnet run --project CompanyManagement.API
```

Once running, open:
👉 https://localhost:7125/swagger (or the URL shown in your terminal)

From ** Visual Studio 2022 **
Open the solution in Visual Studio.

1. Set CompanyManagement.API as the startup project.
2. Press F5 (Debug) or Ctrl+F5 (Run without debugging).
3. The Swagger UI should open automatically. If not, navigate to /swagger in your browser.

📝 Notes
No SQL Server needed — all data is stored in-memory and will be lost when the app stops.
API endpoints & documentation are available via Swagger UI at /swagger.

📂 Project Structure

CompanyManagement.API             → Web API project
CompanyManagement.Application     → Application layer (business logic)
CompanyManagement.Domain          → Domain entities & interfaces
CompanyManagement.Infrastructure  → Infrastructure & data access (in-memory DB)

🤝 Contributing
Pull requests and issues are welcome!
