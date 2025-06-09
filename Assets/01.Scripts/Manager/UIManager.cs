using System;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    private static UiManager _uiManager;

    public static UiManager UIManager
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
    
    [SerializeField] public MainMenu mainMenu;
    [SerializeField] public Status status;
    [SerializeField] public Inventory inventory;

    private void Awake()
    {
        if (_uiManager == null)
        {
            _uiManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
}
