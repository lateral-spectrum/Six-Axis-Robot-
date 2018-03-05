using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisController : MonoBehaviour {

    public RobotRawController rrc;

    public float BaseJointAngle;
    public float ShoulderJointAngle;
    public float ElbowJointAngle;
    public float FourthAxisJointAngle;
    public float FifthAxisJointAngle;
    public float SixthAxisJointAngle;

    bool moving_base_joint;
    bool moving_shoulder_joint;
    bool moving_elbow_joint;
    bool moving_fourth_axis_joint;
    bool moving_fifth_axis_joint;
    bool moving_sixth_axis_joint;

    public void MoveBaseJoint(float step)
    {
        rrc.BaseJointSpringTargetPosition += step; 
    }

    public IEnumerator MoveBaseJointToPosition(float target_position)
    {
        float ang_diff = rrc.BaseJointSpringTargetPosition - target_position; 
        int number_of_steps = 90;
        float step_size = ang_diff / number_of_steps; 

        for (int i = 0; i < number_of_steps; i++)
        {
            rrc.BaseJointSpringTargetPosition += step_size;

            yield return new WaitForEndOfFrame(); // to change velocity maintaining smoothness, this has to change to something
        }
    }

    public IEnumerator MoveShoulderJointToPosition(float[] param_arr)
    {
        float target_position = param_arr[0];
        float seconds_to_complete = param_arr[1]; 

        float ang_diff = rrc.ShoulderJointSpringTargetPosition - target_position;
        int number_of_steps = 1000;
        float step_size = ang_diff / number_of_steps;
        float wait_time = ang_diff / seconds_to_complete;

        print("Waiting for: " + wait_time + " between each step.");

        for (int i = 0; i < number_of_steps; i++)
        {
            rrc.ShoulderJointSpringTargetPosition += step_size;

            //yield return new WaitForSeconds(1f); 
            yield return new WaitForSeconds()
            //yield return new WaitForFixedUpdate(); // to change velocity maintaining smoothness, this has to change to something            
        }
    }





}
