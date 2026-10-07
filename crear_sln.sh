mkdir "$1"
cd "$1"

dotnet new sln -n "$1"
dotnet new console -n Console
dotnet new classlib -n Dominio

dotnet sln add Console/Console.csproj 
dotnet sln add Dominio/Dominio.csproj

dotnet add Console/Console.csproj reference Dominio/Dominio.csproj
