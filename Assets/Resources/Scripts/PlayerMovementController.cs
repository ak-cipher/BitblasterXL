using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerMovementController : MonoBehaviour 
{
    public float defaultMovementSpeed;
    public float extraAcceleration;
    public float breakingFactor;
    public float defaultTurnSpeed;
    public float maxSpeed = 250f;

   
    private void Update()
    {
        float movementSpeed = this.defaultMovementSpeed;

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            movementSpeed += this.extraAcceleration;
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            movementSpeed *= this.breakingFactor;
        }

        this.transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
           this.transform.Rotate(Vector3.forward, this.defaultTurnSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.back, this.defaultTurnSpeed * Time.deltaTime);
        }

    }

    
    public void ButtonUp()
    {  
        float movementSpeed = this.defaultMovementSpeed;
        if(movementSpeed < this.maxSpeed)
        {
            movementSpeed += this.extraAcceleration;
            this.transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
    }

    public void ButtonDown()
    {
        float movementSpeed = this.defaultMovementSpeed;
        movementSpeed *= this.breakingFactor;
        this.transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
    }

    public void ButtonLeft()
    {
        this.transform.Rotate(Vector3.forward, this.defaultTurnSpeed * Time.deltaTime);
    }

    public void ButtonRight()
    {
        this.transform.Rotate(Vector3.back, this.defaultTurnSpeed * Time.deltaTime);
    }
}
