# blazorCrud


Blazor (Browser + Razor)

http://www.eduardopires.net.br/2018/02/framework-spa-da-microsoft-conheca-o-blazor/



dotnet add package Microsoft.EntityFrameworkCore.Design  

dotnet add package Pomelo.EntityFrameworkCore.MySql

dotnet ef dbcontext scaffold "Server=localhost;User Id=xxxx;Password=xxxx;Database=Usuarios" "Pomelo.EntityFrameworkCore.MySql" -c MyDbContex

dotnet ef migrations add InitialMigration

dotnet ef database update
