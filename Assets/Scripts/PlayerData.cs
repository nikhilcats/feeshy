using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int gold;

    public PlayerData (Player player)
    {
        gold = player.gold;
    }
}
