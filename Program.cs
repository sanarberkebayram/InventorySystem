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
