using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int gold = 0;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        gold = data.gold;
    }
    void Start()
    {
        LoadPlayer();
    }

    private void OnDestroy()
    {
        SavePlayer();
    }
}
