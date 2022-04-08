using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukeEnemies : MonoBehaviour
{
    public int amountbombs;

    public GameObject enemiesGameObject;
    public GameObject bulletGameObject;
    public GameObject[] bombSprites;

    public AudioSounds audioSounds;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Bombing");
            this.IgniteNuke();
        }
    }

    public void IgniteNuke()
    {
        if(this.amountbombs > 0)
        {
            audioSounds.PlayBombSound();
            foreach (Transform enemy in this.enemiesGameObject.transform)
            {
                EnemyDestroyController enemyDestroyController = enemy.GetComponent<EnemyDestroyController>();
                enemyDestroyController.DestroyByPlayer();
            }

            foreach(Transform enemyBullets in this.bulletGameObject.transform)
            {
                Destroy(enemyBullets.gameObject);
            }
            this.amountbombs--;
        }
    }

    private void FixedUpdate()
    {
        for(int i =0; i<5;i++)
        {
            if(i<this.amountbombs)
            {
                bombSprites[i].SetActive(true);
            }
            else
            {
                bombSprites[i].SetActive(false);
            }
        }
    }
}
