using System;using UnityEngine;

public enum PlayerClass
{
    Warrior,
    Archer,
    Mage,
}

public class Player : MonoBehaviour
{
    public PlayerSO playerSo;
    
    public string Name { get; private set; } = "new Player";

    public int Level { get; private set; } = 1;
    public int Exp { get; private set; } = 2;
    public int Gold { get; private set; } = 190000;
    
    public float AddedAttack { get; private set; }
    public float Attack => AddedAttack + playerSo.BaseAttack;
    public float AddedArmor { get; private set; }
    public float Armor => AddedArmor + playerSo.BaseArmor;
    public float AddedHealth { get; private set; }
    public float Health => AddedHealth + playerSo.BaseHealth;
    public float AddedCriticalChance { get; private set; }
    public float CriticalChance => AddedCriticalChance + playerSo.BaseCriticalChance;
    
    public PlayerClass PlayerClass { get; private set; } = PlayerClass.Warrior;
    
    
    public void SetAttack(float value)
    {
        AddedAttack += value;
    }

    public void SetArmor(float value)
    {
        AddedArmor += value;
    }

    public void SetHealth(float value)
    {
        AddedHealth += value;
    }

    public void SetCriticalChance(float value)
    {
        AddedCriticalChance += value;
    }
}