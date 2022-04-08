using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeserkCollisionController : MonoBehaviour
{
    
    public AudioSounds audioSounds;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            audioSounds.PlayBeserkSound();
            EnemyDestroyController edc = collision.gameObject.GetComponent<EnemyDestroyController>();
            edc.DestroyByPlayer();
        }
    }
}
