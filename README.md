# SmartBlazor

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

A template application featuring Microsoft Blazor Tech with ASP.NET Core 6.x

This code requires:

-> Microsoft .NET Core 6.x
-> Microsoft ASP.NET Core 6.x

You may download requirements for any platform here: https://dotnet.microsoft.com/download/dotnet/6.0


## Container

### Build as Docker image

    docker build -t smartblazor:1.0 .

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
