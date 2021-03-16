using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopClick : MonoBehaviour
{
    public GameObject panel;
    public void OnMouseDown()
    {
        Debug.Log("Shop Opened");
        panel.SetActive(true);
        gameObject.SetActive(false);
    }
}
