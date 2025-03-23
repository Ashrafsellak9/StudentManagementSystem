# StudentManagementSystem

Student Management System

Overview

The Student Management System is a web application built using ASP.NET Core Razor Pages and Entity Framework Core. It allows users to manage student records efficiently, including adding, editing, and deleting students. The project also integrates ASP.NET Core Identity for user authentication and authorization.

Features

Add, Edit, View, and Delete Student Records

User Authentication (Register, Login, Logout) using ASP.NET Core Identity

Secure role-based access control

Database integration using Entity Framework Core with SQL Server

Razor Pages for dynamic UI rendering

Technologies Used

ASP.NET Core Razor Pages

Entity Framework Core

SQL Server

ASP.NET Core Identity

Bootstrap (for styling)

Installation & Setup

Prerequisites

Make sure you have the following installed:

.NET 6 SDK or later

SQL Server (or an alternative database)

Visual Studio (recommended) or Visual Studio Code

Steps to Run the Project

Clone the Repository

git clone https://github.com/your-repo-url/student-management-system.git
cd student-management-system

Configure the Database

Open appsettings.json and update the connection string:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=StudentManagementDB;Trusted_Connection=True;"
}

Install Dependencies

dotnet restore

Apply Migrations & Update Database

dotnet ef database update --context StudentManagementSystem.Data.ApplicationDbContext

Run the Application

dotnet run

Open a web browser and go to https://localhost:5001 (or the specified port).

Usage

Register a new user to access the system.

Log in to manage student records.

Perform CRUD operations (Create, Read, Update, Delete) on student data.

Troubleshooting

If you encounter issues with migrations:

dotnet ef migrations add InitialCreate --context StudentManagementSystem.Data.ApplicationDbContext

If multiple DbContext instances exist, explicitly specify the context:

Update-Database -Context StudentManagementSystem.Data.ApplicationDbContext

License

This project is licensed under the MIT License.

Contributing

Contributions are welcome! Feel free to submit pull requests or report issues.

Contact

For any questions or support, reach out to sellakachraf9@gmail.com.
