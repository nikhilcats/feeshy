using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DirtClick : MonoBehaviour
{
    public Button farmButton;
    public Inventory inventory;
    public ItemDatabase itemDatabase;
    private void Start()
    {
        farmButton.onClick.AddListener(() => PlantFish(farmButton));
    }
    /*public void OnMouseDown()
    {
        Debug.Log("i clicke dit it!!!!");
        Vector2 mousePos = Input.mousePosition;
        Debug.Log(mousePos.x);
        Debug.Log(mousePos.y);

    }*/
    public void PlantFish(Button button)
    {
        Debug.Log("Initial count: " + inventory.invItems.Count);
        int invSize = inventory.invItems.Count;
        var pos = Input.mousePosition;
        Debug.Log(pos.x + "," + pos.y);
        if (invSize > 0)
        {
            int tempID = inventory.invItems[invSize - 1].id;
            Item tempItem = itemDatabase.GetItem(tempID);
            Plant p1 = new Plant(tempItem.icon, pos);
            inventory.RemoveItem(tempID);
        }
        Debug.Log("Planted fish");
    }
}
