using UnityEngine;
using System.Collections;

public class OBB : PhysicsCollider
{
    // TODO: YOUR CODE HERE
    public Vector3[] axes 
    { 
        get
        {
            return new Vector3[3] { transform.right, transform.up, transform.forward }; // {x,y,z} axes
        }
    }

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
            return transform.position - halfWidth;
        }
    }
    
    // the maximal point of the box
    public Vector3 max
    {
        get
        {
            return transform.position + halfWidth;
        } 
    }

    public override Shape shape => Shape.OBB;
}
