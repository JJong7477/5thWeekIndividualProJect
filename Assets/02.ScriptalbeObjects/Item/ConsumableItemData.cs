using UnityEngine;

public abstract class ConsumableItemData : ItemData
{
    [Header("Stack")]
    [SerializeField] private int maxStack = 99;
    
    public int MaxStack => maxStack;
}
