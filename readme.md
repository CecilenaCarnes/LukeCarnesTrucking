LCTLoadTracker is an app for tracking applicants, employees, owners, customers, loads, mileage and payroll.  Currently only person and load entry exist.

This is an MVC app built from EF and a SQL database.  I have supplied seed data for person and load. You will need to do update-database to create the database.



Project Requirements:
    - Create one class, with one object and populate it with data.  Display the data in the 
        application.
            - Created Person Class 
                - Controller created multiple objects of the Person class for             
                    create, edit, and delete.
                - List of Person returned within the application on the person tab.
    


    - 3 Functions or Methods
        - Person Controller - PersonExists
        - Person Controller - Index
        - Loads Controller - LoadExists
        - Loads Controller - Index
    

    Choose 3 or more from Features List
         
            1- Create an additional class which inherits one or more properties from it parent.
                Created Employee Class which inherits multiple fields from the Person class.
            2- Create a dictionay or list, populate it with several values, retrieve at least one value, and use it in your program.
                Created and used several lists with in the loads class and views.
                - LIST - Person table - returning Person Data.
                - LIST - Product list in Load Class.
            3- Read Data from external file.  Reading data from SQL Database.  You can add data to the database using the web page and it is returned within the form.
            4- Use LINQ - Person Controller is using a LINQ query to return Person 
                    list. Load Controller is using a LINQ query to return Loads.
            5 - Entity Framework - Create and Write to SQL Db - Ernesto Approved Feature 
                Provided Structure and Seed data for Person and Loads.

