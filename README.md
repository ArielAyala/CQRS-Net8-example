````markdown name=README.md
# CQRS-Net8-example

[![.NET Version](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/github/license/ArielAyala/CQRS-Net8-example.svg)](LICENSE)
[![Last Commit](https://img.shields.io/github/last-commit/ArielAyala/CQRS-Net8-example.svg)](https://github.com/ArielAyala/CQRS-Net8-example/commits/main)
[![Issues](https://img.shields.io/github/issues/ArielAyala/CQRS-Net8-example.svg)](https://github.com/ArielAyala/CQRS-Net8-example/issues)

## Overview

`CQRS-Net8-example` is a sample project demonstrating the implementation of the **CQRS (Command Query Responsibility Segregation)** pattern using **.NET 8**. This repository provides a practical reference for developers interested in structuring scalable, maintainable applications by separating read and write operations.

## Features

- **CQRS Pattern**: Clean separation between read (query) and write (command) logic.
- **.NET 8**: Utilizes the latest features and performance improvements from .NET 8.
- **MediatR**: Leverages MediatR for request handling and decoupled architecture.
- **Entity Framework Core**: Uses EF Core for data persistence.
- **RESTful API**: Sample endpoints to demonstrate CQRS in practice.
- **Extensible Structure**: Easily adaptable for real-world projects.

## Technologies Used

- [.NET 8](https://dotnet.microsoft.com/)
- [MediatR](https://github.com/jbogard/MediatR)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Swagger](https://swagger.io/) for API documentation

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Installation

```bash
git clone https://github.com/ArielAyala/CQRS-Net8-example.git
cd CQRS-Net8-example
dotnet restore
```

### Running the Project

```bash
dotnet run
```

API documentation will be available at `/swagger` when running locally.

## Project Structure

- `Commands/`: Write operations (create, update, delete)
- `Queries/`: Read operations (get, list)
- `Handlers/`: Request handlers for commands and queries
- `Models/`: Domain models/entities
- `Controllers/`: API endpoints
- `Data/`: Database context and configuration

## Example Endpoints

- `GET /api/items` — Retrieve all items (Query)
- `POST /api/items` — Create a new item (Command)

## Why CQRS?

CQRS helps to:
- Improve scalability by separating read/write workloads.
- Simplify complex business logic.
- Enhance maintainability and testability.
- Optimize performance for queries and commands.

## Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the MIT License.

---

Feel free to explore, clone, and adapt this project for your own needs. If you find it helpful, give it a star ⭐!

````
