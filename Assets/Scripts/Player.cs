using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public int lifePoints = 6;
    public Rigidbody playerRb;
    public GameObject focalPoint;
    public float verticalInput;

    public virtual void IntializeVariables()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    public void Move()
    {
        verticalInput = Input.GetAxis("Vertical");
        
        playerRb.AddForce(focalPoint.transform.forward * speed * Time.deltaTime* verticalInput, ForceMode.Impulse);
    }

}
