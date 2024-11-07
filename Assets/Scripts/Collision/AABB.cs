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

    // The minimum point of the bounding box
    public Vector3 min
    {
        get
        {
            return -halfWidth;
        }
    }

    // equivalent to the extents as previously defined
    public Vector3 max { get { return halfWidth; } }

    public override Shape shape => Shape.AABB;
}
