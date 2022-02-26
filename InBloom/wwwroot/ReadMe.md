dotnet new webapp -o InBloom
code -r InBloom
dotnet dev-certs https --trust
dotnet watch run
ctrl+c
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.13
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 5.0.13
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.13
dotnet watch run
ctrl+c
dotnet-aspnet-codegenerator razorpage -m Flower -dc FlowerContext -udl -outDir Pages/Flowers --referenceScriptLibraries -sqlite
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet watch run
ctrl+c
dotnet dev-certs https --trust
dotnet ef database update
dotnet watch run
ctrl+c
dotnet dev-certs https --trust
dotnet ef database update
dotnet watch run
ctrl+c

