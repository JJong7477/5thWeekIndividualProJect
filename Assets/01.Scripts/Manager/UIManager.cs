using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [field:SerializeField] public MainMenu MainMenu { get; private set; }
    [field:SerializeField] public Status Status { get; private set; }
    [field:SerializeField] public Inventory Inventory { get; private set; }
    
    private static UIManager _uiManager;

    public static UIManager Instance
    {
        get
        {
            if (_uiManager == null)
            {
                return null;
            }
            return _uiManager;
        }
    }
    
    private void Awake()
    {
        if (_uiManager == null)
        {
            _uiManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }
}
