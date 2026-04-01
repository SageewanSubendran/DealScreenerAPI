# DealScreenerAPI
Given data regarding a real estate deal, API will return key data to determine the strength of the deal.

The DealScreener API is a high-performance .NET 8 Web API that analyzes real estate investment deals.

## Features
- Cash flow analysis
- Cap rate calculation
- Cash-on-cash return
- Mortgage amortization
- Deal scoring engine

## Tech Stack
- .NET 8
- Entity Framework Core (ready)
- Docker
- Swagger
- xUnit

## Run Locally
```bash
docker-compose up --build
```

## Example Request
```json
{
  "purchasePrice": 500000,
  "downPayment": 100000,
  "interestRate": 5.5,
  "loanTermYears": 25,
  "monthlyRent": 3200,
  "expenses": {
    "tax": 300,
    "insurance": 150,
    "maintenance": 200,
    "propertyManagement": 0
  }
}
```
