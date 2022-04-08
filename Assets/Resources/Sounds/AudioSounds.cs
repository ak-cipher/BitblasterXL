using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSounds : MonoBehaviour
{
    public AudioClip[] audioClip;
    public AudioSource audioSource;
  

    public void PlayShootingSound()
    {
        audioSource.PlayOneShot(audioClip[0]);
    }

    public void PlayLaserSound()
    {
        audioSource.PlayOneShot(audioClip[1]);
    }

    public void PlayBeserkSound()
    {
        audioSource.PlayOneShot(audioClip[2]);
    }

    public void PlayBlinkSound()
    {
        audioSource.PlayOneShot(audioClip[3]);
    }

    public void PlayBombSound()
    {
        audioSource.PlayOneShot(audioClip[4]);
    }
}
