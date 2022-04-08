
using UnityEngine;
using UnityEngine.EventSystems;

public class FireButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public bool isPressed;
    public ShootingController shootingController;
    public float nextShot;
    public float bulletTimeGap;




   

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
