# SmartBlazor

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

A template application featuring Microsoft Blazor Tech with ASP.NET Core 6.x

## Container

### Build as Docker image

    docker build -t smartblazor:1.0 .

### Tag image to be uploaded to a repository

    docker tag smartblazor:1.0 docker.io/[your_user]/smartblazor:1.0

### Run docker image

    docker run --publish 80:80 --name SmartBlazor smartblazor:1.0 