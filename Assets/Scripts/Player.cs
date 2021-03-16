using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int gold = 0;
    public List<int> inventoryItemIds = new List<int>();
    public List<int> inventoryItemAmounts = new List<int>();
    public Inventory inventory;

    public void SavePlayer()
    {
        int index = 0;
        foreach (Item item in inventory.invItems)
        {

            inventoryItemIds.Add(inventory.invItems[index].id);
            inventoryItemAmounts.Add(inventory.invItems[index].amount);
            index++;
        }
        SaveSystem.SavePlayer(this);
        Debug.Log("RAN SAVE");
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        this.gold = data.gold;
        this.inventoryItemIds = data.inventoryItemIds;
        this.inventoryItemAmounts = data.inventoryItemAmounts;
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
