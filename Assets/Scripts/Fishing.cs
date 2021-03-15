using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishing
{
    public List<Item> CatchableObjects = new List<Item>();
    public Item OrangeFish;
    public Item GreenFish;
    public Item BlueFish;
    public Item RainbowFish;

    public Item CastLine()
    {
        System.Random random = new System.Random();
        Debug.Log("line has been cast");
        CatchableObjects.Add(GreenFish);
        CatchableObjects.Add(GreenFish);
        CatchableObjects.Add(GreenFish);
        CatchableObjects.Add(GreenFish);
        CatchableObjects.Add(GreenFish);
        CatchableObjects.Add(GreenFish);
        CatchableObjects.Add(GreenFish);
        CatchableObjects.Add(GreenFish);
        CatchableObjects.Add(BlueFish);
        CatchableObjects.Add(BlueFish);
        CatchableObjects.Add(BlueFish);
        CatchableObjects.Add(BlueFish);
        CatchableObjects.Add(BlueFish);
        CatchableObjects.Add(BlueFish);
        CatchableObjects.Add(BlueFish);
        CatchableObjects.Add(BlueFish);
        CatchableObjects.Add(OrangeFish);
        CatchableObjects.Add(OrangeFish);
        CatchableObjects.Add(RainbowFish);
        int index = random.Next(CatchableObjects.Count);
        Debug.Log(CatchableObjects[index]);
        Item objectCaught = CatchableObjects[index];
        return objectCaught;
    }
}
