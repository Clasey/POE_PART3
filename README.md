Project Name: Claim Management App
Description
The Claim Management App is a simple ASP.NET Core MVC application designed to manage lecturer claims. This lightweight application provides the following functionality:

Login System: Supports login for lecturers and administrators with pre-defined credentials.
Lecturer Features:
Submit new claims with details such as description, amount, and notes.
View the list of submitted claims.
Admin Features:
Approve or deny submitted claims.
View all claims submitted by lecturers with their statuses.
This version of the application does not include a database for simplicity. All data is stored in memory while the application runs.

Prerequisites
.NET 6.0 SDK: Install from here.
Visual Studio 2022 (or later) with ASP.NET and web development workloads installed.
Setup Instructions
Clone the Repository
Clone the project repository to your local machine:

bash
Copy code
git clone <repository_url>
cd ClaimManagementApp
Open the Project
Open the ClaimManagementApp folder in Visual Studio.

Restore Dependencies
Restore all required NuGet packages by running the following command in the terminal:

bash
Copy code
dotnet restore
Run the Application
Start the application by pressing F5 or running:

bash
Copy code
dotnet run
The app will launch in your default browser.

Usage
Login Credentials:

Lecturer:
Username: lecturer
Password: password
Admin:
Username: admin
Password: admin
Lecturer Features:

Login with lecturer credentials.
Submit a claim using the "Submit New Claim" button.
View all submitted claims and their statuses.
Admin Features:

Login with admin credentials.
View all submitted claims.
Approve or deny claims using the respective buttons.
Project Structure
bash
Copy code
ClaimManagementApp
├── Controllers
│   ├── AccountController.cs      # Manages user login functionality
│   ├── ClaimController.cs        # Handles claim management actions
│
├── Models
│   ├── Claim.cs                  # Defines the Claim model
│   ├── LoginViewModel.cs         # Defines the Login ViewModel
│
├── Views
│   ├── Account
│   │   ├── Login.cshtml          # Login page for lecturers and admin
│   ├── Claim
│   │   ├── Index.cshtml          # Displays claims for lecturers
│   │   ├── Create.cshtml         # Form to submit a new claim
│   │   ├── AdminDashboard.cshtml # Admin's claim management page
│   ├── Shared
│       ├── _Layout.cshtml        # Shared layout for the application
│       ├── Error.cshtml          # Error handling page
│
├── Startup.cs                    # Configures the app and services
├── Program.cs                    # Entry point of the application
Key Features
Role-Based Access:
Separate interfaces for lecturers and administrators.
In-Memory Data Storage:
Data is stored in memory during the application's runtime.
Claim Status Management:
Admin can approve or deny claims.
Future Enhancements
Add a database (e.g., SQL Server) for data persistence.
Implement user registration functionality.
Improve UI/UX using a front-end framework like Bootstrap.
Add advanced admin features like claim filtering and exporting data.
Troubleshooting
App Doesn't Start:
Ensure all dependencies are installed by running:

bash
Copy code
dotnet restore
Missing Login Credentials:
Use the default credentials mentioned above.

Static Data Loss:
Since the app uses in-memory data, claims reset when the app restarts. Add a database later to persist data.

Contributing
Fork the repository.
Create a feature branch:
bash
Copy code
git checkout -b feature-name
Commit your changes:
bash
Copy code
git commit -m "Add feature"
Push to the branch:
bash
Copy code
git push origin feature-name
Open a pull request.
