
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public RightButton rightButton;
    public LeftButton leftButton;
    public UpButton upButton;
    public DownButton downButton;
    public FireButton fireButton;
    public PlayerMovementController playerMovementController;
    public ShootingController shootingController;

    private void Update()
    {
        if(playerMovementController!= null)
        {
            if (this.rightButton.isPressed && this.fireButton.isPressed)
            {
                playerMovementController.ButtonRight();
                if (Time.time > shootingController.nextshot && shootingController.ammoAmount > 0)
                {
                    shootingController.ShootBullet();
                }
            }
            else if (this.leftButton.isPressed && this.fireButton.isPressed)
            {
                playerMovementController.ButtonLeft();
                if (Time.time > shootingController.nextshot && shootingController.ammoAmount > 0)
                {
                    shootingController.ShootBullet();
                }
            }
            else if (this.upButton.isPressed && this.fireButton.isPressed)
            {
                playerMovementController.ButtonUp();
                if (Time.time > shootingController.nextshot && shootingController.ammoAmount > 0)
                {
                    shootingController.ShootBullet();
                }
            }
            else if (this.downButton.isPressed && this.fireButton.isPressed)
            {
                playerMovementController.ButtonDown();
                if (Time.time > shootingController.nextshot && shootingController.ammoAmount > 0)
                {
                    shootingController.ShootBullet();
                }
            }
            else if (this.rightButton.isPressed)
            {
                playerMovementController.ButtonRight();
            }
            else if (this.leftButton.isPressed)
            {
                playerMovementController.ButtonLeft();
            }
            else if (this.downButton.isPressed)
            {
                playerMovementController.ButtonDown();
            }
            else if (this.upButton.isPressed)
            {
                playerMovementController.ButtonUp();
            }
            else if (this.fireButton.isPressed)
            {
                if (Time.time > shootingController.nextshot && shootingController.ammoAmount > 0)
                {
                    shootingController.ShootBullet();
                }

            }
        }
        
    }

}
