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
        this.inventoryItemIds.Clear();
        this.inventoryItemAmounts.Clear();
        int index = 0;
        foreach (Item item in inventory.invItems)
        {
            inventoryItemIds.Add(inventory.invItems[index].id);
            inventoryItemAmounts.Add(inventory.invItems[index].amount);
            index++;
        }
        SaveSystem.SavePlayer(this);
        Debug.Log("RAN SAVE");
        this.inventoryItemIds.Clear();
        this.inventoryItemAmounts.Clear();
    }
    public void LoadPlayer()
    {
        this.inventoryItemIds.Clear();
        this.inventoryItemAmounts.Clear();
        PlayerData data = SaveSystem.LoadPlayer();
        this.gold = data.gold;
        this.inventoryItemIds = data.inventoryItemIds;
        this.inventoryItemAmounts = data.inventoryItemAmounts;
        inventory.invItems.Clear();
        foreach(int i in inventoryItemIds)
        {
            for(int z = 0; z < inventoryItemAmounts[i]; z++)
            {
                inventory.GiveItem(i);
            }
            
        }
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
