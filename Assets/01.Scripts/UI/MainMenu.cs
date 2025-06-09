using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private Player player;
    
    [SerializeField] private TextMeshProUGUI playerClass;
    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private TextMeshProUGUI playerLevel;
    [SerializeField] private TextMeshProUGUI playerInfo;
    [SerializeField] private TextMeshProUGUI playerExp;
    [SerializeField] private TextMeshProUGUI playerGold;
    [SerializeField] private Image playerExpImage;
    
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    private void Start()
    {
        player = GameManager.Instance.player;
    }

    private void Update()
    {
        UpdatePlayerStatus();
        UpdatePlayerExp();
        UpdatePlayerGold();
    }

    private void UpdatePlayerStatus()
    {
        playerClass.text = player.PlayerClass.ToString();
        playerName.text = player.Name;
        playerLevel.text = player.Level.ToString();
    }

    private void UpdatePlayerExp()
    {
        playerExp.text = player.Exp.ToString() + " / 10";
        playerExpImage.fillAmount = player.Exp / 10f;
    }

    private void UpdatePlayerGold()
    {
        playerGold.text = player.Gold.ToString();
    }

    public void OpenMainMenu()
    {
        this.gameObject.SetActive(true);
    }

    public void CloseMainMenu()
    {
        this.gameObject.SetActive(false);
    }
}
