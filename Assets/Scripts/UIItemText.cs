using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIItemText : MonoBehaviour
{
    public Item item;
    private TMP_Text txt;

    private void Awake()
    {
        txt = GetComponent<TMP_Text>();
    }

    public void UpdateText(Item item)
    {
        this.item = item;
        if (this.item != null)
        {
            txt.text = item.amount.ToString();
        }
        else
        {
            txt.text = " ";
        }
    }
}
