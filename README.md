# 🏋️ Fitness Gym Management System

A comprehensive **Windows desktop application** built with **C# (.NET Framework)** and **Microsoft SQL Server**, designed to streamline gym operations, including member enrollment, subscription management, workout session scheduling, and administrative access control.

---

## 📌 Project Overview

* **Platform:** Windows Desktop Application (WinForms)
* **Language & Framework:** C# / .NET Framework
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET
* **Architecture:** Modular UserControl-based UI Architecture

---

## 🚀 Key Features & Modules

### 1. Member Management (`UC_AddMember`, `UC_ViewMembers`)

* Register new members with personal details, emergency contacts, and joining dates.
* Search, filter, update, and remove existing member profiles.
* View detailed member profiles and active subscription statuses.

### 2. Subscription & Plan Management (`UC_ManageSubscriptions`)

* Define and configure membership tiers:

  * Monthly
  * Quarterly
  * Annual
  * VIP
* Track active, expiring, and renewed subscriptions.
* Automatically calculate membership validity.
* Track payment status.

### 3. Session Scheduling (`UC_ManageSessions`)

* Schedule private training sessions and group workout classes.
* Assign trainers/coaches to specific sessions.
* Track session capacity limits.
* Manage available time slots.
* Prevent scheduling conflicts and overlapping sessions.

### 4. User & Role Administration (`UC_ManageUsers`)

* Role-based access control:

  * Admin
  * Staff
  * Receptionist
* Secure credential management for system login.
* Control access to administrative functions based on user roles.

---

## 🛠️ System Architecture & UI Design

### Custom Navigation

The application uses reusable **UserControls** that are dynamically loaded inside the main container (`MainForm2`), providing a smooth and organized desktop user experience similar to a Single Page Application (SPA).

### Data Access Layer

The `DB.cs` class provides centralized database connectivity and helper methods using:

* `SqlConnection`
* `SqlCommand`
* `SqlDataAdapter`
* Parameterized SQL queries

Parameterized queries help protect the application against **SQL Injection** and improve database interaction reliability.

---

## 📂 Repository Structure

```text
Fitness-Gym-Management-System/
│
├── Properties/                    # Assembly information and project properties
├── Resources/                    # UI icons and graphic assets
│
├── DB.cs                          # Database connection and helper methods
├── Program.cs                     # Application entry point
├── MainForm2.cs                   # Main application container and navigation
├── fitness gym.cs                 # Login and authentication form
├── CustomerButton.cs              # Custom UI button component
│
├── UC_AddMember.cs                # Member enrollment module
├── UC_ViewMembers.cs              # Member search and directory module
├── UC_ManageSubscriptions.cs     # Membership plans management
├── UC_ManageSessions.cs           # Training session booking module
├── UC_ManageUsers.cs              # Administrative user access module
├── UC_About.cs                    # Application information and credits
│
├── App.config                     # Database connection configuration
└── fitness gym system.sln         # Visual Studio solution file
```

---

## ⚙️ Getting Started

### Prerequisites

Before running the project, make sure you have:

* **Visual Studio 2019 / 2022**
* **.NET desktop development** workload
* **Microsoft SQL Server** (LocalDB, Express, or Standard)
* **SQL Server Management Studio (SSMS)**

---

## 🔧 Installation & Setup

### 1. Clone the Repository

```bash
git clone https://github.com/Muhammad-Yasser-Al-Hamad/Fitness-Gym-Management-System.git
cd Fitness-Gym-Management-System
```

### 2. Configure the Database

Open `App.config` or `DB.cs` and update the SQL Server connection string according to your local environment.

Example:

```xml
<connectionStrings>
  <add 
    name="GymDB"
    connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=FitnessGymDB;Integrated Security=True"
    providerName="System.Data.SqlClient" />
</connectionStrings>
```

Replace:

```text
YOUR_SERVER_NAME
```

with your SQL Server instance name.

### 3. Open the Project

Open:

```text
fitness gym system.sln
```

using Visual Studio.

### 4. Restore Dependencies

Restore the required NuGet packages and build the solution:

```text
Ctrl + Shift + B
```

### 5. Run the Application

Press:

```text
F5
```

to build and launch the application.

---

## 🔐 Security

The application uses **parameterized SQL queries** when communicating with the database to reduce the risk of SQL Injection.

Role-based access control is also implemented to restrict administrative functionality based on the logged-in user's role.

---

## 🎯 Project Goals

The main goal of this project is to provide a simple and efficient management system that helps gyms organize:

* Member information
* Membership subscriptions
* Payments
* Training sessions
* Staff access
* Administrative operations

---

## 👥 Author

**Muhammad Yasser Al-Hamad**

*Faculty of Information Technology*
*Misr University for Science and Technology (MUST)*

---

## 📌 Technologies Used

```text
C#
.NET Framework
Windows Forms (WinForms)
Microsoft SQL Server
ADO.NET
Visual Studio
SQL Server Management Studio
```
