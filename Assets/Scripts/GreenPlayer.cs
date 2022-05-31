using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayer : Player
{
    // Start is called before the first frame update
    void Start()
    {
        base.intializeVariables();
        base.speed = 50;
        base.lifePoints = 3;
    }

    // Update is called once per frame
    void Update()
    {
        base.move();
    }
}
