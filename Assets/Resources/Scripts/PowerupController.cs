using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupController : MonoBehaviour
{
    public float powerupDuration;
    public bool powerupActive = true;
    public MultiShoot multiShoot;

    public GameObject laser;
    public GameObject beserk;

    string powerupType ;
    float activeUntillTime = 0f;


    private void Start()
    {
        //ActivateLaser();
    }
    private void FixedUpdate()
    {
        if(this.powerupActive && Time.time < this.activeUntillTime)
        {
            if(this.powerupType == "MultiShoot")
            {
                multiShoot.MultiBulletShoot();
            }
            else if (this.powerupType == "Laser")
            {
                this.laser.SetActive(true);
            }
            else if (this.powerupType == "Beserk")
            {
                this.beserk.SetActive(true);
            }
        }
        else
        {
            this.powerupType = null;
            this.powerupActive = false;
        }

        if(this.powerupType!= "Laser")
        {
            this.laser.SetActive(false);
        }
        if (this.powerupType != "Beserk")
        {
            this.beserk.SetActive(false);
        }
    }

    public void ActivateMultiShoot()
    {
        this.powerupActive = true;
        this.powerupType = "MultiShoot";
        this.activeUntillTime = Time.time + this.powerupDuration;
    }

    public void ActivateLaser()
    {
        this.powerupActive = true;
        this.powerupType = "Laser";
        this.activeUntillTime = Time.time + this.powerupDuration;
    }

    public void ActivateBeserkMode()
    {
        this.powerupActive = true;
        this.powerupType = "Beserk";
        this.activeUntillTime = Time.time + this.powerupDuration;
    }
}
