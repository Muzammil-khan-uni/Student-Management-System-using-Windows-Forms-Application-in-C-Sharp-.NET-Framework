# Student Management System using Windows Forms Application in C Sharp .NET-Framework With SQL

ADD RECORD

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System-using-Windows-Forms-Application-in-C-Sharp-.NET-Framework/blob/main/SS/ADD%20RECORD.png)

LOAD RECORD

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System-using-Windows-Forms-Application-in-C-Sharp-.NET-Framework/blob/main/SS/LOAD%20RECORD.png)

UPDATE RECORD

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System-using-Windows-Forms-Application-in-C-Sharp-.NET-Framework/blob/main/SS/UPDATE%20RECORD.png)

DELETE RECORD

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System-using-Windows-Forms-Application-in-C-Sharp-.NET-Framework/blob/main/SS/DELETE%20RECORD.png)
![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System-using-Windows-Forms-Application-in-C-Sharp-.NET-Framework/blob/main/SS/DELETE%20RECORD1.png)

This project is a Windows Forms Application developed using C# and .NET Framework, which provides a graphical interface to perform CRUD operations (Create, Read, Update, Delete) on a student database. It connects to a SQL Server database and allows the user to manage student records including name, roll number, and email.

🧱 Core Functionalities:

1. Add Student (Insert Operation)

When the user enters student details (Name, Roll No, Email) and clicks the Submit button:

The application collects data from the form.

It executes a SQL INSERT query using a SqlCommand with parameters.

Displays a message indicating success or failure of the operation.

2. Clear Fields

The Clear button resets all the input fields (name, rollno, and email) to blank values.

3. Display All Records (Read Operation)

When the Load button is clicked:

A SELECT * FROM STUDENTDB query is executed.

The resulting records are loaded into a DataGridView using SqlDataAdapter and DataTable.

This allows the user to view all student records in a tabular form.

4. Update Student

On clicking the Update button:

The application updates the Name and Email fields for the given Roll No.

A SQL UPDATE statement is executed where Roll_No matches the user input.

Displays a message about whether the update was successful or not.

5. Delete Student

When the Delete button is clicked:

It executes a DELETE statement on the record with the specified Roll No.

Shows a success/failure message based on whether a matching record was found.

🛠️ Technologies Used:

| Component     | Technology                                      |
| ------------- | ----------------------------------------------- |
| Language      | C#                                              |
| Framework     | .NET Framework (Windows Forms)                  |
| UI            | Windows Forms Designer                          |
| Database      | SQL Server                                      |
| Data Access   | `SqlConnection`, `SqlCommand`, `SqlDataAdapter` |
| Configuration | `App.config` for connection string              |

🎯 Project Objectives:

To practice basic database operations (CRUD) in C#.

To understand event-driven programming using Windows Forms.

To explore working with SQL Server from C# via ADO.NET.

To build a user-friendly desktop app for managing student data.
