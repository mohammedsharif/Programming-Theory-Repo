using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : Player
{
    // Start is called before the first frame update
    void Start()
    {
        base.intializeVariables();
        base.speed = 25;
        base.lifePoints = 6;
    }

    // Update is called once per frame
    void Update()
    {
        base.move();
    }
}
