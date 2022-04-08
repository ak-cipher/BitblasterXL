using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColliisonController : MonoBehaviour
{
    Enemies enemies;
    

    private void Awake()
    {
        GameObject gob = GameObject.FindGameObjectWithTag("EnemySapwnGameObject");
        this.enemies = gob.GetComponent<Enemies>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "OutterBorders")
        {
            Debug.Log("Enemies dead by outter wall");
            enemies.currentEnemyAmount--;
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Bullet")
        {
            EnemyDestroyController enemyDestroyController = this.GetComponent<EnemyDestroyController>();
            enemyDestroyController.DestroyByPlayer();
            Destroy(collision.gameObject);

        }
      
        //else if (collision.gameObject.tag == "Laser")
        //{
        //    EnemyDestroyController edc = this.GetComponent<EnemyDestroyController>();
        //    edc.DestroyByPlayer();
        //}

    }
    
}

