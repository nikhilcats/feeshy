using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string name;
    public string description;
    public Sprite icon;
    public int amount;
    public int price;
    
    public Item(int id, string name, string description, int amount, int price)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.icon = Resources.Load<Sprite>(name);
        this.amount = amount;
        this.price = price;
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.name = item.name;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>(item.name);
        this.amount = item.amount;
        this.price = item.price;
    }
}