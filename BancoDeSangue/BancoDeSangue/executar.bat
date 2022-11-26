docker pull mcr.microsoft.com/mssql/server:2019-latest
docker run -v c:\volumes\mssql --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=BcoSague#2022" -p 1450:1433 -d mcr.microsoft.com/mssql/server:2019-latest

dotnet restore
dotnet tool install --global dotnet-ef --version 5.0.17
dotnet ef migrations add Migration5 --context BancoContext
dotnet ef database update --context BancoContext


dotnet run