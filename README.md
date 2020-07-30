# Thisney.Ticket Sample
Asp.NET Core 2.2 WebAPI  +  Angular 8 frontend  +  SQLServer database

Requires:
  An installed instance of MSSQLServer
  Angular CLI installed
  Node.js instaled
  .NET Core 2.2.300
  
Before running:
  1) Adjust connectionstrings to run on top of your MSSQLServer instance. For that, update files DataBase/Context/ContextFactory.cs and API/app.settings
  2) In VS or VSCode terminal, navigate to Database project, and run 'dotnet ef database update' (if VSCode) or 'Update-Database' (if VS)
  3) Run the solution
  4) Navigate to SPA folder then execute 'ng serve' 
  5) Enjoy the sample
