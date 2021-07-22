using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class FastEnemy : Enemy
{
    // POLYMORPHISM
    protected override void Move()
    {
        MoveTowards(GetPlayerTargetVector());
    }
}
