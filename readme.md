# Invoice Management API

A full-stack **Invoice Management System** built with **.NET 8**, **Clean Architecture**, **EF Core**, and **Keycloak (Auth)**.

This project is being built in public to showcase professional API design, modular architecture, and real-world full-stack dev practices.

---

## 🧱 Stack

- **Backend:** ASP.NET Core 8 Web API
- **Frontend:** Next.js 14 + React + TypeScript
- **Auth:** Keycloak (to be integrated)
- **ORM:** Entity Framework Core
- **Database:** In-Memory (Dev), SQL Server (Prod)
- **Architecture:** Clean Architecture (modular, testable, maintainable)
- **CI/CD & Deployment:** Coming soon...

---

## 📁 Project Structure

invoice-management-api/
│
├── src/
│ ├── WebApi/ # Entry point for the API
│ ├── Application/ # Business logic & interfaces
│ ├── Domain/ # POCOs / Entities
│ ├── Infrastructure/ # EF Core, services, persistence
│ └── Persistence/
│ └── Configurations/
│
├── InvoiceManagement.sln # Solution file



---

## ⚙️ Features

- 🔐 **User Management** (via Keycloak - coming soon)
- 📦 **Client CRUD**
- 🧾 **Invoice & Invoice Items**
- 📊 **Dashboard Metrics**
    - Total Invoices
    - Paid / Unpaid breakdown
    - Bar chart: Monthly/Quarterly/Yearly income

---

## 🚀 Setup (Local Dev)

1. Clone the repo
2. Run the API 
3. Currently uses **InMemoryDatabase**
4. Frontend setup (coming soon)

```bash
dotnet restore
dotnet run --project src/WebApi


Coming Soon
✅ Keycloak Auth & Role-based Access

✅ Emailing Invoices

✅ Export to PDF

✅ Multi-tenancy

✅ Deployment 


🔌 API Endpoints (Planned)
Auth (via Keycloak)
POST /auth/login

POST /auth/register

POST /auth/refresh

GET /auth/profile

Clients
GET /api/clients

GET /api/clients/{id}

POST /api/clients

PUT /api/clients/{id}

DELETE /api/clients/{id}

Invoices
GET /api/invoices

GET /api/invoices/{id}

POST /api/invoices

PUT /api/invoices/{id}

DELETE /api/invoices/{id}

Dashboard
GET /api/dashboard/summary

GET /api/dashboard/monthly

GET /api/dashboard/yearly

✅ Production Checklist
 Clean Architecture

 Logging (Serilog)

 Health Checks

 Global Error Handling

 API Versioning

 Swagger / OpenAPI Docs

 Unit / Integration Tests

 Dockerized

 CI/CD

👨‍💻 Author
@EmmanuelDonkor — Building in public on LinkedIn
