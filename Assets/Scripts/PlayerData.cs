using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int gold;
    public List<int> inventoryItemIds;
    public List<int> inventoryItemAmounts;

    public PlayerData (Player player)
    {
        inventoryItemIds = player.inventoryItemIds;
        inventoryItemAmounts = player.inventoryItemAmounts;
        gold = player.gold;
    }
}
