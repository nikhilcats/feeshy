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
        items = new List<Item>()
        {
            new Item(0, "Bait", "Bait to catch fish with", 1, 1),
            new Item(1, "Blue Fish", "A common blue fish", 1, 2),
            new Item(2, "Green Fish", "At least it's not a blue fish", 1, 3),
            new Item(3, "Orange Fish", "An orange fish? That's pretty pog", 1, 4),
            new Item(4, "Rainbow Fish", "LEGENDARY JUICER RAINBOW FISH PogU", 1, 5)
        };
    }
}
