# C# - Test Driven Development

This project focuses on implementing Test Driven Development (TDD) practices in C#.

## Project Structure

Each task in this project follows a standard structure:
- A solution file (.sln)
- A class library project (netstandard2.0)
- A test library project using NUnit (netcoreapp2.1)

## Requirements

- **Editor**: Visual Studio Code
- **Platform**: Ubuntu 14.04 LTS
- **Framework**: .NET Core
- **Testing Framework**: NUnit

## Tasks

### 0. Add integers
Write a method that adds 2 numbers.

- **Namespace**: MyMath
- **Class**: Operations
- **Prototype**: `public static int Add(int a, int b)`
- **Returns**: sum of a and b

## Setup Instructions

To set up and run the project:

1. Navigate to the task directory:
   ```bash
   cd 0-add
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Build the solution:
   ```bash
   dotnet build
   ```

4. Run the tests:
   ```bash
   dotnet test
   ```

## Directory Structure

```
0-add/
├── 0-add.sln
├── MyMath/
│   ├── MyMath.cs
│   └── MyMath.csproj
└── MyMath.Tests/
    ├── MyMath.Tests.cs
    └── MyMath.Tests.csproj
```

## Author
Yvan