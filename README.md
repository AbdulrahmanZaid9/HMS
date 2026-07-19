# HMS – Hotel Management System

A desktop **Hotel Management System** built with C# and Windows Forms, following a clean **3-tier architecture** (Presentation → Business Logic → Data Access). It covers the full daily workflow of a hotel front desk: managing rooms, customers, reservations, check-in/check-out, extra service bookings, billing, payments, users, and revenue reports.

## Features

- 🔐 **User Authentication** — Login system with password hashing (SHA-256) and an optional "remember me" feature.
- 👥 **User Management** — Add/update users, change password, verify password, view profile.
- 🧑‍🤝‍🧑 **Customer Management** — Add, update, view, and search customer records.
- 🛏️ **Room Management** — Add/edit rooms and room types, view room availability and details (with room images).
- 📅 **Reservations** — Create and manage reservations, view current reservations and reservation history.
- 🚪 **Check-In / Check-Out** — Dedicated workflows with detailed check-in and check-out screens.
- 🛎️ **Service Booking** — Manage extra services and service categories, book services for a stay, and update pricing.
- 💳 **Billing & Payments** — Generate bills, add services to a bill, view bill summaries, and record payments by multiple payment methods/types.
- 📊 **Reports** — Daily / monthly / yearly revenue reports, revenue by room type, revenue by room, customer revenue, customer stay, and outstanding bills reports.
- 📝 **Logging** — Rolling daily log files powered by Serilog for diagnostics and auditing.
- 📦 **Installer** — A Visual Studio Installer project (`Setup1_HMS`) to package the app, along with a ready-to-restore SQL Server database backup.

## Project Structure

The solution follows a layered architecture, separating UI, business rules, and data access:

```
HMS/
├── HMS/                 # Presentation layer (WinForms UI)
│   ├── Login/            # Login & authentication screens
│   ├── Users/             # User management
│   ├── Customers/         # Customer management
│   ├── Rooms/             # Room & room type management
│   ├── reservations/      # Reservations, check-in/check-out, billing
│   ├── ServicesBooking/   # Services & service bookings
│   ├── Reports/           # Revenue and business reports
│   └── Global Classes/    # Shared UI helpers & logging
├── HMS_Buisness/         # Business logic layer
├── HMS_DataAccess/       # Data access layer (SQL Server)
├── Utilities/             # Shared utilities (validation, security helpers)
└── Setup1_HMS/            # Installer project & database backup
```

## Tech Stack

- **Language / Framework:** C#, .NET Framework 4.7.2, Windows Forms
- **Database:** Microsoft SQL Server
- **Logging:** [Serilog](https://serilog.net/) (rolling file sink)
- **Architecture:** 3-tier (Presentation / Business / Data Access)
- **Packaging:** Visual Studio Installer Project

## Getting Started

### Prerequisites

- Windows OS
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or later) with the **.NET desktop development** workload
- **.NET Framework 4.7.2** developer pack
- **Microsoft SQL Server** (Express edition or higher) and SQL Server Management Studio (SSMS)

### 1. Clone the repository

```bash
git clone https://github.com/AbdulrahmanZaid9/HMS.git
cd HMS
```

### 2. Restore the database

A ready-made backup is included at:

```
Setup1_HMS/Release/HMS Installer/HotelManagementDB.bak
```

Restore it in SSMS:

1. Open SSMS and connect to your SQL Server instance.
2. Right-click **Databases → Restore Database…**
3. Choose **Device**, select the `.bak` file above, and restore it as `HotelManagementDB`.

### 3. Configure the connection string

The connection string is defined in `HMS_DataAccess/clsDataAccessSettings.cs`:

```csharp
public static string connectionString = "Server=.;Database=HotelManagementDB;User Id=sa;Password=sa123456;";
```

Update `Server`, `User Id`, and `Password` to match your local SQL Server setup before running the project.

> ⚠️ **Note:** This connection string is hardcoded with sample credentials for local development. For any real/production deployment, move it to a secure configuration source (e.g. `App.config` with encrypted sections, environment variables, or a secrets manager) instead of committing credentials to source control.

### 4. Build & run

1. Open `HMS/HMS.slnx` in Visual Studio.
2. Restore NuGet packages (Serilog, Microsoft.SqlServer.Types, etc.).
3. Set **HMS** as the startup project.
4. Build and run (F5).
5. Log in with a user from the restored database to access the system.

## Building the Installer

The `Setup1_HMS` project can be built to produce a standalone Windows installer (`.msi`) for distributing the application without requiring Visual Studio on the target machine.

## Roadmap Ideas

- [ ] Migrate connection string handling to a secure configuration approach
- [ ] Add automated tests for the business logic layer
- [ ] Export reports to PDF/Excel
- [ ] Add role-based access control for different staff types

## License

This project currently has no license file. Add one (e.g. MIT) if you intend to allow others to reuse the code.

## Author

Developed by [Abdulrahman Zaid](https://github.com/AbdulrahmanZaid9).
