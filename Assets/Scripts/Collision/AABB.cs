using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AABB : PhysicsCollider
{
    // TODO: YOUR CODE HERE
    public Vector3 center
    {
        get
        {
            return transform.position;
        }
    }
    public Vector3 halfWidth
    { 
        get
        { return 0.5f * transform.localScale; }
    }

    public override Shape shape => Shape.AABB;
}
