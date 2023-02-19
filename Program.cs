using Todo.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();//add suporte aos controllers
builder.Services.AddDbContext<AppDbContext>();//add suporte ao banco
var app = builder.Build();
app.MapControllers();


app.Run();

//dotnet add package Microsoft.EntityFrameworkCore.Sqlite
//dotnet add package Microsoft.EntityFrameworkCore.Design
//dotnet add package Microsoft.EntityFrameworkCore.Sqlite.Design
//Microsoft.EnityFrameworkCore.Sqlite.Tools
//dotnet ef migrations add CreateDatabase -- criar banco
//dotnet ef database update
//dotnet tool install --global dotnet-ef