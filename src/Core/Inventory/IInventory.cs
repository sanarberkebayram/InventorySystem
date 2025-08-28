
using InventorySystem.Core.Item;

namespace InventorySystem.Core.Inventory;

public interface IInventory
{
    int Count { get; }

    bool CanAdd(IItem item);
    bool HasItem(IItem item);
    bool HasItem(string itemId);

    void AddItem(IItem item);
    void RemoveItem(string itemId);
    void RemoveItem(IItem item);

    IItem GetItem(string itemId);
    IReadOnlyList<IItem> GetItems();

    event Action<IItem> OnItemAdded;
    event Action<IItem> OnItemRemoved;
}
