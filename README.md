# Technician Service Management System

## Overview

The Technician Service Management System is a Windows Forms application developed in C#. It is designed to manage service requests and customer interactions for a service-based company. The application allows administrators, technicians, and receptionists to handle their respective tasks, including logging in, managing service requests, generating reports, and updating user information. This project utilizes a SQL Server database to store user credentials, customer information, and service request data.

## Table of Contents

1. [Features](#features)
2. [Installation](#installation)
3. [Usage](#usage)
4. [Project Structure](#project-structure)
5. [Database Configuration](#database-configuration)
6. [Contributing](#contributing)
7. [License](#license)

## Features

- **Login System**: Secure login functionality for technicians, receptionists, and administrators.
- **Technician Home Page**: View and manage pending service requests.
- **Service Request Management**: Mark service requests as completed, update service details, and view customer information.
- **Monthly Reports**: Generate and view reports on service requests and income for a given month.
- **User Management**: Admin functionalities for registering new employees (technicians and receptionists) and managing user information.
- **Settings Page**: Technicians can update their contact details (email and phone number).
- **Database Interaction**: SQL Server integration for storing and managing user and service data.

## Installation

### Prerequisites

- Visual Studio 2022 or later
- .NET Framework 4.8 or later
- SQL Server (Express or any version)
- Git (for cloning the repository)

### Steps

1. **Clone the Repository**: Clone this repository to your local machine using:
   ```bash
   git clone https://github.com/your-username/TechnicianServiceManagement.git
   ```

2. **Open the Project**: Open the solution file (`TechnicianServiceManagement.sln`) in Visual Studio.

3. **Restore NuGet Packages**: Visual Studio should automatically restore NuGet packages. If not, go to `Tools -> NuGet Package Manager -> Package Manager Console` and run:
   ```bash
   Update-Package -Reinstall
   ```

4. **Set Up the Database**:
   - Configure the connection string in `App.config` or `Web.config` with your SQL Server details.
   - Execute the SQL script provided in the `/Database` directory to create the required tables (`Users`, `Customer`, `Technician`, `All_Accounts`, etc.).

5. **Build and Run**: Compile the project by clicking on `Build -> Build Solution` (or press `Ctrl + Shift + B`). Start the application by clicking `Start` (or press `F5`).

## Usage

### Logging In

- Start the application. The initial screen will be the `LoginTechnicianPage`.
- Enter valid credentials based on the role (Admin, Receptionist, Technician).

### Technician Home Page

- View a list of pending service requests.
- Select a service request to view more details or mark it as completed.
- Navigate to settings to update personal information.

### Admin Functions

- Register new technicians or receptionists.
- Generate monthly service and income reports.

### Service Request Management

- Update service descriptions, dates, and mark services as completed.
- View customer details associated with service requests.

### Monthly Reports

- Generate reports for a specific month and year.
- View total income and list of completed services for the selected period.

## Project Structure

- `/TechnicianServiceManagement.sln`: Solution file for Visual Studio.
- `/Program.cs`: Main entry point for the application.
- `/Forms/`: Contains all the form files (`*.cs` and `*.Designer.cs`) for different functionalities (login, technician home page, etc.).
- `/Classes/`: Business logic classes (e.g., `TechnicianLoginCheck.cs`, `RegisterCompletedService.cs`, `TechnicianGetDetails.cs`).
- `/Database/`: SQL scripts and related database files for setting up the application database.
- `/App.config`: Configuration file with connection strings and settings.

## Database Configuration

1. **Connection String**: Ensure the connection string in `App.config` is correctly set to connect to your SQL Server instance.
   ```xml
   <connectionStrings>
       <add name="myCS" connectionString="Server=your_server_name;Database=your_db_name;User Id=your_username;Password=your_password;" providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

2. **Database Tables**: The application interacts with the following tables:
   - `Users`: Stores user credentials and role information.
   - `Customer`: Stores customer information and service details.
   - `Technician`: Stores technician-specific details.
   - `All_Accounts`: Used for managing different user roles and login credentials.

3. **Initial Data**: Use the provided SQL script in the `/Database` directory to create and populate these tables with initial data.
