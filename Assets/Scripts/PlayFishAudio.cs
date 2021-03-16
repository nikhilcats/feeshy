using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFishAudio : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip fishLineClip;
    public AudioClip caughtClip;
    public float volume = 1f;

    public void playFishLine()
    {
        audiosource.PlayOneShot(fishLineClip, volume);
    }

    public void playCaught()
    {
        audiosource.PlayOneShot(caughtClip, volume);
    }
}
