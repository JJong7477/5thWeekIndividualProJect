using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Inventory : MonoBehaviour
{
    [SerializeField] private InventoryUI inventoryUI;
    public List<Item> items = new List<Item>();

    private void Reset()
    {
        inventoryUI = this.gameObject.GetComponent<InventoryUI>();
    }

    private void Start()
    {
        AddItem(4);
        AddItem(1);
        AddItem(5);
        AddItem(3);
        AddItem(2);
    }

    public void AddItem(int itemNum)
    {
        inventoryUI.AddItem(itemNum, FindFirstEmptySlot());
        items.Add(ItemDataManager.Instance.items[itemNum].CreateItem());
    }

    public int FindFirstEmptySlot()
    {
        if (items.Count >= inventoryUI.itemSlots.Length) return -1;
        
        return items.Count;
    }
    
    public void RemoveItem(Item item, int index)
    {
        inventoryUI.RemoveItem(index);
        items.Remove(item);
    }
}
