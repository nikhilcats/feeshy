using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    private GameObject border;
    public Button exitButton;

    // Camera cam1, cam2, cam3;
    private void OnEnable()
    {
        border = GameObject.Find("ShopBorder");
        exitButton.onClick.AddListener(() => ExitShop(exitButton));
    }
    private void ExitShop(Button button)
    {
        gameObject.SetActive(false);
        border.SetActive(true);
        Debug.Log("Exit Shop");
    }
}
