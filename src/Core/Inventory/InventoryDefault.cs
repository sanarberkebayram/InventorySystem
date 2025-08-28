using InventorySystem.Core.Item;

namespace InventorySystem.Core.Inventory;

public class InventoryDefault : IInventory
{
    public int Count => _lookUp.Count;
    public event Action<IItem>? OnItemAdded;
    public event Action<IItem>? OnItemRemoved;

    private readonly int _capacity;
    private readonly Dictionary<string, IItem> _lookUp;

    public InventoryDefault(int capacity = 10)
    {
        _capacity = capacity;
        _lookUp = new();
    }

    public void AddItem(IItem item)
    {
        _lookUp.Add(item.Id, item);
        OnItemAdded?.Invoke(item);
    }

    public bool CanAdd(IItem item)
    {
        if (!CheckCapacity())
            return false;

        return !_lookUp.ContainsKey(item.Id);
    }

    public IItem GetItem(string itemId) => _lookUp[itemId];

    public IReadOnlyList<IItem> GetItems() => _lookUp.Values.ToList().AsReadOnly();

    public bool HasItem(IItem item) => HasItem(item.Id);

    public bool HasItem(string itemId) => _lookUp.ContainsKey(itemId);

    public void RemoveItem(string itemId)
    {
        var item = GetItem(itemId);
        _lookUp.Remove(itemId);
        OnItemRemoved?.Invoke(item);
    }

    public void RemoveItem(IItem item) => RemoveItem(item.Id);

    private bool CheckCapacity() => _lookUp.Values.Count < _capacity;
}
