
using UnityEngine;
using UnityEngine.UI;

public class ShootingController : MonoBehaviour
{
    public float bulletTimeGap;
    public float bulletSpeed;
    public int ammoAmount;

    public Transform spawnPoint;
    public GameObject bulletPrefab;
    public GameObject bullets;
    public Text ammoText;

    public FireButton fireButton;
    public AudioSounds audioSounds;

    public GameObject laser;
    public GameObject beserk;
   

    public float nextshot = 0f;

   
    void Update()
    {
        this.ammoText.text = ammoAmount.ToString();
        if (Input.GetKey(KeyCode.M) && Time.time >  this.nextshot && this.ammoAmount > 0)
        {
            ShootBullet();
            
        }
        
    }

    public void ShootBullet()
    {
        if (!(laser.activeInHierarchy) && !(beserk.activeInHierarchy))
        {
            audioSounds.PlayShootingSound();
            this.nextshot = Time.time + this.bulletTimeGap;
            fireButton.nextShot = Time.time + fireButton.bulletTimeGap;
            GameObject newBullet = (GameObject)Instantiate(this.bulletPrefab);
            newBullet.transform.position = spawnPoint.position;

            newBullet.transform.parent = bullets.transform;

            Rigidbody2D bulletRigidbody = newBullet.GetComponent<Rigidbody2D>();
            bulletRigidbody.AddForce(this.transform.up * this.bulletSpeed);

            this.ammoAmount--;
        }
        
    }

}
