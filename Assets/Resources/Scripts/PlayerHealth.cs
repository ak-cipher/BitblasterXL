using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class PlayerHealth : MonoBehaviour
{
    public float invincibleTime;
    public GameObject[] shieldSprites;
    public GameObject shipSprite;
    bool isInvincible = false;
    public int shieldAmount;
    public Score score;
    public AudioSounds audioSounds;

    private void Awake()
    {
        Advertisement.Initialize("4696717");
    }

    public void TakeDamge()
    {
        if(!this.isInvincible)
        {
            this.shieldAmount--;
            if(this.shieldAmount < 0)
            {
                Debug.Log("Destroy ship");
                this.DestroyPlayer();
            }
            else
            {
                Debug.Log("Invincibility");
                StartCoroutine(InvinciblePlayer());
            }
        }
    }

    public void DestroyPlayer()
    {
        this.score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        if(score.currentScore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score.currentScore);
        }
        
        Destroy(this.gameObject);
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
        //Advertisement.Show();
        //Application.Quit();
    }

    public IEnumerator InvinciblePlayer()
    {
        this.isInvincible = true;
        float invisTime = this.invincibleTime / 8;

        for(int i =0;i<4;i++)
        {
            audioSounds.PlayBlinkSound();
            this.shipSprite.SetActive(false);
            yield return new WaitForSeconds(invisTime);
            this.shipSprite.SetActive(true);
            yield return new WaitForSeconds(invisTime);
        }
        this.isInvincible = false;
    }


    private void FixedUpdate()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i < this.shieldAmount)
            {
                shieldSprites[i].SetActive(true);
            }
            else
            {
                shieldSprites[i].SetActive(false);
            }
        }
    }

}
