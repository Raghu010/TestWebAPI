The project is built using .Net 8. targeting .Net SDK 8.0.404.
Added the necessary packages to configure the EntityFramework core in the application.
Created model folder which contains CreateEF file which contains all the properties that the database table should have.
As a next step added a Data folder to the project which contains AppDBContextContext class.
In the next step, configured the local database in the appsettings.json file and read the ConnectionString using the respective object.
In the next step, added the migration in package console manager which created the new database.
Written the end points to perform the CRUD operations on the data.
