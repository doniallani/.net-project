using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class InventoryService : InventoryServices

    {
        private readonly Dictionary<String, InventoryItems> _inventoryItems;
        public InventoryService()
        {
            _inventoryItems = new Dictionary<String, InventoryItems>();
        }
        public InventoryItems AddInventoryItems(InventoryItems items)
        {
            _inventoryItems.Add(items.ItemName, items);
            return items;
        }
        public Dictionary<String, InventoryItems> GetInventoryItems()
        {
            return _inventoryItems;
            throw new NotImplementedException();
        }
    }
}
