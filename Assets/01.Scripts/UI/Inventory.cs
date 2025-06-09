using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerInventory;
    
    public void OpenInventory()
    {
        this.gameObject.SetActive(true);
    }

    public void CloseInventory()
    {
        this.gameObject.SetActive(false);
    }
}
