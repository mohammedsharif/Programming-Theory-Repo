using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public int lifePoints = 6;
    public Rigidbody playerRb;
    public float verticalInput;
    public float horizontalInput;

    public virtual void intializeVariables()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    public void move()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        
        playerRb.AddForce(Vector3.forward * speed * Time.deltaTime * verticalInput, ForceMode.Impulse);
        playerRb.AddForce(Vector3.right * speed * Time.deltaTime *  horizontalInput, ForceMode.Impulse);
    }

}
