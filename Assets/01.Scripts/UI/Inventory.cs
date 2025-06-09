using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerInventory;
    [SerializeField] private Transform itemSlotContainer;
    [SerializeField] private GameObject itemSlotPrefab;
    [SerializeField] private ItemSlot[] itemSlots;
    
    private void Reset()
    {
        playerInventory = Utility.FindChildComponent<TextMeshProUGUI>(transform, "PlayerInventory");
    }

    public void Init()
    {
        itemSlotContainer = Utility.FindChildInChild(transform, "Content");
        
        itemSlots = new ItemSlot[36];

        for (int i = 0; i < itemSlots.Length; i++)
        {
            CreateItemSlots(i);
        }
    }

    private void CreateItemSlots(int index)
    {
        GameObject go = Instantiate(itemSlotPrefab, itemSlotContainer);
        itemSlots[index] = go.GetComponent<ItemSlot>();
    }

    public void OpenInventory()
    {
        this.gameObject.SetActive(true);
    }

    public void CloseInventory()
    {
        this.gameObject.SetActive(false);
    }
}
