using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{
    public byte opacity = 100;
    public GameObject canvas;
    public Button prefabPlant;
    public Transform buttonPanel;
    private Sprite icon;
    private Image spriteImage;
    private Vector2 pos;

    public Plant(Sprite icon, Vector2 pos)
    {
        this.icon = icon;
        this.pos = pos;
    }

    private void Awake()
    {
        spriteImage = GetComponent<Image>();
        spriteImage.color = new Color32(255, 255, 255, opacity);
        spriteImage.sprite = this.icon;
        Button plantObject = Instantiate(prefabPlant);
        plantObject.transform.SetParent(buttonPanel);
    }

}
