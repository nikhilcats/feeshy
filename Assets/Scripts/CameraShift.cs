using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShift : MonoBehaviour
{
    public Camera cam1, cam2, cam3;

 
    // Start is called before the first frame update
    void Start()
    {
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);
        cam3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown("c"))
        {
            cam1.gameObject.SetActive(true);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown("v"))
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(true);
            cam3.gameObject.SetActive(false);
            
        }
        if (Input.GetKeyDown("b"))
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(true);
        }
    }
}
