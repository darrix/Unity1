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
            transform.Rotate(degreesPerFrame,0,0);
        }
        else if (currentAxis == SpinAxis.Y)
        {
            transform.Rotate(0, degreesPerFrame, 0);
        }
        else
        {
            transform.Rotate(0,0,degreesPerFrame);
        }
    }
}
