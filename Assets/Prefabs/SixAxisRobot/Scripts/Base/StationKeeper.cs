using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationKeeper : MonoBehaviour {

    public bool MaintainPosition;
    public RobotPose PoseToMaintain; 

    HingeJoint[] hinge_joints; 

    void Start()
    {
        RobotRawController rrc = GetComponent<RobotRawController>();

        hinge_joints = new HingeJoint[] {
            rrc.BaseJoint, rrc.ShoulderJoint, rrc.ElbowJoint,
            rrc.FourthAxisJoint, rrc.FifthAxisJoint, rrc.SixthAxisJoint };
    }

    void FixedUpdate()
    {

    }

}
