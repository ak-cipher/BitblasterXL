using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressed;

    public PlayerMovementController playerMovementController;

   

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
