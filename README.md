# Laptop Shop Inventory Management System

A desktop-based inventory management application developed using C# Windows Forms and Microsoft SQL Server.

## About the Project

The **Laptop Shop Inventory Management System** is a desktop application designed to simplify and organize laptop inventory management. It allows users to manage laptop records through basic CRUD (Create, Read, Update, Delete) operations.

The application provides a simple interface where users can add new laptop information, view available inventory, update existing records, delete products, and search for laptops by company name or model.

This project is intended for laptop shop owners and employees who need an organized way to maintain product information and manage inventory efficiently.

## Features

- **Add Laptop:** Insert new laptop records into the database.
- **View Inventory:** Display all available laptop records in a DataGridView.
- **Update Laptop:** Modify existing laptop information.
- **Delete Laptop:** Remove laptop records from the database.
- **Search Laptop:** Search for laptops using company name or model.
- **Clear Fields:** Clear the input fields for new entries.
- **Database Integration:** Store and manage inventory records using Microsoft SQL Server.

## Technologies Used

- **Programming Language:** C#
- **Framework:** Windows Forms (.NET)
- **Database:** Microsoft SQL Server
- **IDE:** Visual Studio
- **Database Connectivity:** Microsoft.Data.SqlClient

## Database Structure

**Database Name:** `LaptopDB`

**Table Name:** `Laptops`

| Column Name | Data Type | Description |
|---|---|---|
| LaptopID | INT | Unique laptop identification number |
| Company | VARCHAR(50) | Laptop company name |
| Model | VARCHAR(100) | Laptop model |
| Processor | VARCHAR(100) | Processor information |
| RAM | VARCHAR(30) | RAM capacity |
| Storage | VARCHAR(50) | Storage capacity |
| Quantity | INT | Available quantity |
| Price | DECIMAL(10,2) | Laptop price |
| Warranty | VARCHAR(50) | Warranty information |

## Project Structure

```text
Laptop-Shop-Inventory-Management-System/
│
├── CRUDproject.slnx
├── CRUDproject.csproj
├── Program.cs
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── DbConnection.cs
├── LaptopDB.sql
├── README.md
│
└── Properties/
```

## Installation and Setup

Follow these steps to run the application on your computer.

### 1. Clone the Repository

```bash
https://github.com/BishwojitSarkar/Laptop_Shop_Inventory
```

Alternatively, download the repository as a ZIP file and extract it.

### 2. Create the Database

- Open Microsoft SQL Server Management Studio (SSMS).
- Connect to your SQL Server instance.
- Open the `LaptopDB.sql` file.
- Execute the SQL script.
- The `LaptopDB` database and its table records will be created.

### 3. Configure Database Connection

Open `DbConnection.cs` and update the connection string according to your SQL Server instance.

Example:

```csharp
private static string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LaptopDB;Integrated Security=True;TrustServerCertificate=True";
```

### 4. Open the Project

- Open `CRUDproject.slnx` using Visual Studio.
- Make sure the `Microsoft.Data.SqlClient` NuGet package is installed.
- Build the solution.

### 5. Run the Application

Run the project from Visual Studio. The application will connect to the SQL Server database and display the available laptop inventory.

## API Reference

This project does not use any external APIs.

Database operations are performed using Microsoft.Data.SqlClient to connect the Windows Forms application with Microsoft SQL Server.

The application uses SQL queries for:

- INSERT – Add new laptop records.
- SELECT – Retrieve laptop information.
- UPDATE – Modify existing laptop records.
- DELETE – Remove laptop records.
- LIKE – Search laptops by company name or model.

## Acknowledgements

- Microsoft for providing Visual Studio, C#, and SQL Server.
- The Microsoft Learn documentation for C# and Windows Forms.
- The .NET developer community for helpful learning resources.
- Academic guidance and support throughout the development of this project.

## Project Purpose

This project was developed as an academic project to demonstrate practical knowledge of C# Windows Forms, database connectivity, SQL queries, and CRUD operations.

## Author

**Bishwojit Sarkar**

GitHub: [https://github.com/BishwojitSarkar]

---

*Developed as an academic project using C# Windows Forms and Microsoft SQL Server.*
