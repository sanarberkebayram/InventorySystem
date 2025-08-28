namespace InventorySystem.Core.Item
{
    public interface IItem
    {
        public string Id { get; }
        public string ItemTypeId { get; }
    }
}
