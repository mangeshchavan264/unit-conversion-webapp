# Unit Conversion API

## Overview

Unit Conversion API is an ASP.NET Core Web API that converts values between different units of measurement.

Currently supported categories:

* Length
* Weight / Mass
* Temperature

The solution is designed with scalability in mind, allowing additional units and conversion categories to be added with minimal code changes.

---

## Technologies Used

* .NET 8
* ASP.NET Core Web API
* Swagger / OpenAPI
* Dependency Injection
* C#

---

## Project Structure

```text
Controllers/
Data/
Models/
Services/
Program.cs
```

### Components

* Controllers: API endpoints
* Models: Request and response DTOs
* Services: Business logic for conversions
* Data: Unit definitions and conversion factors

---

## Running the Project

### Prerequisites

* .NET 8 SDK
* Visual Studio 2022

### Run Locally

Restore packages:

```bash
dotnet restore
```

Build:

```bash
dotnet build
```

Run:

```bash
dotnet run
```

Swagger UI will be available at:

```text
https://localhost:<port>/swagger
```

---

## API Endpoint

### Convert Units

POST

```text
/api/conversion
```

Request:

```json
{
  "value": 100,
  "fromUnit": "meter",
  "toUnit": "feet"
}
```

Response:

```json
{
  "originalValue": 100,
  "fromUnit": "meter",
  "toUnit": "feet",
  "convertedValue": 328.084
}
```

---

## Supported Units

### Length

* meter
* kilometer
* centimeter
* millimeter
* feet
* inch
* yard
* mile

### Weight

* kilogram
* gram
* milligram
* pound
* ounce

### Temperature

* celsius
* fahrenheit

---

## Design Decisions

### Service Layer

Conversion logic is separated from controllers using a service layer to improve maintainability and testability.

### Dependency Injection

Services are registered using ASP.NET Core Dependency Injection.

### Centralized Unit Definitions

Conversion factors are maintained in a dedicated location, making it easy to add new units.

---

## Future Improvements

* Database-backed unit definitions
* Additional conversion categories
* Global exception handling middleware
* Unit testing
* Docker support
* Logging with Serilog

---

## Trade-Offs

For simplicity, conversion factors are hardcoded in memory.

In a production system, unit definitions would likely be stored in a database or configuration source to support hundreds of units and dynamic updates.
