using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVer = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float _rotationX = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // code in this method is run with each frame update (what's the rate?)
        /*
         * How to think about rotations:  pitch is rotation around the x-axis; yaw is rotation around the y-axis;
         * roll is rotation around the z-axis.  
         */
        
        if (axes == RotationAxes.MouseX)
        {
            // rotating *around* the x-axis, so the x-angle stays constant?
            // for now, think of this as translating x-mouse movement into rotation around the y-axis
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            // vertical rotation here, i.e., around the x axis, constrained to max and min vertical points
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVer;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            
            // for the current position, get the vector value of Y and convert it to an angle.  Is Vector3 expecting
            // Euler angles?
            float rotationY = transform.localEulerAngles.y;

            // we are creating a new Vector3 here because the localEulerAngles property is readonly
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {
            // both horizontal and vertical rotation
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVer;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;
            
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            
        }
    }
}