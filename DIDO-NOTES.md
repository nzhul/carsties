1. `dotnet watch` > watches for changes in the project and automatically recompiles the project
2. NuGet Gallery Extension:
   - patcx.vscode-nuget-gallery is basically VisualStudio package manager for VSCode
3. `dotnet tool list -g` > gives you the list of dotnet tools installed globally on your machine
4. `dotnet tool install dotnet-ef -g` installs the dotnet-ef tool globally to the latest version > currently this is 8.0.6
5. `dotnet ef migrations add "InitialCreate" -o Data/Migrations` > creates a new migration using the EF Core CLI
6. `docker compose up -d` > starts the docker-compose file in detached mode, this will create and run postgresql database in docker.
   1. NOTE: Please note that we intentionally changed the port from 5432 to 5433 so it is not conflicting with any other postgresql database running on the machine.
7. `dotnet ef database update` > updates the database with the latest migration
8. `dotnet new webapi -o src/SearchService` > creates a new webapi project in the src/SearchService folder
9. `dotnet sln add src/SearchService` > adds the SearchService project to the solution
10. `git reset --hard 02e183d` > resets the git repository to the commit with the hash 02e183d
11. `docker volume list` > lists all the docker volumes
12. `docker volume rm <volume-name>` > removes the docker volume
13. You can access rabbitmq management console at http://localhost:15672 > username: guest, password: guest
14. https://masstransit.io/ > MassTransit is a free, open-source distributed application framework for .NET (dido: Imagine EntityFramework for messaging)
15. `dotnet new classlib -o src/Contracts` > creates a new class library project in the src/Contracts folder
16. `dotnet add reference ../../src/Contracts/` > adds a reference to the Contracts project in the SearchService project
17. `docker volume ls -q | xargs docker volume rm` > removes all the docker volumes
18. `docker image ls -q | xargs docker image rm` > removes all the docker images
19. `docker compose build auction-svc` > builds the auction-svc service in the docker-compose file
20. `Ctrl + Shift + P` > .NET: Generate Assets for Build and Debug > generates the launch.json and tasks.json files