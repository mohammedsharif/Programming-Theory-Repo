using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : Player
{
    // Start is called before the first frame update
    void Start()
    {
        base.IntializeVariables();
        base.speed = 25;
        base.lifePoints = 6;

        base.SetPlayerPostion(new Vector3(25,0.7f,-47));
    }

    // Update is called once per frame
    void Update()
    {
        base.Move();
    }
}
