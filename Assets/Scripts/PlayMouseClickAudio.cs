using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMouseClickAudio : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip mouseClickClip;
    public float volume = 1f;

    public void PlayMouseClick()
    {
        audiosource.PlayOneShot(mouseClickClip, volume);
    }
}
