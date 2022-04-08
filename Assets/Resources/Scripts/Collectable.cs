using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public float blinkDuration;
    public string collectableType;
    float killTime;

    SpriteRenderer collectableSprite;
    bool isBlinking = false;


    private void Start()
    {
        this.killTime = Time.time + this.blinkDuration;
        this.collectableSprite = this.gameObject.GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if(Time.time < this.killTime && (!this.isBlinking))
        {
            StartCoroutine(Blink());
        }
        if(Time.time > this.killTime)
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator Blink()
    {
        for(int i = 0;i<4;i++)
        {
            //this.collectableSprite.enabled = false;
            //yield return new WaitForSeconds(0.25f);
            this.collectableSprite.enabled = true;
            yield return new WaitForSeconds(0.25f);
        }
    }

    public static Collectable CreateAmmo()
    {
        GameObject ammo = (GameObject)Instantiate(Resources.Load("Prefabs/Ammo"));
        return ammo.GetComponent<Collectable>();
    }

    public static Collectable CreateMultiShoot()
    {
        GameObject mutiShoot = (GameObject)Instantiate(Resources.Load("Prefabs/MultiShoot"));
        return mutiShoot.GetComponent<Collectable>();
    }

    public static Collectable CreateBeserk()
    {
        GameObject beserk = (GameObject)Instantiate(Resources.Load("Prefabs/Beserk"));
        return beserk.GetComponent<Collectable>();
    }

    public static Collectable CreateShield()
    {
        GameObject shield = (GameObject)Instantiate(Resources.Load("Prefabs/Shield"));
        return shield.GetComponent<Collectable>();
    }

    public static Collectable CreateLaser()
    {
        GameObject laser = (GameObject)Instantiate(Resources.Load("Prefabs/Laser"));
        return laser.GetComponent<Collectable>();
    }

    public static Collectable CreateNukes()
    {
        GameObject nuke = (GameObject)Instantiate(Resources.Load("Prefabs/Nuke"));
        return nuke.GetComponent<Collectable>();
    }
}
