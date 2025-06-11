using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Item/Potion", fileName = "Item_Potion_")]
public class PotionItemData : ConsumableItemData
{
    [Header("Potion")]
    [SerializeField] private float value;
    public float Value => value;
    
    public override Item CreateItem()
    {
        return new PortionItem(this);
    }
}
