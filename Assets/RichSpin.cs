using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RichSpin : MonoBehaviour
{
    public enum SpinAxis
    {
        X,
        Y,
        Z
    }

    public enum WorldOrientation
    {
        Self,
        World
    }

    public WorldOrientation worldOrientation = WorldOrientation.Self;

    private Space getWorldOrientation()
    {
        return (worldOrientation == WorldOrientation.Self) ? Space.Self : Space.World;
    }

    public float degreesPerFrame = 5.0f;

    public SpinAxis currentAxis = SpinAxis.X;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentAxis == SpinAxis.X)
        {
            transform.Rotate(degreesPerFrame, 0, 0, getWorldOrientation());
        }
        else if (currentAxis == SpinAxis.Y)
        {
            transform.Rotate(0, degreesPerFrame, 0, getWorldOrientation());
        }
        else
        {
            transform.Rotate(0,0,degreesPerFrame, getWorldOrientation());
        }
    }
}
