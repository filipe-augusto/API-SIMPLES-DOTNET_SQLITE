var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

//dotnet add package Microsoft.EntityFrameworkCore.Sqlite
//dotnet add package Microsoft.EntityFrameworkCore.Design
//dotnet add package Microsoft.EntityFrameworkCore.Sqlite.Design
//Microsoft.EnityFrameworkCore.Sqlite.Tools
//dotnet ef migrations add CreateDatabase -- criar banco
//dotnet ef database update
//dotnet tool install --global dotnet-ef