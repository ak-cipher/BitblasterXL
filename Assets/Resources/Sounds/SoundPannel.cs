using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundPannel : MonoBehaviour
{
    public GameObject soundPannel;
    private bool isPannnelActive = false ;
    public Sprite buttonImage1;
    public Sprite buttonImage2;
    public Button button;


    private void Awake()
    {
        if(PlayerPrefs.HasKey("SoundActive"))
        {
            if(PlayerPrefs.GetInt("SoundActive") == 1)
            {
                button.image.sprite = buttonImage1;
            }
            else
            {
                button.image.sprite = buttonImage2;
            }
            
        }
        else
        {
            PlayerPrefs.SetInt("SoundActive", 1);
            button.image.sprite = buttonImage1;
        }
        soundPannel.SetActive(false);
        isPannnelActive = false;
    }

    private void Update()
    {

        if (isPannnelActive)
        {
            soundPannel.SetActive(true);
        }
        else
            soundPannel.SetActive(false);
    }

    public void SoundPannelControl()
    {
        isPannnelActive = !isPannnelActive;
    }

    public void Sound()
    {
        if (PlayerPrefs.GetInt("SoundActive") == 0)
        {
            Debug.Log("Set sound 1");
            int muteSound = 1;
            PlayerPrefs.SetInt("SoundActive", muteSound);
            button.image.sprite = buttonImage1;
        }
        else
        {
            Debug.Log("Set sound 0");
            int highSound = 0;
            PlayerPrefs.SetInt("SoundActive", highSound);
            button.image.sprite = buttonImage2;
        }
            
    }
}
