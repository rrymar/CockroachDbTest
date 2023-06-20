## .NET 6 + Entity Framework + CockroachDb POC 

### Preparation of Env

#### Sign-up at https://cockroachlabs.cloud/

 Install Root certificate provided by CockroachLabs 

#### Install .NET 6

#### Install global EF tool:

`dotnet tool install --global dotnet-ef`


## Run 

Replace connection string 
 `optionsBuilder.UseNpgsql(....)`


 Run console app
 
 To add new migrations run  `dotnet ef migrations add name`