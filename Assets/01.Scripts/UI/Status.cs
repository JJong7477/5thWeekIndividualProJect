using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Status : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerAttack;
    [SerializeField] private TextMeshProUGUI playerArmor;
    [SerializeField] private TextMeshProUGUI playerHealth;
    [SerializeField] private TextMeshProUGUI playerCritical;

    private Player player;
    
    private void Start()
    {
        player = GameManager.Instance.player;
    }

    private void Reset()
    {
        playerAttack = Utility.FindChildComponent<TextMeshProUGUI>(transform, "PlayerAttack");
        playerArmor = Utility.FindChildComponent<TextMeshProUGUI>(transform, "PlayerArmor");
        playerHealth = Utility.FindChildComponent<TextMeshProUGUI>(transform, "PlayerHealth");
        playerCritical = Utility.FindChildComponent<TextMeshProUGUI>(transform, "PlayerCritical");
    }

    private void Update()
    {
        SetStatus();
    }

    private void SetStatus()
    {
        playerAttack.text = ($"{player.Attack} (+{player.AddedAttack})");
        playerArmor.text = ($"{player.Armor} (+{player.AddedArmor})");
        playerHealth.text = ($"{player.Health} (+{player.AddedHealth})");
        playerCritical.text = ($"{player.CriticalChance} (+{player.AddedCriticalChance})");
    }
    
    public void OpenStatus()
    {
        this.gameObject.SetActive(true);
    }

    public void CloseStatus()
    {
        this.gameObject.SetActive(false);
    }
}
