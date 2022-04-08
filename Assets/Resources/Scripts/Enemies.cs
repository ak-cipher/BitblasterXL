using UnityEngine;

public class Enemies : MonoBehaviour
{
    public GameObject[] spawnAreas;
    public int maxEnemyAmount;
    public int currentEnemyAmount = 0;
    public int totalEnemyAmount = 0;
    public int extraEnemiesPerTotalEnemy;

    int maxEnemies;


    private void Update()
    {
        maxEnemies = totalEnemyAmount / 2;
        
        this.SpawnNewEnemy();
    }
    public void SpawnNewEnemy()
    {
        if (currentEnemyAmount < maxEnemies)
        {
            float v = Random.value;
            if(v >0.5f)
            {
                CreateEnemy enemy;
                enemy = CreateEnemy.GetNewPrimitiveEnemy();
                this.SetupNewEnemy(enemy);

                this.currentEnemyAmount++;
            }
            else if (v >= 0.2f)
            {
                CreateEnemy enemy;
                enemy = CreateEnemy.GetEnemyShooting();
                this.SetupNewEnemy(enemy);

                this.currentEnemyAmount++;
            }
            else
            {
                CreateEnemy enemy;
                enemy = CreateEnemy.GetEnemySpliter();
                this.SetupNewEnemy(enemy);
                this.currentEnemyAmount++;
            }

        }



    }
    public void SetupNewEnemy(CreateEnemy enemy, GameObject spawnArea = null)
    {
        if (spawnArea == null)
        {
            int i = Random.Range(0, spawnAreas.Length);
            spawnArea = this.spawnAreas[i];
        }

        Vector3 spawnPosition = GetSpawnPosition(spawnArea);


        enemy.transform.position = spawnPosition;
        enemy.transform.parent = this.transform;

        //EnemyMovementController enemyMovementController = enemy.movementController;

        if (spawnArea.name == "Left")
        {
            enemy.movementController.movementDirection = Vector3.right;
        }
        else if (spawnArea.name == "Right")
        {
            enemy.movementController.movementDirection = Vector3.left;
        }
        else if (spawnArea.name == "Top")
        {
            enemy.movementController.movementDirection = Vector3.down;
        }
        else if (spawnArea.name == "Bottom")
        {
            enemy.movementController.movementDirection = Vector3.up;
        }


    }

    public Vector3 GetSpawnPosition(GameObject spawnArea)
    {
        Vector3 scale = spawnArea.transform.localScale;
        float x, y;
        x = spawnArea.transform.position.x + Random.Range(-scale.x / 2, scale.x / 2);
        y = spawnArea.transform.position.y + Random.Range(-scale.y / 2, scale.y / 2);

        Vector3 location = new Vector3(x,y,0);
        return location;
    }



}
