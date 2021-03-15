using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int gold = 0;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
        Debug.Log("RAN SAVE");
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        gold = data.gold;
        Debug.Log("RAN LOAD");
    }
    void Start()
    {
        LoadPlayer();
    }

    void OnDestroy()
    {
        SavePlayer();
    }
}
