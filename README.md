# management-application.NET

## Description:
The web application Management, built using ASP.NET framework.  It is suitable for television production companies, allowing them to handle actor, TV series, and episode information, with distinct user roles such as Executive, Coordinator, Clerk, and Admin, and features for adding, viewing, and editing data related to actors, shows, and episodes. This project is ideal for learning web development, working with relational data models, and implementing CRUD operations with .NET technologies.

## Requirements
Prerequisites
Software Requirements:

.NET Framework: Version 4.8 or higher
Visual Studio: 2022 or later with the following workloads:
ASP.NET and web development
.NET Framework development
SQL Server: 2019 or later (LocalDB or full installation)
Web Browser: Google Chrome, Edge, or any modern browser
Dependencies:

Entity Framework 6
AutoMapper 12.x
User Roles:

Executive: Can create actors and manage details.
Coordinator: Can associate shows with actors.
Installation and Setup
Clone the repository:
bash
Copy code
git clone https://github.com/your-username/actor-management-system.git
Open the solution file (ActorManagementSystem.sln) in Visual Studio.
Configure the database connection string in Web.config to match your SQL Server instance.
Apply migrations and seed the database using the Package Manager Console:
bash
Copy code
Update-Database
Build and run the project from Visual Studio.
Running the Application
Start the application by pressing F5 in Visual Studio.
Open the browser and navigate to:
arduino
Copy code
http://localhost:<port>
Log in using the provided credentials or create a new account (if applicable).
