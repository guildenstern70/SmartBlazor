# SmartBlazor

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

A template application featuring Microsoft Blazor Tech with ASP.NET Core 7.x with

- Entity Framework Core - https://learn.microsoft.com/en-us/ef/core/
- Bulma CSS Framework - https://bulma.io/
- Blazorise UI Framework - https://blazorise.com/
- SQLite DB - https://www.sqlite.org/index.html

You may download requirements for any platform here: https://dotnet.microsoft.com/download/dotnet/7.0


## Container

### Build as Docker image

    docker build --platform linux/amd64 -t smartblazor:1.0 .

### Tag image to be uploaded to a repository

    docker tag smartblazor:1.0 docker.io/[your_user]/smartblazor:1.0

### Run docker image

    docker run --publish 80:80 --name SmartBlazor smartblazor:1.0 


## Database and Entity Framework Core

### Initialize and populate DB

If EF Tools are not installed, run

    Install-Package Microsoft.EntityFrameworkCore.Tools

then (you may want to delete all 'smartblazor.db.*' files)

    Update-Database


### Setup DB from scratch

    Install-Package Microsoft.EntityFrameworkCore.Tools
    Add-Migration InitialCreate
    Update-Database

or, using dotnet CLI:

    dotnet tool install --global dotnet-ef
    dotnet add package Microsoft.EntityFrameworkCore.Sqlite
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    dotnet ef migrations add InitialCreate
    dotnet ef database update

