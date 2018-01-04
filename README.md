# AngularASPNETCore2WebApiAuth
Sample project demonstrating jwt-based authentication with an Angular (v5.2.1) frontend and ASP.NET Core 2 WebApi.  Includes both local user registration and facebook login scenarios.

## Development Environment
Sql Server Express 2017 & Sql Server Management Studio 2017
Runs in both Visual Studio 2017 & Visual Studio Code
Node 8.9.4 & NPM 5.6.0
.NET Core 2.0 sdk
Angular CLI -> `npm install -g @angular/cli` https://github.com/angular/angular-cli
 

## Setup
To run the project obtain the repo and then:
1. Install npm packages by running  `\src>npm install` in the `src` directory.
2. Restore nuget packages by running `\src>dotnet restore` in the `src` directory.
3. Create the database using existing migrations by running `\src>dotnet ef database update` in the `src` directory.
4. Run the project by running `\src>dotnet run` in the `src` directory.
5. Point your browser to **http://localhost:5000**.

The project can also be run from either Visual Studio 2017 or Visual Studio Code with the IDE handling some of the steps above but if you have issues try running the above from the command line to ensure everything is setup.


