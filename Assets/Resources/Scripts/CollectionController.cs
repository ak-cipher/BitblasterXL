using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionController : MonoBehaviour
{ 
    public PlayerHealth playerHealth;
    public NukeEnemies nukeEnemies;
    public ShootingController shootingController;
    public PowerupController powerupController;

    

    private void Start()
    {
        //this.playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        //this.nukeEnemies = GameObject.FindGameObjectWithTag("Player").GetComponent<NukeEnemies>();
        //this.shootingController = GameObject.FindGameObjectWithTag("Player").GetComponent<ShootingController>();
        //this.powerupController = GameObject.FindGameObjectWithTag("Player").GetComponent<PowerupController>();
    }

    public void Collect(GameObject collectable)
    {

        Collectable collectableScript = collectable.GetComponent<Collectable>();
        string collectableType = collectableScript.collectableType;

        if (collectableType == "Ammo")
        {
            shootingController.ammoAmount += 10;
            
        }
        else if (collectableType == "Laser")
        {
            powerupController.ActivateLaser();
           
        }
        else if (collectableType == "Beserk")
        {
            powerupController.ActivateBeserkMode();
           
        }
        else if (collectableType == "Shield")
        {
            if (playerHealth.shieldAmount < 5)
            {
                playerHealth.shieldAmount++;
               
            }
        }
        else if (collectableType == "Nuke")
        {
            if (nukeEnemies.amountbombs < 5)
            {
                nukeEnemies.amountbombs++;
              
            }
        }
        else if (collectableType == "MultiShoot")
        {
            powerupController.ActivateMultiShoot();
          
        }
        Destroy(collectable);
    }

    
}
