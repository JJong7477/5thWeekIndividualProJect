using UnityEngine;

[CreateAssetMenu(menuName = "New SO/Player", fileName = "PlayerSO")]
public class PlayerSO : ScriptableObject
{
    [Header("PlayerBaseStatus")]
    [SerializeField] private float baseAttack;
    [SerializeField] private float baseArmor;
    [SerializeField] private float baseHealth;
    [SerializeField] private float baseCriticalChance;

    public float BaseAttack => baseAttack;
    public float BaseArmor => baseArmor;
    public float BaseHealth => baseHealth;
    public float BaseCriticalChance => baseCriticalChance;
}