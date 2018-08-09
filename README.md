# blazorCrud


dotnet add package Microsoft.EntityFrameworkCore.Design  

dotnet add package Pomelo.EntityFrameworkCore.MySql

dotnet ef dbcontext scaffold "Server=localhost;User Id=xxxx;Password=xxxx;Database=Usuarios" "Pomelo.EntityFrameworkCore.MySql" -c MyDbContex

dotnet ef migrations add InitialMigration

dotnet ef database update
