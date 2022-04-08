using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public GameObject poerUpLaser;
    public GameObject poerUpBeserk;
    public GameObject poerUpMultiShoot;

    public GameObject resourceAmmo;
    public GameObject resourceShield;
    public GameObject resourceNuke;

    float powerUpSpawnChance = 0.1f;


    public void spawnRandomCollectables(Transform pos)
    {
        float v = Random.value;
        if(v <= this.powerUpSpawnChance)
        {
            this.spawnRandomPowerUp(pos);
        }
        else
        {
            this.spawnRandomResource(pos);
        }
    }

    public void spawnRandomResource(Transform pos)
    {
        float v = Random.value;

        Collectable newCollectable;

        if(v>0.1f)
        {
            newCollectable = Collectable.CreateAmmo();
        }
        else if(v >= 0.05f)
        {
            newCollectable = Collectable.CreateNukes();
        }
        else
        {
            newCollectable = Collectable.CreateShield();
        }

        newCollectable.gameObject.transform.position = pos.position;
    }

    public void spawnRandomPowerUp(Transform pos)
    {
        float v = Random.value;

        Collectable newCollectable;

        if (v > 0.7f)
        {
            newCollectable = Collectable.CreateMultiShoot();
        }
        else if (v >= 0.3f)
        {
            newCollectable = Collectable.CreateBeserk();
        }
        else
        {
            newCollectable = Collectable.CreateLaser();
        }
        newCollectable.gameObject.transform.position = pos.position;
    }



}
