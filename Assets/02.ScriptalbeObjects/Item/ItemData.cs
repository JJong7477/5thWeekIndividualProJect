using UnityEngine;

public abstract class ItemData : ScriptableObject
{
    [Header("ItemInfo")]
    [SerializeField] private int itemNum;
    [SerializeField] private string itemName;
    [SerializeField] private string itemDescription;
    [SerializeField] private Sprite icon;
    [SerializeField] private ItemType itemType;
    
    public int ItemNum => itemNum;
    public string ItemName => itemName;
    public string ItemDescription => itemDescription;
    public Sprite Icon => icon;
    public ItemType ItemType => itemType;
    
    public abstract Item CreateItem();
}
