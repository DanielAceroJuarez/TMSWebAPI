# Transportation Management System (TMS) Web API

## Overview

The TMS Web API provides backend support for managing shipments, including creation, retrieval, update, and deletion of shipment records. It is designed using best practices and includes the following features:

- Singleton and Dependency Injection design patterns
- Unit tests with NUnit
- Generics and Extension Methods
- Strategy pattern for shipping cost calculations

## Classes and Design Patterns

### Shipment

Represents a shipment in the TMS.

### ShipmentRepository

Implements a generic repository for managing shipments.

### ShipmentManager

Singleton class for managing shipment repositories.

### IShippingStrategy, StandardShippingStrategy, ExpressShippingStrategy

Implement the Strategy pattern for calculating shipping costs.

## Unit Tests

Unit tests are provided using NUnit to ensure the functionality of the repository.

## Extension Methods

Extension methods are implemented to calculate the shipping cost.

## Technical Specifications

- **Framework**: .NET Core
- **Language**: C#
- **Testing Framework**: NUnit
- **Design Patterns**: Singleton, Dependency Injection, Strategy
- **Concepts**: Generics, Extension Methods

## Getting Started

1. Clone the repository.
2. Run the unit tests using NUnit.
3. Use the API to manage shipments.

## Example Usage

1. Start the API:

```bash
dotnet run
