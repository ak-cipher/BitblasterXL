using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCollisionController : MonoBehaviour
{

    public AudioSounds audioSounds;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            audioSounds.PlayLaserSound();
            EnemyDestroyController edc = collision.gameObject.GetComponent<EnemyDestroyController>();
            edc.DestroyByPlayer();
        }
    }
}
