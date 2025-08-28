namespace InventorySystem.Core.Item
{
    public class ItemDefault : IItem
    {
        public string Id { get; protected set; }
        public string ItemTypeId { get; protected set; }

        public ItemDefault(string itemTypeId, string id = "")
        {
            if (string.IsNullOrWhiteSpace(id))
                id = Guid.NewGuid().ToString();
            Id = id;
            ItemTypeId = itemTypeId;
        }
    }
}
