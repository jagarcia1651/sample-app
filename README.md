This project consists of a .NET Web API using FastEndpoints and a React application built with Vite and TypeScript. The project requires Node.js LTS and .NET LTS to run.

## Prerequisites

### Required 
- **Node.js**: Install the latest LTS version from [nodejs.org](https://nodejs.org/).
- **.NET SDK**: Install the latest LTS version from [dotnet.microsoft.com](https://dotnet.microsoft.com/download).


### Recommended
- **Docker**: Install Docker or Docker Desktop from [docker.com](https://www.docker.com/products/docker-desktop).

## Launching the Applications with Docker (recomended)

Ensure docker or docker desktop are running.

### Visual Studio

Setting the docker-compose project to your startup project should launch the containers.

The default address for the react application is [http://localhost:8080](http://localhost:8080).

The default address for the swagger documentation for the Api is [http://localhost:5001](https://localhost:5001).

### Terminal

You can launch the containers using `docker compose up` from the repository root.

### License
This project is licensed under the MIT License.
