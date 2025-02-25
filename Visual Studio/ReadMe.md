# MVC & Entity Framework Code-First Applications

This repository contains two applications:  

- **[Car Insurance](./CarInsurance/)**  
- **[Entity Framework Student Database Application](./Basic-Entity-framework-Student-Database/)**  

The **ASP.NET MVC application** is a simple insurance quote calculator that determines monthly rates based on the user's age, car details, speeding tickets, and additional risk factors like DUI and full coverage selection. It uses **ASP.NET MVC 4/5, C#, and Entity Framework** with an **MSSQL database** to store and process data.

The **Entity Framework Code-First console application** creates a basic **Student database** using **Entity Framework (EF6) and SQL Server**. It defines a `Student` entity, initializes the database, and inserts a sample student record. This demonstrates how EF Code-First can be used to manage a SQL database dynamically within a C# application.

Both applications require **MSSQL Server** and Entity Framework migrations to set up the database. Follow standard EF migration commands (`Enable-Migrations`, `Add-Migration`, `Update-Database`) to initialize the database. Update the **connection string** in `App.config` for the console app to match your SQL Server setup.  

For further improvements, CRUD operations can be added to the console app, and the MVC app can be enhanced with better UI and validation.  

