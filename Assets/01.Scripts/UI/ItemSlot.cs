using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private GameObject iconGO;
    [SerializeField] private GameObject textGO;
    [SerializeField] private Image iconImage;
    [SerializeField] private TextMeshProUGUI itemAmountText;
    
    [field:SerializeField] public int Index { get; private set; }
    [field:SerializeField] public int ItemIndex { get; private set; }
    
    public bool HasItem => iconImage.sprite != null;


    private void Reset()
    {
        iconGO = transform.Find("Icon").gameObject;
        textGO = transform.Find("Amount").gameObject;
        iconImage = iconGO.GetComponent<Image>();
        itemAmountText = textGO.GetComponent<TextMeshProUGUI>();
    }

    public void SetIndex(int index)
    {
        Index = index;
    }

    public void SetItem(Sprite sprite, int itemNum)
    {
        if (sprite != null)
        {
            iconImage.sprite = sprite;
            ItemIndex = itemNum;
            SetItemAmount(1);
            ShowIcon();
        }
        else
        {
            RemoveItem();
        }
    }
    
    public void RemoveItem()
    {
        iconImage.sprite = null;
        HideIcon();
    }

    public void ShowIcon()
    {
        iconGO.SetActive(true);
    }

    public void HideIcon()
    {
        iconGO.SetActive(false);
    }

    public void ShowText()
    {
        textGO.SetActive(true);
    }

    public void HideText()
    {
        textGO.SetActive(false);
    }

    public void SetItemAmount(int amount)
    {
        if (HasItem && amount > 1)
        {
            ShowText();
        }
        else
        {
            HideText();
        }
        
        itemAmountText.text = amount.ToString();
    }

    public int OnClick()
    {
        return ItemIndex;
    }
}