/////////////// UTILIZAR EL PROYECTO  EN ".NET" ///////////////////


Usefull resources:

***** Identity Login and how to set up: *****

https://medium.com/oracledevs/using-oracle-database-with-asp-net-core-identity-3216fab69eb

Notes:
- No need to create a SQL script as it will use the migrations to the DB when run and create the needed tables.
- Delete the Unicode parameter from the connection string and change the password for the user to make a valid string.

***** CRUD *****

https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-7.0#create-controller-and-views

Notes: 
- Make model class based on the SQL.
- Then follow tutorial to create views and CRUD based on the model.
