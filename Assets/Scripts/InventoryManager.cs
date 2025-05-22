using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public ItemData[] itemData;

    private void Start()
    {
        items.Add(new Item(1, itemData[0]));
        items.Add(new Item(1, itemData[1]));
        items.Add(new Item(1, itemData[2]));
    }

    public void AddItem(ItemData itemData, int qty = 1)
    {
        Item item = new Item(qty, itemData);
        items.Add(item);
    }
    
    public void RemoveItem(ItemData itemData, int qty = 1)
    {
        Item item = null;
        for (int i = 0; i < items.Count; i++)
        {
           if (items[i].data == itemData) item = items[i];
        }
        if (item == null) return;
        
        item.qty -= qty;
        if (item.qty <= 0) items.Remove(item);
    }
}
