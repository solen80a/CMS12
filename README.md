# Empty CMS template

## How to run

Chose one of the following options to get started. 

### Local
Prerequisities
- .NET SDK 8+
- SQL Server 2016 Express LocalDB (or later)

IIS Express Visual Studio 
1. Open the solution in Visual Studio and run the project using IIS Express.		
2. The database will be created automatically on first run.
3. The application will be available at https://localhost:61920 (or similar URL).
4. You can change the port number in the project settings if needed.

http://localhost:61920/episerver/cms

Create admin user
http://localhost:61920/Util/register

Leran how to create a starter site CMS 12
https://www.jondjones.com/learn-optimizely/cms/the-ultimate-guide-to-optimizely-cms-12/


### Windows

Prerequisities
- .NET SDK 8+
- SQL Server 2016 Express LocalDB (or later)

```bash
$ dotnet run
````

### Any OS with Docker

Prerequisities
- Docker
- Enable Docker support when applying the template
- Review the .env file and make changes where necessary to the Docker-related variables

```bash
$ docker-compose up
````

> Note that this Docker setup is just configured for local development. Follow this [guide to enable HTTPS](https://github.com/dotnet/dotnet-docker/blob/main/samples/run-aspnetcore-https-development.md).

#### Reclaiming Docker Image Space

1. Backup the App_Data/\${DB_NAME}.mdf and App_Data/\${DB_NAME}.ldf DB restoration files for safety
2. Run `docker compose down --rmi all` to remove containers, networks, and images associated with the specific project instance
3. In the future, run `docker compose up` anytime you want to recreate the images and containers

### Any OS with external database server

Prerequisities
- .NET SDK 8+
- SQL Server 2016 (or later) on a external server, e.g. Azure SQL

Create an empty database on the external database server and update the connection string accordingly.

```bash
$ dotnet run
````
