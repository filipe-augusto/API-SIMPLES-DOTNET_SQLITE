Crud simples em .net usando a arquitetura MVC. 
Banco usado nesse exemplo foi o Sqlite.

Pacotes usados
//dotnet add package Microsoft.EntityFrameworkCore.Sqlite
//dotnet add package Microsoft.EntityFrameworkCore.Design
//dotnet add package Microsoft.EntityFrameworkCore.Sqlite.Design
//Microsoft.EnityFrameworkCore.Sqlite.Tools

Criar o banco
//dotnet ef migrations add CreateDatabase -- criar banco
//dotnet ef database update
//dotnet tool install --global dotnet-ef
