# Invoice Management API

A modern and modular **Invoice Management System** built using **.NET 8**, **Clean Architecture**, **Entity Framework Core**, and **Keycloak** for authentication. This project demonstrates scalable, maintainable API design for real-world business applications.

The solution is being built in public to showcase professional software development practices, with a focus on clean separation of concerns and extensibility for enterprise environments.

---

## 🧱 Technology Stack

- **Backend:** ASP.NET Core 8 Web API
- **Frontend:** Next.js 14 + React + TypeScript (coming soon)
- **Authentication:** Keycloak (OAuth2 / OpenID Connect)
- **ORM:** Entity Framework Core
- **Database:** In-Memory for development, SQL Server for production
- **Architecture:** Clean Architecture (layered, testable, maintainable)
- **CI/CD & Deployment:** Docker, GitHub Actions

---

## 📁 Project Structure

```
invoice-management-api/
│
├── src/
│   ├── WebApi/              # Entry point for the API
│   ├── Application/         # Business logic & service interfaces
│   ├── Domain/              # Core domain models (entities, enums, etc.)
│   ├── Infrastructure/      # External integrations (EF Core, services)
│   └── Persistence/
│       └── Configurations/  # EF Core entity configurations
│
├── InvoiceManagement.sln    # Solution file
```

---

## ⚙️ Key Features

- 🔐 Secure user authentication and role-based access (via Keycloak)
- 📦 Full **Client** and **Invoice** CRUD capabilities
- 🧾 Invoice generation and management, including line items
- 📊 Analytics Dashboard with:
  - Total invoice count
  - Paid vs Unpaid summaries
  - Monthly, quarterly, yearly income charts

---

## 🚀 Getting Started (Local Development)

1. Clone the repository
2. Run the API locally at `https://localhost:5001` (default config)
3. Uses **InMemoryDatabase** for quick prototyping
4. Frontend setup will be available soon

```bash
git clone https://github.com/yourusername/invoice-management-api.git
cd invoice-management-api
dotnet restore
dotnet run --project src/WebApi
```

---

## 🛠️ Roadmap & Upcoming Features

- 🔁 **Keycloak** integration for full authentication & authorization
- 📧 Emailing invoices to clients
- 📄 Export invoices to PDF format
- 🧑‍💼 Multi-tenancy support for SaaS scenarios
- 🐳 Docker support for containerized deployments
- ☁️ Deployment via Railway, Azure.

---

## 🔌 Planned API Endpoints

### Authentication
- `POST /auth/login`
- `POST /auth/register`
- `POST /auth/refresh`
- `GET /auth/profile`

### Clients
- `GET /api/clients`
- `GET /api/clients/{id}`
- `POST /api/clients`
- `PUT /api/clients/{id}`
- `DELETE /api/clients/{id}`

### Invoices
- `GET /api/invoices`
- `GET /api/invoices/{id}`
- `POST /api/invoices`
- `PUT /api/invoices/{id}`
- `DELETE /api/invoices/{id}`

### Dashboard
- `GET /api/dashboard/summary`
- `GET /api/dashboard/monthly`
- `GET /api/dashboard/yearly`

---

## ✅ Production Readiness Checklist

- [x] Clean Architecture
- [x] Logging with Serilog
- [x] Health checks & monitoring
- [x] Centralized error handling
- [x] API Versioning
- [x] Swagger/OpenAPI Documentation
- [x] Unit & Integration Tests
- [x] Dockerized Services
- [ ] CI/CD pipeline integration

---

## 👨‍💻 Author

**[@emmanueldonkor](https://linkedin.com/in/emmanueldonkor)** – Building in public and sharing real-world projects on LinkedIn.
