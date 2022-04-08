using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyController : MonoBehaviour
{
    public int pointOnDestruction;

    public bool isSpiliter = false;

    Collectables collectables;

    public Score score;
    Enemies enemies;

    private void Awake()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        GameObject gob = GameObject.FindGameObjectWithTag("EnemySapwnGameObject");
        this.enemies = gob.GetComponent<Enemies>();
        this.collectables = GameObject.FindGameObjectWithTag("Collectables").GetComponent<Collectables>();
    }

  public void DestroyByPlayer()
    {
        Debug.Log("Enemy Destroyed");

        this.collectables.spawnRandomCollectables(this.transform);

        enemies.currentEnemyAmount--;
        score.RaiseScore(this.pointOnDestruction);
        Destroy(this.gameObject);
    }
}
