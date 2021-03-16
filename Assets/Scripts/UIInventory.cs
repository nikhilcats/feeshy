using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIInventory : MonoBehaviour
{
    public List<UIItem> uiItems = new List<UIItem>();
    public List<UIItemText> uiTexts = new List<UIItemText>();
    public GameObject slotPrefab;
    public Transform slotPanel;
    public int numberOfSlots = 8;
    public TMP_Text txt;


    private void Awake()
    {
        Debug.Log("IM AWAKE :D");
        for (int i = 0; i < numberOfSlots; i++)
        {
            GameObject instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
            uiItems.Add(instance.GetComponentInChildren<UIItem>());

            uiTexts.Add(instance.GetComponentInChildren<UIItemText>());

        }
    }

    public void Start()
    {
        
    }

   /* public void OrganizeSlots()
    {
        List<UIItem> uiItemsTemp = new List<UIItem>();
        List<UIItemText> uiTextsTemp = new List<UIItemText>();
        for (int i = 0; i < numberOfSlots; i++)
        {
            if (this.uiItems[i].item != null)
            {
                uiItemsTemp.Add(this.uiItems[i]);
                uiTextsTemp.Add(this.uiTexts[i]);
            }
        }

        int toAdd = uiItemsTemp.Count;
        Debug.Log("toAdd: " + toAdd);
        List<UIItem> refItemsTemp = new 
        List<UIItemText> refTextsTemp = this.refTexts;
        foreach (var x in refItemsTemp)
        {
            Debug.Log("Existsv1? : " + (x.item != null));
            if (x.item != null)
            {
                Debug.Log("item amount: " + x.item.amount);
            }
        }
        for (int j = 0; j < toAdd; j++)
        {
            refItemsTemp[j] = uiItemsTemp[j];
            refTextsTemp[j] = uiTextsTemp[j];
        }
        foreach (var x in refItemsTemp)
        {
            Debug.Log("Exists? : " + (x.item != null));
            if (x.item != null)
            {
                Debug.Log(x.item.amount);
            }
        }
        this.uiItems = refItemsTemp;
        this.uiTexts = refTextsTemp;

    }*/

    public void UpdateSlot(int slot, Item item)
    {
        uiItems[slot].UpdateItem(item);
        uiTexts[slot].UpdateText(item);
    }

    public void RefreshSlot(Item item)
    {
        //uiItems[uiItems.FindIndex(i => i.item.id == item.id)].UpdateItem(item);
        uiTexts[uiItems.FindIndex(i => i.item.id == item.id)].UpdateText(item);
        //OrganizeSlots();
    }

    public void AddNewItem(Item item)
    {
        UpdateSlot(uiItems.FindIndex(i => i.item == null), item);
    }
    
    public void RemoveItem(Item item)
    {
        UpdateSlot(uiItems.FindIndex(i => i.item.id == item.id), null);
        //OrganizeSlots();
    }
}