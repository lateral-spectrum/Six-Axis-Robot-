using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour {

    public AxisController AxisController; 

    public void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            AxisController.MoveBaseJoint(0.1f); 
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            float target_angle = 90f;

            float[] param_arr = new float[] { 90f, 90f }; // 90 dps

            AxisController.StartCoroutine("MoveShoulderJointToPosition", param_arr); 
        }

        if (Input.GetKeyDown(KeyCode.G))
        {

            float[] param_arr = new float[] { 90f, 8f }; // 90 degrees in 2 seconds

            AxisController.StartCoroutine("MoveShoulderJointToPosition", param_arr); 
        }

        
    }
}
