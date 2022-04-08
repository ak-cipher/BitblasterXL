using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource audioSource;


    private void Start()
    {
        if (PlayerPrefs.HasKey("SoundActive"))
        {
            if (PlayerPrefs.GetInt("SoundActive") == 0)
            {
                Debug.Log("sound unactive");
                audioSource.volume = 0f;
            }
            else
            {
                Debug.Log("sOUND Active");
                audioSource.volume = 1f;
            }

        }
    }
}
