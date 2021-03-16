using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtClick : MonoBehaviour
{
    public Inventory inventory;
    public GameObject bluePrefab;
    public GameObject greenPrefab;
    public GameObject orangePrefab;
    public GameObject rainbowPrefab;
    public RectTransform rectTransform;
    public PlantAudio plantclip;
    Ray2D ray;
    RaycastHit2D hit;
    Camera cam2;
    private void Start()
    {
        cam2 = GameObject.Find("cam2").GetComponent<Camera>();
        rectTransform = GetComponent<RectTransform>();
    }
    private void OnMouseDown()
    {
        RaycastHit2D hit = Physics2D.GetRayIntersection(cam2.ScreenPointToRay(Input.mousePosition));
        Debug.Log("works");
        int size = inventory.invItems.Count;
        if (size > 0)
        {
            switch (inventory.invItems[size - 1].id)
            {
                case 1:
                    GameObject.Instantiate(bluePrefab, hit.point, Quaternion.identity);
                    plantclip.plantAudio();
                    break;
                case 2:
                    GameObject.Instantiate(greenPrefab, hit.point, Quaternion.identity);
                    plantclip.plantAudio();
                    break;
                case 3:
                    GameObject.Instantiate(orangePrefab, hit.point, Quaternion.identity);
                    plantclip.plantAudio();
                    break;
                case 4:
                    GameObject.Instantiate(rainbowPrefab, hit.point, Quaternion.identity);
                    plantclip.plantAudio();
                    break;
                default:
                    Debug.Log("Didnt work");
                    break;
            }
            inventory.RemoveItem(inventory.invItems[size - 1].id);
        }
    }

    /*public RaycastHit2D RayFromCamera(Vector2 mousePosition, float rayLength)
    {
        RaycastHit2D hit;
        Ray2D ray = cam2.ScreenPointToRay(mousePosition);
        Physics2D.Raycast(ray, );
        return hit;

    }*/
}
