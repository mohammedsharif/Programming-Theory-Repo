using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayer : Player
{
    // Start is called before the first frame update
    void Start()
    {
        base.IntializeVariables();
        base.speed = 50;
        base.lifePoints = 3;

        base.SetPlayerPostion(new Vector3(25,0.7f,-47));
    }

    // Update is called once per frame
    void Update()
    {
        base.Move();
        SpeedUp();
    }

    void SpeedUp()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            base.playerRb.AddForce(focalPoint.transform.forward * verticalInput * 500 * Time.deltaTime, ForceMode.Impulse); 
        }
    }
}
