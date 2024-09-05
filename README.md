 Contract Monthly Claim System (CMCS) Documentation
 Introduction
 
The Contract Monthly Claim System (CMCS) is a .NET web-based application designed to streamline the process of submitting and approving monthly claims for Independent Contractor (IC) lecturers. This system provides a user-friendly interface for lecturers, Programme Coordinators, and Academic Managers to manage the claims process efficiently. The CMCS is developed as part of the Programming 2B module (PROG6212) at The Independent Institute of Education, aiming to enhance the practical skills of students in C# programming and .NET GUI development.
 
Project Overview
Objectives
 
This project's main objective is to develop a practical .NET application that enables the automation and management of the claim submission process. The project is divided into three main parts, each focusing on different aspects of the system's development:
 
1. Project Planning and Prototype Development: This includes the design of the system's architecture, the creation of UML diagrams, and the development of a non-functional GUI prototype.
2. Implementation of a Functional Web Application: Adding features to the prototype, such as claim submission, document upload, and status tracking.
3. Automation and Enhancement: Improving the application's functionalities, automating tasks, and preparing a presentation to showcase the system.
 
 Project Planning and Prototype Development
 Design Choices
 the design of the CMCS was planned with a focus on user experience and system functionality. The database structure was designed to store and manage claim data efficiently, while the GUI layout was created to ensure ease of use for all users.
 
•	Database Structure: The database is modeled using a UML class diagram that represents the various entities involved in the claim process, including lecturers, claims, and supporting documents.
•	GUI Layout: The user interface was designed using Windows Presentation Forms or MVC, providing a clear and intuitive layout for users to interact with the system.
 
 UML Class Diagram

1. Users (Lecturers, Programe Coordinators, Academic Managers)
2. Claims
3. ClaimItems
4. SupportingDocuments
5. ApprovalWorkflows
6. Notifications
7. AuditLogs
 
The database will use advanced features such as:
•	Temporal tables for historical tracking of claim statuses
•	 Full-text search for efficient document retrieval
•	 Partitioning for improved query performance on large datasets
 
 Project Plan
 
A detailed project plan was developed, outlining the tasks, dependencies, and timeline for each phase of the project. The plan ensures that the development process is realistic and achievable within the given timeframe.
 
 GUI Prototype
 
The prototype of the GUI includes the following features:
 
•	Claim Submission: A form where lecturers can input their hours worked and hourly rate and submit their claims.
•	Approval Process: Views for Programme Coordinators and Academic Managers to verify and approve claims.
•	Document Upload: A feature that allows lecturers to upload supporting documents with their claims.
 
 Assumptions and Constraints:
Assumption: application is user friendly and responsive.
Constraint: The system must comply with GDPR and other relevant data protection regulations.
Assumption: The system will handle up to 100 active users and 1,000 claims per month.
Constraint: The application must maintain 99.9% uptime.
Assumption: Integration with existing HR and payroll systems will be required.

Rationale for Design Decisions
1. Modular Architecture: Enables easier maintenance and scalability.
2. Advanced Database Features: Improves performance and data integrity.
3. Responsive Design: Ensures usability across various devices.
4. Accessibility and Localization: Broadens the potential user base.
5. Microinteractions: Enhances user engagement and provides visual feedback.

 Conclusion
 
The CMCS project demonstrates the practical application of C# and .NET Core in developing a real-world web application. Through this project, students gained valuable experience in software development, from initial planning and design to implementation and enhancement. The final system provides a robust solution for managing the claim submission process, offering significant benefits in terms of efficiency and user satisfaction.

how to set up the app:
1. download vs studio
2. download the zip folder or clone the repo
3. open the folder on your IDE
4. build and run the app
