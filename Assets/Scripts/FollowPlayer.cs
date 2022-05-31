using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    private float horizontalInput;
    [SerializeField] float turnSpeed = 50f;

    // Update is called once per frame
    private void Update() 
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
    }

    void LateUpdate()
    {
        transform.position = player.transform.position; 
    }
}
