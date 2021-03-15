using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> invItems = new List<Item>();
    public ItemDatabase itemDatabase;

    public Item CheckForItem(int id)
    {
        return invItems.Find(item => item.id == id);
    }

    public void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        Item item = CheckForItem(id);
        if (item == null)
        {
            invItems.Add(itemToAdd);
            Debug.Log("Amount: " + CheckForItem(id).amount);
        }
        else
        {
            item.amount += 1;
            Debug.Log("Amount: " + CheckForItem(id).amount);
        }
    }

    public void RemoveItem(int id)
    {
        Item item = CheckForItem(id);
        if (item != null)
        {
            if (item.amount == 1)
            {
                invItems.Remove(item);
                if (CheckForItem(id) == null)
                {
                    Debug.Log("success removing last object");
                }
            }
            else if (item.amount > 1)
            {
                item.amount -= 1;
                Debug.Log("Item amount after removing NOT last object: " + CheckForItem(id).amount);
            }
        }    
    }
    void Start()
    {

    }

    void Update()
    {
        
    }
}
