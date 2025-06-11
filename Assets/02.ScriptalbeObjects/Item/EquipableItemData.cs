using UnityEngine;

[CreateAssetMenu(menuName = "New Item/Equipment", fileName = "Item_Equipment_")]
public class EquipmentItemData : ItemData
{
    [Header("EquippedStatus")]
    [SerializeField] private float itemAttackStat;
    [SerializeField] private float itemArmorStat;
    [SerializeField] private float itemHealthStat;
    [SerializeField] private float itemCriticalStat;
    
    public float ItemAttackStat => itemAttackStat;
    public float ItemArmorStat => itemArmorStat;
    public float ItemHealthStat => itemHealthStat;
    public float ItemCriticalStat => itemCriticalStat;
    
    public override Item CreateItem()
    {
        return new EquipmentItem(this);
    }
}