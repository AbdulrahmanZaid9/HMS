# HMS – Hotel Management System

A desktop Hotel Management System built with C# and Windows Forms, following a 3-tier architecture (Presentation, Business Logic, Data Access). It supports the daily operations of a hotel front desk, including room management, customer management, reservations, check-in and check-out, service bookings, billing, payments, user management, and revenue reporting.

## Table of Contents

- [Features](#features)
- [Screenshots](#screenshots)
- [Project Structure](#project-structure)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
- [Building the Installer](#building-the-installer)
- [Roadmap](#roadmap)
- [License](#license)
- [Author](#author)

## Features

**User Authentication and Management**
Login system with SHA-256 password hashing and an optional "remember me" feature. Includes user creation, password changes, password verification, and profile viewing.

**Customer Management**
Add, update, view, and search customer records.

**Room Management**
Add and edit rooms and room types. View room availability, details, and associated images.

**Reservations**
Create and manage reservations. View current reservations and full reservation history.

**Check-In and Check-Out**
Dedicated workflows with detailed check-in and check-out screens.

**Service Booking**
Manage services and service categories. Book services for a stay and update service pricing.

**Billing and Payments**
Generate bills, add services to a bill, view bill summaries, and record payments across multiple payment methods and types.

**Reports**
Daily, monthly, and yearly revenue reports; revenue by room type; revenue by room; customer revenue; customer stay; and outstanding bills reports.

**Logging**
Rolling daily log files powered by Serilog for diagnostics and auditing.

**Installer**
A Visual Studio Installer project (Setup1_HMS) for packaging the application, along with a ready-to-restore SQL Server database backup.

## Screenshots

### Login and Dashboard

| Login | Dashboard |
|---|---|
| ![Login](screenshots/login.png) | ![Dashboard](screenshots/dashboard.png) |

### Users and Profile

| Users Management | View Profile |
|---|---|
| ![Users Management](screenshots/users-management.png) | ![View Profile](screenshots/view-profile.png) |

### Customer Management

| Customer List | Customer Actions |
|---|---|
| ![Customer List](screenshots/customer-list.png) | ![Customer Actions](screenshots/customer-actions.png) |

| Add Customer | Reservation History |
|---|---|
| ![Add Customer](screenshots/add-customer.png) | ![Reservation History](screenshots/reservation-history.png) |

### Room Management

| Room Details |  |
|---|---|
| ![Room Details](screenshots/room-details.png) |  |

### Reservations

| Reservations List and Actions | Current Reservation |
|---|---|
| ![Reservations List](screenshots/reservations-list.png) | ![Current Reservation](screenshots/current-reservation.png) |

### Services

| Services Management | Service Booking List |
|---|---|
| ![Services Management](screenshots/services-management.png) | ![Service Booking List](screenshots/service-booking-list.png) |

| Service Booking Actions | Add Services to Bill |
|---|---|
| ![Service Booking Actions](screenshots/service-booking-actions.png) | ![Add Services to Bill](screenshots/add-services-to-bill.png) |

### Billing

| Bill Summary |  |
|---|---|
| ![Bill Summary](screenshots/bill-summary.png) |  |

### Reports

| Revenue Reports |  |
|---|---|
| ![Revenue Reports](screenshots/revenue-reports.png) |  |

## Project Structure

The solution is organized into separate layers for the user interface, business rules, and data access.

```
HMS/
├── HMS/                   Presentation layer (WinForms UI)
│   ├── Login/              Login and authentication screens
│   ├── Users/               User management
│   ├── Customers/            Customer management
│   ├── Rooms/                 Room and room type management
│   ├── reservations/           Reservations, check-in/check-out, billing
│   ├── ServicesBooking/         Services and service bookings
│   ├── Reports/                  Revenue and business reports
│   └── Global Classes/            Shared UI helpers and logging
├── HMS_Buisness/           Business logic layer
├── HMS_DataAccess/          Data access layer (SQL Server)
├── Utilities/                 Shared utilities (validation, security helpers)
└── Setup1_HMS/                  Installer project and database backup
```

## Tech Stack

| Layer                 | Technology                                  |
|------------------------|-----------------------------------------------|
| Language / Framework    | C#, .NET Framework 4.7.2, Windows Forms       |
| Database                 | Microsoft SQL Server                          |
| Logging                   | Serilog (rolling file sink)                   |
| Architecture                | 3-tier: Presentation, Business, Data Access |
| Packaging                    | Visual Studio Installer Project             |

## Getting Started

### Prerequisites

- Windows operating system
- Visual Studio 2022 or later, with the ".NET desktop development" workload
- .NET Framework 4.7.2 developer pack
- Microsoft SQL Server (Express edition or higher) and SQL Server Management Studio (SSMS)

### 1. Clone the repository

```bash
git clone https://github.com/AbdulrahmanZaid9/HMS.git
cd HMS
```

### 2. Restore the database

A database backup is included at:

```
Setup1_HMS/Release/HMS Installer/HotelManagementDB.bak
```

To restore it in SSMS:

1. Open SSMS and connect to your SQL Server instance.
2. Right-click **Databases**, then select **Restore Database**.
3. Choose **Device**, select the `.bak` file listed above, and restore it as `HotelManagementDB`.

### 3. Configure the connection string

The connection string is defined in `HMS_DataAccess/clsDataAccessSettings.cs`:

```csharp
public static string connectionString = "Server=.;Database=HotelManagementDB;User Id=sa;Password=sa123456;";
```

Update the `Server`, `User Id`, and `Password` values to match your local SQL Server setup before running the project.

Note: This connection string currently contains hardcoded sample credentials for local development. For any production deployment, this should be moved to a secure configuration source, such as an encrypted configuration section, environment variables, or a secrets manager, rather than committed to source control.

### 4. Build and run

1. Open `HMS/HMS.slnx` in Visual Studio.
2. Restore the required NuGet packages (Serilog, Microsoft.SqlServer.Types, and others listed in `packages.config`).
3. Set **HMS** as the startup project.
4. Build and run the solution.
5. Log in using a user from the restored database to access the system.

## Building the Installer

The `Setup1_HMS` project can be built to produce a standalone Windows installer (.msi) for distributing the application to machines without Visual Studio installed.

## Roadmap

- Migrate connection string handling to a secure configuration approach
- Add automated tests for the business logic layer
- Add export of reports to PDF or Excel
- Add role-based access control for different staff types

## License

This project does not currently include a license file. A license (for example, MIT) should be added if external use or contribution is intended.

## Author

Developed by [Abdulrahman Zaid](https://github.com/AbdulrahmanZaid9).
<img width="824" height="580" alt="login" src="https://github.com/user-attachments/assets/3265716b-ca10-4f3f-9e14-c25192ee2d6d" />
