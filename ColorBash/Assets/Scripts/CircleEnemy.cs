using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleEnemy : Square
{
    protected override void OnCollisionEnter2D(Collision2D collision){
        return;
    }
}
