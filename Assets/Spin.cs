using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Spin : MonoBehaviour
{
    [FormerlySerializedAs("speed")] public float degreesPerFrame = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(degreesPerFrame, 0, 0);    
    }
}
