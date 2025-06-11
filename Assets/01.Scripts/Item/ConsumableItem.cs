using UnityEngine;

public abstract class ConsumableItem : Item
{
    public ConsumableItem(ConsumableItemData data, int amount = 1) : base(data)
    {
        ConsumableData = data;
        SetAmount(amount);
    }
    
    public ConsumableItemData ConsumableData { get; private set; }
    public int Amount { get; protected set; }
    public int MaxStack => ConsumableData.MaxStack;
    public bool IsMax => Amount >= ConsumableData.MaxStack;
    public bool IsEmpty => Amount <= 0;

    public void SetAmount(int amount)
    {
        Amount = Mathf.Clamp(amount, 0, MaxStack);
    }
}
