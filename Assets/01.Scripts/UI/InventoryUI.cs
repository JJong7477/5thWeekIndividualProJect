using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerInventory;
    [SerializeField] private Transform itemSlotContainer;
    [SerializeField] public ItemSlot[] itemSlots;
    [SerializeField] private Inventory inventory;
    
    [SerializeField] private GameObject useButton;
    [SerializeField] private GameObject equipButton;
    [SerializeField] private GameObject unEquipButton;
    [SerializeField] private GameObject itemSlotPrefab;
    
    private void Reset()
    {
        playerInventory = Utility.FindChildComponent<TextMeshProUGUI>(transform, "PlayerInventory");
        useButton = this.transform.Find("UseButton").gameObject;
        equipButton = this.transform.Find("EquipButton").gameObject;
        unEquipButton = this.transform.Find("UnEquipButton").gameObject;
        itemSlotPrefab = Resources.Load<GameObject>("Prefabs/ItemSlot");
        inventory = GetComponent<Inventory>();
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
        itemSlots[index].SetIndex(index);
    }

    private void Update()
    {

    }
    
    public void OpenInventory()
    {
        this.gameObject.SetActive(true);
    }

    public void CloseInventory()
    {
        this.gameObject.SetActive(false);
    }

    public void AddItem(int itemNum, int index)
    {
        itemSlots[index].SetItem(ItemDataManager.Instance.items[itemNum].Icon, itemNum);
    }

    public void RemoveItem(int index)
    {
        itemSlots[index]?.RemoveItem();
    }

    public void OnClickItemSlot(int index)
    {
        if (inventory.items[index] is PortionItem)
        {
            useButton.SetActive(true);
        }
        else if (inventory.items[index] is EquipmentItem equipmentItem)
        {
            if (equipmentItem.isEquipped)
            {
                unEquipButton.SetActive(true);
            }
            else
            {
                equipButton.SetActive(true);
            }
        }
    }
    
    //클릭했을때 내가 뭘 알수있지
    
    
}
