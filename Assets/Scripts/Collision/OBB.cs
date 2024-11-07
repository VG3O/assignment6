using UnityEngine;
using System.Collections;

public class OBB : PhysicsCollider
{
    // TODO: YOUR CODE HERE
    public Vector3 center;
    public Vector3 halfWidth; // extents
    public Vector3[] axes = new Vector3[3];

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



    public override Shape shape => Shape.OBB;
}
