# Romeros Tires And Rims
#### This project is a point of sale system developed in Visual Basic specifically designed for businesses selling car tires, rims, and suspension parts. It allows salespersons to manage their customers, conduct sales operations, and export data to Excel. It utilizes a Microsoft SQL Server database to store information.
## Installation

1. **Prerequisites:**
   - Visual Studio with support for Visual Basic.
   - Microsoft SQL Server installed and running.

2. **Database Setup:**
   - Execute the provided SQL script located in the `Database Config` folder to create the database structure and populate it with sample data.
     - The script file is named [DatabaseScript.sql].
     - You can find the script file within the `Database Config` folder in the project.

# Features
1. **Sign Up:**
   - Only salespersons can sign up for accounts. Provide necessary information such as name, email, and password to create a new account.
2. **Login:**
   - Run the application and log in with your salesperson account.
3. **Customer Management:**
   - Create new customer profiles.
   - Edit existing customer information.
   - Delete customer profiles when necessary.
   - Search for customers by name, phone number, or any other relevant criteria.
4. **Export to Excel:**
   - Salespersons can export customer information to an Excel file for further analysis or reporting.

# Contribution
Contributions are welcome! If you wish to contribute to this project, follow these steps:
- Fork the repository.
- Create a new branch (git checkout -b feature/new-feature).
- Make your changes and commit (git commit -am 'Add a new feature').
- Push to the branch (git push origin feature/new-feature).
- Create a new pull request.
