using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float m_speed;
    public float speed 
    {
        get{return m_speed;}
        set{
            if (value >= 0)
                m_speed = value;
            else 
                Debug.Log("Negative speed not allowed");
            }
    }

    protected int lifePoints = 6;
    protected Rigidbody playerRb;
    [SerializeField] protected GameObject focalPoint;
    protected float verticalInput;

    protected virtual void IntializeVariables()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    protected void SetPlayerPostion(Vector3 position)
    {
        transform.position = position;
    } 

    protected void Move()
    {
        verticalInput = Input.GetAxis("Vertical");
        
        playerRb.AddForce(focalPoint.transform.forward * speed * Time.deltaTime* verticalInput, ForceMode.Impulse);
    }

}
