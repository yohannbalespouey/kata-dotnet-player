# Kata - .NET Player

## Overview  
This repository is a _starting template_ for a .NET code kata / exercise — designed to be used in a **pair-programming** session or a technical screening. 

It's a .NET 8.0 ASP.NET Core Web API project for managing users, designed as a coding kata exercise.

## Project Structure

```
KataPlayer.sln                               # Solution file
├── src/
│   └── Api/                                 # Main API project
│       ├── Api.csproj                       # Project file (targets .NET 8.0)
│       ├── Program.cs                       # Application entry point
│       ├── Controllers/
│       │   └── UserController.cs            # REST API endpoints for user operations
│       ├── Core/
│       │   └── Users/
│       │       ├── User.cs                  # User domain model
│       │       ├── UserService.cs           # Business logic for user operations
│       │       └── UserMemoryRepository.cs  # In-memory data storage
│       └── Properties/
│           └── launchSettings.json          # Launch configuration
│
└── tests/
    └── Api.UnitTests/                       # Unit tests project
        ├── Api.UnitTests.csproj             # Test project file (xUnit)
        └── Core/
            └── Step1.UserServiceTests.cs    # Tests for UserService
```

## Technology Stack

- **.NET 8.0** - Target framework
- **ASP.NET Core** - Web API framework
- **Swashbuckle** - Swagger/OpenAPI documentation
- **xUnit** - Unit testing framework
- **In-Memory Storage** - Dictionary-based data persistence

## Features

### API Endpoints

- `GET /api/users?id={id}` - Retrieve a user by ID
- `POST /api/users?name={name}` - Create a new user
- `PUT /api/users/{user_id}` - Delete a user (Note: HTTP method naming inconsistency)

### Core Components

#### User Model (`User.cs`)
- `Id` - Auto-generated GUID (formatted as hex string)
- `Name` - User's name

#### UserService (`UserService.cs`)
- `GetUser(string id)` - Retrieves a user from the repository
- `CreateUser(string name)` - Creates and persists a new user
- `DeleteUser(User user)` - Deletes a user (not yet implemented)

#### UserMemoryRepository (`UserMemoryRepository.cs`)
Static in-memory repository using `Dictionary<string, User>` for storage:
- `FindUser(string id)` - Finds a user by ID
- `Save(User user)` - Saves a user to memory
- `Delete(string id)` - Removes a user from memory

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- IDE (Visual Studio, VS Code, or Rider)

### Build the Project

```bash
dotnet build
```

### Run the API

```bash
dotnet run --project src/Api/Api.csproj
```

The API will be available at:
- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`
- Swagger UI: `https://localhost:5001/swagger`

### Run Tests

```bash
dotnet test
```

## Development Notes

### Current Implementation Status

✅ **Completed:**
- User model with auto-generated ID
- In-memory repository pattern
- User creation and retrieval functionality
- Basic unit tests for create and get operations

⚠️ **In Progress:**
- Delete user functionality (throws `NotImplementedException`)
- Controller endpoints are placeholders returning `NoContent()` or throwing exceptions

### Known Issues

- HTTP verb mismatch: Delete operation uses `PUT` instead of `DELETE`
- Repository uses static state (not thread-safe, shared across all instances)
- No error handling for missing users (will throw `KeyNotFoundException`)
- Test for delete operation expects `null` but service throws exception

## Testing

The project includes unit tests using xUnit framework:

- `Test_CreateUser` - Validates user creation with correct name
- `Test_GetUser` - Verifies user retrieval after creation
- `Test_DeleteUser` - Tests user deletion (currently failing due to NotImplementedException)

## Configuration

- `appsettings.json` - Production configuration
- `appsettings.Development.json` - Development-specific settings
- `launchSettings.json` - Debug launch profiles

## API Documentation

When running in Development mode, Swagger UI is available for interactive API documentation and testing.

---

**Note:** This is a kata exercise project. Some features are intentionally incomplete for learning purposes.
