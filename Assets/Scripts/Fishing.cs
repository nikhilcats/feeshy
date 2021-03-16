using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishing
{
    public List<Item> CatchableObjects = new List<Item>();
    public Item orangeFish;
    public Item greenFish;
    public Item blueFish;
    public Item rainbowFish;
    public Inventory inventory;

    public Item CastLine(ItemDatabase itemDatabase, Inventory inventory)
    {
        this.inventory = inventory;
        ItemDatabase db = itemDatabase;
        System.Random random = new System.Random();
        Debug.Log("line has been cast");

        //setting fish to equivalent db spots
        blueFish = db.GetItem(1);
        greenFish = db.GetItem(2);
        orangeFish = db.GetItem(3);
        rainbowFish = db.GetItem(4);

        //Populates list with weighted catchable objects, currently out of 100, first for loop populates 80 of most common fish
        for (int i = 0; i < 40; i++)
        {
            CatchableObjects.Add(greenFish);
            CatchableObjects.Add(blueFish);
        }
        for (int i = 0; i < 15; i++)
        {
            CatchableObjects.Add(orangeFish);
        }
        for (int i = 0; i < 5; i++)
        {
            CatchableObjects.Add(rainbowFish);
        }
        Debug.Log(CatchableObjects.Count);
        int index = random.Next(CatchableObjects.Count);
        Debug.Log(CatchableObjects[index]);

        Item objectCaught = CatchableObjects[index];

        inventory.GiveItem(1);
        inventory.GiveItem(0);
        inventory.GiveItem(0);
        inventory.GiveItem(0);
        inventory.GiveItem(3);

        //depopulates list so that it doesn't overflow very important :)
        CatchableObjects.Clear();
        return objectCaught;
    }
}
