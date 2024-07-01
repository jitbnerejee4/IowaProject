COUNTY ADJACENCY CHECKER
Overview 
The County Adjacency Checker is a WPF application that allows users to determine if two counties in Iowa are adjacent. Users can input the names of the counties, and the application will check their adjacency based on data stored in a MySQL database.

Prerequisites 
1.	Visual Studio 2017 or later. 
2.	MySQL Server 2017 or later. 
3.	MySQL Workbench (optional, for database management).

Project Structure 
•	CountyAdjacencyChecker.sln: Visual Studio solution file 
•	CountyAdjacencyChecker/: Project directory containing the WPF application. 
•	App.xaml: Application definition and resources. 
•	App.xaml.cs: Application entry point. 
•	MainWindow.xaml: Main window UI definition. 
•	MainWindow.xaml.cs: Main window logic. 
•	CountyAdjacency.cs: Class containing methods to interact with the database.

Database Setup 
•	createdb.sql: Script to create the database and tables.
•	adddata.sql: Script to add data through general SQL statements. Initially we have only ‘Story’, ‘Greene’ and ‘Tama’. ‘Story’ and ‘Greene’, ‘Story’ and ‘Tama’ are adjacent to each other. 
•	addcounty.sql: Script to create stored procedure for adding county.
•	addcountyadjacency.sql: Script to create stored procedure for adding adjacency data. 
•	arecountiesadjacent.sql: Script to create the stored procedure for checking adjacency.

Application Setup
1.	Download the project: Download the project directory to your local machine.
2.	Open in Visual Studio: Open the ‘CountyAdjacencyChecker.sln’ file in Visual Studio.
3.	Build the Solution: Go to the ‘Build’ menu and select ‘Build Solution’.

Configuration
Database Connection String: Update the connection string in CountyAdjacency.cs to match your MySQL server configuration:
private string connectionString = "Server=localhost;Database=CountyAdjacencyDB;User ID=root;Password=yourpassword;";
Replace ‘localhost’, ‘root’, and ‘yourpassword’ with your MySQL server address, username, and password.

Usage
1.	Run the Application: Press ‘F5’ or click the ‘Start’ button in Visual Studio to run the application.
2.	Check Adjacency: Enter the names of the two counties you want to check in the provided text boxes. Click the ‘Check Adjacency’ button. The result will be displayed below the button indicating whether the counties are adjacent. If one of the counties does not exist in the database it will say ‘County not found’.
Assumptions 
•	The database contains all necessary county and adjacency data. 
•	The user has the appropriate permissions to access the MySQL database. 
•	The MySQL server is running and accessible from the machine running the application.
C# Files 
•	App.xaml: Defines application-level resources and startup behavior. 
•	App.xaml.cs: Contains the application entry point logic. 
•	MainWindow.xaml: Defines the main window's UI elements. 
•	MainWindow.xaml.cs: Contains the main window's event handlers and logic.
•	CountyAdjacency.cs: Contains methods for interacting with the database, including fetching county IDs and checking adjacency.

