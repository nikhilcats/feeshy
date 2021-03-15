using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string name;
    public string description;
    public Sprite icon;
    
    public Item(int id, string name, string description)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Sprites/Items" + name);
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.name = item.name;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>("Sprites/Items" + item.name);
    }
}