using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraShift : MonoBehaviour
{
    public Camera cam1, cam2, cam3;
    public Button button1, button2;
    public GameObject farmSystem;
    private int sceneNum = 1;
    private GameObject shopBorder;

 
    // Start is called before the first frame update
    void Start()
    {
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        farmSystem.gameObject.SetActive(false);
        button1.onClick.AddListener(LeftOnClick);
        button2.onClick.AddListener(RightOnClick);
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown("c"))
        {
            cam1.gameObject.SetActive(true);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(false);
            farmSystem.gameObject.SetActive(false);
            sceneNum = 1;
        }
        if (Input.GetKeyDown("v"))
        {
            cam1.gameObject.SetActive(false);
           cam2.gameObject.SetActive(true);
            cam3.gameObject.SetActive(false);
            farmSystem.gameObject.SetActive(true);
            sceneNum = 2;

        }
        if (Input.GetKeyDown("b"))
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(true);
            farmSystem.gameObject.SetActive(false);
            sceneNum = 3;
        }
    }

    void LeftOnClick()
    {
        if (sceneNum == 2)
        {
            cam1.gameObject.SetActive(true);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(false);
            farmSystem.gameObject.SetActive(false);
            sceneNum = 1;
        }
        else if (sceneNum == 3)
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(true);
            cam3.gameObject.SetActive(false);
            farmSystem.gameObject.SetActive(true);
            sceneNum = 2;
        }
    }
    
    void RightOnClick()
    {
        if (sceneNum == 1)
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(true);
            cam3.gameObject.SetActive(false);
            farmSystem.gameObject.SetActive(true);
            sceneNum = 2;
        }
        else if (sceneNum == 2)
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(true);
            farmSystem.gameObject.SetActive(false);
            sceneNum = 3;
        }
    }
}
