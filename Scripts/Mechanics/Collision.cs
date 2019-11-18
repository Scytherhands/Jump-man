using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Mechanics;

public class Collision : PlayerController
{
    void OnCollisionEnter2D(Collision2D col) 
    {
        if(col.gameObject.name == "Floor") 
        {
            velocity.y = 7;
        }
    }
}
