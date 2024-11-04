using UnityEngine;
using System.Collections;

public class OBB : PhysicsCollider
{
    private Vector3 center;
    private Vector3 halfWidth; // extents
    private Vector3[] axes = new Vector3[3];


    public override Shape shape => Shape.OBB;
}
