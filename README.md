# git-demo
Demo repository with a C# Calculator project and comprehensive unit tests.

## Project Structure

- **src/Calculations** - A .NET class library containing a Calculator class with various mathematical operations
- **tests/Calculations.Tests** - xUnit test project with comprehensive unit tests for the Calculator

## Features

The Calculator class provides the following operations:
- Basic arithmetic: Add, Subtract, Multiply, Divide
- Advanced math: Power, Square Root
- Statistical: Average, Max, Min
- Utilities: Percentage calculation

## Building the Project

```bash
dotnet build CalculationsDemo.sln --configuration Release
```

## Running Tests

```bash
dotnet test CalculationsDemo.sln --configuration Release
```

## GitHub Actions

This repository includes two GitHub Actions workflows:
- **Build** - Builds the solution on every push and pull request
- **Tests** - Runs all unit tests on every push and pull request

## Requirements

- .NET 8.0 SDK or later
