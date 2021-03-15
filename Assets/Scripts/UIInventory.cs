using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public List<UIItem> uiItems = new List<UIItem>();
    public GameObject slotPrefab;
    public GameObject slotPanel;
    public int numberOfSlots = 8;

    private void Awake()
    {
        for (int i = 0; i < numberOfSlots; i++)
        {
            //uiItems.Add()
        }
    }
}
