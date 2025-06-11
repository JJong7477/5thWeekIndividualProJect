using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortionItem : ConsumableItem
{
    public PortionItem(PotionItemData data, int amount = 1) : base(data, amount) { }

    public void Use()
    {
        Amount--;
    }
}