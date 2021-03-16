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

        foreach (Item item in inventory.invItems)
        {
            inventoryItemIds.Add(item.id);
            inventoryItemAmounts.Add(item.amount);
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

        for (int i = 0; i < inventoryItemIds.Count; i++)
        {
            for (int z = 0; z < inventoryItemAmounts[i]; z++)
            {
                inventory.GiveItem(inventoryItemIds[i]);
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
