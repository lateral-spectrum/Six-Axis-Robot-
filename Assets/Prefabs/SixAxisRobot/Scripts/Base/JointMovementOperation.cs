using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// might be useful for planning moves

public class JointMovementOperation : MonoBehaviour {

    RobotPose target_position;
    HingeJoint[] hinge_joints;

    float angle_tolerance = 1f; 

    void Start()
    {
        RobotRawController rrc = GetComponent<RobotRawController>();

        hinge_joints = new HingeJoint[] {
            rrc.BaseJoint, rrc.ShoulderJoint, rrc.ElbowJoint,
            rrc.FourthAxisJoint, rrc.FifthAxisJoint, rrc.SixthAxisJoint }; 
    }

    public JointMovementOperation(RobotPose position_target)
    {
        target_position = position_target; 
    }

    //public IEnumerator Run()
    //{
    //    for (int i = 0; i < hinge_joints.Length; i++)
    //    {
    //        float diff = hinge_joints[i].angle - 
    //        if (hinge_joints[i].angle )
    //    }
    //}
   
}
