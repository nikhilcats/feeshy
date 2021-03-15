using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingAction : MonoBehaviour
{
    Fishing fishing = new Fishing();
    private void OnMouseDown()
    {
        Debug.Log("Ive been clicked UWU");
        fishing.CastLine();
    }
    
}
