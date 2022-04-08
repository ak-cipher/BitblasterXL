
using UnityEngine;
public class MultiShoot : MonoBehaviour
{
    public float bulletTimeGap;
    public float bulletSpeed;
    public ShootingController shootingController;
  
    
    public GameObject bulletPrefab;
    public GameObject bullets;

    public GameObject[] bulletSpawnPosition;
    public AudioSounds audioSounds;

    float nextshot = 0f;

    
    public void MultiBulletShoot()
    {
        if(Time.time > this.nextshot + this.bulletTimeGap)
        {
            this.nextshot = Time.time ;
            if(shootingController.ammoAmount >= 5)
            {
                audioSounds.PlayShootingSound();
                foreach (GameObject spawnPoint in this.bulletSpawnPosition)
                {
                    GameObject newBullet = (GameObject)Instantiate(this.bulletPrefab);
                    newBullet.transform.position = spawnPoint.transform.position;

                    newBullet.transform.parent = bullets.transform;

                    Vector3 dir = (spawnPoint.transform.position - this.transform.position).normalized;

                    Rigidbody2D bulletRigidbody = newBullet.GetComponent<Rigidbody2D>();
                    bulletRigidbody.AddForce(dir * this.bulletSpeed);

                    shootingController.ammoAmount--;
                }
            }

        }
        

        
       
    }


}
