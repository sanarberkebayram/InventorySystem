# Inventory System

A simple C# console application demonstrating a basic inventory system.

## Description

This project implements a basic inventory system with the ability to add and remove items. The core logic is built around an `IInventory` interface and an `IItem` interface, with default implementations provided.

## Getting Started

### Prerequisites

*   .NET 9.0 SDK

### Building and Running

1.  Clone the repository.
2.  Navigate to the project directory.
3.  Build the project:
    ```bash
    dotnet build
    ```
4.  Run the project:
    ```bash
    dotnet run
    ```

## Usage

The `Program.cs` file provides a simple example of how to use the inventory system:

```csharp
using InventorySystem.Core.Inventory;
using InventorySystem.Core.Item;

string mockItemTypeId = "mock";
IItem item = new ItemDefault(mockItemTypeId);

IInventory inventory = new InventoryDefault();
inventory.OnItemAdded += (item) => Console.WriteLine($"item {item.Id} added");
inventory.OnItemRemoved += (item) => Console.WriteLine($"item {item.Id} removed");

if (inventory.CanAdd(item))
    inventory.AddItem(item);
Console.WriteLine($"Count {inventory.Count} after first item");

if (inventory.HasItem(item))
    inventory.RemoveItem(item);

Console.WriteLine($"Count {inventory.Count} after removal");


if (inventory.CanAdd(item))
    inventory.AddItem(item);
Console.WriteLine($"Count {inventory.Count} after second item");

if (inventory.HasItem(item))
    inventory.RemoveItem(item);

Console.WriteLine($"Count {inventory.Count} after removal");
```
