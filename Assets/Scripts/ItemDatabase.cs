using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items;
    private void Awake()
    {
        items = new List<Item>();
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }
    
    public Item GetItem(string itemName)
    {
        return items.Find(item => item.name == itemName);
    }

    void BuildDatabase()
    {
        items = new List<Item>();
    }
}
