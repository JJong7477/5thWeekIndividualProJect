public class EquipmentItem : Item
{
    public EquipmentItem(EquipmentItemData data) : base(data)
    {
    }
    
    public EquipmentItemData EquipmentItemData { get; private set; }
    public bool isEquipped = false;
}
