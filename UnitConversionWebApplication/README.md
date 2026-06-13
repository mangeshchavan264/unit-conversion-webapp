# Unit Conversion Web Application

A lightweight ASP.NET Core 8 Web API with a static HTML frontend for converting values across Length, Weight, and Temperature units.

## Tech Stack

- **Backend:** ASP.NET Core 8 Web API
- **Frontend:** Plain HTML/CSS/JavaScript (static file in `wwwroot`)
- **API Docs:** Swagger / OpenAPI (`Swashbuckle.AspNetCore 6.6.2`)

## Project Structure

```
├── Controllers/
│   └── ConversionController.cs   # POST /api/conversion/convert
├── Data/
│   └── UnitDefinitions.cs        # Unit dictionaries (Length, Weight)
├── Middleware/
│   └── ExceptionHandlingMiddleware.cs  # Global error handler
├── Models/
│   ├── ConversionRequest.cs      # Input model (Value, FromUnit, ToUnit)
│   └── ConversionResponse.cs     # Output model
├── Services/
│   ├── IConversionService.cs     # Service interface
│   └── ConversionService.cs      # Conversion logic
├── wwwroot/
│   └── index.html                # Frontend UI
└── Program.cs                    # App entry point & middleware setup
```

## Supported Units

| Category    | Units |
|-------------|-------|
| Length      | meter, kilometer, centimeter, millimeter, feet, inch, yard, mile |
| Weight      | kg, gm, milligram, pound, ounce |
| Temperature | celsius, fahrenheit, kelvin |

## API

### POST `/api/conversion/convert`

**Request body:**
```json
{
  "value": 100,
  "fromUnit": "meter",
  "toUnit": "feet"
}
```

**Response:**
```json
{
  "originalValue": 100,
  "fromUnit": "meter",
  "toUnit": "feet",
  "convertedValue": 328.084
}
```

**Error response (400):**
```json
{ "message": "Unsupported temperature unit: xyz" }
```


## Screenshot

![App UI](wwwroot/screenshots/app.png)


## Kiro CLI

[![Built with Kiro](https://kiro.dev/images/kiro-badge-light.svg)](https://kiro.dev)

This project was built with assistance from [Kiro CLI](https://kiro.dev) — an AI-powered development agent that runs in the terminal.

Key things Kiro helped with:
- Generating the conversion service and controller logic
- Creating the static HTML frontend with unit dropdowns
- Writing and maintaining this README
