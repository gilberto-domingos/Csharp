# Rascunho de comandos .Net :

dotnet list package

rm -rf Migrations
dotnet ef migrations add Initial
dotnet ef database update

dotnet ef migrations add SeedInicial
dotnet ef database update

dotnet add package Moq
dotnet new xunit -n SeuProjeto.Tests
cd SeuProjeto.Tests
dotnet add reference ../SeuProjeto/SeuProjeto.csproj
dotnet add package coverlet.collector
dotnet test --collect:"XPlat Code Coverage"
dotnet tool install --global dotnet-reportgenerator-globaltool
reportgenerator -reports:**/coverage.cobertura.xml -targetdir:coverage-report -reporttypes:Html


dotnet ef migrations remove    
dotnet ef migrations add InitialCreate
dotnet ef database update

dotnet ef database drop
dotnet ef database update

dotnet tool install --global dotnet-ef

dotnet ef database update --project Caminho/Para/ProjetoDeInfraestrutura.csproj

dotnet ef migrations add MigrationName
dotnet ef migrations remove

dotnet ef database drop --force

dotnet clean
dotnet build

dotnet ef migrations add UpdateAutorModel

dotnet restore

dotnet ef migrations add UpdateAutorModel
dotnet ef database update

dotnet ef migrations add RenomearIdParaIdAutor
dotnet ef database update

dotnet build
dotnet watch run
dotnet new webapi
dotnet new xunit
dotnet add package Swashbuckle.AspNetCore
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer 
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet new webapi -n LaboratorioDeTestesAPI



