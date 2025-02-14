# Sample Crud MVC

To run this project you will need docker desktop, [dockder desktop](https://www.docker.com/products/docker-desktop/#:~:text=Download%20Docker%20Desktop)

## Clone repository
Clone and cd in to directory
```
git clone https://github.com/Collin-1/C-Sharp-basics.git
cd C-Sharp-basics/
```
## Run project

Go to the MVC branch by running the command on terminal:  
```
git checkout MVC
```
#### Start docker-compose
I used a docker-compose file to run an MS SQL server, so to run the project you will need to start the docker compose file by running the following command:
```
docker-compose up
```
Docker will run to services, :
To login in adminer use the below credentials but only after you have ran the migrations:

```
System   :  MS SQL
Server   :  sql-server-db
Username :  sa
Password :  MyP@ssw0rd
Database :  personnel
```

#### run migrations

To run the migrations to create the database and tables run the below commands:

``` I do not have admin right to my work pc so the below command were ran on git bash using dotnet commands, but if you have access to Package Manager Console the command can be use there as well```
```
cd SampleCRUDMVC/  // enter the project
dotnet ef database update
```
#### Open Visual Studio
To open the project on visual studio run the below commands on the terminal:
```
start devenv SampleCRUDMVC/SampleCRUDMVC.sln
```

Launch the app and click employees to view, add, delete, and edit employees.