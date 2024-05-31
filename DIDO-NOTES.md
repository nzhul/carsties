1. NuGet Gallery Extension:
   - patcx.vscode-nuget-gallery is basically VisualStudio package manager for VSCode
2. `dotnet tool list -g` > gives you the list of dotnet tools installed globally on your machine
3. `dotnet tool install dotnet-ef -g` installs the dotnet-ef tool globally to the latest version > currently this is 8.0.6
4. `dotnet ef migrations add "InitialCreate" -o Data/Migrations` > creates a new migration using the EF Core CLI
5. `docker compose up -d` > starts the docker-compose file in detached mode, this will create and run postgresql database in docker.
   1. NOTE: Please note that we intentionally changed the port from 5432 to 5433 so it is not conflicting with any other postgresql database running on the machine.
6. `dotnet ef database update` > updates the database with the latest migration