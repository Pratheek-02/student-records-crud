Project Purpose

This project is a Student Management System that allows users to perform basic CRUD (Create, Read, Update, Delete) operations on student data.
It is designed to demonstrate how frontend and backend technologies work together to manage data efficiently.

Users can:

Add new student records
View all students
Update existing student details
Delete student records
 Tech Stack
Frontend: React.js
Backend: ASP.NET Web API
Database: SQL Server
Tools: Visual Studio, VS Code, Git
Features
Add student details (Name, Course, etc.)
Display student list
Edit/update student information
Delete student records
API integration using Axios
 How to Run the Project
 1. Clone the Repository
git clone https://github.com/Pratheek-02/OurProject.git
 2. Backend Setup (ASP.NET API)
Open the backend project in Visual Studio
Restore NuGet packages
Update database connection string in appsettings.json
Run the API
 It will run on: http://localhost:5016
 3. Frontend Setup (React)
Open frontend folder in VS Code
Install dependencies:
npm install
Start the React app:
npm start

It will run on: http://localhost:3000

 4. API Configuration

Make sure the base URL in your React code is:

const BASE_URL = "http://localhost:5016/Student";




📚 Learning Outcome
Understanding CRUD operations
API integration using Axios
Frontend-backend communication
State management using React Hooks
👤 Author

Pratheek
