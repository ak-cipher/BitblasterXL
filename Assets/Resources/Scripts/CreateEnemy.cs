using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
   public  EnemyMovementController movementController;
   Enemies enemies;


    public static CreateEnemy GetNewPrimitiveEnemy()
    {
        GameObject enemy = (GameObject)Instantiate(Resources.Load("Prefabs/EnemyPrimitive"));
        return enemy.GetComponent<CreateEnemy>();
    }

    public static CreateEnemy GetEnemySpliter()
    {
        GameObject enemy = (GameObject)Instantiate(Resources.Load("Prefabs/EnemySpliter"));
        return enemy.GetComponent<CreateEnemy>();
    }

    public static CreateEnemy GetEnemyShooting()
    {
        GameObject enemy = (GameObject)Instantiate(Resources.Load("Prefabs/EnemyShooter"));
        return enemy.GetComponent<CreateEnemy>();
    }

   

}
