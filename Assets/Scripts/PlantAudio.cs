using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantAudio : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip plantaudioclip;
    public float volume = 1f;

    public void plantAudio()
    {
        audiosource.PlayOneShot(plantaudioclip, volume);
    }

}
