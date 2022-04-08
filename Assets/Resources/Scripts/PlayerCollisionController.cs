
using UnityEngine;

public class PlayerCollisionController : MonoBehaviour
{
    PlayerHealth playerHealth;
    public CollectionController collectionController;


    private void Start()
    {
        this.playerHealth = this.transform.parent.gameObject.GetComponent<PlayerHealth>();
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "InnerBorders")
        {
            Debug.Log("Player Destroyed");
            playerHealth.DestroyPlayer();
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Take Damge");
            playerHealth.TakeDamge();
        }
        else if (collision.gameObject.tag == "Collectable")
        {
            this.collectionController.Collect(collision.gameObject);

        }
    }


}
