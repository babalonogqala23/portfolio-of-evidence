Documentation
 Contract Monthly Claim System (CMCS) - Part 1 Documentation:
Welcome to the Portfolio of Evidence (PoE) part 1 for PROG6212. In this section, I will develop a .NET application using WPF in C# to create the Contract Monthly Claim System (CMCS). This system simplifies the submission and approval of monthly claims for Independent Contractor (IC) lecturers, incorporating complex calculations and document uploads. Through hands-on tasks, you'll design and implement an intuitive user interface, enhancing both efficiency and accuracy. By the end, I will be proficient in WPF GUI development, and have a proficient application ready for deployment.
1. Design Choices and Structure
Database Structure
The CMCS uses a relational database with the following main entities:
•	User: Stores information about lecturers, programme coordinators, and academic managers.
•	Claim: Represents a monthly claim submitted by a lecturer.
•	ClaimDetails: Contains specific details of each claim, such as hours worked and hourly rate.
•	ClaimType: Defines different types of claims (e.g., regular hours, overtime).
•	Approval: Tracks the approval status and process for each claim.
GUI Layout
The CMCS GUI is designed using Windows Presentation Foundation (WPF) and consists of the following main windows:
•	Main Window: Serves as the entry point and navigation hub.
•	Claims Management: Allows lecturers to submit and track claims.
•	User Management: Enables administrators to manage user accounts.
•	Approval Process: Facilitates claim verification and approval by coordinators and managers.
2. Assumptions and Constraints
•	The system assumes that all users have basic computer literacy and can navigate a web-based application.
•	The application is designed for use within a single educational institution and may require modifications for multi-institution use.
•	The system relies on accurate input from lecturers and assumes that supporting documents are genuine.
•	The application is constrained by the security measures of the .NET framework and the hosting environment.
 3. How to Run and Install the App
 Prerequisites
•	Windows 10 or later
•	.NET Framework 4.7.2 or later
•	Visual Studio 2019 or later (for development)
 Installation Steps
1. Clone the repository from GitHub: git clone “https://github.com/babalonogqala23/portfolio-of-evidence.git”
2. Open the solution file `CMCS.sln` in Visual Studio.
3. Restore NuGet packages by right-clicking on the solution and selecting "Restore NuGet Packages".
4. Build the solution by clicking on "Build" > "Build Solution" in the top menu.
 Running the Application
1. In Visual Studio, set the `CMCS.WPF` project as the startup project.
2. Press F5 or click the "Start" button to run the application.
3. The main window of the CMCS application should appear.

main window
![Screenshot (9)](https://github.com/user-attachments/assets/d70aee42-6456-4dd3-a20a-8ec7e77a61a9)

submit claim
![Screenshot (10)](https://github.com/user-attachments/assets/dc063003-cf32-4fc2-be11-325bd6fa6f0d)

user information
![Screenshot (11)](https://github.com/user-attachments/assets/49f3324a-f2b4-452c-a650-b0c2de12936b)

approval page
![Screenshot (12)](https://github.com/user-attachments/assets/210c59a7-aeea-43f5-980e-e19928be4757)





